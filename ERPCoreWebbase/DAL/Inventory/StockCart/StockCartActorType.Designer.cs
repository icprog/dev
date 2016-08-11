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
namespace NAS.DAL.Inventory.StockCart
{

    public partial class StockCartActorType : XPCustomObject
    {
        Guid fStockCartActorTypeId;
        [Key(true)]
        public Guid StockCartActorTypeId
        {
            get { return fStockCartActorTypeId; }
            set { SetPropertyValue<Guid>("StockCartActorTypeId", ref fStockCartActorTypeId, value); }
        }
        string fName;
        [Size(255)]
        public string Name
        {
            get { return fName; }
            set { SetPropertyValue<string>("Name", ref fName, value); }
        }
        string fDescription;
        [Size(1024)]
        public string Description
        {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        short fRowStatus;
        public short RowStatus
        {
            get { return fRowStatus; }
            set { SetPropertyValue<short>("RowStatus", ref fRowStatus, value); }
        }

        [Association(@"StockCartActorReferencesStockCartActorType", typeof(StockCartActor))]
        public XPCollection<StockCartActor> StockCartActors { get { return GetCollection<StockCartActor>("StockCartActors"); } } 
		
	}

}