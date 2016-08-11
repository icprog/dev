﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Utility;

namespace WebModule.Warehouse
{
    public partial class SourceExistequipment : System.Web.UI.Page, WebModule.Interfaces.IERPCoreWebModuleBase
    {
        public string AccessObjectId
        {
            get
            {
                return Constant.ACCESSOBJECT_WAREHOUSE_SOURCEEXISTMATERIAL_ID;
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
        protected void Page_Load(object sender, EventArgs e)
        {
            gr_data.DataSource =
              new[] { 
                     new { key="123", code = "HDP001", name = "Công cụ dụng cụ 1", unit="thùng", 
                             description = "Công cụ dụng cụ 1", sourcemin= "100",sourcesafe="200", cycle="30"
                    },
                    new { key="1234", code = "HDP003", name = "Công cụ dụng cụ 2", unit="Hộp", 
                             description = "Công cụ dụng cụ 2", sourcemin= "150",sourcesafe="250", cycle="40"
                    },
                };
            gr_data.KeyFieldName = "key";
            gr_data.DataBind();
        }

        protected void gr_data_InitNewRow(object sender, DevExpress.Web.Data.ASPxDataInitNewRowEventArgs e)
        {
            gr_data.CancelEdit();
            gr_data.JSProperties.Add("cpNew", "new");
        }
    }
}