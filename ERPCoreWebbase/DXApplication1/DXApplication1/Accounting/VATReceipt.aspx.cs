﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility;

namespace WebModule.Accounting
{
    public partial class VATReceipt : System.Web.UI.Page, WebModule.Interfaces.IERPCoreWebModuleBase
    {
        public string AccessObjectId
        {
            get
            {
                return Constant.ACCESSOBJECT_ACCOUNT_VATRECEIPT_ID;
            }
        }
        public string AccessObjectGroupId
        {
            get
            {
                return Constant.ACCESSOBJECT_ACCOUNT_GROUPID;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}