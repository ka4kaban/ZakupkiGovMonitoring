using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class LotItems
    {
        public List<LotItem> LotItemsList { get; set; }

        public LotItems(XElement node)
        {
            IEnumerable<XElement> lotNodes = node.Descendants().Where(s => s.Name.LocalName.ToLower() == "lotItem".ToLower());
            LotItemsList = new List<LotItem>();
            foreach (XElement el in lotNodes)
            {
                LotItemsList.Add(new LotItem(el));
            }

        }
    }
}
