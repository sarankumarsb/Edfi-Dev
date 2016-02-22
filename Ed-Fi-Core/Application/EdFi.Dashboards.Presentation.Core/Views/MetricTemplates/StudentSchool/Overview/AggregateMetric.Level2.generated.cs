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

namespace EdFi.Dashboards.Presentation.Core.Views.MetricTemplates.StudentSchool.Overview
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
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/StudentSchool/Overview/AggregateMetric.Level2.cshtml")]
    public class AggregateMetric_Level2 : System.Web.Mvc.WebViewPage<AggregateMetric>
    {
        public AggregateMetric_Level2()
        {
        }
        public override void Execute()
        {

WriteLiteral("<tr id=\"vMetric");


            
            #line 2 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" style=\"height: 35px;\">\r\n    <td title=\"");


            
            #line 3 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
          Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"bulleted-metric bulleted-metric-indented\">\r\n        <i class=\"icon-blank" +
"\"></i>\r\n        <p class=\"title\">\r\n            <h3 class=\"inline\">\r\n            " +
"    <a href=\"");


            
            #line 7 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
                     Write(Url.Content(Model.Url));

            
            #line default
            #line hidden
WriteLiteral("\" id=\"vName");


            
            #line 7 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
                                                         Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 7 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
                                                                                  Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n            </h3>\r\n");


            
            #line 9 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
             if (!string.IsNullOrEmpty(Model.Context))
            {

            
            #line default
            #line hidden
WriteLiteral("                <span id=\"vContext");


            
            #line 11 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
                              Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">&nbsp;(");


            
            #line 11 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
                                                              Write(Model.Context);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");


            
            #line 12 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <span id=\"vDescription");


            
            #line 13 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
                              Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"description\">\r\n                ");


            
            #line 14 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
           Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n        </p>\r\n    </td>\r\n    <td>\r\n        ");


            
            #line 19 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
   Write(Html.Partial("AggregateSummary", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td>\r\n        ");


            
            #line 22 "..\..\Views\MetricTemplates\StudentSchool\Overview\AggregateMetric.Level2.cshtml"
   Write(Html.Partial("AggregateStatus", Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n</tr>");


        }
    }
}
#pragma warning restore 1591
