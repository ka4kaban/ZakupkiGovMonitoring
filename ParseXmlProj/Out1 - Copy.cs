//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml;
//using System.Xml.Linq;
//using System.Xml.Serialization;

//namespace ParseXmlProj
//{
//    public static class Out1
//    {
//        public static void PursePurchaseContract()
//        {
//            var serializer = new XmlSerializer(typeof(Xml2CSharpContract.PurchaseContract));
//            string filePath = @"D:\xmlStorage\0000000001_purchaseContract_20131203_000000_001\0000000001_purchaseContract_20131203_000000_001.xml";
//            XDocument xml = XDocument.Load(filePath);
//            var buffer = Encoding.UTF8.GetBytes(xml.Root.ToString());

//            using (var stream = new MemoryStream(buffer))
//            {
//                var purchaseNotice = (Xml2CSharpContract.PurchaseContract)serializer.Deserialize(stream);
//            }
//            //try
//            //{
//            //    //string filePath = @"C:\contacts.xml";
//            //    string filePath = @"D:\xmlStorage\0000000001_purchaseContract_20131203_000000_001\0000000001_purchaseContract_20131203_000000_001.xml";
//            //    XDocument xml = XDocument.Load(filePath);
//            //    //var query = from c in xml.Root.Descendants("contact")
//            //    //            where (int)c.Attribute("id") < 4
//            //    //            select c.Element("firstName").Value + " " +
//            //    //                   c.Element("lastName").Value;
//            //    //PurchaseContractHeader info = PurchaseContractHeader.GetPurchaseContractInfo(xml);

//            //    XElement head = (XElement)xml.Root.FirstNode;
//            //    XElement body = (XElement)xml.Root.FirstNode.NextNode;

//            //    PurchaseContractHeader info = new PurchaseContractHeader(head);
//            //    PurchaseContractData data = new PurchaseContractData(body);
//            //}
//            //catch (Exception ex)
//            //{
//            //}
//        }

//        public static void ParsePurchaseContractAccountAuto() {
//            string path = @"D:\xmlStorage\0000000001_purchaseContractAccount_20140110_000000_001.xml\0000000001_purchaseContractAccount_20140110_000000_001.xml";
//            Xml2CSharp4.PurchaseContractAccount res = parseXML<Xml2CSharp4.PurchaseContractAccount>(path);
           
//        }

//        public static T parseXML<T>(string fullName)
//        {
//            var serializer = new XmlSerializer(typeof(T));
//            XDocument xml = XDocument.Load(fullName);
//            var buffer = Encoding.UTF8.GetBytes(xml.Root.ToString());
//            var stream = new MemoryStream(buffer);
//            return (T)serializer.Deserialize(stream);
//        }

//        public static void ParsePurchaseNotice()
//        {
//            var serializer = new XmlSerializer(typeof(Xml2CSharp.PurchaseNotice));
//            string filePath = @"D:\xmlStorage\0000000001_purchaseNotice_20130619_033104_001\0000000001_purchaseNotice_20130619_033104_001.xml";
//            XDocument xml = XDocument.Load(filePath);
//            var buffer = Encoding.UTF8.GetBytes(xml.Root.ToString());

//            using (var stream = new MemoryStream(buffer))
//            {
//                var purchaseNotice = (Xml2CSharp.PurchaseNotice)serializer.Deserialize(stream);
//            }

//           //    XDocument xml = XDocument.Load(filePath);
//            //try
//            //{
//            //    string filePath = @"D:\xmlStorage\0000000001_purchaseNotice_20130619_033104_001\0000000001_purchaseNotice_20130619_033104_001.xml";
//            //    XDocument xml = XDocument.Load(filePath);
//            //    XElement head = (XElement)xml.Root.FirstNode;
//            //    XElement body = (XElement)xml.Root.FirstNode.NextNode;

//            //    PurchaseNoticeHeader info = new PurchaseNoticeHeader(head);
//            //    PurchaseNoticeData data = new PurchaseNoticeData(body);
//            //}
//            //catch (Exception ex)
//            //{
//            //    string message = ex.Message;
//            //    string stackTrace = ex.StackTrace;
//            //}
//        }
//    }
//}
