using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParseXmlProj
{
  
   

   

    [XmlRoot(ElementName = "organization", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
    public class Organization
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "mainInfo", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public MainInfo MainInfo { get; set; }
    }

    [XmlRoot(ElementName = "contact", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "phone", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Phone { get; set; }
        [XmlElement(ElementName = "fax", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Fax { get; set; }
        [XmlElement(ElementName = "email", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Email { get; set; }
        [XmlElement(ElementName = "organization", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Organization Organization { get; set; }
    }

    [XmlRoot(ElementName = "documentationDelivery", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class DocumentationDelivery
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "deliveryStartDateTime", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string DeliveryStartDateTime { get; set; }
        [XmlElement(ElementName = "deliveryEndDateTime", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string DeliveryEndDateTime { get; set; }
        [XmlElement(ElementName = "place", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Place { get; set; }
        [XmlElement(ElementName = "procedure", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Procedure { get; set; }
    }

   

 

    [XmlRoot(ElementName = "electronicPlaceInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class ElectronicPlaceInfo
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Name { get; set; }
        [XmlElement(ElementName = "url", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Url { get; set; }
        [XmlElement(ElementName = "electronicPlaceId", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string ElectronicPlaceId { get; set; }
        [XmlElement(ElementName = "purchaseDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseDateTime { get; set; }
        [XmlElement(ElementName = "examinationPlace", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ExaminationPlace { get; set; }
        [XmlElement(ElementName = "examinationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ExaminationDateTime { get; set; }
    }

  

   

    [XmlRoot(ElementName = "lotItem", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
    public class LotItem
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "ordinalNumber", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string OrdinalNumber { get; set; }
        [XmlElement(ElementName = "okdp", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Okdp Okdp { get; set; }
        [XmlElement(ElementName = "okved", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Okved Okved { get; set; }
        [XmlElement(ElementName = "okei", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Okei Okei { get; set; }
        [XmlElement(ElementName = "qty", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public string Qty { get; set; }
    }

    [XmlRoot(ElementName = "lotItems", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
    public class LotItems
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "lotItem", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public LotItem LotItem { get; set; }
    }

   

    [XmlRoot(ElementName = "lots", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class Lots
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "lot", Namespace = "http://zakupki.gov.ru/223fz/types/1")]
        public Lot Lot { get; set; }
    }

    [XmlRoot(ElementName = "purchaseNoticeData", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseNoticeData
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "createDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CreateDateTime { get; set; }
        [XmlElement(ElementName = "urlOOS", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string UrlOOS { get; set; }
        [XmlElement(ElementName = "registrationNumber", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string RegistrationNumber { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Name { get; set; }
        [XmlElement(ElementName = "customer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Customer Customer { get; set; }
        [XmlElement(ElementName = "purchaseMethodCode", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseMethodCode { get; set; }
        [XmlElement(ElementName = "purchaseCodeName", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseCodeName { get; set; }
        [XmlElement(ElementName = "placer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Placer Placer { get; set; }
        [XmlElement(ElementName = "contact", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Contact Contact { get; set; }
        [XmlElement(ElementName = "publicationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublicationDateTime { get; set; }
        [XmlElement(ElementName = "documentationDelivery", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public DocumentationDelivery DocumentationDelivery { get; set; }
        [XmlElement(ElementName = "status", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Status { get; set; }
        [XmlElement(ElementName = "version", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Version { get; set; }
        [XmlElement(ElementName = "attachments", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Attachments Attachments { get; set; }
        [XmlElement(ElementName = "modificationDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ModificationDate { get; set; }
        [XmlElement(ElementName = "saveUserId", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string SaveUserId { get; set; }
        [XmlElement(ElementName = "electronicPlaceInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public ElectronicPlaceInfo ElectronicPlaceInfo { get; set; }
        [XmlElement(ElementName = "submissionCloseDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string SubmissionCloseDateTime { get; set; }
        [XmlElement(ElementName = "publicationPlannedDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublicationPlannedDate { get; set; }
        [XmlElement(ElementName = "lots", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Lots Lots { get; set; }
    }



    [XmlRoot(ElementName = "purchaseNotice", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseNotice
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
