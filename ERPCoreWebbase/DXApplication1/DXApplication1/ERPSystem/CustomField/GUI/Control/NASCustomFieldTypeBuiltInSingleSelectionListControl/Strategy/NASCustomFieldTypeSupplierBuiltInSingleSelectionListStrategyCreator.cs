﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebModule.ERPSystem.CustomField.GUI.Control.NASCustomFieldTypeBuiltInSingleSelectionListControl.Strategy
{
    public class NASCustomFieldTypeSupplierBuiltInSingleSelectionListStrategyCreator : NASCustomFieldTypeBuiltInSingleSelectionListStrategyCreator
    {
        public override NASCustomFieldTypeBuiltInSingleSelectionListStrategy Create()
        {
            return new NASCustomFieldTypeSupplierBuiltInSingleSelectionListStrategy();
        }
    }
}