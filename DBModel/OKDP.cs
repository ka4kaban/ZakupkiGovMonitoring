using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class OKDP
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public OKDP(XElement node)
        {
            Code = node.GetString("Code");
            Name = node.GetString("Name");
        }
    }

}
