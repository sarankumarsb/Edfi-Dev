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

namespace EdFi.Dashboards.Presentation.Core.Areas.Admin.Views.Shared
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
    
    #line 1 "..\..\Areas\Admin\Views\Shared\_AreaLayout.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line 2 "..\..\Areas\Admin\Views\Shared\_AreaLayout.cshtml"
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/_AreaLayout.cshtml")]
    public class AreaLayout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public AreaLayout()
        {
        }
        public override void Execute()
        {



            
            #line 3 "..\..\Areas\Admin\Views\Shared\_AreaLayout.cshtml"
  
    ViewBag.Title = "Admin";
    Layout = this.GetLayout("_SiteLayout");


            
            #line default
            #line hidden
WriteLiteral("\r\n");


DefineSection("head", () => {

WriteLiteral("\r\n\t");


            
            #line 9 "..\..\Areas\Admin\Views\Shared\_AreaLayout.cshtml"
Write(RenderSection("ContentPlaceHolderHead", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");


});

WriteLiteral("\r\n\r\n");


DefineSection("ContentDataHeader", () => {

WriteLiteral("\r\n");


            
            #line 13 "..\..\Areas\Admin\Views\Shared\_AreaLayout.cshtml"
      Html.RenderAction("EducationOrganizationHeader", "AdminLayout");

            
            #line default
            #line hidden

});

WriteLiteral("\r\n\r\n");


DefineSection("ContentMenu", () => {

WriteLiteral("\r\n");


            
            #line 17 "..\..\Areas\Admin\Views\Shared\_AreaLayout.cshtml"
      Html.RenderAction("Menu", "AdminLayout");

            
            #line default
            #line hidden

});

WriteLiteral("\r\n\r\n");


DefineSection("ContentPlaceHolderTopMost", () => {

WriteLiteral("\r\n    <div class=\"l-area-layout\"> \r\n        ");


            
            #line 22 "..\..\Areas\Admin\Views\Shared\_AreaLayout.cshtml"
   Write(RenderSection("ContentPlaceHolder1", required: false));

            
            #line default
            #line hidden
WriteLiteral(@"
    </div>        

    <!-- PageContext hidden field -->
	<input type=""hidden"" name=""PageContext"" value=""Admin"" />

	<!-- The ToolTip -->
	<div id=""JQToolTip""></div>

	<script type=""text/javascript"">
		$(document).ready(function () {
			$("".JQToolTipTarget"").tooltip({
				tip: '#JQToolTip',
				effect: 'slide',
				position: 'bottom center',
				bounce: true,
				offset: [5, 0]

			});
		});
	</script>
");


});

WriteLiteral("\r\n");


        }
    }
}
#pragma warning restore 1591
