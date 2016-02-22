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

namespace EdFi.Dashboards.Presentation.Web.Views.Shared
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
    
    #line 1 "..\..\Views\Shared\_SiteLayout.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Views\Shared\_SiteLayout.cshtml"
    using Cassette.Views;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Views\Shared\_SiteLayout.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Views\Shared\_SiteLayout.cshtml"
    using EdFi.Dashboards.Common.Configuration;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 5 "..\..\Views\Shared\_SiteLayout.cshtml"
    using EdFi.Dashboards.Presentation.Core.Controllers;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Views\Shared\_SiteLayout.cshtml"
    using EdFi.Dashboards.Presentation.Web.Architecture.HtmlHelperExtensions;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    #line 7 "..\..\Views\Shared\_SiteLayout.cshtml"
    using EdFi.Dashboards.Resources.Navigation.Mvc;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Views\Shared\_SiteLayout.cshtml"
    using EdFi.Dashboards.SecurityTokenService.Authentication;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Shared/_SiteLayout.cshtml")]
    public partial class SiteLayout : System.Web.Mvc.WebViewPage<dynamic>
    {
        public SiteLayout()
        {
        }
        public override void Execute()
        {









            
            #line 9 "..\..\Views\Shared\_SiteLayout.cshtml"
  
    Bundles.Reference("Core_Content/Scripts/External");
    Bundles.Reference("Core_Content/Scripts/Application");
    Bundles.Reference("Core_Content/HtmlTemplates/EdFiGrid");
    Bundles.Reference("Core_Content/HtmlTemplates/MetricsBasedWatchList");

    Bundles.Reference("Core_Content/StyleSheets");
    Bundles.Reference("Content/StyleSheets");
    Bundles.Reference("Content/Scripts");
    Bundles.Reference("jquery-ui");


            
            #line default
            #line hidden
WriteLiteral(@"<!doctype html>

<html lang=""en"">
    
<head>
	<meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta charset=""utf-8"">
    <meta http-equiv=""CACHE-CONTROL"" content=""NO-CACHE"">
    <meta http-equiv=""PRAGMA"" content=""NO-CACHE"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta http-equiv=""Refresh"" content=""10800"">");



WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 31 "..\..\Views\Shared\_SiteLayout.cshtml"
                            Write(Url.Content("~/Core_Content/StyleSheets/fontello.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <!--[if IE 7]>\r\n        <link rel=\"stylesheet\" href=\"");


            
            #line 33 "..\..\Views\Shared\_SiteLayout.cshtml"
                                Write(Url.Content("~/Core_Content/StyleSheets/fontello-ie7.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <![endif]--> \r\n    ");


            
            #line 35 "..\..\Views\Shared\_SiteLayout.cshtml"
Write(Bundles.RenderStylesheets());

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");


            
            #line 36 "..\..\Views\Shared\_SiteLayout.cshtml"
Write(Bundles.RenderScripts());

            
            #line default
            #line hidden
WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 37 "..\..\Views\Shared\_SiteLayout.cshtml"
                            Write(Url.Content("~/Core_Content/StyleSheets/bootstrap.min.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 38 "..\..\Views\Shared\_SiteLayout.cshtml"
                            Write(Url.Content("~/Core_Content/StyleSheets/jquery.fileupload-ui.css"));

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <script type=\"text/javascript\">\r\n        //This is a global variable for " +
"the path of the application.\r\n        //We have scenarios inside of .js files wh" +
"ere we need to reference paths....\r\n");


            
            #line 42 "..\..\Views\Shared\_SiteLayout.cshtml"
          Html.RenderAction("JQueryGlobalSiteBasePath", typeof(MasterPageController).GetControllerName()); 

            
            #line default
            #line hidden
WriteLiteral("    </script>\r\n    ");


            
            #line 44 "..\..\Views\Shared\_SiteLayout.cshtml"
Write(Bundles.RenderHtmlTemplates());

            
            #line default
            #line hidden
WriteLiteral("\r\n    ");



WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"");


            
            #line 46 "..\..\Views\Shared\_SiteLayout.cshtml"
                            Write(Url.Content("~/Core_Content/StyleSheets/HideDBId.css"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\'text/css\' media=\'screen\' title=\'Hide Ids\'>\r\n    <link rel=\"alternate styl" +
"esheet\" href=\"");


            
            #line 47 "..\..\Views\Shared\_SiteLayout.cshtml"
                                      Write(Url.Content("~/Core_Content/StyleSheets/ShowDBId.css"));

            
            #line default
            #line hidden
WriteLiteral("\" type=\'text/css\' media=\'screen\' title=\'Show Ids\' disabled=\'disabled\'>\r\n    <link" +
" rel=\"shortcut icon\" href=\"");


            
            #line 48 "..\..\Views\Shared\_SiteLayout.cshtml"
                               Write(Url.Content("~/Content/Images/arkansas.ico"));

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n    ");


            
            #line 49 "..\..\Views\Shared\_SiteLayout.cshtml"
Write(RenderSection("head", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</head>\r\n\r\n<body class=\"");


            
            #line 52 "..\..\Views\Shared\_SiteLayout.cshtml"
        Write(Html.GetBrowserSpecificCssClasses());

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");


            
            #line 53 "..\..\Views\Shared\_SiteLayout.cshtml"
       Html.RenderAction("SystemMessage", typeof(MasterPageController).GetControllerName()); 

            
            #line default
            #line hidden
WriteLiteral("    \r\n    <script type=\"text/javascript\">\r\n        var expandCollapseImages = {\r\n" +
"            BulletMinus: \"");


            
            #line 57 "..\..\Views\Shared\_SiteLayout.cshtml"
                      Write(EdFiDashboards.Site.Common.ThemeImage("BulletMinus.gif").Resolve());

            
            #line default
            #line hidden
WriteLiteral("\",\r\n            BulletPlus: \"");


            
            #line 58 "..\..\Views\Shared\_SiteLayout.cshtml"
                     Write(EdFiDashboards.Site.Common.ThemeImage("BulletPlus.gif").Resolve());

            
            #line default
            #line hidden
WriteLiteral(@"""
        };
        
        $(document).ready(function() {
            if (typeof (InitEdFiGridSettings) === 'function') {
                InitEdFiGridSettings();
            }
        });
        
        // for links that skip down the page, force focus on target element
        $(document).ready(function () {	
            $(""a[href^='#']"").click(function () {
                $(""#"" + $(this).attr(""href"").slice(1) + """").focus();
            });
        });
        
");


            
            #line 74 "..\..\Views\Shared\_SiteLayout.cshtml"
         if(TimeoutWarningConfiguration.Current.WarningEnabled)
        {

            
            #line default
            #line hidden
WriteLiteral("            ");

WriteLiteral("\r\n        $(document).ready(function() {\r\n            setSessionExpirationAlert(");


            
            #line 78 "..\..\Views\Shared\_SiteLayout.cshtml"
                                  Write(TimeoutWarningConfiguration.Current.WarningEnabled.ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral(", ");


            
            #line 78 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                                                                              Write(TimeoutWarningConfiguration.Current.ForceEnabled.ToString().ToLower());

            
            #line default
            #line hidden
WriteLiteral(", \'");


            
            #line 78 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                                                                                                                                                         Write(Url.Content(TimeoutWarningConfiguration.Current.KeepAliveUrl));

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 78 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                                                                                                                                                                                                                             Write(Url.Content(TimeoutWarningConfiguration.Current.LogoutUrl));

            
            #line default
            #line hidden
WriteLiteral("\', ");


            
            #line 78 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                                                                                                                                                                                                                                                                                             Write(TimeoutWarningConfiguration.Current.TimeUntilWarning);

            
            #line default
            #line hidden
WriteLiteral(", ");


            
            #line 78 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                      Write(TimeoutWarningConfiguration.Current.TimeUntilForcedLogout);

            
            #line default
            #line hidden
WriteLiteral(", \'");


            
            #line 78 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Enum.GetName(typeof(TimeoutWarningConfiguration.TimeoutForceAction), TimeoutWarningConfiguration.Current.ForceAction));

            
            #line default
            #line hidden
WriteLiteral("\');\r\n                });\r\n        ");

WriteLiteral("\r\n");


            
            #line 81 "..\..\Views\Shared\_SiteLayout.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral(@"    </script> 
    <div id=""dialog-confirm""></div>
    <!-- New Stuff -->
    <header id=""header"" class=""constrained"">
        <span class=""state-logo hidden"">Arkansas Department of Education Logo</span>
        <a id=""skip"" href=""#maincontent"">Skip Navigation</a>
        <ul>
");


            
            #line 89 "..\..\Views\Shared\_SiteLayout.cshtml"
             if (!Request.Url.AbsolutePath.ToLower().Contains("search")) {

            
            #line default
            #line hidden
WriteLiteral("                <li><a class=\"btn\" href=\"#\" onclick=\"exportAll_Click();\"><i class" +
"=\"icon-floppy\"></i> Export All</a></li>\r\n");


            
            #line 91 "..\..\Views\Shared\_SiteLayout.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral(@"            <li><a class=""btn"" href=""#"" onclick=""javascript:window.print();""><i class=""icon-print""></i> Print</a></li>
            <li><a id=""buttonFeedback"" class=""btn btn-em"" href=""#""><i class=""icon-help-circle""></i> Support</a></li>
            <li><a class=""btn"" href=""#"" onclick=""window.location='");


            
            #line 94 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                             Write(EdFiDashboardsSite.Common.Logout().Resolve());

            
            #line default
            #line hidden
WriteLiteral("\';\"><i class=\"icon-logout\"></i> Log Out</a></li>\r\n        </ul>\r\n        <nav id=" +
"\"nav-main\">\r\n");


            
            #line 97 "..\..\Views\Shared\_SiteLayout.cshtml"
               Html.RenderAction("LevelCrumb", typeof(MasterPageController).GetControllerName()); 

            
            #line default
            #line hidden

            
            #line 98 "..\..\Views\Shared\_SiteLayout.cshtml"
               Html.RenderAction("Search", typeof(MasterPageController).GetControllerName()); 

            
            #line default
            #line hidden
WriteLiteral("        </nav>\r\n    </header>\r\n    <div id=\"content\" class=\"constrained\">\r\n");


            
            #line 102 "..\..\Views\Shared\_SiteLayout.cshtml"
         if (IsSectionDefined("ContentDataHeader")) {
            
            
            #line default
            #line hidden
            
            #line 103 "..\..\Views\Shared\_SiteLayout.cshtml"
       Write(RenderSection("ContentDataHeader", required: false));

            
            #line default
            #line hidden
            
            #line 103 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                                
        }

            
            #line default
            #line hidden

            
            #line 105 "..\..\Views\Shared\_SiteLayout.cshtml"
         if (IsSectionDefined("ContentMenu")) {
            
            
            #line default
            #line hidden
            
            #line 106 "..\..\Views\Shared\_SiteLayout.cshtml"
       Write(RenderSection("ContentMenu", required: false));

            
            #line default
            #line hidden
            
            #line 106 "..\..\Views\Shared\_SiteLayout.cshtml"
                                                          
        }

            
            #line default
            #line hidden
WriteLiteral("        <div id=\"maincontent\" tabindex=\"-1\">\r\n            ");


            
            #line 109 "..\..\Views\Shared\_SiteLayout.cshtml"
       Write(RenderSection("ContentPlaceHolderTopMost", required: false));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </div>\r\n        ");


            
            #line 111 "..\..\Views\Shared\_SiteLayout.cshtml"
   Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n    <footer id=\"footer\" class=\"constrained\">\r\n        <div>\r\n");


            
            #line 115 "..\..\Views\Shared\_SiteLayout.cshtml"
               Html.RenderPartial("Legend"); 

            
            #line default
            #line hidden
WriteLiteral("        </div>\r\n        <div class=\"copyright\">\r\n            <span class=\"site-lo" +
"go\"></span>\r\n            <p>&copy; ");


            
            #line 119 "..\..\Views\Shared\_SiteLayout.cshtml"
                 Write(DateTime.Now.Year);

            
            #line default
            #line hidden

            
            #line 119 "..\..\Views\Shared\_SiteLayout.cshtml"
                                        WriteLiteral(" Ed-Fi Alliance, LLC. All Rights Reserved.</p>\r\n            <p>");

            
            #line default
            #line hidden
            
            #line 120 "..\..\Views\Shared\_SiteLayout.cshtml"
                  Html.RenderAction("TopRightCorner", typeof(MasterPageController).GetControllerName()); 
            
            #line default
            #line hidden
WriteLiteral("</p>\r\n            <img id=\"red\" src=\"");


            
            #line 121 "..\..\Views\Shared\_SiteLayout.cshtml"
                           Write(EdFiDashboards.Site.Common.ThemeImage("redStripe.png").Resolve());

            
            #line default
            #line hidden
WriteLiteral("\" class=\"hidden\" aria-hidden=\"true\" alt=\"Image used in charts\"/>\r\n        </div>\r" +
"\n    </footer>\r\n\t    <input id=\"userFullName\" type=\"hidden\" value=\"");


            
            #line 124 "..\..\Views\Shared\_SiteLayout.cshtml"
                                               Write(UserInformation.Current == null ? string.Empty : UserInformation.Current.FullName);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n    \r\n");


            
            #line 126 "..\..\Views\Shared\_SiteLayout.cshtml"
      Html.RenderAction("Feedback", typeof(MasterPageController).GetControllerName(), new { supportLinkControlId = "#buttonFeedback", allowNameEdit = false }); 

            
            #line default
            #line hidden
WriteLiteral("    \r\n    ");


            
            #line 128 "..\..\Views\Shared\_SiteLayout.cshtml"
Write(RenderSection("TrailerScript", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n</body>\r\n\r\n</html>\r\n");


        }
    }
}
#pragma warning restore 1591
