﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace ParseXmlProj.AutoClasses
//{
//    class PurchaseRejectionAuto
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
  
 
  
    [XmlRoot(ElementName = "purchaseRejectionData", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseRejectionData
    {
        [Key]
        public int Id { get; set; }
        [XmlElement(ElementName = "guid", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Guid { get; set; }
        [XmlElement(ElementName = "createDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CreateDateTime { get; set; }
        [XmlElement(ElementName = "urlOOS", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string UrlOOS { get; set; }
        [XmlElement(ElementName = "cancelNoticeRegistrationNumber", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CancelNoticeRegistrationNumber { get; set; }
        [XmlElement(ElementName = "name", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string Name { get; set; }
        [XmlElement(ElementName = "purchaseMethodCode", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseMethodCode { get; set; }
        [XmlElement(ElementName = "purchaseCodeName", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PurchaseCodeName { get; set; }
        [XmlElement(ElementName = "publicationDateTime", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string PublicationDateTime { get; set; }
        [XmlElement(ElementName = "rejectionDate", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string RejectionDate { get; set; }
        [XmlElement(ElementName = "causeForRejection", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public string CauseForRejection { get; set; }
        [XmlElement(ElementName = "placer", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Placer Placer { get; set; }
        [XmlElement(ElementName = "attachments", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
        public Attachments Attachments { get; set; }
    }

    
   
    [XmlRoot(ElementName = "purchaseRejection", Namespace = "http://zakupki.gov.ru/223fz/purchase/1")]
    public class PurchaseRejection
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
