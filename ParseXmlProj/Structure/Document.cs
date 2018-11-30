//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ParseXmlProj.Structure
//{
//    public class Document
//    {
//        public Guid Guid { get; set; }
//        public DateTime CreateDateTime { get; set; }
//        public string FileName { get; set; }
//        public string Description { get; set; }
//        public string Url { get; set; }

//        public Document(XElement node)
//        {
//            this.Guid = node.GetGuid("Guid");
//            this.CreateDateTime = node.GetDateTime("CreateDateTime");
//            this.FileName = node.GetString("FileName");
//            this.Description = node.GetString("Description");
//            this.Url = node.GetString("Url");
//        }
//    }
//}
