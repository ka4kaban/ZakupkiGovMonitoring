using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class PurchaseContractLot
    {
        public Guid Guid { get; set; }
        public string Subject { get; set; }
        public PurchaseContractLot(XElement node)
        {
            this.Guid = node.GetGuid("guid");
            this.Subject = node.GetString("Subject");
        }
    }
}
