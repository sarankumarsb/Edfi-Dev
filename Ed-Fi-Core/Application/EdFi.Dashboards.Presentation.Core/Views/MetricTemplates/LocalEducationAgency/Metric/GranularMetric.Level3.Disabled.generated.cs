﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdFi.Dashboards.Presentation.Core.Views.MetricTemplates.LocalEducationAgency.Metric
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/LocalEducationAgency/Metric/GranularMetric.Level3.Disable" +
        "d.cshtml")]
    public partial class GranularMetric_Level3_Disabled : System.Web.Mvc.WebViewPage<IGranularMetric>
    {
        public GranularMetric_Level3_Disabled()
        {
        }
        public override void Execute()
        {

WriteLiteral("<tr id=\"vMetric");


            
            #line 2 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\"  data-metric-id=\"");


            
            #line 2 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
                                                      Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("\" data-metric-variant-id=\"");


            
            #line 2 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
                                                                                                 Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <td headers=\"MetricName");


            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"DisplayName\" title=\"");


            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
                                                                                                                             Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <p class=\"arrow\">\r\n            <i class=\"icon-blank\"></i>\r\n          " +
"  <a name=\"m");


            
            #line 6 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
                  Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\"></a>\r\n            <span class=\"metricId\">\r\n                ");


            
            #line 8 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
            Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 8 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
                              Write(Model.MetricVariantType);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n            ");


            
            #line 10 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
        Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 11 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
             if (!String.IsNullOrWhiteSpace(Model.Context))
            {

            
            #line default
            #line hidden
WriteLiteral("                <span>&nbsp;(");


            
            #line 13 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
                        Write(Model.Context);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");


            
            #line 14 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Level3.Disabled.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("          \r\n        </p>\r\n    </td>\r\n    <td colspan=\"6\"></td>\r\n</tr>");


        }
    }
}
#pragma warning restore 1591