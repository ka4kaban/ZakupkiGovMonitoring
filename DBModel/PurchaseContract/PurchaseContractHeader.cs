using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class PurchaseContractHeader
    {
        public DateTime CreateDateTime { get; set; }
        public Guid PurchaseGuid { get; set; }

        public PurchaseContractHeader(XElement head)
        {
            PurchaseGuid = head.GetGuid("guid");
            CreateDateTime = head.GetDateTime("createDateTime");
        }
    }

}
