//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ParseXmlProj.Structure
//{
//    public class ContractItemCollection
//    {
//        public List<ContractItem> Items { get; set; }
//        public ContractItemCollection(XElement node)
//        {
//            IEnumerable<XElement> contractItemNodes = node.Descendants().Where(s => s.Name.LocalName.ToLower() == "ContractItem".ToLower());
//            Items = new List<ContractItem>();
//            foreach (XElement el in contractItemNodes)
//            {
//                Items.Add(new ContractItem(el));
//            }

//        }
//    }
//}
