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
        public static void e(Stream stream, string path) {
            // Get the object used to communicate with the server.
            FtpWebRequest request =
                (FtpWebRequest)WebRequest.Create("ftp://www.mkwk018.cba.pl/ftptestmaciejs.cba.pl/test.pdf");
            request.Method = WebRequestMethods.Ftp.UploadFile;
            request.Credentials = new NetworkCredential("maciejsowiar", "4Dm!n");
            //using (var resp = (FtpWebResponse)request.GetResponse()) {
            //    Console.WriteLine(resp.StatusCode);
            //}
            //request.Method = WebRequestMethods.Ftp.UploadFile;
            request.UseBinary = true;

            StreamReader sourceStream = new StreamReader(path+@"\GoogleDriveExporter.pdf");
            byte[] fileContents = Encoding.UTF8.GetBytes(sourceStream.ReadToEnd());
            sourceStream.Close();
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
