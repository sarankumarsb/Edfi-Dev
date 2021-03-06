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

namespace EdFi.Dashboards.Presentation.Core.Views.MetricTemplates.LocalEducationAgency.GoalPlanning
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/LocalEducationAgency/GoalPlanning/GranularMetric.Level2.c" +
        "shtml")]
    public class GranularMetric_Level2 : System.Web.Mvc.WebViewPage<IGranularMetric>
    {
        public GranularMetric_Level2()
        {
        }
        public override void Execute()
        {

WriteLiteral("<tr id=\"vMetric");


            
            #line 2 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"container\">\r\n    <td headers=\"MetricName");


            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" title=\"");


            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                                                                 Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <span id=\"vMetricVariantId");


            
            #line 4 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                              Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"metricId\">\r\n            ");


            
            #line 5 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
        Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 5 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                          Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n        <h3 class=\"title\">\r\n            <span>");


            
            #line 8 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
              Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 9 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
             if (!String.IsNullOrWhiteSpace(Model.Context))
            {

            
            #line default
            #line hidden
WriteLiteral("                <span id=\"vContext");


            
            #line 11 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                              Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"MetricTitle\">&nbsp;(");


            
            #line 11 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                                                  Write(Model.Context);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");


            
            #line 12 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </h3>\r\n        <div id=\"vDescription");


            
            #line 14 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                         Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"description\">");


            
            #line 14 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                                      Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n        \r\n        ");


            
            #line 16 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
   Write(Html.Partial("UnderConstruction", (MetricBase)Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n    <td headers=\"MetricValue");


            
            #line 18 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                        Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"State\">\r\n        <span id=\"vStatus");


            
            #line 19 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                     Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 20 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
       Write(Html.Partial("StatusLabel", Model.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricGoal");


            
            #line 23 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"Trend\">\r\n        <span id=\"vGoal");


            
            #line 24 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                   Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 25 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
       Write(Model.Values["DisplayGoal"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricDifferenceFromGoal");



            #line 28 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                     Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));
            
            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"CampusGoal\">\r\n        <span id=\"vDifference");


            
            #line 29 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                         Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"");


            
            #line 29 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                          Write(Legacy.DifferenceFromGoalClass(Model.Values["GoalDifference"]));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 30 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
       Write(Model.Values["DisplayGoalDifference"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricNewGoal");


            
            #line 33 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                          Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"DifferenceFromGoal\">\r\n        <input required aria-required=\"tr" +
"ue\" id=\"newGoal");


            
            #line 34 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                    Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"newGoal\" type=\"text\" value=\"");


            
            #line 34 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                                                                                Write(Model.Goal.Value);

            
            #line default
            #line hidden
WriteLiteral("\" data-metricId=\"");


            
            #line 34 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                                                                                                                  Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("\" data-currentGoal=\"");


            
            #line 34 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                                                                                                                                                     Write(Model.Goal.Value);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Set New Goal For ");


            
            #line 34 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                                                                                                                                                                                                 Write(Model.Parent.Name);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 34 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                                                                                                                                                                                                                      Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n    </td>\r\n    <td headers=\"DropDown");


            
            #line 36 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                     Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-tem-type=\"ContextMenu\">\r\n        ");


            
            #line 37 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
   Write(Html.Partial("ContextMenu", (MetricBase)Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n    </td>\r\n</tr>\r\n\r\n<script>\r\n    $(\'input[title=\"Set New Goal For ");


            
            #line 42 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                 Write(Model.Parent.Name);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 42 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level2.cshtml"
                                                      Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\"]\').keyup(function (event) {\r\n        if (event.keyCode == 13) {\r\n            go" +
"als.publishEdOrgGoals();\r\n        }\r\n    });\r\n</script>\r\n");


        }
    }
}
#pragma warning restore 1591
