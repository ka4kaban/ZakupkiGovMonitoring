using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DBModel
{
    public class Lot
    {
        public Guid Guid { get; set; }
        public string OrdinalNumber { get; set; }
        public string Subject { get; set; }
        public Currency Currency { get; set; }
        public string InitialSum { get; set; }
        public string DeliveryPlace { get; set; }
        public Nullable<bool> ForSmallOrMiddle { get; set; }
        public Nullable<bool> ExcludePurchaseFromPlan { get; set; }
        public Nullable<bool> SubcontractorsRequirement { get; set; }
        public Nullable<bool> IgnoredPurchase { get; set; }
        public Nullable<bool> Centralized { get; set; }

        public string DeliveryPlaceIndication { get; set; }
        public Nullable<bool> JointLot { get; set; }
        public LotItems LotItems { get; set; } //TODO: refactor

        public Lot(XElement node)
        {
            this.Guid = node.GetGuid("guid");
            this.OrdinalNumber = node.GetString("OrdinalNumber");
            this.Subject = node.GetString("Subject");
            if (node.GetDescendant("Currency") != null)
                this.Currency = new Currency(node.GetDescendant("Currency"));//node.GetGuid("Currency");
            this.InitialSum = node.GetString("InitialSum");
            this.DeliveryPlace = node.GetString("DeliveryPlace");

            if (node.GetDescendant("ForSmallOrMiddle") != null)
                ForSmallOrMiddle = node.GetBool("ForSmallOrMiddle");
            if (node.GetDescendant("ExcludePurchaseFromPlan") != null)
                ExcludePurchaseFromPlan = node.GetBool("ExcludePurchaseFromPlan");
            if (node.GetDescendant("SubcontractorsRequirement") != null)
                SubcontractorsRequirement = node.GetBool("SubcontractorsRequirement");
            if (node.GetDescendant("IgnoredPurchase") != null)
                IgnoredPurchase = node.GetBool("IgnoredPurchase");
            if (node.GetDescendant("Centralized") != null)
                Centralized = node.GetBool("Centralized");

            DeliveryPlaceIndication = node.GetString("DeliveryPlaceIndication");
            if (node.GetDescendant("JointLot") != null)
                JointLot = node.GetBool("JointLot");

            if (node.GetDescendant("lotItems") != null)
                LotItems = new LotItems(node.GetDescendant("lotItems"));
        }
    }

    //    <lot>
    //                        <guid>14c552e4-9434-4c7d-8bdd-6115d79284c1</guid>
    //                        <ordinalNumber>1</ordinalNumber>
    //                        <subject>Лот № 1: Поставка сока – 5 700 штук.
    //</subject>
    //                        <currency>
    //                            <code>RUB</code>
    //                            <digitalCode>643</digitalCode>
    //                            <name>Российский рубль</name>
    //                        </currency>
    //                        <initialSum>270634.80</initialSum>
    //                        <deliveryPlace>ФГУП «РФЯЦ-ВНИИТФ им. академ.Е.И.Забабахина», «ЗАТО» г.Снежинск, Челябинская обл., столовая №8. </deliveryPlace>
    //                        <lotItems>
    //                            <lotItem>
    //                                <guid>14c552e4-9434-4c7d-8bdd-6115d79284c1</guid>
    //                                <ordinalNumber>1</ordinalNumber>
    //                                <okdp>
    //                                    <code>1513480</code>
    //                                    <name>Соки</name>
    //                                </okdp>
    //                                <okved>
    //                                    <code>51.70</code>
    //                                    <name>Прочая оптовая торговля</name>
    //                                </okved>
    //                                <okei>
    //                                    <code>796</code>
    //                                    <name>Штука</name>
    //                                </okei>
    //                                <qty>5700</qty>
    //                            </lotItem>
    //                        </lotItems>
    //                    </lot>
}
