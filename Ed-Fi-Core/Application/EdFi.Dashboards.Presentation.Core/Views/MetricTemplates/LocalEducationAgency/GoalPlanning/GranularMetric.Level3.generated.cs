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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/LocalEducationAgency/GoalPlanning/GranularMetric.Level3.c" +
        "shtml")]
    public class GranularMetric_Level3 : System.Web.Mvc.WebViewPage<IGranularMetric>
    {
        public GranularMetric_Level3()
        {
        }
        public override void Execute()
        {

WriteLiteral("<tr id=\"vMetric");


            
            #line 2 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <td title=\"");


            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
          Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\" headers=\"MetricName");


            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                              Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <p class=\"arrow\">\r\n            <i class=\"icon-blank\"></i>\r\n          " +
"  <span id=\"vMetricVariantId");


            
            #line 6 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                  Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"metricId\">");


            
            #line 6 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                                             Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 6 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                                                               Write(Model.MetricVariantType);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n            <span id=\"vName");


            
            #line 7 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                       Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 7 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                 Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");


            
            #line 8 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
             if (!String.IsNullOrWhiteSpace(Model.Context))
            {

            
            #line default
            #line hidden
WriteLiteral("                <span id=\"vContext");


            
            #line 10 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                              Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">(");


            
            #line 10 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                        Write(Model.Context);

            
            #line default
            #line hidden
WriteLiteral(")</span>\r\n");


            
            #line 11 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <span class=\"under-construction\">");


            
            #line 12 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                        Write(Html.Partial("UnderConstruction", (MetricBase)Model));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n        </p>\r\n    </td>\r\n    <td headers=\"MetricValue");


            
            #line 15 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                        Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <span id=\"vStatus");


            
            #line 16 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                     Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 17 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
       Write(Html.Partial("StatusLabel", Model.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricGoal");


            
            #line 20 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                       Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <span id=\"vGoal");


            
            #line 21 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                   Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 22 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
       Write(Model.Values["DisplayGoal"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricDifferenceFromGoal");


            
            #line 25 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                     Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <span id=\"vDifference");


            
            #line 26 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                         Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"");


            
            #line 26 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                          Write(Legacy.DifferenceFromGoalClass(Model.Values["GoalDifference"]));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 27 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
       Write(Model.Values["DisplayGoalDifference"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </span>\r\n    </td>\r\n    <td headers=\"MetricNewGoal");


            
            #line 30 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                          Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <input required aria-required=\"true\" id=\"newGoal");


            
            #line 31 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                    Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"newGoal\" type=\"text\" value=\"");


            
            #line 31 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                                                                                Write(Model.Goal.Value);

            
            #line default
            #line hidden
WriteLiteral("\" data-metricId=\"");


            
            #line 31 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                                                                                                                  Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("\" data-currentGoal=\"");


            
            #line 31 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                                                                                                                                                     Write(Model.Goal.Value);

            
            #line default
            #line hidden
WriteLiteral("\" title=\"Set New Goal For ");



            #line 31 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                                                                                                                                                                                                 Write(Model.Parent.Name);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 31 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                                                                                                                                                                                                                      Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\"/>\r\n    </td>\r\n    <td headers=\"DropDown");


            
            #line 33 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                     Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));
            
            
            #line default
            #line hidden
WriteLiteral("\">\r\n        ");


            
            #line 34 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
   Write(Html.Partial("ContextMenu", (MetricBase)Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        <script>\r\n            $(\'input[title=\"Set New Goal For ");


            
            #line 36 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                         Write(Model.Parent.Name);

            
            #line default
            #line hidden
WriteLiteral(" ");


            
            #line 36 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\GranularMetric.Level3.cshtml"
                                                              Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\"]\').keyup(function (event) {\r\n                if (event.keyCode == 13) {\r\n      " +
"              goals.publishEdOrgGoals();\r\n                }\r\n            });\r\n  " +
"      </script>\r\n    </td>\r\n</tr>\r\n\r\n");


        }
    }
}
#pragma warning restore 1591
