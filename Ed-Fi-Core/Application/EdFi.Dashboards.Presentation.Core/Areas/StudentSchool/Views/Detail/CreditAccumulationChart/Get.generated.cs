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

namespace EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Views.Detail.CreditAccumulationChart
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
    
    #line 1 "..\..\Areas\StudentSchool\Views\Detail\CreditAccumulationChart\Get.cshtml"
    using System.Web.UI.DataVisualization.Charting;
    
    #line default
    #line hidden
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\StudentSchool\Views\Detail\CreditAccumulationChart\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line 3 "..\..\Areas\StudentSchool\Views\Detail\CreditAccumulationChart\Get.cshtml"
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Architecture;
    
    #line 4 "..\..\Areas\StudentSchool\Views\Detail\CreditAccumulationChart\Get.cshtml"
    using EdFi.Dashboards.Presentation.Web.Architecture.HtmlHelperExtensions;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/StudentSchool/Views/Detail/CreditAccumulationChart/Get.cshtml")]
    public class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Resources.Models.Charting.ChartData>
    {
        public Get()
        {
        }
        public override void Execute()
        {





WriteLiteral("\n");


            
            #line 7 "..\..\Areas\StudentSchool\Views\Detail\CreditAccumulationChart\Get.cshtml"
  
  var studentUSI = EdFiDashboardContext.Current.StudentUSI.GetValueOrDefault();
  var metricVariantId = EdFiDashboardContext.Current.MetricVariantId.GetValueOrDefault();


            
            #line default
            #line hidden
WriteLiteral("\n    <script>\r\n        analyticsManager.trackDrilldown(\'StudentCreditAccumulation" +
"Chart\', \'");


            
            #line 13 "..\..\Areas\StudentSchool\Views\Detail\CreditAccumulationChart\Get.cshtml"
                                                                       Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 13 "..\..\Areas\StudentSchool\Views\Detail\CreditAccumulationChart\Get.cshtml"
                                                                                             Write(studentUSI);

            
            #line default
            #line hidden
WriteLiteral("\');\n    </script>\n\n    ");


            
            #line 16 "..\..\Areas\StudentSchool\Views\Detail\CreditAccumulationChart\Get.cshtml"
Write(Html.BarChart(Model, 740, 250, 30, 0, 5, "{0}", true, SeriesChartType.Column, false));

            
            #line default
            #line hidden
WriteLiteral("\n    <p class=\"metric-subtitle\">*In cases where a student has incomplete or missi" +
"ng transcript data, credit shortfalls may be likely.</p>\n");


        }
    }
}
#pragma warning restore 1591
