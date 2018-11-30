using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ParseXmlProj
{
  

    [XmlRoot(ElementName = "purchaseContractAccountData", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseContractAccountData
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "creationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CreationDateTime { get; set; }
        [XmlElement(ElementName = "urlOOS", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string UrlOOS { get; set; }
        [XmlElement(ElementName = "placer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Placer Placer { get; set; }
        [XmlElement(ElementName = "customer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Customer Customer { get; set; }
        [XmlElement(ElementName = "period", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Period { get; set; }
        [XmlElement(ElementName = "contractsNumber", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ContractsNumber { get; set; }
        [XmlElement(ElementName = "contractsOverallCost", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ContractsOverallCost { get; set; }
        [XmlElement(ElementName = "currency", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Currency Currency { get; set; }
        [XmlElement(ElementName = "publicationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublicationDateTime { get; set; }
        [XmlElement(ElementName = "typeCode", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string TypeCode { get; set; }
        [XmlElement(ElementName = "typeDescription", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string TypeDescription { get; set; }
        [XmlElement(ElementName = "status", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Status { get; set; }
        [XmlElement(ElementName = "version", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Version { get; set; }
        [XmlElement(ElementName = "attachments", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Attachments { get; set; }
    }

   

    [XmlRoot(ElementName = "purchaseContractAccount", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseContractAccount
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

