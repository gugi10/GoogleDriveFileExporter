namespace GoogleDriveExporter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.downloadButton = new System.Windows.Forms.Button();
            this.localPathToDownload = new System.Windows.Forms.TextBox();
            this.localPathToDownloadLabel = new System.Windows.Forms.Label();
            this.DebugLog = new System.Windows.Forms.RichTextBox();
            this.DebugLogLabel = new System.Windows.Forms.Label();
            this.downloadAndSendToServer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pathToFtp = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.fileTypeComboBox = new System.Windows.Forms.ComboBox();
            this.fileTypeLabel = new System.Windows.Forms.Label();
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(286, 58);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(233, 24);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Local download";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // localPathToDownload
            // 
            this.localPathToDownload.Location = new System.Drawing.Point(286, 32);
            this.localPathToDownload.Name = "localPathToDownload";
            this.localPathToDownload.Size = new System.Drawing.Size(233, 20);
            this.localPathToDownload.TabIndex = 2;
            // 
            // localPathToDownloadLabel
            // 
            this.localPathToDownloadLabel.AutoSize = true;
            this.localPathToDownloadLabel.Location = new System.Drawing.Point(283, 16);
            this.localPathToDownloadLabel.Name = "localPathToDownloadLabel";
            this.localPathToDownloadLabel.Size = new System.Drawing.Size(121, 13);
            this.localPathToDownloadLabel.TabIndex = 3;
            this.localPathToDownloadLabel.Text = "Local path for download";
            // 
            // DebugLog
            // 
            this.DebugLog.Location = new System.Drawing.Point(724, 32);
            this.DebugLog.Name = "DebugLog";
            this.DebugLog.Size = new System.Drawing.Size(384, 532);
            this.DebugLog.TabIndex = 4;
            this.DebugLog.Text = "";
            // 
            // DebugLogLabel
            // 
            this.DebugLogLabel.AutoSize = true;
            this.DebugLogLabel.Location = new System.Drawing.Point(721, 16);
            this.DebugLogLabel.Name = "DebugLogLabel";
            this.DebugLogLabel.Size = new System.Drawing.Size(60, 13);
            this.DebugLogLabel.TabIndex = 5;
            this.DebugLogLabel.Text = "Debug Log";
            this.DebugLogLabel.Click += new System.EventHandler(this.DebugLogLabel_Click);
            // 
            // downloadAndSendToServer
            // 
            this.downloadAndSendToServer.Location = new System.Drawing.Point(12, 179);
            this.downloadAndSendToServer.Name = "downloadAndSendToServer";
            this.downloadAndSendToServer.Size = new System.Drawing.Size(233, 23);
            this.downloadAndSendToServer.TabIndex = 6;
            this.downloadAndSendToServer.Text = "Download and send";
            this.downloadAndSendToServer.UseVisualStyleBackColor = true;
            this.downloadAndSendToServer.Click += new System.EventHandler(this.downloadAndSendToServer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ftp path";
            // 
            // pathToFtp
            // 
            this.pathToFtp.Location = new System.Drawing.Point(12, 32);
            this.pathToFtp.Name = "pathToFtp";
            this.pathToFtp.Size = new System.Drawing.Size(233, 20);
            this.pathToFtp.TabIndex = 8;
            this.pathToFtp.TextChanged += new System.EventHandler(this.pathToFtp_TextChanged);
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.Location = new System.Drawing.Point(12, 55);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(33, 13);
            this.login.TabIndex = 9;
            this.login.Text = "Login";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(12, 95);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(53, 13);
            this.password.TabIndex = 10;
            this.password.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(12, 111);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(233, 20);
            this.passwordTextBox.TabIndex = 11;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(12, 72);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(233, 20);
            this.loginTextBox.TabIndex = 12;
            // 
            // fileTypeComboBox
            // 
            this.fileTypeComboBox.FormattingEnabled = true;
            this.fileTypeComboBox.Location = new System.Drawing.Point(12, 152);
            this.fileTypeComboBox.Name = "fileTypeComboBox";
            this.fileTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.fileTypeComboBox.TabIndex = 13;
            this.fileTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.fileTypeComboBox_SelectedIndexChanged);
            // 
            // fileTypeLabel
            // 
            this.fileTypeLabel.AutoSize = true;
            this.fileTypeLabel.Location = new System.Drawing.Point(15, 138);
            this.fileTypeLabel.Name = "fileTypeLabel";
            this.fileTypeLabel.Size = new System.Drawing.Size(46, 13);
            this.fileTypeLabel.TabIndex = 14;
            this.fileTypeLabel.Text = "File type";
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(12, 543);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(68, 21);
            this.helpButton.TabIndex = 15;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.fileTypeLabel);
            this.Controls.Add(this.fileTypeComboBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.pathToFtp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.downloadAndSendToServer);
            this.Controls.Add(this.DebugLogLabel);
            this.Controls.Add(this.DebugLog);
            this.Controls.Add(this.localPathToDownloadLabel);
            this.Controls.Add(this.localPathToDownload);
            this.Controls.Add(this.downloadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox localPathToDownload;
        private System.Windows.Forms.Label localPathToDownloadLabel;
        private System.Windows.Forms.RichTextBox DebugLog;
        private System.Windows.Forms.Label DebugLogLabel;
        private System.Windows.Forms.Button downloadAndSendToServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pathToFtp;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.ComboBox fileTypeComboBox;
        private System.Windows.Forms.Label fileTypeLabel;
        private System.Windows.Forms.Button helpButton;
    }
}

