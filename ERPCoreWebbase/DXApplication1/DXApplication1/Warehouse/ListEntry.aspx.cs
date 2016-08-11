﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility;

namespace WebModule.Warehouse.UserControl
{
    public partial class ListEntry : System.Web.UI.Page, WebModule.Interfaces.IERPCoreWebModuleBase
    {
        public string AccessObjectId
        {
            get
            {
                return Constant.ACCESSOBJECT_WAREHOUSE_HISTORYENTRY_ID;
            }
        }
        public string AccessObjectGroupId
        {
            get
            {
                return Constant.ACCESSOBJECT_WAREHOUSE_GROUPID;
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Utils.ApplyTheme(this);
        }
        private void BindGrid()
        {

            grdDataAccept.DataSource =
               new[] { 
                       new { key="123", code="MH001", name="Mặt hàng 1", unit = "Thùng", lot = "0123",
                             amount= "100", amountreal="90", amountdiff="10", codedepence="MAT001", position = "Kho 5", adjusteddate = "", status="Chưa điều chỉnh"
                    },
                    new { key="1234", code="MH002", name="Mặt hàng 2", unit = "Hộp", lot = "0123",
                             amount= "150", amountreal="150", amountdiff="0", codedepence="MAT002", position = "Kho 6", adjusteddate = "29/08/2013", status="Đã điều chỉnh"
                    },
                };
            grdDataAccept.KeyFieldName = "key";
            grdDataAccept.DataBind();


        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack || !Page.IsCallback)
            {
                BindGrid();
            }
            else
            {

            }
        }


        protected void cpHeader_Callback(object sender, DevExpress.Web.ASPxClasses.CallbackEventArgsBase e)
        {
            switch (e.Parameter)
            {
                case "refresh":
                    BindGrid();
                    break;
                default:
                    break;
            }
        }

        protected void grdDataAccept_RowUpdating(object sender, DevExpress.Web.Data.ASPxDataUpdatingEventArgs e)
        {

        }

        protected void grdDataAccept_StartRowEditing1(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        {
            BindGrid();


            //Session["productMode"] = vs;

            grdDataAccept.CancelEdit();
            grdDataAccept.JSProperties.Add("cpEdit", "edit");
        }

        
    }
}