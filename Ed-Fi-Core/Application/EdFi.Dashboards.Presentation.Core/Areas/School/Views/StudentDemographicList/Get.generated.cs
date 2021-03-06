﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdFi.Dashboards.Presentation.Core.Areas.School.Views.StudentDemographicList
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
    
    #line 1 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Common.Utilities;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 5 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.School.Controllers;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.School.Models.StudentDemographicList;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Models.Shared;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Providers.Models;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    #line 8 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.Resources.Navigation.Mvc;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
    using EdFi.Dashboards.SecurityTokenService.Authentication;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/School/Views/StudentDemographicList/Get.cshtml")]
    public partial class Get : System.Web.Mvc.WebViewPage<StudentDemographicListModel>
    {
        public Get()
        {
        }
        public override void Execute()
        {









WriteLiteral("\r\n");


WriteLiteral("           \r\n");


            
            #line 13 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
  
    //ViewBag.Title = "Demographic";
    var safeDemographicName = Model.Demographic.Replace(" ", "").Replace("/", "").Replace("-", "").Replace(")", "").Replace("(", "");
    var localEducationAgencyId = EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault();
    var schoolId = EdFiDashboardContext.Current.SchoolId.GetValueOrDefault();
    var staffUSI = UserInformation.Current.StaffUSI;


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("ContentPlaceHolderHead", () => {

WriteLiteral("\r\n    <title>");


            
            #line 22 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
       Write(Html.Action("Title", typeof(SchoolLayoutController).GetControllerName(), new { subTitle = Model.Demographic }));

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n    <script type=\"text/javascript\">\r\n        var pageArea = { Area: \'sc" +
"hool\', Page: \'Students by Demographics\' };\r\n    </script>\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("ContentPlaceHolder1", () => {

WriteLiteral(@"
    <div class=""student-drop-down"" id=""demographicSelector"">
        <h2>Students by Demographic</h2>
        <label class=""content-label"" for=""demographicSelect"">Select demographic to show:</label>
        <select id=""demographicSelect"" class=""drop-down"">
");


            
            #line 33 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
             if (Model.PageTitle.ToLower() == "select demographic")
            {

            
            #line default
            #line hidden
WriteLiteral("                <option selected=\"selected\">");


            
            #line 35 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                                       Write(Model.PageTitle.ToUpper());

            
            #line default
            #line hidden
WriteLiteral("</option>\r\n");


            
            #line 36 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <optgroup label=\"Gender\">\r\n");


            
            #line 38 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                 foreach (var gender in Model.MenuModel.Gender)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 40 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                              Write(gender.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 41 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && gender.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 44 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 45 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                   Write(gender.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 47 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n            <optgroup label=\"Ethnicity\">\r\n");


            
            #line 50 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                 foreach (var ethnicity in Model.MenuModel.Ethnicity)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 52 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                              Write(ethnicity.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 53 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && ethnicity.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 56 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 57 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                   Write(ethnicity.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 59 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n            <optgroup label=\"Race\">\r\n");


            
            #line 62 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                 foreach (var race in Model.MenuModel.Race)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 64 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                              Write(race.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 65 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && race.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 68 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 69 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                   Write(race.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 71 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n            <optgroup label=\"Program\">\r\n");


            
            #line 74 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                 foreach (var program in Model.MenuModel.Program)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 76 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                              Write(program.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 77 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && program.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 80 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 81 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                   Write(program.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 83 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n            <optgroup label=\"Indicator\">\r\n");


            
            #line 86 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                 foreach (var indicator in Model.MenuModel.Indicator)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <option value=\"");


            
            #line 88 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                              Write(indicator.Url);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n");


            
            #line 89 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                         if (Request.Url != null && indicator.Attribute == Model.Demographic)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            ");

WriteLiteral("selected=\'selected\'\r\n");


            
            #line 92 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                        }
            
            #line default
            #line hidden
WriteLiteral(">\r\n                        ");


            
            #line 93 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                   Write(indicator.Attribute);

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </option>\r\n");


            
            #line 95 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </optgroup>\r\n        </select>\r\n    </div>\r\n\r\n<script type=\"text/java" +
"script\">\r\n    $(document).ready(function () {\r\n        $(\"#demographicSelect\").n" +
"avigateOnChange();\r\n        $(\'#Demographic");


            
            #line 103 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                   Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("-EdFiGrid-interaction-custom\').append($(\'#buttonExportAll");


            
            #line 103 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                                                                                                  Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("\'));\r\n        $(\'#buttonExportAll");


            
            #line 104 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                       Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("\').show();\r\n        $(\'#Demographic");


            
            #line 105 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                   Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("-EdFiGrid\').bind(\'afterDrawEvent\', function(e, table) {\r\n                        " +
"Demographic");


            
            #line 106 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                               Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("CustomStudentList.redrawCheckboxes();\r\n                    });\r\n    });\r\n</script" +
">\r\n\r\n");


            
            #line 111 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
      
        if (Model.GridData != null)
        {
            var callbackUrl = EdFiDashboardContext.Current.RoutedUrl;

            var edFiGridModelProvider = IoC.Resolve<IEdFiGridModelProvider>();

            var edfiGridModel = edFiGridModelProvider.GetEdFiGridModel(
                displayInteractionMenu: true, 
                displayAddRemoveColumns: true, 
                fixedHeight: 0, 
                name: "Demographic" + safeDemographicName, 
                metricVariantId: null, 
                gridTable: Model.GridData, 
                metricFootnotes: null, 
                nonPersistedSettings: null, 
                sizeToWindow: true, 
                listType: "StudentList", 
                legendViewNames: new List<string> {"Default"}, 
                hrefToUse: null, 
                usePagination: true, 
                paginationCallbackUrl: callbackUrl, 
                allowMaximizeGrid: true, 
                studentWatchlist: null, 
                selectedDemographicOption: Model.Demographic, 
                selectedSchoolCategoryOption: null, 
                selectedGradeOption: null, 
                previousNextSessionPage: Model.PreviousNextSessionPage, 
                exportGridDataUrl: Model.ExportGridDataUrl, 
                gridListType: Model.ListType);

            var customStudentListModel = new CustomStudentListModel
            {
                ControlId = "Demographic" + safeDemographicName,
                IsCustomStudentList = false,
                LinkParentIdentifier = "#Demographic" + safeDemographicName + "-EdFiGrid-interaction-custom",
                CheckboxParentIentifier = "#Demographic" + safeDemographicName + "-EdFiGrid-fixed-data-table",
                SelectAllCheckboxParentIentifier = "#Demographic" + safeDemographicName + "-EdFiGrid-fixed-header-table",
                CustomStudentListId = null,
                LocalEducationAgencyId = localEducationAgencyId,
                SchoolId = schoolId,
                StaffUSI = staffUSI,
                CustomStudentListUrl = EdFiDashboards.Site.Staff.CustomStudentList(schoolId, staffUSI, null, new { format = "json" }),
                UniqueId = schoolId
            };


            
            #line default
            #line hidden
WriteLiteral("            <a id=\"buttonExportAll");


            
            #line 157 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                              Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn\" style=\"display:none;\" onclick=\"Demographic");


            
            #line 157 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
                                                                                                            Write(safeDemographicName);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.exportGrid();\"><i class=\"icon-floppy\"></i> EXPORT ALL</a>\r\n");


            
            #line 158 "..\..\Areas\School\Views\StudentDemographicList\Get.cshtml"
            Html.RenderPartial("EdFiGrid", edfiGridModel);
            Html.RenderPartial("CustomStudentList", customStudentListModel);
        }
    

            
            #line default
            #line hidden

});


        }
    }
}
#pragma warning restore 1591
