using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class ContractItem
    {
        public OKDP OKDP { get; set; }
        public OKVED OKVED { get; set; }
        public OKEI OKEI { get; set; }
        public string QTY { get; set; }
        public string OrdinalNumber { get; set; }

        public ContractItem(XElement node)
        {
            if(node.GetDescendant("OKDP") != null)
                OKDP = new OKDP(node.GetDescendant("OKDP"));
            if (node.GetDescendant("OKVED") != null)
                OKVED = new OKVED(node.GetDescendant("OKVED"));
            if (node.GetDescendant("OKEI") != null)
                OKEI = new OKEI(node.GetDescendant("OKEI"));

            QTY = node.GetString("QTY");
            OrdinalNumber = node.GetString("OrdinalNumber");
        }
    }
}
