//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ParseXmlProj.Structure
//{
//    public class CustomerInfo
//    {
//        //mainInfo
//        public string FullName { get; set; }
//        public string ShortName { get; set; }
//        public string INN { get; set; }
//        public string KPP { get; set; }
//        public string OGRN { get; set; }
//        public string LegalAddress { get; set; }
//        public string PostalAddress { get; set; }
//        public string Phone { get; set; }
//        public string Fax { get; set; }
//        public string Email { get; set; }
//        public string okato { get; set; }

//        public CustomerInfo(XElement node)
//        {
//            FullName = node.GetString("FullName");
//            ShortName = node.GetString("ShortName");
//            INN = node.GetString("INN");
//            KPP = node.GetString("KPP");
//            OGRN = node.GetString("OGRN");
//            LegalAddress = node.GetString("LegalAddress");
//            PostalAddress = node.GetString("PostalAddress");
//            Phone = node.GetString("Phone");
//            Fax = node.GetString("Fax");
//            Email = node.GetString("Email");
//            okato = node.GetString("okato");
//        }
//    }
//}
