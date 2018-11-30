//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ParseXmlProj
//{
//    public class PurchaseNoticeHeader
//    {
//        public DateTime CreateDateTime { get; set; }
//        public Guid PurchaseGuid { get; set; }

//        public PurchaseNoticeHeader(XElement head)
//        {
//            PurchaseGuid = head.GetGuid("guid");
//            CreateDateTime = head.GetDateTime("createDateTime");
//        }
//    }

//}
