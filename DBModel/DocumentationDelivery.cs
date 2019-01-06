using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class DocumentationDelivery
    {
        public DateTime DeliveryStartDateTime { get; set; }
        public DateTime DeliveryEndDateTime { get; set; }
        public string Place { get; set; }
        public string Procedure { get; set; }

        public DocumentationDelivery(XElement node)
        {
            if (node.GetDescendant("DeliveryStartDateTime") != null)
                DeliveryStartDateTime = node.GetDateTime("DeliveryStartDateTime");
            if (node.GetDescendant("DeliveryEndDateTime") != null)
                DeliveryEndDateTime = node.GetDateTime("DeliveryEndDateTime");
            Place = node.GetString("Place");
            Procedure = node.GetString("Procedure");
        }
    }
}
