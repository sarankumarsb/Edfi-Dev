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

namespace EdFi.Dashboards.Presentation.Core.Views.Shared
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
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    #line 1 "..\..\Views\Shared\CustomStudentList.cshtml"
    using EdFi.Dashboards.Resources.Navigation.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/CustomStudentList.cshtml")]
    public class CustomStudentList : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Presentation.Core.Models.Shared.CustomStudentListModel>
    {
        public CustomStudentList()
        {
        }
        public override void Execute()
        {


WriteLiteral("\r\n");


            
            #line 4 "..\..\Views\Shared\CustomStudentList.cshtml"
  
    ViewBag.Title = "Student Selector";
    Layout = null;
    var sessionStudentListUrl = EdFiDashboards.Site.LocalEducationAgency.Resource(Model.LocalEducationAgencyId, "SessionStudentList");


            
            #line default
            #line hidden
WriteLiteral("\r\n<div style=\"display:none;\">\r\n    <!-- Student Name and Image Template for the c" +
"ustom student list dialog -->\r\n    <script id=\"");


            
            #line 12 "..\..\Views\Shared\CustomStudentList.cshtml"
            Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral(@"-CustomStudentList-NameAndImageCellItemTemplate"" type=""x-jquery-tmpl"">
        <tr>
            <td style=""border-right:0px;"">
            {{if I}}
                <img src=""${I}"" style=""border:1px solid gray;height:37px;width:28px;"" />
            {{/if}}
            </td>
            <td>
               ${DV}
            </td>
        </tr>
    </script>

    <div id=""");


            
            #line 25 "..\..\Views\Shared\CustomStudentList.cshtml"
         Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-CreateDialog\" class=\"CustomStudentList-CreateDialog\" title=\"Ad" +
"d students to list\" style=\"display: none;\">\r\n        <div>\r\n            <input i" +
"d=\"");


            
            #line 27 "..\..\Views\Shared\CustomStudentList.cshtml"
                   Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Create-UseNewListRadio\" type=\"radio\" title=\"Use new list\" name" +
"=\"ListUseTypes\" value=\"new\" checked=\"checked\"/>\r\n                <label for=\"");


            
            #line 28 "..\..\Views\Shared\CustomStudentList.cshtml"
                        Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Create-NewListName\">Create a new list named:</label><br />\r\n  " +
"          <input id=\"");


            
            #line 29 "..\..\Views\Shared\CustomStudentList.cshtml"
                   Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Create-NewListName\" type=\"text\" class=\"NestedControl\" /><br />" +
"<br />\r\n            <input id=\"");


            
            #line 30 "..\..\Views\Shared\CustomStudentList.cshtml"
                   Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Create-UseOldListRadio\" title=\"Use existing list\" type=\"radio\"" +
" name=\"ListUseTypes\" value=\"old\" />\r\n            <label for=\"");


            
            #line 31 "..\..\Views\Shared\CustomStudentList.cshtml"
                    Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Create-ListSelectionListbox\">Add selected students to an exist" +
"ing list:</label><br />\r\n            <select id=\"");


            
            #line 32 "..\..\Views\Shared\CustomStudentList.cshtml"
                    Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Create-ListSelectionListbox\" size=\"9\" class=\"NestedControl\" di" +
"sabled=\"disabled\">\r\n            </select>\r\n            <div id=\"");


            
            #line 34 "..\..\Views\Shared\CustomStudentList.cshtml"
                 Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Create-Wait\" style=\"display:none;\">\r\n                <img src=" +
"\"");


            
            #line 35 "..\..\Views\Shared\CustomStudentList.cshtml"
                     Write(EdFiDashboards.Site.Common.ThemeImage("loadingSmall.gif").Resolve());

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Submitting...\" /> Submitting request...\r\n            </div>\r\n        </div" +
">\r\n        <div class=\"CustomStudentList-CreateDialog-StudentList\">\r\n           " +
" <table id=\"");


            
            #line 39 "..\..\Views\Shared\CustomStudentList.cshtml"
                   Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Create-StudentListTable\">\r\n                <tbody></tbody>\r\n  " +
"          </table>\r\n        </div>\r\n    </div>\r\n\r\n    <div id=\"");


            
            #line 45 "..\..\Views\Shared\CustomStudentList.cshtml"
         Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral(@"-CustomStudentList-RemoveDialog"" class=""CustomStudentList-RemoveDialog"" title=""Remove students from list"" style=""display: none;"">
        <div class=""CustomStudentList-RemoveDialog-Label"">The following students will be removed from the list:</div>
        <div id=""");


            
            #line 47 "..\..\Views\Shared\CustomStudentList.cshtml"
             Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-RemoveDialog-Wait\" style=\"display:none;\">\r\n            <img sr" +
"c=\"");


            
            #line 48 "..\..\Views\Shared\CustomStudentList.cshtml"
                 Write(EdFiDashboards.Site.Common.ThemeImage("loadingSmall.gif").Resolve());

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Submitting...\" /> Submitting request...\r\n        </div>\r\n        <div clas" +
"s=\"CustomStudentList-RemoveDialog-StudentList\">\r\n            <table id=\"");


            
            #line 51 "..\..\Views\Shared\CustomStudentList.cshtml"
                   Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Remove-StudentListTable\">\r\n                <tbody></tbody>\r\n  " +
"          </table>\r\n        </div>\r\n    </div>\r\n\r\n    <div id=\"");


            
            #line 57 "..\..\Views\Shared\CustomStudentList.cshtml"
         Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-RenameDialog\" style=\"display: none;\">\r\n        <label for=\"");


            
            #line 58 "..\..\Views\Shared\CustomStudentList.cshtml"
                Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Rename-Input\">New list name:</label>\r\n        <input id=\"");


            
            #line 59 "..\..\Views\Shared\CustomStudentList.cshtml"
               Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Rename-Input\" class=\"CustomStudentList-Rename-Input\" type=\"tex" +
"t\"/>\r\n        <div id=\"");


            
            #line 60 "..\..\Views\Shared\CustomStudentList.cshtml"
             Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-Rename-Wait\" style=\"display:none;\">\r\n            <img src=\"");


            
            #line 61 "..\..\Views\Shared\CustomStudentList.cshtml"
                 Write(EdFiDashboards.Site.Common.ThemeImage("loadingSmall.gif").Resolve());

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Submitting...\" /> Submitting request...\r\n        </div>\r\n    </div>\r\n\r\n   " +
" <div id=\"");


            
            #line 65 "..\..\Views\Shared\CustomStudentList.cshtml"
         Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-DeleteDialog\" style=\"display: none;\">\r\n        Are you sure yo" +
"u want to delete this list?\r\n        <div id=\"");


            
            #line 67 "..\..\Views\Shared\CustomStudentList.cshtml"
             Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("-CustomStudentList-DeleteDialog-Wait\" style=\"display:none;\">\r\n            <img sr" +
"c=\"");


            
            #line 68 "..\..\Views\Shared\CustomStudentList.cshtml"
                 Write(EdFiDashboards.Site.Common.ThemeImage("loadingSmall.gif").Resolve());

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Submitting...\" /> Submitting request...\r\n        </div>\r\n    </div>\r\n\r\n   " +
" <script>\r\n        var ");


            
            #line 73 "..\..\Views\Shared\CustomStudentList.cshtml"
        Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("CustomStudentList = new customStudentList(\'");


            
            #line 73 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("\', \r\n                                                                        ");


            
            #line 74 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                   Write(Model.IsCustomStudentList.ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral(", \r\n                                                                        \'");


            
            #line 75 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(Model.LinkParentIdentifier);

            
            #line default
            #line hidden
WriteLiteral("\', \r\n                                                                        \'");


            
            #line 76 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(Model.CheckboxParentIentifier);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                                                        \'");


            
            #line 77 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(Model.SelectAllCheckboxParentIentifier);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                                                        ");


            
            #line 78 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(Model.CustomStudentListId != null ? Model.CustomStudentListId.ToString() : "null");

            
            #line default
            #line hidden
WriteLiteral(", \r\n                                                                        ");


            
            #line 79 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                   Write(Model.LocalEducationAgencyId);

            
            #line default
            #line hidden
WriteLiteral(", \r\n                                                                        ");


            
            #line 80 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(Model.SchoolId != null ? Model.SchoolId.ToString() : "null");

            
            #line default
            #line hidden
WriteLiteral(", \r\n                                                                        ");


            
            #line 81 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                   Write(Model.StaffUSI);

            
            #line default
            #line hidden
WriteLiteral(", \r\n                                                                        \'");


            
            #line 82 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(Model.CustomStudentListUrl);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                                                        \'");


            
            #line 83 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(sessionStudentListUrl);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n                                                                        ");


            
            #line 84 "..\..\Views\Shared\CustomStudentList.cshtml"
                                                                    Write(Model.UniqueId != null ? Model.UniqueId.ToString() : "null");

            
            #line default
            #line hidden
WriteLiteral(");\r\n        ");


            
            #line 85 "..\..\Views\Shared\CustomStudentList.cshtml"
    Write(Model.ControlId);

            
            #line default
            #line hidden
WriteLiteral("CustomStudentList.initialize();\r\n    </script>\r\n</div>");


        }
    }
}
#pragma warning restore 1591
