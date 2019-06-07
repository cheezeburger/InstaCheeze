namespace InstaCheeze
{
    partial class TwoFactorForm
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
            this.TwoFactorLbl = new System.Windows.Forms.Label();
            this.EnterCodeLbl = new System.Windows.Forms.Label();
            this.TwoFactorCodeTxt = new System.Windows.Forms.TextBox();
            this.TwoFactorLoginBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TwoFactorLbl
            // 
            this.TwoFactorLbl.AutoSize = true;
            this.TwoFactorLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoFactorLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TwoFactorLbl.Location = new System.Drawing.Point(69, 7);
            this.TwoFactorLbl.Name = "TwoFactorLbl";
            this.TwoFactorLbl.Size = new System.Drawing.Size(144, 18);
            this.TwoFactorLbl.TabIndex = 7;
            this.TwoFactorLbl.Text = "Two Factor Authentification";
            // 
            // EnterCodeLbl
            // 
            this.EnterCodeLbl.AutoSize = true;
            this.EnterCodeLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCodeLbl.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EnterCodeLbl.Location = new System.Drawing.Point(6, 36);
            this.EnterCodeLbl.Name = "EnterCodeLbl";
            this.EnterCodeLbl.Size = new System.Drawing.Size(54, 16);
            this.EnterCodeLbl.TabIndex = 8;
            this.EnterCodeLbl.Text = "Enter Code:";
            // 
            // TwoFactorCodeTxt
            // 
            this.TwoFactorCodeTxt.Location = new System.Drawing.Point(69, 36);
            this.TwoFactorCodeTxt.Name = "TwoFactorCodeTxt";
            this.TwoFactorCodeTxt.Size = new System.Drawing.Size(159, 20);
            this.TwoFactorCodeTxt.TabIndex = 9;
            // 
            // TwoFactorLoginBtn
            // 
            this.TwoFactorLoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwoFactorLoginBtn.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwoFactorLoginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TwoFactorLoginBtn.Location = new System.Drawing.Point(69, 72);
            this.TwoFactorLoginBtn.Name = "TwoFactorLoginBtn";
            this.TwoFactorLoginBtn.Size = new System.Drawing.Size(159, 35);
            this.TwoFactorLoginBtn.TabIndex = 10;
            this.TwoFactorLoginBtn.Text = "Login";
            this.TwoFactorLoginBtn.UseVisualStyleBackColor = true;
            this.TwoFactorLoginBtn.Click += new System.EventHandler(this.TwoFactorLoginBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.MinimizeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeBtn.FlatAppearance.BorderColor = System.Drawing.Color.MediumTurquoise;
            this.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeBtn.Location = new System.Drawing.Point(243, 0);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(6, 30);
            this.MinimizeBtn.TabIndex = 21;
            this.MinimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(255, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(6, 30);
            this.closeBtn.TabIndex = 20;
            this.closeBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.closeBtn.UseVisualStyleBackColor = false;
            // 
            // TwoFactorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(21)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(265, 128);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.TwoFactorLoginBtn);
            this.Controls.Add(this.TwoFactorCodeTxt);
            this.Controls.Add(this.EnterCodeLbl);
            this.Controls.Add(this.TwoFactorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TwoFactorForm";
            this.Text = "TwoFactorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TwoFactorLbl;
        private System.Windows.Forms.Label EnterCodeLbl;
        private System.Windows.Forms.TextBox TwoFactorCodeTxt;
        private System.Windows.Forms.Button TwoFactorLoginBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button closeBtn;
    }
}