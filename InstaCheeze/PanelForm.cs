using InstagramApiSharp.API;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System;
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
    public partial class PanelForm : Form
    {
        private String filePath;
        IInstaApi instaApi;
        private OpenFileDialog selectFileDialog;

        public PanelForm()
        {
            InitializeComponent();
        }

        private async void PanelForm_Load(object sender, EventArgs e)
        {
            instaApi = User.SessionApiBuilder();
            statusLabel.Text = "Welcome, " + instaApi.GetLoggedUser().LoggedInUser.UserName + ".";

            var currentUser = await instaApi.UserProcessor.GetCurrentUserAsync();
        }

        private void SelectFileBtn_Click(object sender, EventArgs e)
        {
            selectFileDialog = new OpenFileDialog
            {
                FilterIndex = 0,
                Filter = "Images Files (*.jpeg;*.jpg;*.png)|*.jpeg;*.jpg;*.png",
                RestoreDirectory = true
            };

            if (selectFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = selectFileDialog.FileName;
                selectFileBtn.Text = filePath.Substring(filePath.LastIndexOf('\\')+ 1);
            }
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            StartUpload();
        }

        public async void StartUpload()
        {
            try
            {
                var checkFileExtensionType = (filePath.Substring(filePath.LastIndexOf('.'))).ToLower();
                // Convert Image to JPG
                System.Drawing.Image imageForConversion = System.Drawing.Image.FromFile(@filePath);
                var saveLocation = "";
                filePath = saveLocation = filePath.Substring(0, filePath.LastIndexOf('.')) + "1.jpeg";
                imageForConversion.Save(@saveLocation, System.Drawing.Imaging.ImageFormat.Jpeg);
                checkFileExtensionType = saveLocation.Substring(saveLocation.LastIndexOf('.')).ToLower();

                switch (checkFileExtensionType)
                {
                    case ".jpeg":
                    case ".jpg":
                        await DoPictureUpload();
                        break;
                    default:
                        MessageBox.Show("File is not supported");
                        break;
                }
            }
            catch(NullReferenceException n)
            {
                MessageBox.Show("Please select a media to upload.", "No Files Selected");
            }

            
        }

        private async Task DoPictureUpload()
        {
            uploadBtn.Enabled = false;
            var picture = new InstaImageUpload
            {
                Height = 0,
                Width = 0,
                Uri = @filePath
            };
            var caption = captionRichTxtBox.Text;
            var result = await instaApi.MediaProcessor.UploadPhotoAsync(UpdateUploadProgressToLabel, picture, caption);

            progressLbl.Text = (result.Succeeded ? $"Picture Uploaded: {result.Value.Pk}"
                : $"Unable to upload photo: {result.Info.Message}");
            uploadBtn.Enabled = true;
        }

        //Function to be called by photo upload functions to update progressLbl
        private void UpdateUploadProgressToLabel(InstaUploaderProgress progress)
        {
            if (progress == null)
                return;
            progressLbl.Text = $"{progress.Name}: {progress.UploadState}";
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

        private void MinimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
