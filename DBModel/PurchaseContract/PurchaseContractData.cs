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
        public DateTime FulfillmentDate { get; set; }
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


        public ContractItemCollection ContractItemCollection { get; set; }

        public PurchaseContractData(XElement body)
        {
            //XElement purchaseContractData = body.GetDescendant("purchaseContractData"); //?

            this.Guid = body.GetGuid("guid");
            this.RegistrationNumber = body.GetString("RegistrationNumber");
            this.UrlOOS = body.GetString("UrlOOS");
            this.CreateDateTime = body.GetDateTime("CreateDateTime");
            this.ContractCreateDate = body.GetDateTime("ContractCreateDate");

            Lot = new PurchaseContractLot(body.GetDescendant("lot"));
            Currency = new Currency(body.GetDescendant("Currency"));

            Sum = body.GetString("sum");
            FulfillmentDate = body.GetDateTime("FulfillmentDate");
            PurchaseInfo = new PurchaseInfo(body.GetDescendant("PurchaseInfo"));
            Supplier = new Supplier(body.GetDescendant("Supplier"));
            CustomerInfo = new CustomerInfo(body.GetDescendant("CustomerInfo"));
            Placer = new Placer(body.GetDescendant("Placer"));
            DeliveryPlace = new DeliveryPlace(body.GetDescendant("DeliveryPlace"));

            DeliveryPlaceIndication = body.GetString("DeliveryPlaceIndication");

            ContractItemCollection = new ContractItemCollection(body.GetDescendant("ContractItems"));
            Type = body.GetString("Type");
            Name = ((XElement)body.GetDescendant("PublicationDateTime").PreviousNode).Value.ToString();
            //Name = body.GetString("name");
            PublicationDateTime = body.GetDateTime("PublicationDateTime");
            Status = body.GetString("Status");
            Version = body.GetString("Version");
        }
    }

}
