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

namespace EdFi.Dashboards.Presentation.Web.Areas.LocalEducationAgency.Views.StudentDemographicList
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
    
    #line 1 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 3 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.LocalEducationAgency.Controllers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.LocalEducationAgency.Models.StudentDemographicList;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Models.Shared;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    #line 6 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Resources.Navigation.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.SecurityTokenService.Authentication;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/LocalEducationAgency/Views/StudentDemographicList/Get.cshtml")]
    public partial class Get : System.Web.Mvc.WebViewPage<StudentDemographicListModel>
    {
        public Get()
        {
        }
        public override void Execute()
        {







WriteLiteral("\r\n");


WriteLiteral("           \r\n");


            
            #line 11 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
  
    //ViewBag.Title = "Demographic";

    var safeDemographicName = Model.Demographic.Replace(" ", "").Replace("/", "").Replace("-", "").Replace(")", "").Replace("(", "");
    var localEducationAgencyId = EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault();
    var staffUSI = UserInformation.Current.StaffUSI;


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("ContentPlaceHolderHead", () => {

WriteLiteral("\r\n    <title>");


            
            #line 20 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
       Write(Html.Action("Title", typeof(LocalEducationAgencyLayoutController).GetControllerName(), new { subTitle = Model.Demographic }));

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <script>\r\n        var pageArea = { Area: \'local education agency\', " +
"Page: \'Students by Demographic\' };\r\n    </script>\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("ContentPlaceHolder1", () => {

WriteLiteral(@"
    <div id=""demographicSelector"" class=""student-drop-down"">
        <h2>Students by Demographic</h2>
        <label class=""content-label"" for=""demographicSelect"">Select demographic to show:</label>
        <select id=""demographicSelect"" class=""drop-down"">
");


            
            #line 31 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
             if(Model.Demographic.ToLower() == "select demographic")
            {

            
            #line default
            #line hidden
WriteLiteral("                <option selected=\"selected\">");


            
            #line 33 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                                       Write(Model.Demographic.ToUpper());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");


            
            #line 34 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <optgroup label=\"Gender\">\r\n");


            
            #line 36 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                 foreach (var gender in Model.MenuModel.Gender)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 38 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                              Write(gender.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 39 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && gender.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 42 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 43 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                   Write(gender.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 45 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n            <optgroup label=\"Ethnicity\">\r\n");


            
            #line 48 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                 foreach (var ethnicity in Model.MenuModel.Ethnicity)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 50 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                              Write(ethnicity.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 51 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && ethnicity.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 54 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 55 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                   Write(ethnicity.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 57 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n            <optgroup label=\"Race\">\r\n");


            
            #line 60 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                 foreach (var race in Model.MenuModel.Race)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 62 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                              Write(race.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 63 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && race.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 66 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 67 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                   Write(race.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 69 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n            <optgroup label=\"Program\">\r\n");


            
            #line 72 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                 foreach (var program in Model.MenuModel.Program)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 74 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                              Write(program.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 75 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && program.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 78 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 79 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                   Write(program.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 81 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n            <optgroup label=\"Indicator\">\r\n");


            
            #line 84 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                 foreach (var indicator in Model.MenuModel.Indicator)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 86 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                              Write(indicator.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 87 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && indicator.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 90 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");



WriteLiteral("\r\n");


            
            #line 92 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                         if (indicator.Attribute == "Late Enrollment")
                        {

            
            #line default
            #line hidden
WriteLiteral("                        ");

WriteLiteral("Highly Mobile\r\n");


            
            #line 95 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                        }
                        else
                        {
                        
            
            #line default
            #line hidden
            
            #line 98 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                   Write(indicator.Attribute);

            
            #line default
            #line hidden
            
            #line 98 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                                            
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </option>\r\n");


            
            #line 101 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n        </select>\r\n    </div>\r\n\r\n    <script>\r\n        $" +
"(document).ready(function () {\r\n            $(\"#demographicSelect\").navigateOnCh" +
"ange();\r\n            $(\'#Demographic");


            
            #line 109 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                       Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("-EdFiGrid-interaction-custom\').append($(\'#buttonExportAll");


            
            #line 109 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                                                                                                      Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("\'));\r\n            $(\'#buttonExportAll");


            
            #line 110 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                           Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("\').show();\r\n            $(\'#Demographic");


            
            #line 111 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                       Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("-EdFiGrid\').bind(\'afterDrawEvent\', function(e, table) {\r\n                Demograp" +
"hic");


            
            #line 112 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                       Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("CustomStudentList.redrawCheckboxes();\r\n            });\r\n        });\r\n    </script" +
">\r\n    \r\n\r\n");


            
            #line 118 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
      
        if (Model.GridData != null)
        {
            var callbackUrl = EdFiDashboardContext.Current.RoutedUrl;
            
            var edfiGridModel = new EdFiGridModel
            {
                DisplayInteractionMenu = true,
                DisplayAddRemoveColumns = true,
                FixedHeight = 0,
                GridName = "Demographic" + safeDemographicName,
                GridTable = Model.GridData,
                SizeToWindow = true,
                UniqueTableName = "Demographic" + safeDemographicName,
                EntityList = new EntityListModel { ListType = "StudentList", MetricVariantId = string.Empty, RowIndexForId = 1 },
                LegendViewNames = new List<string> { "Default" },
                DefaultSortColumn = 1,
                UsePagination = true,
                PaginationCallbackUrl = callbackUrl,
                ExportGridDataUrl = Model.ExportGridDataUrl,
                AllowMaximizeGrid = true,
                StudentWatchList = Model.GridData.WatchList,
                SelectedDemographicOption = Model.Demographic,
                PreviousNextSessionPage = Model.PreviousNextSessionPage,
                ListType = Model.ListType
            };

            var customStudentListModel = new CustomStudentListModel
            {
                ControlId = "Demographic" + safeDemographicName,
                IsCustomStudentList = false,
                LinkParentIdentifier = "#Demographic" + safeDemographicName + "-EdFiGrid-interaction-custom",
                CheckboxParentIentifier = "#Demographic" + safeDemographicName + "-EdFiGrid-fixed-data-table",
                SelectAllCheckboxParentIentifier = "#Demographic" + safeDemographicName + "-EdFiGrid-fixed-header-table",
                CustomStudentListId = null,
                LocalEducationAgencyId = localEducationAgencyId,
                SchoolId = null,
                StaffUSI = staffUSI,
                CustomStudentListUrl = EdFiDashboards.Site.Staff.LocalEducationAgencyCustomStudentList(localEducationAgencyId, staffUSI, null, new { format = "json" }),
                UniqueId = localEducationAgencyId
            };


            
            #line default
            #line hidden
WriteLiteral("            <!--<a id=\"buttonExportAll");


            
            #line 160 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                                  Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn\" style=\"display:none;\" onclick=\"ExportLocalEducationAgencyStudentDem" +
"ographicList(\'");


            
            #line 160 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                                                                                                                                                       Write(Model.Demographic);

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 160 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                                                                                                                                                                               Write(EdFiDashboards.Site.LocalEducationAgency.ExportStudentDemographicList(localEducationAgencyId, Model.Demographic, new { format = "csv" }));

            
            #line default
            #line hidden
WriteLiteral("\');\"><i class=\"icon-floppy\"></i> EXPORT ALL</a>-->\r\n");



WriteLiteral("            <a id=\"buttonExportAll");


            
            #line 161 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                              Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn\" style=\"display:none;\" onclick=\"Demographic");


            
            #line 161 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
                                                                                                            Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.exportGrid();\"><i class=\"icon-floppy\"></i> EXPORT ALL</a>\r\n");


            
            #line 162 "..\..\Areas\LocalEducationAgency\Views\StudentDemographicList\Get.cshtml"
            Html.RenderPartial("EdFiGrid", edfiGridModel);
            Html.RenderPartial("CustomStudentList", model: customStudentListModel);
        }
    

            
            #line default
            #line hidden

});

WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591
