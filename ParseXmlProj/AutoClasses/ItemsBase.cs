using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ParseXmlProj
{
    [XmlRoot(ElementName = "header")]
    public class Header
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "createDateTime")]
        public string CreateDateTime { get; set; }
    }

    [XmlRoot(ElementName = "placer")]
    public class Placer
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "mainInfo")]
        public MainInfo MainInfo { get; set; }
    }

    [XmlRoot(ElementName = "customer")]
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "mainInfo")]
        public MainInfo MainInfo { get; set; }
    }

    [XmlRoot(ElementName = "attachments")]
    public class Attachments
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "totalDocumentsCount")]
        public string TotalDocumentsCount { get; set; }
        [XmlElement(ElementName = "document")]
        public Document Document { get; set; }
    }

    [XmlRoot(ElementName = "body")]
    public class Body
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "item")]
        public Item Item { get; set; }
    }

    [XmlRoot(ElementName = "currency")]
    public class Currency
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "digitalCode")]
        public string DigitalCode { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "supplierInfo")]
    public class SupplierInfo
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "inn")]
        public string Inn { get; set; }
        [XmlElement(ElementName = "kpp")]
        public string Kpp { get; set; }
        [XmlElement(ElementName = "ogrn")]
        public string Ogrn { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
    }

    [XmlRoot(ElementName = "document")]
    public class Document
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "createDateTime")]
        public string CreateDateTime { get; set; }
        [XmlElement(ElementName = "fileName")]
        public string FileName { get; set; }
        [XmlElement(ElementName = "description")]
        public string Description { get; set; }
        [XmlElement(ElementName = "url")]
        public string Url { get; set; }
    }

    [XmlRoot(ElementName = "purchaseInfo")]
    public class PurchaseInfo
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "purchaseNoticeNumber")]
        public string PurchaseNoticeNumber { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "purchaseMethodCode")]
        public string PurchaseMethodCode { get; set; }
        [XmlElement(ElementName = "purchaseCodeName")]
        public string PurchaseCodeName { get; set; }
    }

    [XmlRoot(ElementName = "okdp")]
    public class Okdp
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "okved")]
    public class Okved
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "okei")]
    public class Okei
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "code")]
        public string Code { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "lotApplicationsList")]
    public class LotApplicationsList
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "protocolLotApplications")]
        public ProtocolLotApplications ProtocolLotApplications { get; set; }
    }

    [XmlRoot(ElementName = "nonResidentInfo")]
    public class NonResidentInfo
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "info")]
        public string Info { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
    }



    [XmlRoot(ElementName = "mainInfo")]
    public class MainInfo
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "fullName")]
        public string FullName { get; set; }
        [XmlElement(ElementName = "shortName")]
        public string ShortName { get; set; }
        [XmlElement(ElementName = "inn")]
        public string Inn { get; set; }
        [XmlElement(ElementName = "kpp")]
        public string Kpp { get; set; }
        [XmlElement(ElementName = "ogrn")]
        public string Ogrn { get; set; }
        [XmlElement(ElementName = "legalAddress")]
        public string LegalAddress { get; set; }
        [XmlElement(ElementName = "postalAddress")]
        public string PostalAddress { get; set; }
        [XmlElement(ElementName = "phone")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "email")]
        public string Email { get; set; }
        [XmlElement(ElementName = "okato")]
        public string Okato { get; set; }
        [XmlElement(ElementName = "fax")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "name")]
        public string Name { get; set; }
        [XmlElement(ElementName = "type")]
        public string Type { get; set; }
    }


    [XmlRoot(ElementName = "protocolLotApplications")]
    public class ProtocolLotApplications
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "lot")]
        public Lot Lot { get; set; }
        [XmlElement(ElementName = "guid")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "ordinalNumber")]
        public string OrdinalNumber { get; set; }
        [XmlElement(ElementName = "subject")]
        public string Subject { get; set; }
        [XmlElement(ElementName = "lotParameters")]
        public LotParameters LotParameters { get; set; }
        [XmlElement(ElementName = "application")]
        public List<Application> Application { get; set; }
        [XmlElement(ElementName = "currency")]
        public Currency Currency { get; set; }
        [XmlElement(ElementName = "initialSum")]
        public string InitialSum { get; set; }
    }



    [XmlRoot(ElementName = "item")]
    public class Item
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "orderClauseData")]
        public OrderClauseData OrderClauseData { get; set; }


        [XmlElement(ElementName = "explanationData")]
        public ExplanationData ExplanationData { get; set; }
        [XmlElement(ElementName = "protocolCancellationData")]
        public ProtocolCancellationData ProtocolCancellationData { get; set; }

        [XmlElement(ElementName = "purchaseContractAccountData")]
        public PurchaseContractAccountData PurchaseContractAccountData { get; set; }

        [XmlElement(ElementName = "purchaseContractData")]
        public PurchaseContractData PurchaseContractData { get; set; }

        [XmlElement(ElementName = "purchaseNoticeData")]
        public PurchaseNoticeData PurchaseNoticeData { get; set; }

        [XmlElement(ElementName = "purchasePlanData")]
        public PurchasePlanData PurchasePlanData { get; set; }

        [XmlElement(ElementName = "purchaseProtocolData")]
        public PurchaseProtocolData PurchaseProtocolData { get; set; }
        [XmlElement(ElementName = "purchaseProtocolOSZData")]
        public PurchaseProtocolOSZData PurchaseProtocolOSZData { get; set; }

        [XmlElement(ElementName = "purchaseProtocolPAAEData")]
        public PurchaseProtocolPAAEData PurchaseProtocolPAAEData { get; set; }

        [XmlElement(ElementName = "purchaseProtocolPAEPData")]
        public PurchaseProtocolPAEPData PurchaseProtocolPAEPData { get; set; }

        [XmlElement(ElementName = "purchaseProtocolRZAEData")]
        public PurchaseProtocolRZAEData PurchaseProtocolRZAEData { get; set; }

        [XmlElement(ElementName = "purchaseProtocolRZOKData")]
        public PurchaseProtocolRZOKData PurchaseProtocolRZOKData { get; set; }

        [XmlElement(ElementName = "purchaseProtocolVKData")]
        public PurchaseProtocolVKData PurchaseProtocolVKData { get; set; }

        [XmlElement(ElementName = "purchaseProtocolZKData")]
        public PurchaseProtocolZKData PurchaseProtocolZKData { get; set; }
        [XmlElement(ElementName = "purchaseRejectionData")]
        public PurchaseRejectionData PurchaseRejectionData { get; set; }

    }



    [XmlRoot(ElementName = "application")]
    public class Application
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "applicationNumber")]
        public string ApplicationNumber { get; set; }
        [XmlElement(ElementName = "nonResidentInfo")]
        public NonResidentInfo NonResidentInfo { get; set; }
        [XmlElement(ElementName = "accepted")]
        public string Accepted { get; set; }
        [XmlElement(ElementName = "supplierInfo")]
        public SupplierInfo SupplierInfo { get; set; }
        [XmlElement(ElementName = "lastPrice")]
        public string LastPrice { get; set; }
        [XmlElement(ElementName = "lastButOnePrice")]
        public string LastButOnePrice { get; set; }
        [XmlElement(ElementName = "applicationPlace")]
        public string ApplicationPlace { get; set; }

        [XmlElement(ElementName = "currency")]
        public Currency Currency { get; set; }

        [XmlElement(ElementName = "applicationDate")]
        public string ApplicationDate { get; set; }
        [XmlElement(ElementName = "price")]
        public string Price { get; set; }
        [XmlElement(ElementName = "appliedDocumentsList")]
        public string AppliedDocumentsList { get; set; }

        [XmlElement(ElementName = "winnerIndication")]
        public string WinnerIndication { get; set; }
        [XmlElement(ElementName = "rejectionReason")]
        public string RejectionReason { get; set; }
    }


    [XmlRoot(ElementName = "lot")]
    public class Lot
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "ordinalNumber")]
        public string OrdinalNumber { get; set; }
        [XmlElement(ElementName = "subject")]
        public string Subject { get; set; }
        [XmlElement(ElementName = "currency")]
        public Currency Currency { get; set; }
        [XmlElement(ElementName = "initialSum")]
        public string InitialSum { get; set; }
        [XmlElement(ElementName = "deliveryPlace")]
        public string DeliveryPlace { get; set; }
        [XmlElement(ElementName = "lotItems")]
        public LotItems LotItems { get; set; }
    }

}
