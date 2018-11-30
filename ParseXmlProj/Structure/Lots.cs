//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace ParseXmlProj.Structure
//{
//    public class Lots
//    {
//        public List<Lot> LotItemns { get; set; }

//        public Lots(XElement node)
//        {
//            IEnumerable<XElement> lotNodes = node.Descendants().Where(s => s.Name.LocalName.ToLower() == "lot".ToLower());
//            LotItemns = new List<Lot>();
//            foreach (XElement el in lotNodes)
//            {
//                LotItemns.Add(new Lot(el));
//            }

//        }
//    }
//}
