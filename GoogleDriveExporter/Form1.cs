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
        List<FileType> comboBoxDataList;
        static Form1 form1;

        public Form1() {
            form1 = this;
            InitializeComponent();
        }

         private void Form1_Load(object sender, EventArgs e) {
            InitializeTextBox();
            InitializeDirveManager();
            FillTheDataToComboBox();
        }

        private void FillTheDataToComboBox() {
            fileTypeComboBox.DisplayMember = "Name";
            fileTypeComboBox.ValueMember = "Value";
            comboBoxDataList = new List<FileType>();
            comboBoxDataList.Add(new FileType() { Name = "Microsoft excel", Value = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", FileExtension = "xls" });
            comboBoxDataList.Add(new FileType() { Name = "Open Office sheet", Value = "application/x-vnd.oasis.opendocument.spreadsheet", FileExtension = "xls" });
            comboBoxDataList.Add(new FileType() { Name = "PDF", Value = "application/pdf", FileExtension = "pdf"});
            comboBoxDataList.Add(new FileType() { Name = "CSV", Value = "text/csv", FileExtension = "csv" });
            comboBoxDataList.Add(new FileType() { Name = "TSV", Value = "text/tab-separated-values", FileExtension = "tsv" });
            fileTypeComboBox.DataSource = comboBoxDataList;

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
            var result = MessageBox.Show("Do you need help with generating google drive api?: https://developers.google.com/drive/v3/web/quickstart/dotnet","Help",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                System.Diagnostics.Process.Start("https://developers.google.com/drive/v3/web/quickstart/dotnet");
            }
        }
        public string GetSelectedValueInComboBox() {
            
            return fileTypeComboBox.SelectedValue.ToString();
        }

        public string GetSelectedTextInComboBox() {
            return fileTypeComboBox.GetItemText(fileTypeComboBox.SelectedItem);
        }

        public string getFileExtensionFromComboBoxItem() {
            FileType typeOfFile = (FileType)fileTypeComboBox.SelectedItem;
            return typeOfFile.FileExtension;
        }
       
    }
    
}
