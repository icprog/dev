﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebModule.NAANAdmin.Application.Usercontrol
{
    public partial class uApplication : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var datasource = new[]
            {
                new { OrganizationId=1, ParentOrganizationId=0, Id="MS0001",name="Trang Chủ", Description="Trang chủ",  Property="" },
                new { OrganizationId=2, ParentOrganizationId=1, Id="MS0002",name="Tổ chức", Description="Tổ chức", Property="123456879" },
                new { OrganizationId=3, ParentOrganizationId=2, Id="MS0003",name="Người dùng", Description="Người sử dụng trong tổ chức", Property="" },
                new { OrganizationId=4, ParentOrganizationId=3, Id="MS0004",name="Danh mục", Description="Danh mục", Property="" },
                new { OrganizationId=5, ParentOrganizationId=3, Id="MS0005",name="Mời", Description="Mời", Property="" },
                new { OrganizationId=6, ParentOrganizationId=5, Id="MS0006",name="Mời qua email", Description="Mời người sử dụng", Property="" },
                new { OrganizationId=7, ParentOrganizationId=5, Id="MS0007",name="Mời theo danh sách file", Description="Mời theo danh sách file", Property="" },
                new { OrganizationId=8, ParentOrganizationId=1, Id="MS0008",name="MailServer", Description="MailServer", Property="" },
                new { OrganizationId=9, ParentOrganizationId=0, Id="MS0009",name="Nghiệp vụ mua", Description="Nghiệp vụ mua", Property="" },
                new { OrganizationId=10, ParentOrganizationId=0, Id="MS00010",name="Nghiệp vụ bán", Description="Nghiệp vụ bán", Property="" },
                new { OrganizationId=11, ParentOrganizationId=0, Id="MS0011",name="Cấu hình Dữ liệu", Description="Cấu hình Dữ liệu", Property="" },
                new { OrganizationId=12, ParentOrganizationId=11, Id="MS0012",name="OperationDB", Description="OperationDB", Property="" },
                new { OrganizationId=13, ParentOrganizationId=11, Id="MS0023",name="Warehouse", Description="Warehouse", Property="" },
                new { OrganizationId=14, ParentOrganizationId=11, Id="MS0014",name="Analytic Services", Description="Analytic Services", Property="" },
                new { OrganizationId=15, ParentOrganizationId=11, Id="MS0015",name="FileServer", Description="FileServer", Property="" },
                new { OrganizationId=16, ParentOrganizationId=11, Id="MS0016",name="Search Services", Description="Search Services", Property="" },
            };
            tlSitemap.DataSource = datasource;
            tlSitemap.DataBind();
        }
    }
}