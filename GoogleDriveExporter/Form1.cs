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
            driveManager = new DriveManager(this);
            InitializeTextBox();
        }
        
        private void InitializeTextBox() {
            string path = new Uri(
            System.IO.Path.GetDirectoryName(
            System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
            ).LocalPath;
            localPathToDownload.Text = System.IO.Path.GetFullPath(path);
        }
       
        private void downloadButton_Click(object sender, EventArgs e) {
            driveManager.InitializeDeviceService();
            string pathToDownload = localPathToDownload.Text;
            driveManager.DownloadFile(pathToDownload); 
        }
        public static void UpdateDebugLog(string message) {

            form1.DebugLog.AppendText(DateTime.Now + "\n");
            form1.DebugLog.AppendText(message + "\n");
            
        }

        private void button1_Click(object sender, EventArgs e) {
            
        }
    }
}
