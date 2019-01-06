using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class PurchaseContractData
    {
        public Guid Guid { get; set; }
        public string RegistrationNumber { get; set; }
        public string UrlOOS { get; set; }
        public DateTime CreateDateTime { get; set; }
        public DateTime ContractCreateDate { get; set; }
        public PurchaseContractLot Lot { get; set; }
        public Currency Currency { get; set; }
        public string Sum { get; set; }
        public string FulfillmentDate { get; set; }
        public PurchaseInfo PurchaseInfo { get; set; }
        public Supplier Supplier { get; set; }
        public CustomerInfo CustomerInfo { get; set; }
        public Placer Placer { get; set; }
        public DeliveryPlace DeliveryPlace { get; set; }
        public string DeliveryPlaceIndication { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime PublicationDateTime { get; set; }
        public string Status { get; set; }
        public string Version { get; set; }
        XElement Body { get; set; }

        public ContractItemCollection ContractItemCollection { get; set; }

        //public PurchaseContractData(XElement body): this()
        //{
        //    Body = body;
        //}

        public void ParseXML()
        {
            //XElement purchaseContractData = body.GetDescendant("purchaseContractData"); //?

            this.Guid = Body.GetGuid("guid");
            this.RegistrationNumber = Body.GetString("RegistrationNumber");
            this.UrlOOS = Body.GetString("UrlOOS");
            this.CreateDateTime = Body.GetDateTime("CreateDateTime");
            this.ContractCreateDate = Body.GetDateTime("ContractCreateDate");

            Lot = new PurchaseContractLot(Body.GetDescendant("lot"));
            if (Body.GetDescendant("Currency") != null)
                Currency = new Currency(Body.GetDescendant("Currency"));

            Sum = Body.GetString("sum");
            FulfillmentDate = Body.GetString("FulfillmentDate");
            PurchaseInfo = new PurchaseInfo(Body.GetDescendant("PurchaseInfo"));
            if (Body.GetDescendant("Supplier") != null)
                Supplier = new Supplier(Body.GetDescendant("Supplier"));
            if (Body.GetDescendant("CustomerInfo") != null)
                CustomerInfo = new CustomerInfo(Body.GetDescendant("CustomerInfo"));
            if (Body.GetDescendant("Placer") != null)
                Placer = new Placer(Body.GetDescendant("Placer"));
            if(Body.GetDescendant("DeliveryPlace") != null)
                DeliveryPlace = new DeliveryPlace(Body.GetDescendant("DeliveryPlace"));

            DeliveryPlaceIndication = Body.GetString("DeliveryPlaceIndication");

            ContractItemCollection = new ContractItemCollection(Body.GetDescendant("ContractItems"));
            Type = Body.GetString("Type");
            Name = ((XElement)Body.GetDescendant("PublicationDateTime").PreviousNode).Value.ToString();
            //Name = Body.GetString("name");
            PublicationDateTime = Body.GetDateTime("PublicationDateTime");
            Status = Body.GetString("Status");
            Version = Body.GetString("Version");
        }

        public PurchaseContractData(string path)
        {
            XDocument xml = XDocument.Load(path);
            Body = (XElement)xml.Root.FirstNode.NextNode;

            ParseXML();
        }
    }

}
