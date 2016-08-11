﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebModule.Warehouse.Command.PopupCommand.EdittingMovingInventoryCommand.State
{
    public class DeletingMovingInventoryCommand: NAS.GUI.Pattern.State
    {
        public DeletingMovingInventoryCommand(System.Web.UI.Control _UIControl)
            : base(_UIControl) { }

        public override bool Transit(NAS.GUI.Pattern.Context context, string transition, System.Web.UI.Control _UIControl)
        {
            switch (transition)
            {
                case "Create":
                    context.State = new CreatingMovingInventoryCommand(_UIControl);
                    break;
                case "Edit":
                    context.State = new EdittingMovingInventoryCommand(_UIControl);
                    break;
                case "Delete":
                    context.State = new DeletingMovingInventoryCommand(_UIControl);
                    break;
            }
            return true;
        }

        public override bool PreTransitionCRUD(string transition)
        {
            return true;
        }

        public override bool CRUD()
        {
            getOwnerUIControl().CRUD_DeletingMovingInventoryCommand();
            return true;
        }

        public override bool UpdateGUI()
        {
            getOwnerUIControl().UpdateGUI_DeletingMovingInventoryCommand();
            return true;
        }

        public WebModule.Warehouse.Command.PopupCommand.EdittingMovingInventoryCommand.uEdittingMovingInventoryCommand getOwnerUIControl()
        {
            WebModule.Warehouse.Command.PopupCommand.EdittingMovingInventoryCommand.uEdittingMovingInventoryCommand UI = null;
            if (UIControl != null)
            {
                if (UIControl is WebModule.Warehouse.Command.PopupCommand.EdittingMovingInventoryCommand.uEdittingMovingInventoryCommand)
                {
                    UI = (WebModule.Warehouse.Command.PopupCommand.EdittingMovingInventoryCommand.uEdittingMovingInventoryCommand)UIControl;
                }
            }
            return UI;
        }
    }
}