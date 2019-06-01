namespace InstaCheeze
{
    partial class PanelForm
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
            this.statusLabel = new System.Windows.Forms.Label();
            this.uploadLbl = new System.Windows.Forms.Label();
            this.selectFileBtn = new System.Windows.Forms.Button();
            this.addCaptionLbl = new System.Windows.Forms.Label();
            this.captionRichTxtBox = new System.Windows.Forms.RichTextBox();
            this.tagLbl = new System.Windows.Forms.Label();
            this.uploadBtn = new System.Windows.Forms.Button();
            this.progressLbl = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statusLabel.Location = new System.Drawing.Point(12, 9);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 18);
            this.statusLabel.TabIndex = 0;
            // 
            // uploadLbl
            // 
            this.uploadLbl.AutoSize = true;
            this.uploadLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadLbl.Location = new System.Drawing.Point(12, 41);
            this.uploadLbl.Name = "uploadLbl";
            this.uploadLbl.Size = new System.Drawing.Size(119, 18);
            this.uploadLbl.TabIndex = 10;
            this.uploadLbl.Text = "1. Select files to upload:";
            // 
            // selectFileBtn
            // 
            this.selectFileBtn.Location = new System.Drawing.Point(15, 72);
            this.selectFileBtn.Name = "selectFileBtn";
            this.selectFileBtn.Size = new System.Drawing.Size(283, 23);
            this.selectFileBtn.TabIndex = 11;
            this.selectFileBtn.Text = "Select photo";
            this.selectFileBtn.UseVisualStyleBackColor = true;
            this.selectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // addCaptionLbl
            // 
            this.addCaptionLbl.AutoSize = true;
            this.addCaptionLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCaptionLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addCaptionLbl.Location = new System.Drawing.Point(12, 112);
            this.addCaptionLbl.Name = "addCaptionLbl";
            this.addCaptionLbl.Size = new System.Drawing.Size(76, 18);
            this.addCaptionLbl.TabIndex = 12;
            this.addCaptionLbl.Text = "2. Add caption";
            // 
            // captionRichTxtBox
            // 
            this.captionRichTxtBox.Location = new System.Drawing.Point(15, 133);
            this.captionRichTxtBox.MaxLength = 2199;
            this.captionRichTxtBox.Name = "captionRichTxtBox";
            this.captionRichTxtBox.Size = new System.Drawing.Size(283, 83);
            this.captionRichTxtBox.TabIndex = 13;
            this.captionRichTxtBox.Text = "";
            // 
            // tagLbl
            // 
            this.tagLbl.AutoSize = true;
            this.tagLbl.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tagLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tagLbl.Location = new System.Drawing.Point(12, 238);
            this.tagLbl.Name = "tagLbl";
            this.tagLbl.Size = new System.Drawing.Size(51, 18);
            this.tagLbl.TabIndex = 14;
            this.tagLbl.Text = "3. Upload";
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(12, 268);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(283, 23);
            this.uploadBtn.TabIndex = 15;
            this.uploadBtn.Text = "Start Uploading";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // progressLbl
            // 
            this.progressLbl.AutoSize = true;
            this.progressLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.progressLbl.Location = new System.Drawing.Point(9, 302);
            this.progressLbl.Name = "progressLbl";
            this.progressLbl.Size = new System.Drawing.Size(0, 13);
            this.progressLbl.TabIndex = 16;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Red;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(303, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(6, 30);
            this.closeBtn.TabIndex = 17;
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
            this.MinimizeBtn.Location = new System.Drawing.Point(288, -1);
            this.MinimizeBtn.Margin = new System.Windows.Forms.Padding(1);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(6, 30);
            this.MinimizeBtn.TabIndex = 18;
            this.MinimizeBtn.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // PanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(21)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(310, 335);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.progressLbl);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.tagLbl);
            this.Controls.Add(this.captionRichTxtBox);
            this.Controls.Add(this.addCaptionLbl);
            this.Controls.Add(this.selectFileBtn);
            this.Controls.Add(this.uploadLbl);
            this.Controls.Add(this.statusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelForm";
            this.Text = "PanelForm";
            this.Load += new System.EventHandler(this.PanelForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label uploadLbl;
        private System.Windows.Forms.Button selectFileBtn;
        private System.Windows.Forms.Label addCaptionLbl;
        private System.Windows.Forms.RichTextBox captionRichTxtBox;
        private System.Windows.Forms.Label tagLbl;
        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.Label progressLbl;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button MinimizeBtn;
    }
}