using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace GoogleDriveExporter {
    public partial class Form1 : Form { 
        DriveManager driveManager;
        SendFTP ftpToSend;
        static Form1 form1;
        public Form1() {
            form1 = this;
            InitializeComponent();
            InitializeTextBox();
            InitializeDirveManager();
        }
        
        private void InitializeTextBox() {
            string path = new Uri(
            System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
            ).LocalPath;
            localPathToDownload.Text = System.IO.Path.GetFullPath(path);
            loginTextBox.Text = "maciejsowiar";
            passwordTextBox.Text = "4Dm!n";
            pathToFtp.Text = "ftp://www.mkwk018.cba.pl/ftptestmaciejs.cba.pl/test.pdf";
        }

        private void InitializeDirveManager() {
            driveManager = new DriveManager(this);
            driveManager.InitializeDeviceService();
        }
       
        private void downloadButton_Click(object sender, EventArgs e) {
            InitializeDirveManager();
            string pathToDownload = localPathToDownload.Text;
            driveManager.DownloadFile();
            driveManager.LocalDownloadFile(localPathToDownload.Text);
        }

        private void downloadAndSendToServer_Click(object sender, EventArgs e) {
            InitializeDirveManager();
            driveManager.DownloadFile();
            SendFTP.SendFtpToServer(driveManager.streamS, loginTextBox.Text, passwordTextBox.Text, pathToFtp.Text);
        }

        private void pathToFtp_TextChanged(object sender, EventArgs e) {

        }

        public static void UpdateDebugLog(string message) {

            form1.DebugLog.AppendText(DateTime.Now + "\n");
            form1.DebugLog.AppendText(message + "\n");
            
        }

        private void fileTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void helpButton_Click(object sender, EventArgs e) {
            var result = MessageBox.Show("If you need help with generating api from google drive open: https://developers.google.com/drive/v3/web/quickstart/dotnet","Help",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                System.Diagnostics.Process.Start("https://developers.google.com/drive/v3/web/quickstart/dotnet");
            }
        }
    }
}
