using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace GoogleDriveExporter {
    class SendFTP {
        //https://www.mkwk018.cba.pl/ftp/
        Form1 form;
        public SendFTP() {
            form = new Form1();
        }
        public static void SendFtpToServer(System.IO.MemoryStream stream, string login, string password, string ftpAdress) {
            FtpWebRequest request =
                (FtpWebRequest)WebRequest.Create(ftpAdress);
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential(login, password);
            request.UseBinary = true;
            byte[] fileContents = stream.GetBuffer();
            request.ContentLength = fileContents.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Form1.UpdateDebugLog("Upload File Complete, status {0}");
            Form1.UpdateDebugLog(response.StatusDescription);

            response.Close();
        }
    }
}
