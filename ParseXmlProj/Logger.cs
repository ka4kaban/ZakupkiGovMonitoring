using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseXmlProj
{

    //public class Logger
    //{
    //    private static readonly LogFactory logFactory = new NLog.LogFactory();

    //    public Logger()
    //    {
    //    }

    //    public void Trace(LogLevel level, string category, string msg, Exception ex = null)
    //    {
    //        var message = new StringBuilder();

    //        if (!string.IsNullOrWhiteSpace(msg))
    //            message.Append(" ").Append(msg);

    //        if (ex != null && !string.IsNullOrWhiteSpace(ex.GetBaseException().Message))
    //        {
    //            message.Append(" ").Append(ex.GetBaseException().Message);
    //            message.Append(" ").Append(ex.StackTrace);
    //            if (ex.InnerException != null && !string.IsNullOrWhiteSpace(ex.InnerException.GetBaseException().Message))
    //            {
    //                message.Append(" ").Append(ex.InnerException.GetBaseException().Message);
    //                message.Append(" ").Append(ex.InnerException.StackTrace);
    //            }
    //        }

    //        var logs = logFactory.GetLogger(category);
    //        logs.Log(level, message.ToString());
    //    }
    //}

    //public static class Logger
    //{
    //    const string logsFolder = @"D:\xmlStorage\logs\";
    //    public enum LogType : int { Err = 0, Processed = 1, Warning = 2 };

    //    public static string CreateFolders()
    //    {
    //        DirectoryInfo root = new DirectoryInfo(logsFolder);
    //        DateTime curDate = DateTime.Now;

    //        string currentDateLogFolder = logsFolder + curDate.Date.ToShortDateString();
    //        bool isFolderExists = Directory.Exists(currentDateLogFolder);

    //        if (!isFolderExists)
    //        {
    //            Directory.CreateDirectory(currentDateLogFolder);
    //            Directory.CreateDirectory(currentDateLogFolder + "\\" + LogType.Err.ToString());
    //            Directory.CreateDirectory(currentDateLogFolder + "\\" + LogType.Warning.ToString());
    //            Directory.CreateDirectory(currentDateLogFolder + "\\" + LogType.Processed.ToString());
    //        }
    //        return currentDateLogFolder;
    //    }

    //    public static void Log(string message, LogType lType)
    //    {
    //        string currentDateLogFolder = CreateFolders();
    //        string logFile = currentDateLogFolder + "\\" + lType.ToString() + "\\log.txt";
    //        bool isFileExists = File.Exists(logFile);

    //        if (!isFileExists)
    //        {
    //            File.Create(logFile);
    //        }

    //        using (var tw = new StreamWriter(logFile, isFileExists))
    //        {
    //            tw.WriteLine(message);
    //            tw.Close();
    //        }
    //    }
    //}
}
