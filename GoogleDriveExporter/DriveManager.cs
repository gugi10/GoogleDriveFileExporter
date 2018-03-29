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

    public class DriveManager {
        // If modifying these scopes, delete your previously saved credentials
        // at ~/.credentials/drive-dotnet-quickstart.json
        static string[] Scopes = { DriveService.Scope.DriveReadonly };
        static string ApplicationName = "Drive API .NET Quickstart";
        DriveService service;


        public void initializeDriverService() {
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
                Console.WriteLine("Credential file saved to: " + credPath);
            }

            // Create Drive API service.
            service = new DriveService(new BaseClientService.Initializer() {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
         downloadFile();
        }

        void downloadFile() {
            var fileId = "10mDzj3gWgsyNWuzoqj0qC2-wmpciUtBI-rW2PyRiaak";
            var request = service.Files.Export(fileId, "application/pdf");
            var streamS = new System.IO.MemoryStream();
            printFile(service, fileId);
            request.MediaDownloader.ProgressChanged +=
            (IDownloadProgress progress) => {
                switch (progress.Status) {
                    case DownloadStatus.Downloading: {
                            Console.WriteLine(progress.BytesDownloaded);
                            break;
                        }
                    case DownloadStatus.Completed: {
                            Console.WriteLine("Download complete.");
                            break;
                        }
                    case DownloadStatus.Failed: {
                            Console.Read();
                            Console.WriteLine("Download failed.");
                            break;
                        }
                }
                Console.ReadKey();
            };
            request.Download(streamS);
            using (FileStream fs = System.IO.File.Create("C:\\Users\\Maciek\\source\\repos\\GoogleDriveExportertest3.pdf")) {
            Console.WriteLine("Saving file");
                Byte[] info = streamS.GetBuffer();
                fs.Write(info, 0, info.Length);
            }
        }

        void printFile(DriveService service, String fileId) {
            try {
                Google.Apis.Drive.v2.Data.File file = service.Files.Get(fileId).Execute();

                Console.WriteLine("Title: " + file.Title);
                Console.WriteLine("Description: " + file.Description);
                Console.WriteLine("MIME type: " + file.MimeType);
            }
            catch (Exception e) {
                Console.WriteLine("An error occurred: " + e.Message);
                Console.ReadKey();
            }
        }
    }

