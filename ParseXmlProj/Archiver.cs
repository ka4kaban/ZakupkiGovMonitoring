using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseXmlProj
{
    public static class Archiver
    {
        //TODO: merge it with storagedownloader  
        public static List<string> GetDataBuses()
        {
            return new List<string>()
            {
                "0000000001/",
                "0000000002/",
                "0000000003/",
                "0000000004/",
                "0000000005/",
                "0000000006/",
                "0000000007/"
            };
        }
        public const string zipsFolder = @"D:\xmlStorage\out\";
        public const string extractFolder = @"D:\xmlStorage\extract\";
        
        static List<string> GetFileNames(string folder, string searchPattern)
        {
            List<string> result = new List<string>();
            DirectoryInfo d = new DirectoryInfo(folder);
            FileInfo[] Files = d.GetFiles(searchPattern);

            foreach (FileInfo file in Files)
            {
                result.Add(file.Name);
            }

            return result;
        }

        public static void UnzipAllFiles()
        {

            List<string> dataBuses = GetDataBuses();

            foreach (string dataBuse in dataBuses)
            {

                List<string> zipFiles = GetFileNames(zipsFolder + dataBuse, "*.zip");
                foreach (string zipFile in zipFiles)
                {
                    try
                    {
                        UnzipFile(zipFile, dataBuse);
                    }
                    catch
                    {
                    }
                }
            }
        }
        static void UnzipFile(string zipName, string dataBuse)
        {
            string unzipFolder = extractFolder + dataBuse.Replace(@"/",@"\") + zipName.Replace(".xml", string.Empty).Replace(".zip", string.Empty);
            bool exists = Directory.Exists(unzipFolder);
            if (!exists)
                Directory.CreateDirectory(unzipFolder);

            ZipFile.ExtractToDirectory(zipsFolder + dataBuse.Replace(@"/", @"\") + zipName, unzipFolder);
        }
    }
}
