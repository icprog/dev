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
namespace NAS.DAL.Inventory.Operation
{
    [MapInheritance(MapInheritanceType.OwnTable)]
    public partial class CommanderStockCartItem : StockCart.StockCartItem
    {

        private double _RequiredQuantity;
        private double _BiasQuantity;

        public double BiasQuantity
        {
            get
            {
                return _BiasQuantity;
            }
            set
            {
                SetPropertyValue("BiasQuantity", ref _BiasQuantity, value);
            }
        }

        public double RequiredQuantity
        {
            get
            {
                return _RequiredQuantity;
            }
            set
            {
                SetPropertyValue("RequiredQuantity", ref _RequiredQuantity, value);
            }
        }
	}

}