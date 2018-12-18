using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class DeliveryPlace
    {
        public string Address { get; set; }
        public DeliveryPlace(XElement node)
        {
            Address = node.GetString("address");
        }
    }
}
