using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace DBModel
{
    public static class Start
    {
        public static Logger Logger { set; get; }
        public  static void InitNLog() {
            var config = new NLog.Config.LoggingConfiguration();

            var logfile = new NLog.Targets.FileTarget("logfile") { FileName = "file.txt" };
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole");

            config.AddRule(LogLevel.Info, LogLevel.Fatal, logconsole);
            config.AddRule(LogLevel.Debug, LogLevel.Fatal, logfile);

            NLog.LogManager.Configuration = config;
            Logger = NLog.LogManager.GetCurrentClassLogger();
        }
        public static void PursePurchaseContract()
        {
            InitNLog();
            //try
            //{
            //    string filePath = @"D:\xmlStorage\extract\0000000001\0000000001_purchaseContract_20131115_000000_001\0000000001_purchaseContract_20131115_000000_015.xml";
            //    PurchaseContractData data = new PurchaseContractData(filePath);
            //}
            //catch (Exception ex)
            //{
            //    Logger.Error(ex);
            //}
            string purchaseNoticefilePath = string.Empty;
            try
            {
                purchaseNoticefilePath = @"D:\xmlStorage\extract\0000000007\0000000007_purchaseNotice_20170818_044935_001\0000000007_purchaseNotice_20170818_044935_007.xml";
                PurchaseNoticeData data = new PurchaseNoticeData(purchaseNoticefilePath);
            }
            catch (Exception ex)
            {
                Logger.Info("path to file" + purchaseNoticefilePath);
                Logger.Error(ex);
            }
            //D:\xmlStorage\extract\0000000007\0000000007_purchaseNotice_20170818_044935_001\0000000007_purchaseNotice_20170818_044935_007.xml
        }



        //public static void PursePurchaseContract()
        //{
        //    InitNLog();
        //    //var serializer = new XmlSerializer(typeof(PurchaseContract));
        //    //string filePath = @"D:\xmlStorage\0000000001_purchaseContract_20131203_000000_001\0000000001_purchaseContract_20131203_000000_001.xml";
        //    //XDocument xml = XDocument.Load(filePath);
        //    //var buffer = Encoding.UTF8.GetBytes(xml.Root.ToString());

        //    //using (var stream = new MemoryStream(buffer))
        //    //{
        //    //    var purchaseNotice = (PurchaseContract)serializer.Deserialize(stream);
        //    //}

        //    //var logger = NLog.LogManager.GetCurrentClassLogger();
        //    //logger.Info("Hello World");



        //    var logger = NLog.LogManager.GetCurrentClassLogger();

        //    try
        //    {
        //        //string filePath = @"C:\contacts.xml";

        //        string filePath = @"D:\xmlStorage\extract\0000000001\0000000001_purchaseContract_20131115_000000_001\0000000001_purchaseContract_20131115_000000_015.xml";
        //        XDocument xml = XDocument.Load(filePath);
        //        //var query = from c in xml.Root.Descendants("contact")
        //        //            where (int)c.Attribute("id") < 4
        //        //            select c.Element("firstName").Value + " " +
        //        //                   c.Element("lastName").Value;
        //        //PurchaseContractHeader info = PurchaseContractHeader.GetPurchaseContractInfo(xml);

        //        //XElement head = (XElement)xml.Root.FirstNode;
        //        XElement body = (XElement)xml.Root.FirstNode.NextNode;

        //        //PurchaseContractHeader info = new PurchaseContractHeader(head);
        //        PurchaseContractData data = new PurchaseContractData(body);
        //    }
        //    catch (Exception ex)
        //    {
        //        logger.Error(ex);
        //    }

        //    //D:\xmlStorage\extract\0000000007\0000000007_purchaseNotice_20170818_044935_001\0000000007_purchaseNotice_20170818_044935_007.xml
        //}

        //public static void ParsePurchaseContractAccountAuto()
        //{
        //    string path = @"D:\xmlStorage\0000000001_purchaseContractAccount_20140110_000000_001.xml\0000000001_purchaseContractAccount_20140110_000000_001.xml";
        //    PurchaseContractAccount res = parseXML<PurchaseContractAccount>(path);

        //}

        //public static T parseXML<T>(string fullName)
        //{
        //    var serializer = new XmlSerializer(typeof(T));
        //    XDocument xml = XDocument.Load(fullName);
        //    var buffer = Encoding.UTF8.GetBytes(xml.Root.ToString());
        //    var stream = new MemoryStream(buffer);
        //    return (T)serializer.Deserialize(stream);
        //}

        //public static void ParsePurchaseNotice()
        //{
        //    var serializer = new XmlSerializer(typeof(PurchaseNotice));
        //    string filePath = @"D:\xmlStorage\0000000001_purchaseNotice_20130619_033104_001\0000000001_purchaseNotice_20130619_033104_001.xml";
        //    XDocument xml = XDocument.Load(filePath);
        //    var buffer = Encoding.UTF8.GetBytes(xml.Root.ToString());

        //    using (var stream = new MemoryStream(buffer))
        //    {
        //        var purchaseNotice = (PurchaseNotice)serializer.Deserialize(stream);
        //    }

        //    //    XDocument xml = XDocument.Load(filePath);
        //    //try
        //    //{
        //    //    string filePath = @"D:\xmlStorage\0000000001_purchaseNotice_20130619_033104_001\0000000001_purchaseNotice_20130619_033104_001.xml";
        //    //    XDocument xml = XDocument.Load(filePath);
        //    //    XElement head = (XElement)xml.Root.FirstNode;
        //    //    XElement body = (XElement)xml.Root.FirstNode.NextNode;

        //    //    PurchaseNoticeHeader info = new PurchaseNoticeHeader(head);
        //    //    PurchaseNoticeData data = new PurchaseNoticeData(body);
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    string message = ex.Message;
        //    //    string stackTrace = ex.StackTrace;
        //    //}
        //}
    }
}
