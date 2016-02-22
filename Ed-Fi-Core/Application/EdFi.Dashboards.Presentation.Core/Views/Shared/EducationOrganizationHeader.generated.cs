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
    
    #line 2 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 1 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
    using EdFi.Dashboards.Presentation.Core.Controllers;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line 3 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
    using EdFi.Dashboards.Resources.Navigation;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/EducationOrganizationHeader.cshtml")]
    public partial class EducationOrganizationHeader : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Presentation.Core.Models.Shared.EducationOrganizationHeaderModel>
    {
        public EducationOrganizationHeader()
        {
        }
        public override void Execute()
        {




WriteLiteral("<header class=\"l-selected-entity-header\">\r\n");


            
            #line 6 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
      Html.RenderAction("PreviousNext", typeof(PreviousNextController).GetControllerName());

            
            #line default
            #line hidden
WriteLiteral("    <img src=\"");


            
            #line 7 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
         Write(Model.ProfileThumbnail);

            
            #line default
            #line hidden
WriteLiteral("\" alt=\" \" />\r\n");


            
            #line 8 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
     if (!Model.AssociatedEducationOrganizations.Any())
    {

            
            #line default
            #line hidden
WriteLiteral("        <h1>");


            
            #line 10 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
       Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("</h1>\r\n");


            
            #line 11 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <h1>");


            
            #line 14 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
       Write(Model.Name);

            
            #line default
            #line hidden
WriteLiteral("\r\n            <i id=\"educationOrganizationSelector_img\" class=\"icon-down-open\"></" +
"i>\r\n        </h1>\r\n");



WriteLiteral("        <ul id=\"educationOrganizationSelector_ul\">\r\n");


            
            #line 18 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
             foreach (var associatedEducationOrganziation in Model.AssociatedEducationOrganizations)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li><a href=\"");


            
            #line 20 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
                        Write(associatedEducationOrganziation.Href);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 20 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
                                                               Write(associatedEducationOrganziation.Name);

            
            #line default
            #line hidden
WriteLiteral("</a></li>\r\n");


            
            #line 21 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");


            
            #line 23 "..\..\Views\Shared\EducationOrganizationHeader.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral(@"</header>
<script type=""text/javascript"">
    $(document).ready(function () {
        $('#educationOrganizationSelector_img').tooltip({
            tip: '#educationOrganizationSelector_ul',
            effect: 'fade',
            position: 'bottom right',
            bounce: true,
            delay: 500
        });
    
        $('#educationOrganizationSelector_img').click(function (e) {
            var tooltip = $('#educationOrganizationSelector_img').data('tooltip');
            if (tooltip.isShown(false)) {
                tooltip.hide();
            } else {
                tooltip.show();
            }
        });
    });
</script>
");


        }
    }
}
#pragma warning restore 1591