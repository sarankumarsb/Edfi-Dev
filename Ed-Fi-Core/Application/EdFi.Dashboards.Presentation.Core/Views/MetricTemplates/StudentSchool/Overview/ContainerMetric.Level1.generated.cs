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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/StudentSchool/Overview/ContainerMetric.Level1.cshtml")]
    public class ContainerMetric_Level1 : System.Web.Mvc.WebViewPage<ContainerMetric>
    {
        public ContainerMetric_Level1()
        {
        }
        public override void Execute()
        {

WriteLiteral("<tr id=\"vMetric");


            
            #line 2 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t<td title=\"");


            
            #line 3 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
        Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"bulleted-metric bulleted-metric-border\">\r\n\t\t<i class=\"icon-right-circled" +
"\"></i>\r\n\t\t<span class=\"title\">\r\n\t\t\t<h2>\r\n\t\t\t\t<a href=\"");


            
            #line 7 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
         Write(Url.Content(Model.Url));

            
            #line default
            #line hidden
WriteLiteral("\" id=\"vName");


            
            #line 7 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
                                             Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n\t\t\t\t\t");


            
            #line 8 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
 Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n\t\t\t\t</a>\r\n\t\t\t</h2>\r\n");


            
            #line 11 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
 			if (!string.IsNullOrEmpty(Model.Context)) {

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<span id=\"vContext");


            
            #line 12 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
                  Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">&nbsp;(");


            
            #line 12 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
                                                   Write(Model.Context);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");


            
            #line 13 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t\t<span id=\"vDescription");


            
            #line 14 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
                     Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"description\">");


            
            #line 14 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level1.cshtml"
                                                                  Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t</span>\r\n\t</td>\r\n\t<td class=\"bulleted-metric-border\"></td>\r\n\t<td class" +
"=\"bulleted-metric-border\"></td>\r\n</tr>\r\n");


        }
    }
}
#pragma warning restore 1591