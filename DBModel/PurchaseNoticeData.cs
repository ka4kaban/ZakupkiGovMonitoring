using DBModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{


    public class PurchaseNoticeData
    {
        public Guid Guid { get; set; }
        public DateTime CreateDateTime { get; set; }
        public string UrlOOS { get; set; }
        public string RegistrationNumber { get; set; }
        public string Name { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public DateTime modificationDate { get; set; }
        public Placer Placer { get; set; }
        public Contact Contact { get; set; }
        public DateTime PublicationDateTime { get; set; }
        public DocumentationDelivery DocumentationDelivery { get; set; }
        public string Status { get; set; }
        public string Version { get; set; }
        public Attachments attachments { get; set; }
        public int SaveUserId { get; set; }
        public ElectronicPlaceInfo ElectronicPlaceInfo { get; set; }
        public DateTime SubmissionCloseDateTime { get; set; }
        public DateTime PublicationPlannedDate { get; set; }

        public PurchaseNoticeData(XElement body)
        {
            this.Guid = body.GetGuid("guid");
            this.RegistrationNumber = body.GetString("RegistrationNumber");
            this.UrlOOS = body.GetString("UrlOOS");
            this.CreateDateTime = body.GetDateTime("CreateDateTime");
            this.Name = body.GetString("Name");
            CustomerInfo = new CustomerInfo(body.GetDescendant("Customer"));

            Placer = new Placer(body.GetDescendant("Placer"));
            Contact = new Contact(body.GetDescendant("Contact"));
            DocumentationDelivery = new DocumentationDelivery(body.GetDescendant("DocumentationDelivery"));

            PublicationDateTime = body.GetDateTime("PublicationDateTime");
            Status = body.GetString("Status");
            Version = body.GetString("Version");

            modificationDate = body.GetDateTime("modificationDate");

            SaveUserId = body.GetInt("SaveUserId");

            ElectronicPlaceInfo = new ElectronicPlaceInfo(body.GetDescendant("ElectronicPlaceInfo"));
            SubmissionCloseDateTime = body.GetDateTime("SubmissionCloseDateTime");
            PublicationPlannedDate = body.GetDateTime("PublicationPlannedDate");
        }
    }
}
