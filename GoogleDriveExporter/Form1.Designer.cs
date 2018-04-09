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
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // downloadButton
            // 
            this.downloadButton.Location = new System.Drawing.Point(12, 64);
            this.downloadButton.Name = "downloadButton";
            this.downloadButton.Size = new System.Drawing.Size(233, 24);
            this.downloadButton.TabIndex = 1;
            this.downloadButton.Text = "Download locally";
            this.downloadButton.UseVisualStyleBackColor = true;
            this.downloadButton.Click += new System.EventHandler(this.downloadButton_Click);
            // 
            // localPathToDownload
            // 
            this.localPathToDownload.Location = new System.Drawing.Point(12, 38);
            this.localPathToDownload.Name = "localPathToDownload";
            this.localPathToDownload.Size = new System.Drawing.Size(233, 20);
            this.localPathToDownload.TabIndex = 2;
            // 
            // localPathToDownloadLabel
            // 
            this.localPathToDownloadLabel.AutoSize = true;
            this.localPathToDownloadLabel.Location = new System.Drawing.Point(9, 22);
            this.localPathToDownloadLabel.Name = "localPathToDownloadLabel";
            this.localPathToDownloadLabel.Size = new System.Drawing.Size(121, 13);
            this.localPathToDownloadLabel.TabIndex = 3;
            this.localPathToDownloadLabel.Text = "Local path for download";
            // 
            // DebugLog
            // 
            this.DebugLog.Location = new System.Drawing.Point(774, 38);
            this.DebugLog.Name = "DebugLog";
            this.DebugLog.Size = new System.Drawing.Size(334, 526);
            this.DebugLog.TabIndex = 4;
            this.DebugLog.Text = "";
            // 
            // DebugLogLabel
            // 
            this.DebugLogLabel.AutoSize = true;
            this.DebugLogLabel.Location = new System.Drawing.Point(771, 22);
            this.DebugLogLabel.Name = "DebugLogLabel";
            this.DebugLogLabel.Size = new System.Drawing.Size(65, 13);
            this.DebugLogLabel.TabIndex = 5;
            this.DebugLogLabel.Text = "Debug Logs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 576);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DebugLogLabel);
            this.Controls.Add(this.DebugLog);
            this.Controls.Add(this.localPathToDownloadLabel);
            this.Controls.Add(this.localPathToDownload);
            this.Controls.Add(this.downloadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button downloadButton;
        private System.Windows.Forms.TextBox localPathToDownload;
        private System.Windows.Forms.Label localPathToDownloadLabel;
        private System.Windows.Forms.RichTextBox DebugLog;
        private System.Windows.Forms.Label DebugLogLabel;
        private System.Windows.Forms.Button button1;
    }
}

