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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/LocalEducationAgency/GoalPlanning/ContainerMetric.Level0." +
        "cshtml")]
    public class ContainerMetric_Level0 : System.Web.Mvc.WebViewPage<ContainerMetric>
    {
        public ContainerMetric_Level0()
        {
        }
        public override void Execute()
        {

WriteLiteral("<span id=\"vMetricVariantId");


            
            #line 2 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\ContainerMetric.Level0.cshtml"
                      Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"metricId\">\r\n    ");


            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\ContainerMetric.Level0.cshtml"
Write(Model.MetricId);

            
            #line default
            #line hidden
WriteLiteral("-");


            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\ContainerMetric.Level0.cshtml"
                  Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\r\n</span>\r\n<h2><a name=\"");


            
            #line 5 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\ContainerMetric.Level0.cshtml"
         Write(Model.DisplayName.Replace(" ","_"));

            
            #line default
            #line hidden
WriteLiteral("\">Goal Planning - ");


            
            #line 5 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\ContainerMetric.Level0.cshtml"
                                                                Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral("</a></h2>\r\n<a id=\"buttonPublishLEAGoals\" class=\"btn\" href=\"#\" onclick=\"goals.publ" +
"ishEdOrgGoals();\">Publish District Goals</a>\r\n<a id=\"buttonPublishAllGoals\" clas" +
"s=\"btn\" href=\"#\" onclick=\"goals.publishAllGoals();\">Publish All Goals</a>\r\n");


            
            #line 8 "..\..\Views\MetricTemplates\LocalEducationAgency\GoalPlanning\ContainerMetric.Level0.cshtml"
Write(Html.Partial("JumpToMetricSubcategory", Model.Children));

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
