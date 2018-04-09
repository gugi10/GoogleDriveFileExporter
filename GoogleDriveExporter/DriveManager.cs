using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Download;
using Google.Apis.Drive.v2;
using Google.Apis.Drive.v2.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;
using System.Net;
namespace GoogleDriveExporter {
    public class DriveManager {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive API .NET Quickstart";
        DriveService service;
        Form1 mainForm;
        public System.IO.MemoryStream streamS;
        public DriveManager(Form1 form) {
            mainForm = form;
            streamS = new System.IO.MemoryStream();
        }

        public void InitializeDeviceService() {
            UserCredential credential;

            using (var stream =
                new FileStream("client_secret.json", FileMode.Open, FileAccess.Read)) {
                string credPath = System.Environment.GetFolderPath(
                    System.Environment.SpecialFolder.Personal);
                credPath = Path.Combine(credPath, ".credentials/drive-dotnet-quickstart.json");

                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
                Form1.UpdateDebugLog("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            service = new DriveService(new BaseClientService.Initializer() {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        public void DownloadFile() {
            var fileId = "10mDzj3gWgsyNWuzoqj0qC2-wmpciUtBI-rW2PyRiaak";
            var request = service.Files.Export(fileId, "application/pdf");
            printFile(service, fileId);
            request.MediaDownloader.ProgressChanged +=
            (IDownloadProgress progress) =>
            {
                switch (progress.Status) {
                    case DownloadStatus.Downloading: {
                            Form1.UpdateDebugLog(progress.BytesDownloaded.ToString());
                            break;
                        }
                    case DownloadStatus.Completed: {
                            Form1.UpdateDebugLog("Download complete");
                            break;
                        }
                    case DownloadStatus.Failed: {
                            Console.Read();
                            Form1.UpdateDebugLog("Download failed");
                            break;
                        }
                }
            };
            request.Download(streamS);
            //using (FileStream fs = System.IO.File.Create(localPath + "\\GoogleDriveExporter.pdf")) {
            //    Form1.UpdateDebugLog("Saving file");
            //    Byte[] info = streamS.GetBuffer();
            //    fs.Write(info, 0, info.Length);
            //    //"\\GoogleDriveExporter.pdf
            //}
            //SendFTP.SendFtpToServer(streamS, localPath);
        }

        public void LocalDownloadFile(string localPath) {
            using (FileStream fs = System.IO.File.Create(localPath + "\\GoogleDriveExporter.pdf")) {
                Form1.UpdateDebugLog("Saving file");
                Byte[] info = streamS.GetBuffer();
                fs.Write(info, 0, info.Length);
                //"\\GoogleDriveExporter.pdf
                fs.Close();
            }
            streamS.Close();
        }



        void printFile(DriveService service, String fileId) {
            try {
                Google.Apis.Drive.v2.Data.File file = service.Files.Get(fileId).Execute();
                Form1.UpdateDebugLog("Title: " + file.Title);
                Form1.UpdateDebugLog("Description: " + file.Description);
                Form1.UpdateDebugLog("MIME type: " + file.MimeType);
            }                   
            catch (Exception e) {
                Form1.UpdateDebugLog("An error occured: " + e.Message);
                Console.ReadKey();
            }
        }
    }
}

