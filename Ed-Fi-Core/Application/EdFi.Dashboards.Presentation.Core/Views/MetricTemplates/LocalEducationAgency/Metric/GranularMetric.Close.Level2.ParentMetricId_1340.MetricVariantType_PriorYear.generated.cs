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
    
    #line 1 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Close.Level2.ParentMetricId_1340.MetricVariantType_PriorYear.cshtml"
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/LocalEducationAgency/Metric/GranularMetric.Close.Level2.P" +
        "arentMetricId_1340.MetricVariantType_PriorYear.cshtml")]
    public class GranularMetric_Close_Level2_ParentMetricId_1340_MetricVariantType_PriorYear : System.Web.Mvc.WebViewPage<IGranularMetric>
    {
        public GranularMetric_Close_Level2_ParentMetricId_1340_MetricVariantType_PriorYear()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Close.Level2.ParentMetricId_1340.MetricVariantType_PriorYear.cshtml"
 if (((ContainerMetric)Model.Parent).Descendants.Count(x => x.MetricId == Model.MetricId && x.MetricType == MetricType.GranularMetric && ((IGranularMetric)x).Value != null) > 0)
{

            
            #line default
            #line hidden

            #line 5 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Close.Level2.ParentMetricId_1340.MetricVariantType_PriorYear.cshtml"
Write(Html.Partial("DynamicContentDiv", Model));

            
            #line default
            #line hidden
            
            #line 5 "..\..\Views\MetricTemplates\LocalEducationAgency\Metric\GranularMetric.Close.Level2.ParentMetricId_1340.MetricVariantType_PriorYear.cshtml"
            
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
