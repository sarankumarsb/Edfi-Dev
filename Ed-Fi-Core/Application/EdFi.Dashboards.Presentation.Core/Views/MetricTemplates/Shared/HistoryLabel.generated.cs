﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
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
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 2 "..\..\Views\MetricTemplates\Shared\HistoryLabel.cshtml"
    using EdFi.Dashboards.Presentation.Core.Utilities;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\MetricTemplates\Shared\HistoryLabel.cshtml"
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/Shared/HistoryLabel.cshtml")]
    public partial class _Views_MetricTemplates_Shared_HistoryLabel_cshtml : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Metric.Resources.Models.State>
    {
        public _Views_MetricTemplates_Shared_HistoryLabel_cshtml()
        {
        }
        public override void Execute()
        {



WriteLiteral("<p title=\"");


            
            #line 4 "..\..\Views\MetricTemplates\Shared\HistoryLabel.cshtml"
      Write(Model.StateText);

            
            #line default
            #line hidden
WriteLiteral("\">\n");


            
            #line 5 "..\..\Views\MetricTemplates\Shared\HistoryLabel.cshtml"
             if (ViewBag.DisplayText != null)
            {
                
            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\MetricTemplates\Shared\HistoryLabel.cshtml"
           Write(ViewBag.DisplayText);

            
            #line default
            #line hidden
            
            #line 7 "..\..\Views\MetricTemplates\Shared\HistoryLabel.cshtml"
                                    
            }
            else
            {
                
            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\MetricTemplates\Shared\HistoryLabel.cshtml"
           Write(Model.DisplayStateText);

            
            #line default
            #line hidden
            
            #line 11 "..\..\Views\MetricTemplates\Shared\HistoryLabel.cshtml"
                                       
            }

            
            #line default
            #line hidden
WriteLiteral("            ");



WriteLiteral("\n</p>\n");


        }
    }
}
#pragma warning restore 1591
