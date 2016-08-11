//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using NAS.DAL.Nomenclature.Item;
using NAS.DAL.Inventory.Lot;
namespace NAS.DAL.Invoice
{

    public partial class BillItem : XPCustomObject
    {
        Guid fBillItemId;
        [Key(true)]
        public Guid BillItemId
        {
            get { return fBillItemId; }
            set { SetPropertyValue<Guid>("BillItemId", ref fBillItemId, value); }
        }
        string fComment;
        public string Comment
        {
            get { return fComment; }
            set { SetPropertyValue<string>("Comment", ref fComment, value); }
        }
        int fCurrency;
        public int Currency
        {
            get { return fCurrency; }
            set { SetPropertyValue<int>("Currency", ref fCurrency, value); }
        }
        double fPrice;
        public double Price
        {
            get { return fPrice; }
            set { SetPropertyValue<double>("Price", ref fPrice, value); }
        }
        double fPromotionInNumber;
        public double PromotionInNumber
        {
            get { return fPromotionInNumber; }
            set { SetPropertyValue<double>("PromotionInNumber", ref fPromotionInNumber, value); }
        }
        double fPromotionInPercentage;
        public double PromotionInPercentage
        {
            get { return fPromotionInPercentage; }
            set { SetPropertyValue<double>("PromotionInPercentage", ref fPromotionInPercentage, value); }
        }
        double fQuantity;
        public double Quantity
        {
            get { return fQuantity; }
            set { SetPropertyValue<double>("Quantity", ref fQuantity, value); }
        }
        double fTotalPrice;
        public double TotalPrice
        {
            get { return fTotalPrice; }
            set { SetPropertyValue<double>("TotalPrice", ref fTotalPrice, value); }
        }
        short fRowStatus;
        public short RowStatus
        {
            get { return fRowStatus; }
            set { SetPropertyValue<short>("RowStatus", ref fRowStatus, value); }
        }
        ItemUnit fItemUnitId;
        [Association(@"BillItemReferencesItemUnit")]
        public ItemUnit ItemUnitId
        {
            get { return fItemUnitId; }
            set { SetPropertyValue<ItemUnit>("ItemUnitId", ref fItemUnitId, value); }
        }
        Bill fBillId;
        [Association(@"BillItemReferencesBill")]
        public Bill BillId
        {
            get { return fBillId; }
            set { SetPropertyValue<Bill>("BillId", ref fBillId, value); }
        }

        Lot fLotId;
        [Association(@"BillItemReferencesLot")]
        public Lot LotId
        {
            get { return fLotId; }
            set { SetPropertyValue<Lot>("LotId", ref fLotId, value); }
        }

        [Association(@"BillItemTaxReferencesBillItem", typeof(BillItemTax)), Aggregated]
        public XPCollection<BillItemTax> BillItemTaxs { get { return GetCollection<BillItemTax>("BillItemTaxs"); } }

        [NonPersistent]
        public Item ItemId
        {
            get
            {
                return ItemUnitId.ItemId;
            }
            set
            {
            }
        }

        [NonPersistent]
        public Unit UnitId
        {
            get
            {
                return ItemUnitId.UnitId;
            }
            set
            {

            }
        }

    }

}