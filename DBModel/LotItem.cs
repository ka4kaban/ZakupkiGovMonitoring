using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace DBModel
{
    public class LotItem
    {
        public Guid Guid { get; set; }

        public string OrdinalNumber { get; set; }

        //public OKDP OKDP { get; set; }
        //public OKVED OKVED { get; set; }
        //public OKEI OKEI { get; set; }
        public string OKDPCode { get; set; }
        public string OKDPName { get; set; }

        public string OKVEDCode { get; set; }
        public string OKVEDName { get; set; }

        public string OKEICode { get; set; }
        public string OKEIName { get; set; }

        public string QTY { get; set; }

        public LotItem(XElement node)
        {
            //OKDP = new OKDP(node.GetDescendant("okpd2"));
            //OKVED = new OKVED(node.GetDescendant("OKVED2"));
            //OKEI = new OKEI(node.GetDescendant("OKEI"));

            ParseOKDP(node);
            ParseOKVED(node);
            ParseOKEI(node);

            QTY = node.GetString("QTY");
            this.Guid = node.GetGuid("guid");
            OrdinalNumber = node.GetString("OrdinalNumber");
        }

        public void ParseOKDP(XElement node)
        {
            XElement abr = node.GetDescendant("okpd2");
            if (abr != null)
            {
                OKDPCode = node.GetString("Code");
                OKDPName = node.GetString("Name");
            }
        }

        public void ParseOKVED(XElement node)
        {
            XElement abr = node.GetDescendant("OKVED2");
            if (abr != null)
            {
                OKVEDCode = node.GetString("Code");
                OKVEDName = node.GetString("Name");
            }
        }

        public void ParseOKEI(XElement node)
        {
            XElement abr = node.GetDescendant("OKEI");
            if (abr != null)
            {
                OKEICode = node.GetString("Code");
                OKEIName = node.GetString("Name");
            }
        }
    }
}
