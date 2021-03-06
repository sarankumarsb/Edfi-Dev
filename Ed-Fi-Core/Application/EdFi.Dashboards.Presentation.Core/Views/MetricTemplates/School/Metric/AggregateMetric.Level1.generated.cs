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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/School/Metric/AggregateMetric.Level1.cshtml")]
    public partial class AggregateMetric_Level1 : System.Web.Mvc.WebViewPage<AggregateMetric>
    {
        public AggregateMetric_Level1()
        {
        }
        public override void Execute()
        {


            
            #line 2 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
  
    //Define the ParentContainerMetricId to propagate fo the unique columns.
    //This si needed because we have "Complex tables" meaning colspans that then need unique ids in the headers and matching the cells in the rows below with the same headers="uniqueColumnId". 
    this.SetMetricRenderingContextValue("ParentContainerMetricId", Model.MetricId);


            
            #line default
            #line hidden
WriteLiteral("<!-- Inline Style is left intentionally in the MetricTemplate to provide a easyer" +
" way to override.-->\r\n<table summary=\"This table displays metrics regarding ");


            
            #line 8 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                                                  Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral(".\">\r\n<thead>\r\n    <tr id=\"vMetric");


            
            #line 10 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
               Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">    \r\n        <th id=\"MetricName");


            
            #line 11 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                      Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"width: 34%;\" title=\"");


            
            #line 11 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                                                                                                                   Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            <span id=\"vMetricVariantId");


            
            #line 12 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                                  Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"metricId\">\r\n                ");


            
            #line 13 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
            Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 13 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                              Write(Model.MetricVariantType);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n            <a name=\"");


            
            #line 15 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                 Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                ");


            
            #line 16 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
            Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </a>\r\n            <a name=\"m");


            
            #line 18 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                  Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">&nbsp;</a>\r\n        </th>\r\n        <th id=\"MetricValue");


            
            #line 20 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"width: 9%;\" title=\"Color indicates if meeting school goal\">\r\n           " +
" Metric Value <br />\r\n            <small>(% of students)</small>\r\n        </th>\r" +
"\n        <th id=\"MetricTrend");


            
            #line 24 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"width: 7%;\" title=\"Trend arrow indicates difference from relevant prior " +
"period\">\r\n            Trend\r\n        </th>\r\n        <th id=\"MetricGoal");


            
            #line 27 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                      Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"width: 10%;\">\r\n            School Goal\r\n        </th>\r\n        <th id=\"M" +
"etricDifferenceFromGoal");


            
            #line 30 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                                    Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"width: 10%;\" title=\"Color indicates if meeting school goal\">\r\n          " +
"  Difference from Goal\r\n        </th>\r\n        <th id=\"MetricStudentAttainment");


            
            #line 33 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                                   Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" style=\"width: 12%;\">\r\n            Student Attainment<br />\r\n            <small>" +
"(# meeting student goal)</small>\r\n        </th>\r\n        <th id=\"MetricDetails");


            
            #line 37 "..\..\Views\MetricTemplates\School\Metric\AggregateMetric.Level1.cshtml"
                         Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"doNotPrint\" style=\"text-align:center; width: 9%\">\r\n            Details\r\n" +
"        </th>\r\n    </tr>\r\n</thead>\r\n<tbody>\r\n");


        }
    }
}
#pragma warning restore 1591
