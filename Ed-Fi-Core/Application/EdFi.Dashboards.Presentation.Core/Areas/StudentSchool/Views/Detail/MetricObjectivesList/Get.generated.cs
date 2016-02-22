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

namespace EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Views.Detail.MetricObjectivesList
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
    
    #line 1 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    using EdFi.Dashboards.Presentation.Web.Architecture;
    
    #line 2 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Web.Architecture.HtmlHelperExtensions;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/StudentSchool/Views/Detail/MetricObjectivesList/Get.cshtml")]
    public class Get : System.Web.Mvc.WebViewPage<IList<EdFi.Dashboards.Resources.Models.Student.Detail.MetricObjectiveModel>>
    {
        public Get()
        {
        }
        public override void Execute()
        {



WriteLiteral("\r\n");



            #line 5 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"

	var studentUSI = EdFiDashboardContext.Current.StudentUSI.GetValueOrDefault();
	var metricVariantId = EdFiDashboardContext.Current.MetricVariantId.GetValueOrDefault();


            
            #line default
            #line hidden
WriteLiteral("\r\n<script>\r\n\tanalyticsManager.trackDrilldown(\'StudentMetricObjectivesList\', \'");


            
            #line 11 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
                                                             Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 11 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
                                                                                   Write(studentUSI);

            
            #line default
            #line hidden
WriteLiteral("\');\r\n</script>\r\n\r\n");

            

            #line 14 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
 if(Model.Any()) {

            
            #line default
            #line hidden
WriteLiteral("\t<table class=\"standard-table standard-table-compressed\" summary=\"Table displays " +
"a list of metric objectives.\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th>Objective</th>\r\n\t\t\t\t" +
"<th>Value</th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");


            
            #line 23 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
 			for (int i = 0; i < Model.Count(); i++) {
				var objective = Model[i];

            
            #line default
            #line hidden
WriteLiteral("\t\t\t\t<tr>\r\n\t\t\t\t\t<td>\r\n\t\t\t\t\t\t<p class=\"arrow\">\r\n\t\t\t\t\t\t\t<i class=\"icon-blank\"></i>\r\n" +
"\t\t\t\t\t\t\t<span class=\"MetricBulletTitle\">");


            
            #line 29 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
                                   Write(objective.Description);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n\t\t\t\t\t\t</p>\r\n\t\t\t\t\t</td>\r\n\t\t\t\t\t<td>");


            
            #line 32 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
    Write(Html.Partial("MetricStateTypeLabel", objective.State.StateType, new ViewDataDictionary { { "DisplayText", objective.Value } }));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n\t\t\t\t</tr>\r\n");


            
            #line 34 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
			}

            
            #line default
            #line hidden
WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");


            
            #line 37 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
} else {

            
            #line default
            #line hidden
WriteLiteral("\t<span class=\"MetricNoData\">No data available.</span>\r\n");


            
            #line 39 "..\..\Areas\StudentSchool\Views\Detail\MetricObjectivesList\Get.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
