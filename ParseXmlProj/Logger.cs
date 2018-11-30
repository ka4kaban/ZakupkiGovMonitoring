using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseXmlProj
{
    public static class Logger
    {
        const string logsFolder = @"D:\xmlStorage\logs\";
        public enum LogType : int { Err = 0, Processed = 1, Warning = 2 };

        public static string CreateFolders()
        {
            DirectoryInfo root = new DirectoryInfo(logsFolder);
            DateTime curDate = DateTime.Now;

            string currentDateLogFolder = logsFolder + curDate.Date.ToShortDateString();
            bool isFolderExists = Directory.Exists(currentDateLogFolder);

            if (!isFolderExists)
            {
                Directory.CreateDirectory(currentDateLogFolder);
                Directory.CreateDirectory(currentDateLogFolder + "\\" + LogType.Err.ToString());
                Directory.CreateDirectory(currentDateLogFolder + "\\" + LogType.Warning.ToString());
                Directory.CreateDirectory(currentDateLogFolder + "\\" + LogType.Processed.ToString());
            }
            return currentDateLogFolder;
        }

        public static void Log(string message, LogType lType)
        {
            string currentDateLogFolder = CreateFolders();
            string logFile = currentDateLogFolder + "\\" + lType.ToString() + "\\log.txt";
            bool isFileExists = File.Exists(logFile);

            if (!isFileExists)
            {
                File.Create(logFile);
            }

            using (var tw = new StreamWriter(logFile, isFileExists))
            {
                tw.WriteLine(message);
                tw.Close();
            }
        }
    }
}
