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

namespace EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Views.Detail.CourseHistoryList
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
    
    #line 1 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 2 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Models.Shared;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Models.Shared;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Architecture;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/StudentSchool/Views/Detail/CourseHistoryList/Get.cshtml")]
    public class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Resources.Models.Student.Detail.CourseHistory.CourseHistoryModel>
    {
        public Get()
        {
        }
        public override void Execute()
        {




WriteLiteral("\n");


            
            #line 6 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
  
  var studentUSI = EdFiDashboardContext.Current.StudentUSI.GetValueOrDefault();
  var metricVariantId = EdFiDashboardContext.Current.MetricVariantId.GetValueOrDefault();


            
            #line default
            #line hidden
WriteLiteral("\n<script>\r\n    analyticsManager.trackDrilldown(\'StudentCourseHistoryList\', \'");


            
            #line 12 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
                                                             Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 12 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
                                                                                   Write(studentUSI);

            
            #line default
            #line hidden
WriteLiteral("\');\n</script>\n\n");


            
            #line 15 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
 if (Model.SubjectAreas.Any())
{
    var viewModel = new CourseHistoryModel()
                        {
                            CollapseExpandInitialState = ExpandCollapseModel.InitialState.Collapsed,
                            ShowJump = false,
                            Model = Model,
                            MetricVariantId = metricVariantId
                        };
        
            
            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
Write(Html.Partial("CourseHistory", viewModel));

            
            #line default
            #line hidden
            
            #line 25 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
                                                     
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <span class=\"MetricNoData\">No data available.</span>\n");


            
            #line 30 "..\..\Areas\StudentSchool\Views\Detail\CourseHistoryList\Get.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
