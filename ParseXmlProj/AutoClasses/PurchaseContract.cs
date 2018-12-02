using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ParseXmlProj
{

    [XmlRoot(ElementName = "customerInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class CustomerInfo
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "fullName", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string FullName { get; set; }
        [XmlElement(ElementName = "shortName", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string ShortName { get; set; }
        [XmlElement(ElementName = "inn", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Inn { get; set; }
        [XmlElement(ElementName = "kpp", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Kpp { get; set; }
        [XmlElement(ElementName = "ogrn", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Ogrn { get; set; }
        [XmlElement(ElementName = "legalAddress", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string LegalAddress { get; set; }
        [XmlElement(ElementName = "postalAddress", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string PostalAddress { get; set; }
        [XmlElement(ElementName = "phone", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "fax", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "email", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Email { get; set; }
        [XmlElement(ElementName = "okato", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Okato { get; set; }
    }

    [XmlRoot(ElementName = "supplier", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "mainInfo", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public MainInfo MainInfo { get; set; }
    }

    [XmlRoot(ElementName = "deliveryPlace", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class DeliveryPlace
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "address", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Address { get; set; }
    }

    [XmlRoot(ElementName = "contractItem", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class ContractItem
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "okdp", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Okdp Okdp { get; set; }
        [XmlElement(ElementName = "okved", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Okved Okved { get; set; }
        [XmlElement(ElementName = "okei", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Okei Okei { get; set; }
        [XmlElement(ElementName = "qty", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Qty { get; set; }
        [XmlElement(ElementName = "ordinalNumber", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string OrdinalNumber { get; set; }
    }

    [XmlRoot(ElementName = "contractItems", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class ContractItems
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "contractItem", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public ContractItem ContractItem { get; set; }
    }

    [XmlRoot(ElementName = "purchaseContractData", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseContractData
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "registrationNumber", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string RegistrationNumber { get; set; }
        [XmlElement(ElementName = "urlOOS", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string UrlOOS { get; set; }
        [XmlElement(ElementName = "createDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CreateDateTime { get; set; }
        [XmlElement(ElementName = "contractCreateDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ContractCreateDate { get; set; }
        //[XmlElement(ElementName = "lot", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public Lot Lot { get; set; }
        //[XmlElement(ElementName = "currency", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public Currency Currency { get; set; }
        [XmlElement(ElementName = "sum", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Sum { get; set; }
        [XmlElement(ElementName = "fulfillmentDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string FulfillmentDate { get; set; }
        //[XmlElement(ElementName = "purchaseInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public PurchaseInfo PurchaseInfo { get; set; }
        //[XmlElement(ElementName = "placer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public Placer Placer { get; set; }
        //[XmlElement(ElementName = "customerInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public CustomerInfo CustomerInfo { get; set; }
        //[XmlElement(ElementName = "supplier", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public Supplier Supplier { get; set; }
        //[XmlElement(ElementName = "deliveryPlace", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public DeliveryPlace DeliveryPlace { get; set; }
        //[XmlElement(ElementName = "deliveryPlaceIndication", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public string DeliveryPlaceIndication { get; set; }
        //[XmlElement(ElementName = "contractItems", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        //public ContractItems ContractItems { get; set; }
        [XmlElement(ElementName = "type", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Type { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Name { get; set; }
        [XmlElement(ElementName = "publicationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublicationDateTime { get; set; }
        [XmlElement(ElementName = "status", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Status { get; set; }
        [XmlElement(ElementName = "version", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Version { get; set; }
        [XmlElement(ElementName = "attachments", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Attachments { get; set; }
    }


    [XmlRoot(ElementName = "purchaseContract", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseContract
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "header", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Header Header { get; set; }
        [XmlElement(ElementName = "body", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Body Body { get; set; }
        [XmlAttribute(AttributeName = "schemaLocation", Namespace = "http://www.w3.org/2001/XMLSchema-instance")]
        public string SchemaLocation { get; set; }
        [XmlAttribute(AttributeName = "ns5", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns5 { get; set; }
        [XmlAttribute(AttributeName = "xmlns")]
        public string Xmlns { get; set; }
        [XmlAttribute(AttributeName = "ns6", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns6 { get; set; }
        [XmlAttribute(AttributeName = "ns7", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns7 { get; set; }
        [XmlAttribute(AttributeName = "ns8", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns8 { get; set; }
        [XmlAttribute(AttributeName = "ns9", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns9 { get; set; }
        [XmlAttribute(AttributeName = "ns2", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns2 { get; set; }
        [XmlAttribute(AttributeName = "xsi", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Xsi { get; set; }
        [XmlAttribute(AttributeName = "ns3", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns3 { get; set; }
        [XmlAttribute(AttributeName = "ns4", Namespace = "http://www.w3.org/2000/xmlns/")]
        public string Ns4 { get; set; }
    }
}