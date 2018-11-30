//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ParseXmlProj.Structure
//{
//    public class Attachments
//    {
//        public List<Document> Documents { get; set; }

//        public Attachments(XElement node)
//        {
//            IEnumerable<XElement> docNodes = node.Descendants().Where(s => s.Name.LocalName.ToLower() == "document".ToLower());
//            Documents = new List<Document>();
//            foreach (XElement el in docNodes)
//            {
//                Documents.Add(new Document(el));
//            }

//        }
//    }
//}
