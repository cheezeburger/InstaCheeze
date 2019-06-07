using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Logger;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaCheeze
{
    public partial class LoginForm : Form
    {
        public User newUser;
        IInstaApi _instaApiInstance;
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text != "" && passwordTxt.Text != "")
            {
                //Add to default setting if Remember Me checkbox is checked
                if (rememberMeBtn.Checked)
                {
                    Properties.Settings.Default.username = usernameTxt.Text;
                    Properties.Settings.Default.password = passwordTxt.Text;
                    Properties.Settings.Default.Save();
                }

                else
                    Properties.Settings.Default.Reset();
                
                loginBtn.Enabled = false;
                newUser.Username = usernameTxt.Text;
                newUser.Password = passwordTxt.Text;

                newUser.SetUserSessionData();

                _instaApiInstance = User.SessionApiBuilder();

                if (!_instaApiInstance.IsUserAuthenticated)
                {
                    loginProcessLbl.Text = $"Logging in as {newUser.Username}";

                    var loginResult = await _instaApiInstance.LoginAsync();

                    if (loginResult.Succeeded)
                    {
                        this.Hide();
                        var panelForm = new PanelForm();
                        panelForm.Closed += (s, args) => this.Close();
                        panelForm.Show();
                    }

                    //If 2FA is required
                    else if(loginResult.Value == InstaLoginResult.TwoFactorRequired)
                    {
                        var TwoFactorForm = new TwoFactorForm();
                        TwoFactorForm.ShowDialog();

                        this.Hide();
                    }

                    else { 
                        MessageBox.Show(loginResult.Info.Message);
                        loginBtn.Enabled = true;
                    }

                    //Save session 
                    if (rememberMeBtn.Checked)
                        SaveSession();
                }
            }
            else
            {
                MessageBox.Show("Username/Password field cannot be empty");

            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            newUser = new User();
            if (Properties.Settings.Default.username != null && Properties.Settings.Default.password != null)
            {
                usernameTxt.Text = Properties.Settings.Default.username;
                passwordTxt.Text = Properties.Settings.Default.password;

                //Attempt to automatically load previous saved session
                if (File.Exists("state.bin"))
                {
                    LoadSavedSession();
                    
                    var panelForm = new PanelForm();
                    panelForm.ShowDialog();

                    this.Hide();
                }
            }
        }

        //Enable client repositioning
        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoadSavedSession()
        {
            const string stateFile = "state.bin";

            try
            {
                loginProcessLbl.Text = "Loading previous session.";
                using (var fs = File.OpenRead(stateFile))
                {
                    _instaApiInstance = User.SessionApiBuilder();
                    _instaApiInstance.LoadStateDataFromStream(fs);
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void SaveSession()
        {
            var state = _instaApiInstance.GetStateDataAsStream();
            using (var fileStream = File.Create("state.bin"))
            {
                state.Seek(0, SeekOrigin.Begin);
                state.CopyTo(fileStream);
            }
        }
    }
}
