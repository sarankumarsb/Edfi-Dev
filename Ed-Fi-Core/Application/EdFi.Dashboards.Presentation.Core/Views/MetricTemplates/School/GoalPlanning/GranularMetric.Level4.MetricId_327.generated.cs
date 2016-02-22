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

namespace EdFi.Dashboards.Presentation.Core.Views.MetricTemplates.School.GoalPlanning
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/School/GoalPlanning/GranularMetric.Level4.MetricId_327.cs" +
        "html")]
    public class GranularMetric_Level4_MetricId_327 : System.Web.Mvc.WebViewPage<IGranularMetric>
    {
        public GranularMetric_Level4_MetricId_327()
        {
        }
        public override void Execute()
        {

WriteLiteral("<tr id=\"vMetric");


            
            #line 2 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <td headers=\"MetricName");


            
            #line 3 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" title=\"");


            
            #line 3 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                                                                                Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <p class=\"arrow arrow-indented\">\r\n            <span id=\"vMetricVarian" +
"tId");


            
            #line 5 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                  Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"metricId\">\r\n                ");


            
            #line 6 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
            Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 6 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                              Write(Model.MetricVariantType);

            
            #line default
            #line hidden
WriteLiteral("\r\n            </span>\r\n            <span id=\"vName");


            
            #line 8 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                       Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 8 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                                 Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 9 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
             if (!String.IsNullOrWhiteSpace(Model.Context))
            {

            
            #line default
            #line hidden
WriteLiteral("                <span id=\"vContext");


            
            #line 11 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                              Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">(");


            
            #line 11 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                                        Write(Model.Context);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");


            
            #line 12 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <span class=\"under-construction\">");


            
            #line 13 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                        Write(Html.Partial("UnderConstruction", (MetricBase)Model));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n    </td>\r\n    <td headers=\"MetricValue");


            
            #line 16 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                        Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <span id=\"vStatus");


            
            #line 17 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                     Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 18 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
       Write(Html.Partial("StatusLabel", Model.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricGoal");


            
            #line 21 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <span id=\"vGoal");


            
            #line 22 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                   Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 23 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
       Write(Model.Values["DisplayGoal"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricDifferenceFromGoal");


            
            #line 26 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                     Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <span id=\"vDifference");


            
            #line 27 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                         Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"");


            
            #line 27 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                                          Write(Legacy.DifferenceFromGoalClass(Model.Values["GoalDifference"]));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 28 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
       Write(Model.Values["DisplayGoalDifference"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricNewGoal");


            
            #line 31 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                          Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <input required aria-required=\"true\" id=\"newGoal");


            
            #line 32 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                                    Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" type=\"text\" value=\"");


            
            #line 32 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                                                                                Write(Model.Goal.Value);

            
            #line default
            #line hidden
WriteLiteral("\" data-metricId=\"");


            
            #line 32 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                                                                                                                  Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("\" data-currentGoal=\"");


            
            #line 32 "..\..\Views\MetricTemplates\School\GoalPlanning\GranularMetric.Level4.MetricId_327.cshtml"
                                                                                                                                                                     Write(Model.Goal.Value);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"New Goal\"/>\r\n    </td>\r\n</tr>\r\n");


        }
    }
}
#pragma warning restore 1591