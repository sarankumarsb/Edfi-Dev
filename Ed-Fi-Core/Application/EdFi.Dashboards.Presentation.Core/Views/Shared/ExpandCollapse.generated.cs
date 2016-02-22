﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
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
    
    #line 1 "..\..\Views\Shared\ExpandCollapse.cshtml"
    using EdFi.Dashboards.Presentation.Core.Models.Shared;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line 2 "..\..\Views\Shared\ExpandCollapse.cshtml"
    using EdFi.Dashboards.Resources.Navigation;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/ExpandCollapse.cshtml")]
    public partial class ExpandCollapse : System.Web.Mvc.WebViewPage<ExpandCollapseModel>
    {
        public ExpandCollapse()
        {
        }
        public override void Execute()
        {



WriteLiteral("\r\n<a class=\"accordion-toggle\" data-target=\"#");


            
            #line 5 "..\..\Views\Shared\ExpandCollapse.cshtml"
                                     Write(Model.DivId);

            
            #line default
            #line hidden
WriteLiteral("\" href=\"#\" id=\"");


            
            #line 5 "..\..\Views\Shared\ExpandCollapse.cshtml"
                                                                 Write(Model.DivId);

            
            #line default
            #line hidden
WriteLiteral("Toggle\">\r\n    <i class=\"icon icon-expand\" style=\"display:none;\"><span>See</span><" +
"/i>\r\n    <i class=\"icon icon-collapse\"><span>Hide</span></i>\r\n    ");


            
            #line 8 "..\..\Views\Shared\ExpandCollapse.cshtml"
Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n</a>\r\n\r\n");


            
WriteLiteral("\r\n");


            
            #line 21 "..\..\Views\Shared\ExpandCollapse.cshtml"
 if (Model.CollapseExpandInitialState == ExpandCollapseModel.InitialState.Collapsed)
{

            
            #line default
            #line hidden
WriteLiteral("\t<script>\r\n\t\t$(function () { CollapseToggleDiv(\'#");


            
            #line 24 "..\..\Views\Shared\ExpandCollapse.cshtml"
                                  Write(Model.DivId);

            
            #line default
            #line hidden
WriteLiteral("Toggle\', \'#");


            
            #line 24 "..\..\Views\Shared\ExpandCollapse.cshtml"
                                                           Write(Model.DivId);

            
            #line default
            #line hidden
WriteLiteral("\'); });\r\n\t</script>\r\n");


            
            #line 26 "..\..\Views\Shared\ExpandCollapse.cshtml"
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
