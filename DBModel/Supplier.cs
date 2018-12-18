using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class Supplier
    {
        public string Name { get; set; }
        public string INN { get; set; }
        public string KPP { get; set; }
        public string OGRN { get; set; }
        public string Type { get; set; }

        public Supplier(XElement node)
        {
            Name = node.GetString("Name");
            INN = node.GetString("INN");
            KPP = node.GetString("KPP");
            OGRN = node.GetString("OGRN");
            Type = node.GetString("Type");
        }
    }
}
