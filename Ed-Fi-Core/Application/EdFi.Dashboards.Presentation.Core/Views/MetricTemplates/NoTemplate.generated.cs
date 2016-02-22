﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdFi.Dashboards.Presentation.Core.Views.MetricTemplates
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
    
    #line 2 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/NoTemplate.cshtml")]
    public partial class NoTemplate : System.Web.Mvc.WebViewPage<MetricBase>
    {
        public NoTemplate()
        {
        }
        public override void Execute()
        {


WriteLiteral("<tr id=\"vMetric");


            
            #line 3 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <td class=\"MetricSubTitle\" title=\"");


            
            #line 4 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                                 Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\" style=\"border: 2px solid red;\" colspan=\"3\"> <!-- Use colspan=3 because that\'s t" +
"he with templates, 3 is the lowest number of columns we have-->\r\n        <span i" +
"d=\"vName");


            
            #line 5 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                   Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"MetricTitle\">Metric Id(");


            
            #line 5 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                                                                           Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 5 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                                                                                             Write(Model.MetricVariantType);

            
            #line default
            #line hidden
WriteLiteral(")&nbsp;-&nbsp;");


            
            #line 5 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                                                                                                                                    Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <br />\r\n        <span id=\"vDescription");


            
            #line 7 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                          Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 7 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                                                   Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <br/>\r\n        <span>Metric Type: ");


            
            #line 9 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                      Write(Model.MetricType);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <span>Domain Entity Type: ");


            
            #line 10 "..\..\Views\MetricTemplates\NoTemplate.cshtml"
                              Write(string.IsNullOrWhiteSpace(Model.DomainEntityType) ? "DomainEntityType is required but not set." : Model.DomainEntityType);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n    </td>\r\n</tr>\r\n");


        }
    }
}
#pragma warning restore 1591