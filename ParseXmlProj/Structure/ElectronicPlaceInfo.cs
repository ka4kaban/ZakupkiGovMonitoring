//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ParseXmlProj.Structure
//{
//    public class ElectronicPlaceInfo
//    {
//        public string Name { get; set; }
//        public string Url { get; set; }
//        public int ElectronicPlaceId { get; set; }
//        public DateTime PurchaseDateTime { get; set; }
//        public string ExaminationPlace { get; set; }
//        public DateTime ExaminationDateTime { get; set; }

//        public ElectronicPlaceInfo(XElement node)
//        {
//            Name = node.GetString("name");
//            Url = node.GetString("Url");
//            ElectronicPlaceId = node.GetInt("ElectronicPlaceId");
//            PurchaseDateTime = node.GetDateTime("PurchaseDateTime");
//            ExaminationPlace = node.GetString("ExaminationPlace");
//            ExaminationDateTime = node.GetDateTime("ExaminationDateTime");
//        }
//    }
//}