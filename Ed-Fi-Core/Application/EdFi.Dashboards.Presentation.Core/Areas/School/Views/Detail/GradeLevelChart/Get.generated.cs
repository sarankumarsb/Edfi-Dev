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

namespace EdFi.Dashboards.Presentation.Core.Areas.School.Views.Detail.GradeLevelChart
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
    
    #line 1 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
    using System.Web.UI.DataVisualization.Charting;
    
    #line default
    #line hidden
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line 3 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
    using EdFi.Dashboards.Presentation.Web.Architecture.HtmlHelperExtensions;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/School/Views/Detail/GradeLevelChart/Get.cshtml")]
    public class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Resources.Models.Charting.ChartData>
    {
        public Get()
        {
        }
        public override void Execute()
        {





WriteLiteral("             \n");


            
            #line 7 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
  
    var schoolId = EdFiDashboardContext.Current.SchoolId.GetValueOrDefault();
    var metricVariantId = EdFiDashboardContext.Current.MetricVariantId.GetValueOrDefault();


            
            #line default
            #line hidden
WriteLiteral("\n<script>\r\n    analyticsManager.trackDrilldown(\'SchoolGradeLevelChart\', \'");


            
            #line 13 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
                                                          Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 13 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
                                                                                Write(schoolId);

            
            #line default
            #line hidden
WriteLiteral("\');\n</script>\n<p>");


            
            #line 15 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
Write(Model.Goal);

            
            #line default
            #line hidden
WriteLiteral("</p>\n");


            
            #line 16 "..\..\Areas\School\Views\Detail\GradeLevelChart\Get.cshtml"
Write(Html.BarChart(Model, 740, 250, 0, 0, null, null, false, SeriesChartType.Column, false, null));

            
            #line default
            #line hidden
WriteLiteral("\n");


        }
    }
}
#pragma warning restore 1591
