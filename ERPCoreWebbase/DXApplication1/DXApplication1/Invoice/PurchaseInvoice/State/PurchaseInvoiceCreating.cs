﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebModule.Invoice.PurchaseInvoice.GUI;

namespace WebModule.Invoice.PurchaseInvoice.State
{
    public class PurchaseInvoiceCreating : NAS.GUI.Pattern.State
    {
        public PurchaseInvoiceCreating(System.Web.UI.Control control) : base(control) { }

        public override bool Transit(NAS.GUI.Pattern.Context context, string transition, System.Web.UI.Control _UIControl)
        {
            switch (transition.ToUpper())
            {
                case "CANCEL":
                    context.State = new PurchaseInvoiceCanceling(_UIControl);
                    break;
                case "SAVE":
                    context.State = new PurchaseInvoiceEditing(_UIControl);
                    break;
                default:
                    throw new NAS.GUI.Pattern.IncompatibleTransitionException();
            }
            return true;
        }

        public override bool PreTransitionCRUD(string transition)
        {
            return GetOwnerUIControl().PurchaseInvoiceCreating_PreTransitionCRUD(transition);
        }

        public override bool CRUD()
        {
            return GetOwnerUIControl().PurchaseInvoiceCreating_CRUD();
        }

        public override bool UpdateGUI()
        {
            return GetOwnerUIControl().PurchaseInvoiceCreating_UpdateGUI();
        }

        public PurchaseInvoiceEditingForm GetOwnerUIControl()
        {
            PurchaseInvoiceEditingForm ret = null;
            if (UIControl != null)
            {
                if (UIControl is PurchaseInvoiceEditingForm)
                {
                    ret = (PurchaseInvoiceEditingForm)UIControl;
                }
            }
            return ret;
        }
    }
}