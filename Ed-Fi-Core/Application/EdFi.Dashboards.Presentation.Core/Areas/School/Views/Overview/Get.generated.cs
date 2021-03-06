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

namespace EdFi.Dashboards.Presentation.Core.Areas.School.Views.Overview
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
    
    #line 3 "..\..\Areas\School\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line 4 "..\..\Areas\School\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\School\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.School.Controllers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Areas\School\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Utilities.ExtensionMethods.HtmlHelper;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\School\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\School\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Resources.Navigation;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/School/Views/Overview/Get.cshtml")]
    public class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Resources.Models.School.Overview.OverviewModel>
    {
        public Get()
        {
        }
        public override void Execute()
        {

WriteLiteral("           \n");







WriteLiteral("\n");


            
            #line 10 "..\..\Areas\School\Views\Overview\Get.cshtml"
  
    ViewBag.Title = "School Overview";


            
            #line default
            #line hidden
WriteLiteral("\n");


DefineSection("ContentPlaceHolderHead", () => {

WriteLiteral("\n    <title>");


            
            #line 15 "..\..\Areas\School\Views\Overview\Get.cshtml"
       Write(Html.Action("Title", typeof(SchoolLayoutController).GetControllerName(), new { subTitle = "Overview" }));

            
            #line default
            #line hidden
WriteLiteral("</title>\n    <script type=\"text/javascript\">\r\n        var pageArea = { Area: \'sch" +
"ool\', Page: \'Academic Dashboard - Overview\' };\r\n    </script>\n");


});

WriteLiteral("\n\n");


DefineSection("ContentPlaceHolder1", () => {

WriteLiteral("\n    <div class=\"l-metrics\">\r\n        \n        <div class=\"accountability-rating\"" +
">\r\n");


            
            #line 25 "..\..\Areas\School\Views\Overview\Get.cshtml"
             foreach (var rating in Model.Accountability.AccountabilityRatings) 
            {

            
            #line default
            #line hidden
WriteLiteral("                <p>\r\n                    <span>");


            
            #line 28 "..\..\Areas\School\Views\Overview\Get.cshtml"
                     Write(rating.Attribute);

            
            #line default
            #line hidden
WriteLiteral(":</span>\n                    <span>");


            
            #line 29 "..\..\Areas\School\Views\Overview\Get.cshtml"
                     Write(rating.Value);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </p>\n");


            
            #line 31 "..\..\Areas\School\Views\Overview\Get.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </div>\n");


            
            #line 33 "..\..\Areas\School\Views\Overview\Get.cshtml"
           Html.RenderAction("Get", "Metrics",
                                      new
                                          {
                                              renderingMode = Model.RenderingMode,
                                              schoolId = Model.Accountability.SchoolId,
                                              metricVariantId = Model.MetricVariantId
                                          }); 

            
            #line default
            #line hidden
WriteLiteral("    </div>\n");


});

WriteLiteral("\n");


        }
    }
}
#pragma warning restore 1591
