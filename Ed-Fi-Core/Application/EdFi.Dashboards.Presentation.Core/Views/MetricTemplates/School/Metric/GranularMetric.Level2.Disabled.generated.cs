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

namespace EdFi.Dashboards.Presentation.Core.Views.MetricTemplates.School.Metric
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/School/Metric/GranularMetric.Level2.Disabled.cshtml")]
    public class GranularMetric_Level2_Disabled : System.Web.Mvc.WebViewPage<IGranularMetric>
    {
        public GranularMetric_Level2_Disabled()
        {
        }
        public override void Execute()
        {

WriteLiteral("<tr id=\"vMetric");


            
            #line 2 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <td headers=\"MetricName");


            
            #line 3 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"DisplayName\" title=\"");


            
            #line 3 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
                                                                                                                             Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <span class=\"metricId\">");


            
            #line 4 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
                           Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 4 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
                                             Write(Model.MetricVariantType);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        <h3 class=\"title deemphasized\">\r\n            ");


            
            #line 6 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
       Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral(" <span class=\"hidden\">(Disabled)</span>\r\n        <a name=\"m");


            
            #line 7 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
              Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">&nbsp;</a>\r\n        </h3>\r\n        <p class=\"description deemphasized\">");


            
            #line 9 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
                                       Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n    </td>\r\n    <td headers=\"MetricDetails");


            
            #line 11 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.Disabled.cshtml"
                          Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" colspan=\"6\" data-item-type=\"ContextMenu\">\r\n    </td>\r\n</tr>\r\n");


        }
    }
}
#pragma warning restore 1591
