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
      



    [XmlRoot(ElementName = "explanationData", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class ExplanationData
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "urlOOS", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string UrlOOS { get; set; }
        [XmlElement(ElementName = "description", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Description { get; set; }
        [XmlElement(ElementName = "requestSubjectInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string RequestSubjectInfo { get; set; }
        [XmlElement(ElementName = "requestDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string RequestDate { get; set; }
        [XmlElement(ElementName = "status", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Status { get; set; }
        [XmlElement(ElementName = "creationDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CreationDate { get; set; }
        [XmlElement(ElementName = "modificationDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ModificationDate { get; set; }
        [XmlElement(ElementName = "decisionDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string DecisionDate { get; set; }
        [XmlElement(ElementName = "publishDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublishDate { get; set; }
        [XmlElement(ElementName = "attachments", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Attachments Attachments { get; set; }
        [XmlElement(ElementName = "purchaseRegNum", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseRegNum { get; set; }
        [XmlElement(ElementName = "purchaseMethodCode", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseMethodCode { get; set; }
        [XmlElement(ElementName = "purchaseMethodName", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseMethodName { get; set; }
        [XmlElement(ElementName = "purchaseName", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseName { get; set; }
        [XmlElement(ElementName = "placer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Placer Placer { get; set; }
    }

   

   

    [XmlRoot(ElementName = "explanation", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class Explanation
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

