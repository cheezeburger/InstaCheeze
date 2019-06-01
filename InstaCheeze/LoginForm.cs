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

                IInstaApi _instaApiInstance = User.SessionApiBuilder();

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

                    else { 
                        MessageBox.Show(loginResult.Info.Message);
                        loginBtn.Enabled = true;
                    }
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
            if(Properties.Settings.Default.username != null && Properties.Settings.Default.password != null)
            {
                usernameTxt.Text = Properties.Settings.Default.username;
                passwordTxt.Text = Properties.Settings.Default.password;
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
    }
}
