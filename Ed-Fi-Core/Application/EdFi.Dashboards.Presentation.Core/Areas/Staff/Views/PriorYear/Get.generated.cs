﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdFi.Dashboards.Presentation.Core.Areas.Staff.Views.PriorYear
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
    
    #line 1 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 3 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.Staff.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Models.Shared;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Resources.Navigation;
    
    #line 6 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
    using EdFi.Dashboards.Resources.Navigation.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Staff/Views/PriorYear/Get.cshtml")]
    public partial class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Presentation.Core.Areas.Staff.Models.Shared.StaffStudentListModel>
    {
        public Get()
        {
        }
        public override void Execute()
        {






WriteLiteral("\n");


WriteLiteral("\n");


            
            #line 10 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
  
  var localEducationAgencyId = EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault();
  var schoolId = EdFiDashboardContext.Current.SchoolId.GetValueOrDefault();
  var staffUSI = EdFiDashboardContext.Current.StaffUSI.GetValueOrDefault();


            
            #line default
            #line hidden
WriteLiteral("\n");


DefineSection("ContentPlaceHolderHead", () => {

WriteLiteral("\n    <title>");


            
            #line 17 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
       Write(Html.Action("Title", typeof(StaffLayoutController).GetControllerName(), new { subTitle = "Prior Year" }));

            
            #line default
            #line hidden
WriteLiteral("</title>\n    <script type=\"text/javascript\">\r\n        var pageArea = { Area: \'cla" +
"ssroom\', Page: \'Prior Year\' };\r\n    </script>\n");


});

WriteLiteral("\n\n");


DefineSection("ContentPlaceHolder1", () => {

WriteLiteral("\n");


            
            #line 24 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
     
       var edfiGridModel = new EdFiGridModel
                            {
                                   DisplayInteractionMenu = true,
                                   DisplayAddRemoveColumns = true,
                                   FixedHeight = 0,
                                   GridName = "PriorYear",
                                   GridTable = Model.GridTable,
                                   SizeToWindow = true,
                                   UniqueTableName = "PriorYear",
                                   NonPersistedSettings = Model.GetDefaultNonPersistedSettings("PriorYearEdFiGrid"),
                                   EntityList = new EntityListModel { ListType = "StudentList", MetricVariantId = String.Empty, RowIndexForId = 1 },
                                   LegendViewNames = Model.LegendViewNames,
                                   DefaultSortColumn = 1,
                                   AllowMaximizeGrid = true
                               };
                               
        Html.RenderPartial("EdFiGrid", model: edfiGridModel);

        if (Model.IsCurrentUserListOwner)
        {
            var customStudentListModel = new CustomStudentListModel
            {
                ControlId = "PriorYear",
                IsCustomStudentList = Model.IsCustomStudentList,
                LinkParentIdentifier = "#PriorYear-EdFiGrid-interaction-custom",
                CheckboxParentIentifier = "#PriorYear-EdFiGrid-fixed-data-table",
                SelectAllCheckboxParentIentifier = "#PriorYear-EdFiGrid-fixed-header-table",
                CustomStudentListId = Model.IsCustomStudentList ? Model.ListId : (long?)null,
                LocalEducationAgencyId = localEducationAgencyId,
                SchoolId = schoolId,
                StaffUSI = staffUSI,
                CustomStudentListUrl = EdFiDashboards.Site.Staff.CustomStudentList(schoolId, staffUSI, null, new { format = "json" })
            };

            Html.RenderPartial("CustomStudentList", model: customStudentListModel);
        }
    

            
            #line default
            #line hidden
WriteLiteral("\n");


            
            #line 63 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
     if (Model.IsCurrentUserListOwner)
    {

            
            #line default
            #line hidden
WriteLiteral("        <script>\n            $(\'#PriorYear-EdFiGrid\').bind(\'afterDrawEvent\', func" +
"tion(e, table) {\r\n                PriorYearCustomStudentList.redrawCheckboxes();" +
"\n            });\n        </script>\n");


            
            #line 70 "..\..\Areas\Staff\Views\PriorYear\Get.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral(@"    
    <script type=""text/javascript"">
        $('#PriorYear-EdFiGrid').bind('afterMaximizeEvent', function (e, table) {
            $('#PriorYear-EdFiGrid-interaction-custom2').append($('#StaffSlidingSubmenu'));
        });

        $('#PriorYear-EdFiGrid').bind('afterRestoreDownEvent', function (e, table) {
            $('#StaffSlidingMenuHome').append($('#StaffSlidingSubmenu'));
        });
    </script>
");


});

WriteLiteral("\n");


        }
    }
}
#pragma warning restore 1591
