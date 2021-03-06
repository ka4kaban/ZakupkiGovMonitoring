﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace ParseXmlProj
{
    [XmlRoot(ElementName = "protocolInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class ProtocolInfo
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "registrationNumber", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string RegistrationNumber { get; set; }
        [XmlElement(ElementName = "typeName", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string TypeName { get; set; }
        [XmlElement(ElementName = "publicationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublicationDateTime { get; set; }
    }


    [XmlRoot(ElementName = "protocolCancellationData", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class ProtocolCancellationData
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "createDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CreateDateTime { get; set; }
        [XmlElement(ElementName = "publicationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublicationDateTime { get; set; }
        [XmlElement(ElementName = "customer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Customer Customer { get; set; }
        [XmlElement(ElementName = "placer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Placer Placer { get; set; }
        [XmlElement(ElementName = "urlOOS", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string UrlOOS { get; set; }
        [XmlElement(ElementName = "purchaseInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public PurchaseInfo PurchaseInfo { get; set; }
        [XmlElement(ElementName = "protocolInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public ProtocolInfo ProtocolInfo { get; set; }
        [XmlElement(ElementName = "cancellationDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CancellationDate { get; set; }
        [XmlElement(ElementName = "сancellationReason", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string СancellationReason { get; set; }
        [XmlElement(ElementName = "attachments", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Attachments Attachments { get; set; }
    }


    [XmlRoot(ElementName = "protocolCancellation", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class ProtocolCancellation
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