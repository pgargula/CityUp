using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;

namespace CityUpDesktop
{
    class FtpController
    {
        private string host = @"ftp://ftp.cba.pl/";
        private string user = "hackatonsii@hackatonsii.cba.pl";
        private string pass = "Wowtogra1";
        public void upload(string remoteFile, string localFile)
        {
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(host + "/" + remoteFile);
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = true;
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(user, pass);

                byte[] fileContents = System.IO.File.ReadAllBytes(localFile);

                request.ContentLength = fileContents.Length;

                Stream requestStream = request.GetRequestStream();
                requestStream.Write(fileContents, 0, fileContents.Length);
                requestStream.Close();

                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                response.Close();
                
            }
            catch (Exception ex) { Console.WriteLine(ex.ToString()); }
            return;
        }
    }
}
