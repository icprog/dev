﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using Utility;

namespace ERPCore.Accounting
{
    public partial class PaymentVoucher : System.Web.UI.Page, WebModule.Interfaces.IERPCoreWebModuleBase
    {
        public string AccessObjectId
        {
            get
            {
                return Constant.ACCESSOBJECT_ACCOUNT_GROUPID;
            }
        }
        public string AccessObjectGroupId
        {
            get
            {
                return Constant.ACCESSOBJECT_ACCOUNT_GROUPID;
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Utils.ApplyTheme(this);
        }

        private class datasample
        {
            public string Code { get; set; }
            public string Customer { get; set; }
            public string Address { get; set; }
            public string Amount { get; set; }
            public string Order { get; set; }
            public string status { get; set; }
            public string sd { get; set; }
            public string dg { get; set; }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList data = new ArrayList();

            data.Add(new datasample() { sd = "Chi 1",dg = "Ví dụ 1",Code = "PC12989", Customer = "Công ty TNHH Minh Phát", Address = "19 Lạc Long Quân F6 QTB", Amount = "100,000,000", Order = "HD919820/NX", status  = "Đã duyệt"});
            data.Add(new datasample() { sd = "Chi 2", dg = "Ví dụ 2", Code = "PC32489", Customer = "Cửa Hàng Song Hiệp", Address = "2B Bùi Thị Xuân F2 QTB", Amount = "15,000,000", Order = "HD129820/NX", status = "Chưa duyệt" });

            grdData.DataSource = data;
            grdData.DataBind();
        }

        protected void grdData_StartRowEditing(object sender, DevExpress.Web.Data.ASPxStartRowEditingEventArgs e)
        {
            grdData.CancelEdit();
            grdData.JSProperties.Add("cpEdit", "");
        }

        protected void grdData_CustomCallback(object sender, DevExpress.Web.ASPxGridView.ASPxGridViewCustomCallbackEventArgs e)
        {

        }

        protected void grdData_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            grdData.CancelEdit();
            grdData.JSProperties.Add("cpEdit", "");
        }
    }
}