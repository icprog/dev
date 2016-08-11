﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebModule.ERPSystem.CustomField.GUI.Control.State;

namespace WebModule.ERPSystem.CustomField.GUI.Control.NASCustomFieldTypeBuiltInSingleSelectionListControl.State
{
    public class NASCustomFieldTypeBuiltInSingleSelectionListControlDataViewingState : NASCustomFieldTypeControlState
    {
        public NASCustomFieldTypeBuiltInSingleSelectionListControlDataViewingState(System.Web.UI.Control _UIControl)
            : base(_UIControl)
        { }

        #region Transition
        protected override bool Update(NAS.GUI.Pattern.Context context, System.Web.UI.Control _UIControl)
        {
            throw new NAS.GUI.Pattern.IncompatibleTransitionException();
        }

        protected override bool Cancel(NAS.GUI.Pattern.Context context, System.Web.UI.Control _UIControl)
        {
            throw new NAS.GUI.Pattern.IncompatibleTransitionException();
        }

        protected override bool Edit(NAS.GUI.Pattern.Context context, System.Web.UI.Control _UIControl)
        {
            context.State = new NASCustomFieldTypeBuiltInSingleSelectionListControlDataEditingState(_UIControl);
            return true;
        }
        #endregion

        public override bool CRUD()
        {
            return getOwnerUIControl()
                        .NASCustomFieldTypeBuiltInSingleSelectionListControlDataViewingState_CRUD();
        }
        public override bool PreTransitionCRUD(string transition)
        {
            return getOwnerUIControl()
                        .NASCustomFieldTypeBuiltInSingleSelectionListControlDataViewingState_PreTransitionCRUD(transition);
        }
        public override bool UpdateGUI()
        {
            return getOwnerUIControl()
                        .NASCustomFieldTypeBuiltInSingleSelectionListControlDataViewingState_UpdateGUI();
        }

        public NASCustomFieldTypeBuiltInSingleSelectionListControl getOwnerUIControl()
        {
            NASCustomFieldTypeBuiltInSingleSelectionListControl UI = null;
            if (UIControl != null)
            {
                if (UIControl is NASCustomFieldTypeBuiltInSingleSelectionListControl)
                {
                    UI = (NASCustomFieldTypeBuiltInSingleSelectionListControl)UIControl;
                }
            }
            return UI;
        }
    }
}