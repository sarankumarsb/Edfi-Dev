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

namespace EdFi.Dashboards.Presentation.Core.Areas.Search.Views.Results
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
    
    #line 1 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.Common.Utilities;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line 4 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.Search.Controllers;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line 6 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.Resources.Navigation;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.Resources.Navigation.Mvc;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.Resources.Security.Common;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Search\Views\Results\Get.cshtml"
    using EdFi.Dashboards.SecurityTokenService.Authentication;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Search/Views/Results/Get.cshtml")]
    public partial class Get : System.Web.Mvc.WebViewPage<string>
    {
        public Get()
        {
        }
        public override void Execute()
        {










WriteLiteral("         \r\n");


            
            #line 12 "..\..\Areas\Search\Views\Results\Get.cshtml"
  
    //ViewBag.Title = "Search Page";


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("ContentPlaceHolderHead", () => {

WriteLiteral("\r\n    <title>");


            
            #line 17 "..\..\Areas\Search\Views\Results\Get.cshtml"
       Write(Html.Action("Title", typeof(SearchLayoutController).GetControllerName()));

            
            #line default
            #line hidden
WriteLiteral("</title>\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("ContentPlaceHolder1", () => {

WriteLiteral("\r\n");


            
            #line 21 "..\..\Areas\Search\Views\Results\Get.cshtml"
  
		const int maxSearchCount = 250;
        var showStaff = IoC.Resolve<ICurrentUserClaimInterrogator>().HasClaimForLocalEducationAgencyWithinEducationOrganizationHierarchy(EdFiClaimTypes.AdministerDashboard, (int)(EdFiDashboardContext.Current.SchoolId ?? EdFiDashboardContext.Current.LocalEducationAgencyId ?? UserInformation.Current.AssociatedStateAgencies.SingleOrDefault().EducationOrganizationId));


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 26 "..\..\Areas\Search\Views\Results\Get.cshtml"
  
    int? schoolId = EdFiDashboardContext.Current.SchoolId;
    int localEducationAgencyId = EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault();

    string searchString = HttpUtility.UrlDecode(Context.Request.QueryString["t"]);
    int theInt;
    bool isNumericInput = int.TryParse(searchString.Trim(), out theInt);


            
            #line default
            #line hidden
WriteLiteral(@"    <h1>Search Results</h1>
    <div class=""search-box"">
        <label for=""localSearchInput"">Your Search:</label>
        <input id=""localSearchInput"" type=""text"" />
        <input id=""localSearchFilter"" type=""hidden"" />
        <a class=""btn"" href=""#"" onclick=""searchAgainClick();"">Search again <i class=""icon-right""></i></a>
        <div id=""gettingSearchResultsIndicator""></div>
    </div>
    <div class=""filter-container"">
        <span>Display results by:</span>
        <a id=""filterAll"" class=""btn-deemphasized"" onclick=""SetSearchResultsFilter('All')"" href=""#"">SHOW ALL</a>
        <a id=""filterSchools"" class=""btn-deemphasized"" onclick=""SetSearchResultsFilter('Schools')"" href=""#"">SCHOOLS</a>
        <a id=""filterTeachers"" class=""btn-deemphasized"" onclick=""SetSearchResultsFilter('Teachers')"" href=""#"">TEACHERS</a>
        <a id=""filterStudents"" class=""btn-deemphasized"" onclick=""SetSearchResultsFilter('Students')"" href=""#"">STUDENTS</a>
");


            
            #line 48 "..\..\Areas\Search\Views\Results\Get.cshtml"
         if (showStaff)
        {

            
            #line default
            #line hidden
WriteLiteral("            <span id=\"filterStaff\" class=\"btn-deemphasized\" onclick=\"SetSearchRes" +
"ultsFilter(\'Staff\')\">STAFF</span>\r\n");


            
            #line 51 "..\..\Areas\Search\Views\Results\Get.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n    <div id=\"searchResultsDiv\" aria-live=\"assertive\">\r\n\r\n\t</div>\t\r\n\r\n" +
"<script type=\"text/javascript\">\r\n\tvar maxSearchCount = ");


            
            #line 58 "..\..\Areas\Search\Views\Results\Get.cshtml"
                  Write(maxSearchCount);

            
            #line default
            #line hidden
WriteLiteral(";\r\n\r\n\tvar searchResultsPage = \'");


            
            #line 60 "..\..\Areas\Search\Views\Results\Get.cshtml"
                      Write(Html.Raw((EdFiDashboards.Site.Search.Results(localEducationAgencyId) + "?t={textValue}&f={filterValue}").Resolve()));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\tvar getExpandedResultsUrl = \'");


            
            #line 61 "..\..\Areas\Search\Views\Results\Get.cshtml"
                          Write(EdFiDashboards.Site.Search.SearchWebService(localEducationAgencyId, schoolId).Resolve());

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\tvar setSessionObjectUrl = \'");


            
            #line 62 "..\..\Areas\Search\Views\Results\Get.cshtml"
                        Write(EdFiDashboards.Site.Common.EdFiGridWebService_SetSessionObject(EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault()).Resolve());

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\tvar loginButtonImage = \'");


            
            #line 63 "..\..\Areas\Search\Views\Results\Get.cshtml"
                     Write(EdFiDashboards.Site.Common.ThemeImage("LoginButton.png").Resolve());

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\tvar loginUrl = \'");


            
            #line 64 "..\..\Areas\Search\Views\Results\Get.cshtml"
             Write(EdFiDashboards.Site.Admin.LogInAs(EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault()).Resolve());

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\r\n\tvar getLoggerWebServiceUrlWithMethodForSortingAction = \'");


            
            #line 66 "..\..\Areas\Search\Views\Results\Get.cshtml"
                                                     Write(EdFiDashboards.Site.Search.LogUserSortingActionWebService(localEducationAgencyId, schoolId).Resolve());

            
            #line default
            #line hidden
WriteLiteral("\';\r\n\tvar getLoggerWebServiceUrlWithMethodForNavigationAction = \'");


            
            #line 67 "..\..\Areas\Search\Views\Results\Get.cshtml"
                                                        Write(EdFiDashboards.Site.Search.LogUserActionWebService(localEducationAgencyId, schoolId).Resolve());

            
            #line default
            #line hidden
WriteLiteral(@"';
	
	$(document).ready(function() {
	    $('#localSearchInput').val(decodeURIComponent(requestQuerystring('t')));
	    document.title = $('#localSearchInput').val() + "" - Search"";
	    
	    $('#localSearchFilter').val(decodeURIComponent(requestQuerystring('f')));
	    //Add key down event to search when enter.
	    $('#localSearchInput').keydown(function(e) {
		    switch (e.keyCode) {
			    case 13: // return
				    e.preventDefault();
				    searchAgainClick();
				    break;
			    default:
				    // do nothing
				    break;
		    }
	    });
        
		search();
	});
</script>
");


});

WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591