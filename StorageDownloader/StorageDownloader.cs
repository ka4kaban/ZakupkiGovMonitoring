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
        //public string dataBusSuf = "0000000001";
        //string dataBus = "out/" + dataBusSuf;
        public string GetDataBus(string suf)
        {
            return "/out/" + suf;
        }
        //string FTP_StorageWithCredentials = "ftp://fz223free:fz223free@ftp.zakupki.gov.ru";

        public void FindFiles(DateTime start, DateTime end)
        {

        }
        public void DownloadFiles()
        {
        }
        public List<string> GetDataBuses()
        {
            return new List<string>() {
                //"0000000001/",
                //"0000000002/",
                //"0000000003/",
                //"0000000004/",
                //"0000000005/",
                //"0000000006/",
                //"0000000007/",

                //"0000000008/",
                //"0000000009/",
                //"0000000010/",
                //"0000000011/",
                //"0000000012/",
                //"0000000013/",
                //"0000000014/",
                //"0000000015/",
                //"0000000016/",
                //"0000000017/",

                "0000000018/",
                "0000000019/",
                "0000000020/",
                "0000000021/",
                "0000000022/",
                "0000000023/",
                "0000000024/",
                "0000000025/",
                "0000000026/",
                "0000000027/",
                "0000000028/",
                "0000000029/",
                "0000000030/",
                "0000000031/",
                "0000000032/",
                "0000000033/",
                "0000000034/"
            };
        }
        public void StartObserving()
        {
            CreateDirectories();

            string ftphost = "ftp.zakupki.gov.ru";

            List<string> dtbs = GetDataBuses();
            foreach (string dataBus in dtbs)
            {
                List<string> files = getfiles(ftphost, GetDataBus(dataBus), "zip");

                foreach (string shortname in files)
                {
                    try
                    {
                        DownloadFileFTP(shortname, GetDataBus(dataBus));
                    }
                    catch
                    {
                    }
                }
            }
        }

        private string GetCreateFilePath(string shortName, string dataBus)
        {
            //"/out/0000000001/"
            //return @"D:\xmlStorage\temp\" + shortName;
            return @"D:\xmlStorage" + dataBus.Replace(@"/",@"\") + shortName;
        }
        private string GetFtpFullPath(string shortName, string dataBus)
        {
            return "ftp://ftp.zakupki.gov.ru" + dataBus + shortName;
        }
        private void CreateIfNeed(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        public void CreateDirectories()
        {
            string rootPath = @"D:\xmlStorage\";
            string outPath = rootPath + "out";
            string logsPath = rootPath + "logs";
            string extractPath = rootPath + "extract";

            CreateIfNeed(rootPath);
            CreateIfNeed(outPath);
            CreateIfNeed(logsPath);
            CreateIfNeed(extractPath);
            List<string> dataBuses = GetDataBuses();

            foreach (string dataBuse in dataBuses)
            {
                CreateIfNeed(outPath + @"\" + dataBuse);
            }
            foreach (string dataBuse in dataBuses)
            {
                CreateIfNeed(extractPath + @"\" + dataBuse);
            }
        }
        private void DownloadFileFTP(string shortName, string dataBus)
        {
            string ftpfullpath = GetFtpFullPath(shortName, dataBus);
            string createfilepath = GetCreateFilePath(shortName, dataBus);

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpfullpath);
            request.Method = WebRequestMethods.Ftp.DownloadFile;

            request.Credentials = new NetworkCredential(FTPusername, FTPpassword);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();

            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            if (CanDownloadFile(ftpfullpath))
            {

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
            }

            reader.Close();
            response.Close();
        }
        public bool CanDownloadFile(string ftpfullpath)
        {
            const int MinValidFileSize = 224;
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(ftpfullpath);
            request.Proxy = null;
            request.Credentials = new NetworkCredential(FTPusername, FTPpassword);
            request.Method = WebRequestMethods.Ftp.GetFileSize;

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            long size = response.ContentLength;
            response.Close();
            return size > MinValidFileSize;
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
                        //string dataBus = "out/0000000001";
                        //GetDataBus().Replace()
                        //dataBus.Replace("out/", string.Empty)
                        line = line.Replace(dataBus.Replace("out/", string.Empty) + "/", string.Empty);
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
