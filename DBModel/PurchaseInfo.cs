using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class PurchaseInfo
    {
        public double PurchaseNoticeNumber { get; set; }
        public string Name { get; set; }
        public int PurchaseMethodCode { get; set; }
        public String PurchaseCodeName { get; set; }

        public PurchaseInfo(XElement node)
        {
            this.PurchaseNoticeNumber = node.GetDouble("PurchaseNoticeNumber");
            this.Name = node.GetString("Name");
            this.PurchaseMethodCode = node.GetInt("PurchaseMethodCode");
            this.PurchaseCodeName = node.GetString("PurchaseCodeName");
        }
    }
}
