﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18034
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdFi.Dashboards.Presentation.Core.Areas.Admin.Views.LogInAs
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line 1 "..\..\Areas\Admin\Views\LogInAs\Get.cshtml"
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/LogInAs/Get.cshtml")]
    public class Get : System.Web.Mvc.WebViewPage<dynamic>
    {
        public Get()
        {
        }
        public override void Execute()
        {


            
            #line 2 "..\..\Areas\Admin\Views\LogInAs\Get.cshtml"
  
    ViewBag.Title = "Admin";


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("ContentPlaceHolderHead", () => {

WriteLiteral("\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("ContentPlaceHolder1", () => {

WriteLiteral("\r\n    You do not have permission to login as the selected user or the selected us" +
"er cannot login to the system.\r\n");


});

WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591
