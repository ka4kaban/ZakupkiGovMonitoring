using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class ElectronicPlaceInfo
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public int ElectronicPlaceId { get; set; }
        public Nullable<DateTime> PurchaseDateTime { get; set; }
        public string ExaminationPlace { get; set; }
        public Nullable<DateTime> ExaminationDateTime { get; set; }

        public ElectronicPlaceInfo(XElement node)
        {
            if (node == null) return;
            Name = node.GetString("name");
            Url = node.GetString("Url");
            ElectronicPlaceId = node.GetInt("ElectronicPlaceId");

            if (node.GetDescendant("PurchaseDateTime") != null)
                PurchaseDateTime = node.GetDateTime("PurchaseDateTime");
            if (node.GetDescendant("ExaminationPlace") != null)
                ExaminationPlace = node.GetString("ExaminationPlace");
            if (node.GetDescendant("ExaminationDateTime") != null)
                ExaminationDateTime = node.GetDateTime("ExaminationDateTime");
        }
    }
}