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
    
    #line 1 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/School/Metric/GranularMetric.Level2.ParentMetricId_1044.M" +
        "etricVariantType_CurrentYear.cshtml")]
    public class GranularMetric_Level2_ParentMetricId_1044_MetricVariantType_CurrentYear : System.Web.Mvc.WebViewPage<IGranularMetric>
    {
        public GranularMetric_Level2_ParentMetricId_1044_MetricVariantType_CurrentYear()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
 if (((ContainerMetric)Model.Parent).Descendants.Count(x => x.MetricId == Model.MetricId && x.MetricType == MetricType.GranularMetric && ((IGranularMetric)x).Value != null) > 0)
{

            
            #line default
            #line hidden
WriteLiteral("    <tr id=\"vMetric");


            
            #line 5 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
               Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n        <td headers=\"MetricName");


            
            #line 6 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                           Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"DisplayName\" title=\"");


            
            #line 6 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                                                                                                                                 Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            <p class=\"title\">\r\n                <span class=\"metricId\">");


            
            #line 8 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                                   Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 8 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                                                     Write(Model.MetricVariantType);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                ");


            
            #line 9 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
           Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 10 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                 if (!String.IsNullOrWhiteSpace(Model.Context))
                {

            
            #line default
            #line hidden
WriteLiteral("                    ");

WriteLiteral("&nbsp;");

            
            
            #line 12 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                       Write(Model.Context);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 13 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                ");


            
            #line 14 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
           Write(Html.Partial("MetricFootnoteLabelSuperText", Model.Footnotes));

            
            #line default
            #line hidden
WriteLiteral("\r\n                <a name=\"m");


            
            #line 15 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                      Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">&nbsp;</a>\r\n            </p>\r\n            <p class=\"description\">");


            
            #line 17 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                              Write(Model.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            ");


            
            #line 18 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
       Write(Html.Partial("UnderConstruction", (MetricBase)Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td headers=\"MetricValue");


            
            #line 20 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                            Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"State\">\r\n            ");


            
            #line 21 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
       Write(Html.Partial("StatusLabel", Model.State));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td headers=\"MetricTrend");


            
            #line 23 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                            Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"Trend\">\r\n            ");


            
            #line 24 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
       Write(Html.Partial("Trend", Model.Trend));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td headers=\"MetricGoal");


            
            #line 26 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                           Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"CampusGoal\">\r\n");


            
            #line 27 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
             if (Model.Value != null)
            {

            
            #line default
            #line hidden

            #line 29 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
           Write(Model.Values["DisplayGoal"]);

            
            #line default
            #line hidden

            #line 29 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
            
            }

            
            #line default
            #line hidden
WriteLiteral("        </td>\r\n        <td headers=\"MetricDifferenceFromGoal");


            
            #line 32 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                                         Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));
                    
            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"DifferenceFromGoal\" class=\"");
            

            
            #line 32 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                                                                                                                                                       Write(Legacy.DifferenceFromGoalClass(Model.Values["GoalDifference"]));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 33 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
       Write(Model.Values["DisplayGoalDifference"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td headers=\"MetricStudentAttainment");


            
            #line 35 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                                        Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"Population\" id=\"vValue");


            
            #line 35 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                                                                                                                                                 Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n            ");


            
            #line 36 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
       Write(Model.Values["Subpopulation"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 37 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
             if (Model.Values["Subpopulation"] != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <span>of </span>\r\n");


            
            #line 40 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            ");


            
            #line 41 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
       Write(Model.Values["TotalPopulation"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n        <td headers=\"MetricDetails");


            
            #line 43 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
                              Write(this.GetMetricRenderingContextValue("ParentContainerMetricId"));

            
            #line default
            #line hidden
WriteLiteral("\" data-item-type=\"ContextMenu\">\r\n            ");


            
            #line 44 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
       Write(Html.Partial("ContextMenu", (MetricBase)Model));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </td>\r\n    </tr>\r\n");


            
            #line 47 "..\..\Views\MetricTemplates\School\Metric\GranularMetric.Level2.ParentMetricId_1044.MetricVariantType_CurrentYear.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
