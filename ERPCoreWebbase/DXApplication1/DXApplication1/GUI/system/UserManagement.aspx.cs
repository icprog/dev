﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility;

namespace WebModule.GUI.system
{
    public partial class UserManagement : System.Web.UI.Page, WebModule.Interfaces.IERPCoreWebModuleBase
    {

        public string AccessObjectId
        {
            get
            {
                return Constant.ACCESSOBJECT_SYSTEM_USER_ID;
            }
        }

        public string AccessObjectGroupId
        {
            get
            {
                return Constant.ACCESSOBJECT_SYSTEM_GROUPID;
            }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            Utils.ApplyTheme(this);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}