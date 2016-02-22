﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdFi.Dashboards.Presentation.Core.Areas.School.Views.Detail.StudentMetricTable
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
    
    #line 1 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
    using EdFi.Dashboards.Common.Utilities;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 3 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Models.Shared;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Providers.Models;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    #line 5 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
    using EdFi.Dashboards.Resources.Navigation.Mvc;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
    using EdFi.Dashboards.SecurityTokenService.Authentication;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/School/Views/Detail/StudentMetricTable/Get.cshtml")]
    public partial class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Resources.Models.CustomGrid.GridDataWithFootnotes>
    {
        public Get()
        {
        }
        public override void Execute()
        {







WriteLiteral("\n");


            
            #line 9 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
  
    var localEducationAgencyId = EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault();
    var schoolId = EdFiDashboardContext.Current.SchoolId.GetValueOrDefault();
    var staffUSI = UserInformation.Current.StaffUSI;
    var metricVariantId = EdFiDashboardContext.Current.MetricVariantId.GetValueOrDefault();
    var callbackUrl = EdFiDashboardContext.Current.RoutedUrl;

    var edFiGridModelProvider = IoC.Resolve<IEdFiGridModelProvider>();

    var edfiGridModel = edFiGridModelProvider.GetEdFiGridModel(true, true, 10, "Metric" + metricVariantId,
        metricVariantId, Model, Model.MetricFootnotes, Model.GetDefaultNonPersistedSettings("Metric" + metricVariantId + "EdFiGrid"), 
        false, "StudentList", new List<string> { "Default" }, "metricContext", true, callbackUrl, false);

    var customStudentListModel = new CustomStudentListModel
                                        {
                                            ControlId = "Metric" + metricVariantId,
                                            IsCustomStudentList = false,
                                            LinkParentIdentifier = "#Metric" + metricVariantId + "-EdFiGrid-interaction-custom",
                                            CheckboxParentIentifier = "#Metric" + metricVariantId + "-EdFiGrid-fixed-data-table",
                                            SelectAllCheckboxParentIentifier = "#Metric" + metricVariantId + "-EdFiGrid-fixed-header-table",
                                            CustomStudentListId = null,
                                            LocalEducationAgencyId = localEducationAgencyId,
                                            SchoolId = schoolId,
                                            StaffUSI = staffUSI,
                                            CustomStudentListUrl = EdFiDashboards.Site.Staff.CustomStudentList(schoolId, staffUSI, null, new {format = "json"}),
                                            UniqueId = metricVariantId
                                        };


            
            #line default
            #line hidden
WriteLiteral("\n<div id=\"StudentMetricTable");


            
            #line 38 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                       Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\n    <script>\n        analyticsManager.trackDrilldown(\'SchoolStudentMetricTable" +
"\', \'");


            
            #line 40 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                                                                 Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 40 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                                                                                       Write(schoolId);

            
            #line default
            #line hidden
WriteLiteral("\');\n\n        $(document).ready(function () {\n            $(\'#Metric");


            
            #line 43 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                  Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("-EdFiGrid-interaction-custom\').append($(\'#buttonExportAll");


            
            #line 43 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                                                                                             Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\'));\r\n            $(\'#buttonExportAll");


            
            #line 44 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                           Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\').show();\n            \n            $(\'#Metric");


            
            #line 46 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                  Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("-EdFiGrid\').bind(\'afterDrawEvent\', function(e, table) {\n                Metric");


            
            #line 47 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                  Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("CustomStudentList.redrawCheckboxes();\n            });\n        });\n    </script>\n " +
"   <a id=\"buttonExportAll");


            
            #line 51 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                      Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn\" style=\"display:none;\" onclick=\"Metric");


            
            #line 51 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                                                                                           Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.hideInteractionMenu(null);ExportSchoolStudentList(");


            
            #line 51 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                                                                                                                                                                        Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral(", \'");


            
            #line 51 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
                                                                                                                                                                                             Write(EdFiDashboards.Site.School.ExportMetricList(schoolId, metricVariantId, new { format = "csv" }));

            
            #line default
            #line hidden
WriteLiteral("\');\"><i class=\"icon-floppy\"></i> EXPORT ALL</a>\n\n");


            
            #line 53 "..\..\Areas\School\Views\Detail\StudentMetricTable\Get.cshtml"
      
        Html.RenderPartial("EdFiGrid", model: edfiGridModel);

        Html.RenderPartial("CustomStudentList", model: customStudentListModel);
    

            
            #line default
            #line hidden
WriteLiteral("</div>\n");


        }
    }
}
#pragma warning restore 1591