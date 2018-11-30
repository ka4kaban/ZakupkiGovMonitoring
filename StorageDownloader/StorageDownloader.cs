using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StorageDownloader
{
    public class StorageDownloader
    {

        public const string FTPusername = "fz223free";
        public const string FTPpassword = "fz223free";

        string FTP_StorageWithCredentials = "ftp://fz223free:fz223free@ftp.zakupki.gov.ru";

        public void FindFiles(DateTime start, DateTime end)
        {

        }
        public void DownloadFiles()
        {
        }
        public void StartObserving()
        {
            string ftphost = "ftp.zakupki.gov.ru";
            string dataBus = "out/0000000001";

            List<string> files = getfiles(ftphost, dataBus, "zip");

            foreach (string shortname in files)
            {
                try
                {
                    DownloadFileFTP(shortname);
                }
                catch {
                }
            }
        }

        private string GetCreateFilePath(string shortName)
        {
            return @"D:\xmlStorage\temp\" + shortName;
        }
        private string GetFtpFullPath(string shortName)
        {
            string dataBus = "/out/0000000001/";
            return "ftp://ftp.zakupki.gov.ru" + dataBus + shortName;
        }

        //private void DownloadFileFTP(string shortName)
        //{
        //    string ftpfullpath = GetFtpFullPath(shortName);
        //    string createfilepath = GetCreateFilePath(shortName);

        //    using (WebClient request = new WebClient())
        //    {
        //        request.Credentials = new NetworkCredential(FTPusername, FTPpassword);
        //        byte[] fileData = request.DownloadData(ftpfullpath);
        //        if (fileData.Length > 222)
        //        {
        //            using (FileStream file = File.Create(createfilepath))
        //            {
        //                file.Write(fileData, 0, fileData.Length);
        //                file.Close();
        //            }
        //        }
        //    }
        //}

        private void DownloadFileFTP(string shortName)
        {
            string ftpfullpath = GetFtpFullPath(shortName);
            string createfilepath = GetCreateFilePath(shortName);

            // Get the object used to communicate with the server.
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpfullpath);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            request.Credentials = new NetworkCredential(FTPusername, FTPpassword);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            if(response.ContentLength > 222)
                using (FileStream writer = new FileStream(createfilepath, FileMode.Create))
                {

                    long length = response.ContentLength;
                    int bufferSize = 2048;
                    int readCount;
                    byte[] buffer = new byte[2048];

                    readCount = responseStream.Read(buffer, 0, bufferSize);
                    while (readCount > 0)
                    {
                        writer.Write(buffer, 0, readCount);
                        readCount = responseStream.Read(buffer, 0, bufferSize);
                    }
                }

            reader.Close();
            response.Close();
        }
        public List<string> getfiles(string FTPhostname, string dataBus, string extension)
        {
            return getfiles(FTPhostname, dataBus, FTPusername, FTPpassword, extension);
        }

        public List<string> getfiles(string FTPhostname, string dataBus, string FTPusername, string FTPpassword, string extension)
        {
            FtpWebRequest ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + FTPhostname + "/" + dataBus);
            ftpRequest.Credentials = new NetworkCredential(FTPusername, FTPpassword);
            ftpRequest.Method = WebRequestMethods.Ftp.ListDirectory;

            FtpWebResponse response = (FtpWebResponse)ftpRequest.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream());

            List<string> results = new List<string>();

            string line = streamReader.ReadLine();
            while (!string.IsNullOrEmpty(line))
            {

                if (line.Contains(extension))
                {
                    line = streamReader.ReadLine();
                    if (line != null)
                    {
                        line = line.Replace("0000000001/", string.Empty);
                        results.Add(line);
                    }
                }

                else { line = streamReader.ReadLine(); }
            }

            streamReader.Close();
            return results;
        }
    }
}
