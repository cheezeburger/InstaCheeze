namespace InstaCheeze
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.nameLbl = new System.Windows.Forms.Label();
            this.loginProcessLbl = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.rememberMeBtn = new System.Windows.Forms.CheckBox();
            this.keyPic = new System.Windows.Forms.PictureBox();
            this.usernamePic = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.keyPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTxt.Location = new System.Drawing.Point(48, 86);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(207, 19);
            this.usernameTxt.TabIndex = 1;
            this.usernameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTxt.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.Location = new System.Drawing.Point(48, 137);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(207, 26);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBtn
            // 
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(85, 188);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(129, 32);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.nameLbl.Location = new System.Drawing.Point(74, 12);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(144, 33);
            this.nameLbl.TabIndex = 5;
            this.nameLbl.Text = "InstaCheeze";
            // 
            // loginProcessLbl
            // 
            this.loginProcessLbl.AutoSize = true;
            this.loginProcessLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginProcessLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loginProcessLbl.Location = new System.Drawing.Point(5, 221);
            this.loginProcessLbl.Name = "loginProcessLbl";
            this.loginProcessLbl.Size = new System.Drawing.Size(105, 18);
            this.loginProcessLbl.TabIndex = 6;
            this.loginProcessLbl.Text = "developed by Shane";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.descLabel.Location = new System.Drawing.Point(108, 45);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(128, 16);
            this.descLabel.TabIndex = 7;
            this.descLabel.Text = "lightweight Instagram poster";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.passwordLbl.Location = new System.Drawing.Point(46, 116);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(59, 18);
            this.passwordLbl.TabIndex = 8;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.usernameLbl.Location = new System.Drawing.Point(45, 65);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(59, 18);
            this.usernameLbl.TabIndex = 9;
            this.usernameLbl.Text = "Username:";
            // 
            // rememberMeBtn
            // 
            this.rememberMeBtn.AutoSize = true;
            this.rememberMeBtn.Checked = true;
            this.rememberMeBtn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rememberMeBtn.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.rememberMeBtn.Location = new System.Drawing.Point(178, 167);
            this.rememberMeBtn.Name = "rememberMeBtn";
            this.rememberMeBtn.Size = new System.Drawing.Size(85, 18);
            this.rememberMeBtn.TabIndex = 12;
            this.rememberMeBtn.Text = "Remember Me";
            this.rememberMeBtn.UseVisualStyleBackColor = true;
            // 
            // keyPic
            // 
            this.keyPic.Image = global::InstaCheeze.Properties.Resources.key;
            this.keyPic.Location = new System.Drawing.Point(18, 137);
            this.keyPic.Name = "keyPic";
            this.keyPic.Size = new System.Drawing.Size(24, 28);
            this.keyPic.TabIndex = 2;
            this.keyPic.TabStop = false;
            // 
            // usernamePic
            // 
            this.usernamePic.Image = global::InstaCheeze.Properties.Resources.profile;
            this.usernamePic.Location = new System.Drawing.Point(18, 84);
            this.usernamePic.Name = "usernamePic";
            this.usernamePic.Size = new System.Drawing.Size(24, 28);
            this.usernamePic.TabIndex = 0;
            this.usernamePic.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(289, -1);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(6, 30);
            this.closeBtn.TabIndex = 13;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(277, -1);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(6, 30);
            this.MinimizeBtn.TabIndex = 19;
            this.MinimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(21)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(295, 246);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.rememberMeBtn);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.loginProcessLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.keyPic);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.usernamePic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(295, 246);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.keyPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usernamePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox usernamePic;
        private System.Windows.Forms.PictureBox keyPic;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label loginProcessLbl;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.CheckBox rememberMeBtn;
        public System.Windows.Forms.TextBox usernameTxt;
        public System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button MinimizeBtn;
    }
}

