using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class OKVED
    {
        public string Code { get; set; }
        public string Name { get; set; }

        public OKVED(XElement node)
        {
            Code = node.GetString("Code");
            Name = node.GetString("Name");
        }
    }
}
