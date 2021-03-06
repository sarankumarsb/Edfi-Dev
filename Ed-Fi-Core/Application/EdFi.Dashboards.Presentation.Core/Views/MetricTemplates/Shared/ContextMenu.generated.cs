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

namespace EdFi.Dashboards.Presentation.Core.Views.MetricTemplates.Shared
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
    
    #line 1 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 5 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
    using EdFi.Dashboards.Presentation.Core.Utilities;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
    using EdFi.Dashboards.Resources.Navigation;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/Shared/ContextMenu.cshtml")]
    public partial class ContextMenu : System.Web.Mvc.WebViewPage<MetricBase>
    {

public System.Web.WebPages.HelperResult IconName(string action)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 9 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
 
    switch (action)
    {
        case "BarChart":

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            ");

WriteLiteralTo(@__razor_helper_writer, "icon-chart-bar\r\n");



#line 14 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
            break;
        case "Calendar":

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            ");

WriteLiteralTo(@__razor_helper_writer, "icon-calendar\r\n");



#line 17 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
            break;
        case "HistoricalChart":

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            ");

WriteLiteralTo(@__razor_helper_writer, "icon-chart-bar\r\n");



#line 20 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
            break;
        case "MultiTable":

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            ");

WriteLiteralTo(@__razor_helper_writer, "icon-list\r\n");



#line 23 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
            break;
        case "Table":

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "            ");

WriteLiteralTo(@__razor_helper_writer, "icon-menu\r\n");



#line 26 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
            break;
    }

#line default
#line hidden

});

}


public System.Web.WebPages.HelperResult Description(MetricBase model)
{
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 31 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
 
    string description = string.Empty;
    if(model.Parent != null && model.Parent.DisplayName != null)
    {
        description += (model.Parent.DisplayName + ", ");
    }
    
    description += model.DisplayName ?? string.Empty;
    

#line default
#line hidden



#line 40 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
WriteTo(@__razor_helper_writer, description);

#line default
#line hidden

WriteLiteralTo(@__razor_helper_writer, "\r\n");



#line 41 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"

#line default
#line hidden

});

}


        public ContextMenu()
        {
        }
        public override void Execute()
        {






WriteLiteral("           \r\n");



WriteLiteral("\r\n\r\n");



WriteLiteral("\r\n\r\n");


            
            #line 43 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
 if (Model.Actions.Any())
{
    var granular = Model as IGranularMetric;
    if (granular == null || granular.Value != null || Model.Actions.Count(x => x.ActionType == MetricActionType.AlwaysDisplayedDynamicContent) > 0)
    {
        string moreActionDivId = "moreActions-" + Model.MetricVariantId;
        string contextValues = "{metricVariantId:" + Model.MetricVariantId + ",subjectArea:" + Legacy.GetSubjectArea(Model.MetricId) + ",studentUSI:" + EdFiDashboardContext.Current.StudentUSI + ",schoolId:" + EdFiDashboardContext.Current.SchoolId + ",localEducationAgencyId:" + EdFiDashboardContext.Current.LocalEducationAgencyId + ",listContext:" + Request.QueryString["listContext"] + "}";


            
            #line default
            #line hidden
WriteLiteral("        <div class=\"contextMenu-group\">\r\n            <a href=\"#\" id=\"");


            
            #line 52 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                        Write("main" + moreActionDivId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"contextMenu-Button doNotPrint\">More <i class=\"icon-down-dir\"></i><span c" +
"lass=\"hidden\">actions for ");


            
            #line 52 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                                                                                                                                                             Write(Description(Model));

            
            #line default
            #line hidden
WriteLiteral("</span></a>\r\n\r\n            <ul class=\"contextMenu-DropDown doNotPrint\" id=\"");


            
            #line 54 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                                                        Write(moreActionDivId);

            
            #line default
            #line hidden
WriteLiteral("_List\" style=\"display: none;\">\r\n");


            
            #line 55 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                 foreach (var metricAction in Legacy.GetModelActions(Model))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <li>\r\n                        <a href=\"#\"\r\n                  " +
"          id=\"");


            
            #line 59 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                            Write(moreActionDivId + metricAction.GetTitleSafeForHtmlId());

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            data-tdid=\"");


            
            #line 60 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                                   Write(metricAction.GetTitleSafeForHtmlId() + metricAction.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\"\r\n                            onclick=\"");


            
            #line 61 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                                Write(Html.Raw(Legacy.GetMenuActionScript(Model, metricAction, moreActionDivId, contextValues)));

            
            #line default
            #line hidden
WriteLiteral(" return false;\"\r\n                            data-metricAction=\"");


            
            #line 62 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                                          Write(moreActionDivId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                            <i class=\"");


            
            #line 63 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                                 Write(IconName(metricAction.Icon));

            
            #line default
            #line hidden
WriteLiteral(" icon-large\"></i>\r\n                            ");


            
            #line 64 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                       Write(metricAction.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n");


            
            #line 67 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </ul>\r\n        </div>\r\n");


            
            #line 70 "..\..\Views\MetricTemplates\Shared\ContextMenu.cshtml"
    }
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
