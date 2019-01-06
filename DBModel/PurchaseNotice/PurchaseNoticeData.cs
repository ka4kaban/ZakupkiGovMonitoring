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
        public string DeliveryPlaceIndication { get; set; }
        public Nullable<bool> NotDishonest { get; set; }
        public Nullable<bool> Emergency { get; set; }
        public Nullable<bool> JointPurchase { get; set; }
        public Attachments attachments { get; set; }
        public int SaveUserId { get; set; }
        public ElectronicPlaceInfo ElectronicPlaceInfo { get; set; }
        public DateTime SubmissionCloseDateTime { get; set; }
        public DateTime PublicationPlannedDate { get; set; }
        public XElement Body { get; set; }

        public Lots Lots { get; set; }

        public PurchaseNoticeData(string path)
        {
            XDocument xml = XDocument.Load(path);
            Body = (XElement)xml.Root.FirstNode.NextNode;

            ParseXML();
        }

        public void ParseXML()
        {
            this.Guid = Body.GetGuid("guid");
            this.RegistrationNumber = Body.GetString("RegistrationNumber");
            this.UrlOOS = Body.GetString("UrlOOS");
            this.CreateDateTime = Body.GetDateTime("CreateDateTime");
            this.Name = Body.GetString("Name");
            if (Body.GetDescendant("Customer") != null)
                CustomerInfo = new CustomerInfo(Body.GetDescendant("Customer"));
            if (Body.GetDescendant("Placer") != null)
                Placer = new Placer(Body.GetDescendant("Placer"));
            if (Body.GetDescendant("Contact") != null)
                Contact = new Contact(Body.GetDescendant("Contact"));
            if (Body.GetDescendant("DocumentationDelivery") != null)
                DocumentationDelivery = new DocumentationDelivery(Body.GetDescendant("DocumentationDelivery"));

            PublicationDateTime = Body.GetDateTime("PublicationDateTime");
            Status = Body.GetString("Status");
            Version = Body.GetString("Version");


            modificationDate = Body.GetDateTime("modificationDate");

            SaveUserId = Body.GetInt("SaveUserId");
            DeliveryPlaceIndication = Body.GetString("deliveryPlaceIndication");

            if (Body.GetDescendant("notDishonest") != null)
                NotDishonest = Body.GetBool("notDishonest");//?wtf
            if (Body.GetDescendant("emergency") != null)
                Emergency = Body.GetBool("emergency");
            if (Body.GetDescendant("jointPurchase") != null)
                JointPurchase = Body.GetBool("jointPurchase");

            if (Body.GetDescendant("ElectronicPlaceInfo") != null)
                ElectronicPlaceInfo = new ElectronicPlaceInfo(Body.GetDescendant("ElectronicPlaceInfo"));
            SubmissionCloseDateTime = Body.GetDateTime("SubmissionCloseDateTime");
            PublicationPlannedDate = Body.GetDateTime("PublicationPlannedDate");

            if (Body.GetDescendant("Lots") != null)
                Lots = new Lots(Body.GetDescendant("Lots"));
        }
        //public PurchaseNoticeData(XElement body)
        //{
        //    this.Guid = body.GetGuid("guid");
        //    this.RegistrationNumber = body.GetString("RegistrationNumber");
        //    this.UrlOOS = body.GetString("UrlOOS");
        //    this.CreateDateTime = body.GetDateTime("CreateDateTime");
        //    this.Name = body.GetString("Name");
        //    CustomerInfo = new CustomerInfo(body.GetDescendant("Customer"));

        //    Placer = new Placer(body.GetDescendant("Placer"));
        //    Contact = new Contact(body.GetDescendant("Contact"));
        //    DocumentationDelivery = new DocumentationDelivery(body.GetDescendant("DocumentationDelivery"));

        //    PublicationDateTime = body.GetDateTime("PublicationDateTime");
        //    Status = body.GetString("Status");
        //    Version = body.GetString("Version");

        //    modificationDate = body.GetDateTime("modificationDate");

        //    SaveUserId = body.GetInt("SaveUserId");

        //    ElectronicPlaceInfo = new ElectronicPlaceInfo(body.GetDescendant("ElectronicPlaceInfo"));
        //    SubmissionCloseDateTime = body.GetDateTime("SubmissionCloseDateTime");
        //    PublicationPlannedDate = body.GetDateTime("PublicationPlannedDate");
        //}
    }
}
