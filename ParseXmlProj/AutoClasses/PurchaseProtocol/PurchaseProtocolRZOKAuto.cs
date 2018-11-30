using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ParseXmlProj.AutoClasses
//{
//    class PurchaseProtocolRZOKAuto
//    {
//    }
//}

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
   

   
   
   


    

   

   
    [XmlRoot(ElementName = "purchaseProtocolRZOKData", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseProtocolRZOKData
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "createDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CreateDateTime { get; set; }
        [XmlElement(ElementName = "urlOOS", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string UrlOOS { get; set; }
        [XmlElement(ElementName = "purchaseInfo", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public PurchaseInfo PurchaseInfo { get; set; }
        [XmlElement(ElementName = "registrationNumber", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string RegistrationNumber { get; set; }
        [XmlElement(ElementName = "placer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Placer Placer { get; set; }
        [XmlElement(ElementName = "customer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Customer Customer { get; set; }
        [XmlElement(ElementName = "publicationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublicationDateTime { get; set; }
        [XmlElement(ElementName = "status", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Status { get; set; }
        [XmlElement(ElementName = "version", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Version { get; set; }
        [XmlElement(ElementName = "modificationDescription", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ModificationDescription { get; set; }
        [XmlElement(ElementName = "attachments", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Attachments Attachments { get; set; }
        [XmlElement(ElementName = "procedureDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ProcedureDate { get; set; }
        [XmlElement(ElementName = "procedurePlace", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ProcedurePlace { get; set; }
        [XmlElement(ElementName = "protocolVKRegistrationNumber", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ProtocolVKRegistrationNumber { get; set; }
        [XmlElement(ElementName = "protocolVKVersion", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ProtocolVKVersion { get; set; }
        [XmlElement(ElementName = "lotApplicationsList", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public LotApplicationsList LotApplicationsList { get; set; }
        [XmlElement(ElementName = "protocolSignDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string ProtocolSignDate { get; set; }
    }

    

   

    [XmlRoot(ElementName = "purchaseProtocolRZOK", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseProtocolRZOK
    {
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
