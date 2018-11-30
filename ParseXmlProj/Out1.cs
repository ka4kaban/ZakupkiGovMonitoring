using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ParseXmlProj
{
    public static class Out1
    {
        //public static void PursePurchaseContract()
        //{
        //    string filePath = @"D:\xmlStorage\0000000001_purchaseContract_20131203_000000_001\0000000001_purchaseContract_20131203_000000_001.xml";
        //    Xml2CSharpContract.PurchaseContract res = parseXML<Xml2CSharpContract.PurchaseContract>(filePath);
        //}

        //public static void ParsePurchaseContractAccountAuto() {
        //    string path = @"D:\xmlStorage\0000000001_purchaseContractAccount_20140110_000000_001.xml\0000000001_purchaseContractAccount_20140110_000000_001.xml";
        //    Xml2CSharp4.PurchaseContractAccount res = parseXML<Xml2CSharp4.PurchaseContractAccount>(path);
        //}

        public static T ParseXML<T>(string fullName)
        {
            var serializer = new XmlSerializer(typeof(T));
            XDocument xml = XDocument.Load(fullName);
            var buffer = Encoding.UTF8.GetBytes(xml.Root.ToString());
            var stream = new MemoryStream(buffer);
            return (T)serializer.Deserialize(stream);
        }

        //public static void ParsePurchaseNotice()
        //{
        //    string path = @"D:\xmlStorage\0000000001_purchaseNotice_20130619_033104_001\0000000001_purchaseNotice_20130619_033104_001.xml";
        //    Xml2CSharp.PurchaseNotice res = parseXML<Xml2CSharp.PurchaseNotice>(path);
        //}
    }
}
