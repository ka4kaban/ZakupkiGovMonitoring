﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.IO.Compression;
//using System.IO.Compression.FileSystem;

namespace ParseXmlProj
{
    class Program
    {
        public const string zipsFolder = @"D:\xmlStorage\temp\";
        public const string extractFolder = @"D:\xmlStorage\extract\";
        static void Main(string[] args)
        {
            //string filePath = @"D:\xmlStorage\0000000001_purchaseContract_20131203_000000_001\0000000001_purchaseContract_20131203_000000_001.xml";
            //Xml2CSharpContract.PurchaseContract res1 = Out1.ParseXML<Xml2CSharpContract.PurchaseContract>(filePath);

            //string path1 = @"D:\xmlStorage\0000000001_purchaseContractAccount_20140110_000000_001\0000000001_purchaseContractAccount_20140110_000000_001.xml";
            //Xml2CSharp4.PurchaseContractAccount res2 = Out1.ParseXML<Xml2CSharp4.PurchaseContractAccount>(path1);
            //F
            //string path2 = @"D:\xmlStorage\0000000001_purchaseNotice_20130619_033104_001\0000000001_purchaseNotice_20130619_033104_001.xml";
            //Xml2CSharp.PurchaseNotice res3 = Out1.ParseXML<Xml2CSharp.PurchaseNotice>(path2);

            //string pathRej = @"D:\xmlStorage\0000000001_purchaseRejection_20140423_000000_001\0000000001_purchaseRejection_20140423_000000_001.xml";
            //Xml2CSharp5.PurchaseRejection resREj = Out1.ParseXML<Xml2CSharp5.PurchaseRejection>(pathRej);
            ParseAllXML();

            //using (var db = new DirtyContext()) {
            //    db.OrderClauses.Add(new OrderClause());
            //    db.SaveChanges();
            //}
        }
        public static Type GetClassByFileName(string filName)
        {
            Type result = typeof(string);
            if (filName.Contains("purchaseContractAccount"))
                result = typeof(PurchaseContractAccount);
            else if (filName.Contains("purchaseNotice"))
                result = typeof(PurchaseNotice);
            else if (filName.Contains("purchaseRejection"))
                result = typeof(PurchaseRejection);
            else if (filName.Contains("explanation"))
                result = typeof(Explanation);
            else if (filName.Contains("orderClause"))
                result = typeof(OrderClause);
            else if (filName.Contains("purchasePlan"))
                result = typeof(PurchasePlan);
            else if (filName.Contains("purchaseProtocolCancellation"))
                result = typeof(ProtocolCancellation);
            else if (filName.Contains("purchaseProtocolOSZ"))
                result = typeof(PurchaseProtocolOSZ);
            else if (filName.Contains("purchaseProtocolPAAE94"))
                result = typeof(object);
            else if (filName.Contains("purchaseProtocolPAAE"))
                result = typeof(PurchaseProtocolPAAE);
            else if (filName.Contains("purchaseProtocolPAEP"))
                result = typeof(PurchaseProtocolPAEP);
            else if (filName.Contains("purchaseProtocolPAOA"))
                result = typeof(object);
            else if (filName.Contains("purchaseProtocolRZOA"))
                result = typeof(object);
            else if (filName.Contains("purchaseProtocolRZAE"))
                result = typeof(PurchaseProtocolRZAE);
            else if (filName.Contains("purchaseProtocolRZOK"))
                result = typeof(PurchaseProtocolRZOK);
            else if (filName.Contains("purchaseProtocolVK"))
                result = typeof(PurchaseProtocolVK);
            else if (filName.Contains("purchaseProtocolZK"))
                result = typeof(PurchaseProtocolZK);
            else if (filName.Contains("_purchaseProtocol_"))
                result = typeof(PurchaseProtocol);
            else if (filName.Contains("purchaseContract"))
                result = typeof(PurchaseContract);
            else
                Logger.Log("class name for " + filName + " is not exists", Logger.LogType.Err);

            return result;
        }

        public static void ParseAllXML()
        {
            List<string> result = new List<string>();
            DirectoryInfo root = new DirectoryInfo(extractFolder);
            DirectoryInfo[] dirs = root.GetDirectories();

            using (var db = new DirtyContext())
            {

                foreach (DirectoryInfo dir in dirs)
                {
                    FileInfo[] files = dir.GetFiles("*.xml");

                    foreach (FileInfo file in files)
                    {
                        Type t = GetClassByFileName(file.Name);
                        if (t == typeof(OrderClause))
                        {
                            OrderClause resREj = Out1.ParseXML<OrderClause>(file.FullName);
                            //Xml2CSharp.OrderClause resREj = Out1.ParseXML<Xml2CSharp.OrderClause>(file.FullName);
                            db.OrderClauses.Add(resREj);
                            //db.OrderClauses.Add(new OrderClause());
                        }
                        //else 
                        //if (t == typeof(PurchaseNotice))
                        //{
                        //    var resREj = Out1.ParseXML<PurchaseNotice>(file.FullName);
                        //    //db.PurchaseNotices.Add(resREj);
                        //}


                        //db.OrderClauses.a
                        //Logger.Log(file.Name + " has class name for " + t.FullName, Logger.LogType.Processed);
                    }
                }
                db.SaveChanges();
            }
        }

        public static void UnzipAllFiles()
        {
            List<string> zipFiles = GetFileNames(zipsFolder, "*.zip");

            foreach (string zipFile in zipFiles)
            {
                try
                {
                    UnzipFile(zipFile);
                }
                catch
                {
                }
            }
        }
        static void UnzipFile(string zipName)
        {
            string unzipFolder = extractFolder + zipName.Replace(".xml", string.Empty).Replace(".zip", string.Empty);
            bool exists = Directory.Exists(unzipFolder);
            if (!exists)
                Directory.CreateDirectory(unzipFolder);

            ZipFile.ExtractToDirectory(zipsFolder + zipName, unzipFolder);
        }

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
    }
}