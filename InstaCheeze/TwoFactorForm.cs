using InstagramApiSharp.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstaCheeze
{
    public partial class TwoFactorForm : Form
    {
        IInstaApi instaApi;
        public TwoFactorForm()
        {
            InitializeComponent();
        }

        private async void TwoFactorLoginBtn_Click(object sender, EventArgs e)
        {
            instaApi = User.SessionApiBuilder();
            var twoFactorLogin = await instaApi.TwoFactorLoginAsync(TwoFactorCodeTxt.Text);
            if (twoFactorLogin.Succeeded)
            {
                var panelForm = new PanelForm();
                panelForm.ShowDialog();

                this.Hide();
            }
        }

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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
    }
}
