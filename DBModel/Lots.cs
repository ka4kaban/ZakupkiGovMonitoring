﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class Lots
    {
        public List<Lot> LotsList { get; set; }

        public Lots(XElement node)
        {
            IEnumerable<XElement> lotNodes = node.Descendants().Where(s => s.Name.LocalName.ToLower() == "lot".ToLower());
            LotsList = new List<Lot>();
            foreach (XElement el in lotNodes)
            {
                LotsList.Add(new Lot(el));
            }

        }
    }
}
