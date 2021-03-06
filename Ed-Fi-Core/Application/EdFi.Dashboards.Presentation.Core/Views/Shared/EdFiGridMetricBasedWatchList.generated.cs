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

namespace ASP
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
    
    #line 2 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    
    #line 1 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line 3 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    using EdFi.Dashboards.Resources.Models.Common;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Resources.Navigation;
    
    #line 4 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    using EdFi.Dashboards.SecurityTokenService.Authentication;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EdFiGridMetricBasedWatchList.cshtml")]
    public partial class _Views_Shared_EdFiGridMetricBasedWatchList_cshtml : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Presentation.Core.Models.Shared.EdFiGridModel>
    {
        public _Views_Shared_EdFiGridMetricBasedWatchList_cshtml()
        {
        }
        public override void Execute()
        {





WriteLiteral("           \r\n");


            
            #line 7 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
  
    var localEducationAgencyId = EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault();
    var schoolId = EdFiDashboardContext.Current.SchoolId.GetValueOrDefault();
    var staffUSI = UserInformation.Current.StaffUSI;
    var pageStaffUSI = EdFiDashboardContext.Current.StaffUSI.GetValueOrDefault();
    var sectionId = EdFiDashboardContext.Current.SectionOrCohortId.GetValueOrDefault();
    var studentListType = EdFiDashboardContext.Current.StudentListType;
    var atLeaLevel = localEducationAgencyId > 0 && schoolId == 0;


            
            #line default
            #line hidden
WriteLiteral("\r\n<div id=\"");


            
            #line 17 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
     Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-watch-list\" class=\"EdfiGrid-watch-list\">\r\n    <div id=\"");


            
            #line 18 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
         Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-filtered-list-header\" class=\"EdfiGrid-filtered-list-header\">\r\n        <p" +
">\r\n            <label>Dynamic List Name:</label>\r\n            <span data-bind=\"t" +
"ext: WatchListName\"></span>\r\n        </p>\r\n        <div>\r\n");


            
            #line 24 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
             if (!atLeaLevel)
            {

            
            #line default
            #line hidden
WriteLiteral("                <input type=\"checkbox\" data-bind=\"checked: IsWatchListShared\" id=" +
"\"");


            
            #line 26 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                                              Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-watch-list-isShared\"/>\r\n");



WriteLiteral("                <label for=\"");


            
            #line 27 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-watch-list-isShared\">Share Dynamic List</label>\r\n");


            
            #line 28 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\r\n            <button>\r\n                <i class=\"icon-cancel\"></i>\r\n            " +
"</button>\r\n        </div>\r\n        <ul id=\"");


            
            #line 34 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
            Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-watch-list-nav\" class=\"EdfiGrid-watch-list-nav\" data-bind=\"template: { n" +
"ame: \'metricTabTemplate\', foreach: Tabs }\"></ul>\r\n    </div>\r\n    \r\n    <form id" +
"=\"");


            
            #line 37 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
          Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral(@"EdfiGrid-watch-list-form"">
        <div data-bind=""template: { name: 'metricTabPageTemplate', foreach: Tabs }""></div>
        <div class=""EdfiGrid-watch-list-edit"">
            <p>Selected Filters:&nbsp;</p><div data-bind=""text: SelectedValuesDisplay ""></div>
            <ul>
                <li><button id=""");


            
            #line 42 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                            Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-rename-watch-list\" class=\"btn\">Change Name</button></li>\r\n              " +
"  <li><button id=\"");


            
            #line 43 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                            Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-delete-watch-list\" class=\"btn\">Delete</button></li>\r\n                <li" +
"><button id=\"");


            
            #line 44 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                            Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-save-watch-list\" class=\"btn\">Save</button></li>\r\n            </ul>\r\n    " +
"    </div>\r\n    </form>\r\n</div>\r\n\r\n<div id=\"");


            
            #line 50 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
     Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-rename-popup\" title=\"Change Name\" style=\"display: none;\">\r\n    <table>\r\n" +
"        <tr>\r\n            <td style=\"vertical-align: top;\"><label>Enter List Nam" +
"e:</label></td>\r\n            <td><input type=\"text\" id=\"");


            
            #line 54 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                   Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-rename-popup-watch-list-name\"/></td>\r\n        </tr>\r\n        <tr>\r\n     " +
"       <td style=\"vertical-align: top;\"><label>Enter List Description:</label></" +
"td>\r\n            <td><textarea id=\"");


            
            #line 58 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                          Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-rename-popup-watch-list-description\" rows=\"5\" cols=\"50\"></textarea></td>" +
"\r\n        </tr>\r\n    </table>\r\n</div>\r\n\r\n<div id=\"");


            
            #line 63 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
     Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-save-confirmation-popup\" title=\"Save Changes?\" style=\"display: none;\">\r\n" +
"    <label>Do you wish to save your changes?</label>\r\n</div>\r\n\r\n<div id=\"");


            
            #line 67 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
     Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-delete-confirmation-popup\" title=\"Delete Dynamic List\" style=\"display: n" +
"one;\">\r\n    <label>Are you sure you want to delete this dynamic list?</label>\r\n<" +
"/div>\r\n\r\n<div id=\"");


            
            #line 71 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
     Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral(@"EdFiGrid-sharing-confirmation-popup"" title=""Sharing Confirmation"" style=""display: none;"">
    <label>You have selected your dynamic list '<label data-bind=""text: WatchListName""></label>' for sharing with your school. Please save this setting for the list to be shared.</label>
</div>

<script type=""text/javascript"">
    $(""#");


            
            #line 76 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral(@"EdfiGrid-watch-list-form"").submit(function(event) {
        event.preventDefault();
    });
</script>

<!-- This is the top level tab template -->
<script type=""text/html"" id=""metricTabTemplate"">
    <!-- ko if: IsActiveTab() -->
    <li class=""active-filter-tab""><a class=""active-filter-tab"" href=""#"" data-bind=""attr: { id: '");


            
            #line 84 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                                                            Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("-\' + Name + \'-tab\', \'data-tab-content\': \'");


            
            #line 84 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                                                                                                                      Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("-\' + Name }, text: DisplayText\"></a></li>\r\n    <!-- /ko -->\r\n    <!-- ko ifnot: I" +
"sActiveTab() -->\r\n    <li><a href=\"#\" data-bind=\"attr: { id: \'");


            
            #line 87 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("-\' + Name + \'-tab\', \'data-tab-content\': \'");


            
            #line 87 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                                                                  Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("-\' + Name }, text: DisplayText\"></a></li>\r\n    <!-- /ko -->\r\n</script>\r\n<!-- This" +
" is the tab page template -->\r\n<script type=\"text/html\" id=\"metricTabPageTemplat" +
"e\">\r\n    <!-- ko if: IsActiveTab() -->\r\n    <div data-bind=\"attr: { id: \'");


            
            #line 93 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                             Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("-\' + Name }, template: { name: \'metricColumnTemplate\', data: { Columns: Columns }" +
" }\" class=\"active-filter\"></div>\r\n    <!-- /ko -->\r\n    <!-- ko ifnot: IsActiveT" +
"ab() -->\r\n    <div data-bind=\"attr: { id: \'");


            
            #line 96 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                             Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("-\' + Name }, template: { name: \'metricColumnTemplate\', data: { Columns: Columns }" +
" }\"></div>\r\n    <!-- /ko -->\r\n</script>\r\n<!-- This is the Column template -->\r\n<" +
"script type=\"text/html\" id=\"metricColumnTemplate\">\r\n    <!-- ko if: Columns().le" +
"ngth == 4 -->\r\n    <!-- ko foreach: Columns -->\r\n    <div class=\"watch-list-colu" +
"mn thin\" data-bind=\"template: { name: \'metricGroupTemplate\', foreach: Templates " +
"}\"></div>\r\n    <!-- /ko -->\r\n    <!-- /ko -->\r\n    <!-- ko if: Columns().length " +
"== 3 -->\r\n    <!-- ko foreach: Columns -->\r\n    <div class=\"watch-list-column me" +
"dium\" data-bind=\"template: { name: \'metricGroupTemplate\', foreach: Templates }\">" +
"</div>\r\n    <!-- /ko -->\r\n    <!-- /ko -->\r\n    <!-- ko if: Columns().length == " +
"2 -->\r\n    <!-- ko foreach: Columns -->\r\n    <div class=\"watch-list-column wide\"" +
" data-bind=\"template: { name: \'metricGroupTemplate\', foreach: Templates }\"></div" +
">\r\n    <!-- /ko -->\r\n    <!-- /ko -->\r\n    <!-- ko if: Columns().length == 1 -->" +
"\r\n    <!-- ko foreach: Columns -->\r\n    <div class=\"watch-list-column full\" data" +
"-bind=\"template: { name: \'metricGroupTemplate\', foreach: Templates }\"></div>\r\n  " +
"  <!-- /ko -->\r\n    <!-- /ko -->\r\n</script>\r\n<!-- This is the Group template -->" +
"\r\n<script type=\"text/html\" id=\"metricGroupTemplate\">\r\n    <!-- ko ifnot: IsViewM" +
"odelArray -->\r\n    <div data-bind=\"template: { name: TemplateName, data: ViewMod" +
"el }\"></div>\r\n    <!-- /ko -->\r\n    <!-- ko if: IsViewModelArray -->\r\n    <h4 da" +
"ta-bind=\"text: GroupDisplayValue\"></h4>\r\n    <!-- ko foreach: ViewModel -->\r\n   " +
" <div data-bind=\"template: { name: TemplateName, data: ViewModel }\"></div>\r\n    " +
"<!-- /ko -->\r\n    <!-- /ko -->\r\n</script>\r\n<!-- This is the Checkbox template --" +
">\r\n<script type=\"text/html\" id=\"metricCheckboxTemplate\">\r\n    <div class=\"watch-" +
"list-category\">\r\n        <h4 data-bind=\"text: DisplayValue\"></h4>\r\n        \r\n   " +
"     <!-- ko foreach: Values -->\r\n        <div class=\"EdfiGrid-watch-list-checkb" +
"ox\">\r\n            <div data-bind=\"attr: { id: Name + \'-checkbox\' }\">\r\n          " +
"      <input type=\"checkbox\" data-bind=\"attr: { id: $parent.Name + \'-\' + Name, n" +
"ame: $parent.Name, value: Name }, checked: IsSelected\"/>\r\n            </div>\r\n  " +
"          <div data-bind=\"attr: { id: Name + \'-checkbox-label\' }\">\r\n            " +
"    <label data-bind=\"attr: { \'for\': $parent.Name + \'-\' + Name }, text: DisplayV" +
"alue\"></label>\r\n            </div>\r\n        </div>\r\n        <!-- /ko -->\r\n    </" +
"div>\r\n</script>\r\n<!-- This is the inline Checkbox template -->\r\n<script type=\"te" +
"xt/html\" id=\"metricCheckboxInlineTemplate\">\r\n    <div class=\"watch-list-category" +
"\">\r\n        <h4 data-bind=\"text: DisplayValue\"></h4>\r\n        \r\n        <!-- ko " +
"foreach: Values -->\r\n        <p class=\"EdfiGrid-watch-list-checkbox-inline\">\r\n  " +
"          <input type=\"checkbox\" data-bind=\"attr: { id: $parent.Name + \'-\' + Nam" +
"e, name: $parent.Name, value: Name }, checked: IsSelected\"/>\r\n            <label" +
" data-bind=\"attr: { \'for\': $parent.Name + \'-\' + Name }, text: DisplayValue\"></la" +
"bel>\r\n        </p>\r\n        <!-- /ko -->\r\n    </div>\r\n</script>\r\n<!-- This is th" +
"e Radio button template -->\r\n<script type=\"text/html\" id=\"metricRadioButtonTempl" +
"ate\">\r\n    <div class=\"watch-list-category\">\r\n        <h4 data-bind=\"text: Displ" +
"ayValue\"></h4>\r\n        \r\n        <!-- ko foreach: Values -->\r\n        <p>\r\n    " +
"        <input type=\"radio\" data-bind=\"attr: { id: $parent.Name + \'-\' + Name, na" +
"me: $parent.Name, value: Name }, checked: $parent.SelectedValue\"/>\r\n            " +
"<label data-bind=\"attr: { \'for\': $parent.Name + \'-\' + Name }, text: DisplayValue" +
"\"></label>\r\n        </p>\r\n        <!-- /ko -->\r\n    </div>\r\n</script>\r\n<!-- This" +
" is the Double Drop Down with a Textbox template -->\r\n<script type=\"text/html\" i" +
"d=\"metricDropDownTextboxTemplate\">\r\n    <div class=\"watch-list-category\">\r\n     " +
"   <div class=\"EdfiGrid-watch-list-dropdown\">\r\n            <div>\r\n              " +
"  <h4 data-bind=\"text: DisplayValue\"></h4>\r\n            </div>\r\n            <div" +
">\r\n                <select data-bind=\"attr: { id: Name, name: Name }, options: C" +
"omparisons, optionsValue: \'Name\', optionsText: \'DisplayValue\', optionsCaption: \'" +
"Unselected\', value: SelectedComparison\"></select>\r\n                <!-- ko if: S" +
"electedComparison() === undefined -->\r\n                <input type=\"text\" disabl" +
"ed=\"disabled\" data-bind=\"attr: { id: Name + \'-value\', name: Name + \'-value\', \'da" +
"ta-min-value\': TextboxMinValue, \'data-max-value\': TextboxMaxValue, \'data-format\'" +
": TextboxFormat }, value: TextboxValue, valueUpdate: \'afterkeydown\'\" />\r\n       " +
"         <!-- /ko -->\r\n                <!-- ko ifnot: SelectedComparison() === u" +
"ndefined -->\r\n                <input type=\"text\" data-bind=\"attr: { id: Name + \'" +
"-value\', name: Name + \'-value\', \'data-min-value\': TextboxMinValue, \'data-max-val" +
"ue\': TextboxMaxValue, \'data-format\': TextboxFormat }, value: TextboxValue, value" +
"Update: \'afterkeydown\'\" />\r\n                <!-- /ko -->\r\n            </div>\r\n  " +
"      </div>\r\n    </div>\r\n</script>\r\n<!-- This is the Double Drop Down template " +
"-->\r\n<script type=\"text/html\" id=\"metricDropDownTemplate\">\r\n    <div class=\"watc" +
"h-list-category\">\r\n        <div class=\"EdfiGrid-watch-list-dropdown\">\r\n         " +
"   <div>\r\n                <h4 data-bind=\"text: DisplayValue\"></h4>\r\n            " +
"</div>\r\n            <div>\r\n                <select data-bind=\"attr: { id: Name, " +
"name: Name }, options: Comparisons, optionsValue: \'Name\', optionsText: \'DisplayV" +
"alue\', optionsCaption: \'Unselected\', value: SelectedComparison\"></select>\r\n     " +
"           <!-- ko if: Values().length > 0 -->\r\n                <select data-bin" +
"d=\"attr: { id: Name + \'-values\', name: Name + \'-values\' }, options: Values, opti" +
"onsValue: \'Name\', optionsText: \'DisplayValue\', value: SelectedValue, optionsCapt" +
"ion: \'Unselected\'\"></select>\r\n                <!-- /ko -->\r\n            </div>\r\n" +
"        </div>\r\n    </div>\r\n</script>\r\n\r\n<!-- Contains the observable objects th" +
"at will be loaded with json data -->\r\n<script type=\"text/javascript\">\r\n    // th" +
"e top level model containing all data for the watch list\r\n    var WatchListModel" +
" = function (data) {\r\n        var self = this;\r\n        this.WatchListName = ko." +
"observable(data.WatchListName);\r\n        this.WatchListName.subscribe(function()" +
" {\r\n            ");


            
            #line 220 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.IsWatchListChanged = true;\r\n        });\r\n        this.Wa" +
"tchListDescription = ko.observable(data.WatchListDescription);\r\n        this.Wat" +
"chListDescription.subscribe(function() {\r\n            ");


            
            #line 224 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.IsWatchListChanged = true;\r\n        });\r\n        this.Is" +
"WatchListShared = ko.observable(data.IsWatchListShared);\r\n        this.IsWatchLi" +
"stShared.subscribe(function() {\r\n            ");


            
            #line 228 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.IsWatchListChanged = true;\r\n        });\r\n        this.Se" +
"lectedValuesDisplay = ko.observable();\r\n        this.SelectedValuesJson = \'\';\r\n " +
"       this.IsWatchListChanged = data.IsWatchListChanged;\r\n        this.Tabs = k" +
"o.utils.arrayMap(data.Tabs,\r\n            function (tab) {\r\n                retur" +
"n new WatchListTabModel(tab);\r\n            });\r\n    };\r\n\r\n    // contains the ta" +
"b related data\r\n    var WatchListTabModel = function (tab) {\r\n        this.Displ" +
"ayText = tab.DisplayText;\r\n        this.Name = tab.Name;\r\n        this.IsActiveT" +
"ab = ko.observable(tab.IsActiveTab);\r\n\r\n        this.Columns = ko.observableArra" +
"y(ko.utils.arrayMap(tab.Columns,\r\n            function (column) {\r\n             " +
"   return new WatchListColumnModel(column);\r\n            }));\r\n    };\r\n\r\n    // " +
"contains the data related to columns\r\n    var WatchListColumnModel = function(co" +
"lumn) {\r\n        this.Templates = ko.observableArray(ko.utils.arrayMap(column.Te" +
"mplates,\r\n            function (template) {\r\n                return new WatchLis" +
"tTemplateModel(template);\r\n            }));\r\n    };\r\n\r\n    // loads all template" +
"s even nested templates\r\n    var WatchListTemplateModel = function (template) {\r" +
"\n        this.TemplateName =  template.TemplateName;\r\n        this.GroupDisplayV" +
"alue = template.GroupDisplayValue;\r\n        this.ViewModel = null;\r\n        this" +
".IsViewModelArray = $.isArray(template.ViewModel);\r\n\r\n        if (this.IsViewMod" +
"elArray) {\r\n            // if the ViewModel property is an array then recursivel" +
"y load the\r\n            // ViewModel object\r\n            this.ViewModel = ko.uti" +
"ls.arrayMap(template.ViewModel,\r\n                function(templateModel) {\r\n    " +
"                return new WatchListTemplateModel(templateModel);\r\n             " +
"   });\r\n        } else if (template.ViewModel.TemplateName != undefined) {\r\n    " +
"        // if the ViewModel property contains another ViewModel object then\r\n   " +
"         // load the ViewModel object recursively\r\n            this.ViewModel = " +
"new WatchListTemplateModel(template.ViewModel);\r\n        } else {\r\n            s" +
"witch(template.TemplateName) {\r\n                case \'metricRadioButtonTemplate\'" +
":\r\n                case \'metricCheckboxTemplate\':\r\n                case \'metricC" +
"heckboxInlineTemplate\':\r\n                    this.ViewModel = new WatchListSingl" +
"eSelectionModel(template.ViewModel);\r\n                    break;\r\n              " +
"  case \'metricDropDownTemplate\':\r\n                    this.ViewModel = new Watch" +
"ListDoubleSelectionModel(template.ViewModel);\r\n                    break;\r\n     " +
"           case \'metricDropDownTextboxTemplate\':\r\n                    this.ViewM" +
"odel = new WatchListDoubleSelectionTextboxModel(template.ViewModel);\r\n          " +
"          break;\r\n            }\r\n        }\r\n    };\r\n\r\n    // contains the data f" +
"or the single selection controls (radio or checkbox)\r\n    var WatchListSingleSel" +
"ectionModel = function (viewModel) {\r\n        this.Name = viewModel.Name;\r\n     " +
"   this.DisplayValue = viewModel.DisplayValue;\r\n        this.SelectionValue = vi" +
"ewModel.SelectionValue;\r\n        this.SelectedValue = ko.observable();\r\n        " +
"this.SelectedValue.subscribe(function() {\r\n            modelChanged();\r\n        " +
"});\r\n        this.IsShownInFilterList = viewModel.IsShownInFilterList;\r\n\r\n      " +
"  this.Values = ko.observableArray(ko.utils.arrayMap(viewModel.Values,\r\n        " +
"    function (value) {\r\n                return new WatchListSelectionItemModel(v" +
"alue);\r\n            }));\r\n    };\r\n\r\n    // contains the data for a single or dou" +
"ble drop-down control\r\n    var WatchListDoubleSelectionModel = function (viewMod" +
"el) {\r\n        var self = this;\r\n        this.Name = viewModel.Name;\r\n        th" +
"is.DisplayValue = viewModel.DisplayValue;\r\n        this.SelectionValue = viewMod" +
"el.SelectionValue;\r\n        this.Comparisons = ko.observableArray(ko.utils.array" +
"Map(viewModel.Comparisons,\r\n            function(comparison) {\r\n                " +
"return new WatchListSelectionItemModel(comparison);\r\n            }));\r\n        t" +
"his.SelectedDisplayText = \"\";\r\n        this.SelectedComparison = ko.observable()" +
";\r\n        this.SelectedComparison.subscribe(function() {\r\n            self.Sele" +
"ctedDisplayText = $(\'#\' + self.Name + \' option[value=\"\' + self.SelectedCompariso" +
"n() + \'\"]\').text();\r\n            modelChanged();\r\n        });\r\n        this.Valu" +
"es = ko.observableArray(ko.utils.arrayMap(viewModel.Values,\r\n            functio" +
"n(value) {\r\n                return new WatchListSelectionItemModel(value);\r\n    " +
"        }));\r\n        this.SelectedValue = ko.observable();\r\n        this.Select" +
"edValue.subscribe(function() {\r\n            modelChanged();\r\n        });\r\n      " +
"  this.IsShownInFilterList = viewModel.IsShownInFilterList;\r\n    };\r\n\r\n    // co" +
"ntains the data for the drop-down/textbox control\r\n    var WatchListDoubleSelect" +
"ionTextboxModel = function(viewModel) {\r\n        var self = this;\r\n        this." +
"Name = viewModel.Name;\r\n        this.DisplayValue = viewModel.DisplayValue;\r\n   " +
"     this.SelectionValue = viewModel.SelectionValue;\r\n        this.TextboxFormat" +
" = viewModel.TextboxFormat;\r\n        this.TextboxMinValue = viewModel.TextboxMin" +
"Value;\r\n        this.TextboxMaxValue = viewModel.TextboxMaxValue;\r\n        this." +
"TextboxValue = ko.observable();\r\n        this.TextboxValue.subscribe(function() " +
"{\r\n            modelChanged();\r\n        });\r\n        this.Comparisons = ko.obser" +
"vableArray(ko.utils.arrayMap(viewModel.Comparisons,\r\n            function(compar" +
"ison) {\r\n                return new WatchListSelectionItemModel(comparison);\r\n  " +
"          }));\r\n        this.SelectedDisplayText = \"\";\r\n        this.SelectedCom" +
"parison = ko.observable();\r\n        this.SelectedComparison.subscribe(function()" +
" {\r\n            self.SelectedDisplayText = $(\'#\' + self.Name + \' option[value=\"\'" +
" + self.SelectedComparison() + \'\"]\').text();\r\n            modelChanged();\r\n     " +
"   });\r\n        this.IsShownInFilterList = viewModel.IsShownInFilterList;\r\n    }" +
";\r\n\r\n    // this object will be contained in the Comparisons and Values properti" +
"es\r\n    var WatchListSelectionItemModel = function(value) {\r\n        this.Name =" +
" value.Name;\r\n        this.DisplayValue = value.DisplayValue;\r\n        this.IsSe" +
"lected = ko.observable(value.IsSelected);\r\n        this.IsSelected.subscribe(fun" +
"ction() {\r\n            modelChanged();\r\n        });\r\n        this.IsShownInFilte" +
"rList = value.IsShownInFilterList;\r\n    };\r\n\r\n    function modelChanged() {\r\n   " +
"     if (!");


            
            #line 376 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
         Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.IsLoading && !");


            
            #line 376 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                  Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.IsCancelling) {\r\n            ");


            
            #line 377 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.SelectedValuesJson = ");


            
            #line 377 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                                       Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.SelectionBuilder.GetSelectedValuesJson();\r\n            ");


            
            #line 378 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.DisplayBuilder.BuildDisplayList();\r\n            ");


            
            #line 379 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.IsWatchListChanged = true;\r\n\r\n            ");


            
            #line 381 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.setStudentWatchListData(JSON.parse(");


            
            #line 381 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                                     Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.SelectedValuesJson));\r\n        } else if (");


            
            #line 382 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
               Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.IsCancelling && ");


            
            #line 382 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                                         Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.IsWatchListChanged) {\r\n            ");


            
            #line 383 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.setStudentWatchListData(");


            
            #line 383 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                                          Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.WatchListModel.OriginalSelection);\r\n            ");


            
            #line 384 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
        Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral(@"WatchList.WatchListModel.IsWatchListChanged = false;
        }
    }
</script>

<!-- Model Data & Binding -->
<script type=""text/javascript"">
    // we need to set a boolean flag to determine if the grid should be redrawn
    // also look into if we can persist the student USI's back into the grid
    var ");


            
            #line 393 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchListData = ");


            
            #line 393 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                    Write(Model.StudentWatchList.ToJson());

            
            #line default
            #line hidden
WriteLiteral(";\r\n\r\n    var ");


            
            #line 395 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList = new MetricsBasedWatchList(\r\n        \'");


            
            #line 396 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral(@"',
        {
            SavePopup: { PopupName: 'EdfiGrid-save-confirmation-popup' },
            RenamePopup:
            {
                PopupName: 'EdfiGrid-rename-popup',
                TextboxName: 'EdfiGrid-rename-popup-watch-list-name',
                DescriptionNameTextArea: 'EdfiGrid-rename-popup-watch-list-description'
            },
            DeletePopup: { PopupName: 'EdfiGrid-delete-confirmation-popup' },
            SharingPopup: { PopupName: 'EdFiGrid-sharing-confirmation-popup' }
        },
        '");


            
            #line 408 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
     Write(Model.StudentWatchList.WatchListUrl);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n        \'");


            
            #line 409 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
     Write(Model.StudentWatchList.WatchListSearchUrl);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n        {\r\n            LocalEducationAgencyId: ");


            
            #line 411 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                Write(localEducationAgencyId);

            
            #line default
            #line hidden
WriteLiteral(",\r\n            SchoolId: ");


            
            #line 412 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                  Write(schoolId);

            
            #line default
            #line hidden
WriteLiteral(",\r\n            StaffUSI: \"");


            
            #line 413 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                   Write(staffUSI);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n            PageStaffUSI: \"");


            
            #line 414 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                       Write(pageStaffUSI);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n            MetricBasedWatchListId: ");


            
            #line 415 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                Write(studentListType == StudentListType.MetricsBasedWatchList.ToString() ? sectionId : 0);

            
            #line default
            #line hidden
WriteLiteral(",\r\n            StudentListType: \"");


            
            #line 416 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                          Write(studentListType);

            
            #line default
            #line hidden
WriteLiteral("\",\r\n            SavingControllerName: \"");


            
            #line 417 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                               Write(Model.PreviousNextSessionPage);

            
            #line default
            #line hidden
WriteLiteral(@"""
        },
        {
            SaveButton: 'EdfiGrid-save-watch-list',
            DeleteButton: 'EdfiGrid-delete-watch-list',
            RenameButton: 'EdfiGrid-rename-watch-list'
        },
        'EdfiGrid-watch-list-isShared',
        {
            Demographic: '");


            
            #line 426 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                      Write(Model.SelectedDemographicOption);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            SchoolCategory: \'");


            
            #line 427 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                         Write(Model.SelectedSchoolCategoryOption);

            
            #line default
            #line hidden
WriteLiteral("\',\r\n            Grade: \'");


            
            #line 428 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                Write(Model.SelectedGradeOption);

            
            #line default
            #line hidden
WriteLiteral("\'\r\n        }\r\n    );\r\n\r\n    ");


            
            #line 432 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.loadWatchList(");


            
            #line 432 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
                                         Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchListData);\r\n    ");


            
            #line 433 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("WatchList.initializeEvents();\r\n\r\n    $(\'#");


            
            #line 435 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-watch-list\').on(\"closing\", function(e, table) {\r\n        ");


            
            #line 436 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.hideStudentWatchListMenu();\r\n        ");


            
            #line 437 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.hideInteractionMenu(null);\r\n    });\r\n    $(\'#");


            
            #line 439 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdfiGrid-watch-list\').on(\"opening\", function(e, table) {\r\n        ");


            
            #line 440 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.showStudentWatchListMenu();\r\n        ");


            
            #line 441 "..\..\Views\Shared\EdFiGridMetricBasedWatchList.cshtml"
    Write(Model.GridName);

            
            #line default
            #line hidden
WriteLiteral("EdFiGrid.hideInteractionMenu(null);\r\n    });\r\n</script>");


        }
    }
}
#pragma warning restore 1591
