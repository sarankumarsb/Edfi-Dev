﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18046
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Views.Overview
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
    
    #line 1 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    
    #line 2 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Controllers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Utilities.ExtensionMethods.HtmlHelper;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Architecture;
    
    #line 5 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
    using EdFi.Dashboards.Presentation.Web.Utilities;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.4.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/StudentSchool/Views/Overview/Get.cshtml")]
    public partial class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Resources.Models.Student.Overview.OverviewModel>
    {
        public Get()
        {
        }
        public override void Execute()
        {





WriteLiteral("\n");


WriteLiteral("\n");


            
            #line 9 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
  
    ViewBag.Title = "Student Overview";


            
            #line default
            #line hidden
WriteLiteral("\n");


DefineSection("ContentPlaceHolderHead", () => {

WriteLiteral("\n    <title>");


            
            #line 14 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
       Write(Html.Action("Title", typeof(StudentSchoolLayoutController).GetControllerName(), new { subTitle = "Overview" }));

            
            #line default
            #line hidden
WriteLiteral("</title>\n    <script type=\"text/javascript\">\r\n        var pageArea = { Area: \'stu" +
"dent\', Page: \'Academic Dashboard - Overview\' };\r\n    </script>\n");


});

WriteLiteral("\n\n");


DefineSection("ContentPlaceHolder1", () => {

WriteLiteral("\n    <div class=\"l-overview-metrics\">\r\n        <div>\r\n            <div class=\"lef" +
"t\">\r\n                <img id=\"Model.ProfileThumbnail\" src=\"");


            
            #line 24 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                                                  Write(Model.ProfileThumbnail);

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Photograph of ");


            
            #line 24 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                                                                                                Write(Model.FullName);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n            </div>\r\n            <div class=\"right\">\r\n                <p cla" +
"ss=\"entity-title\">");


            
            #line 27 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                                    Write(Model.FullName);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n                <div>\r\n                    <ul class=\"two-column-info-list\"" +
">\r\n                        <li>\r\n                            <span class=\"label\"" +
">Grade Level</span>\r\n                            <span>");


            
            #line 32 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                             Write(Model.GradeLevel);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </li>\r\n                        <li>\r\n           " +
"                 <span class=\"label\">Current Age</span>\r\n                       " +
"     <span>");


            
            #line 36 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                             Write(Model.AgeAsOfToday);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                        </li> \n");


            
            #line 38 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (!String.IsNullOrEmpty(Model.Language))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">Student Language</span>\r\n                                <span>");


            
            #line 42 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                                 Write(Model.Language);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </li>\r\n");


            
            #line 44 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden

            
            #line 45 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (!String.IsNullOrEmpty(Model.HomeLanguage))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">Home Language</span>\r\n                                <span>");


            
            #line 49 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                                 Write(Model.HomeLanguage);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            </li>\r\n");


            
            #line 51 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                        <li>\r\n                            <a href=\"");


            
            #line 53 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                                Write(Model.ParentContactInfoLink);

            
            #line default
            #line hidden
WriteLiteral("\">Parent Contact Info</a>\r\n                        </li>\r\n                    </u" +
"l>                    \r\n                </div>\r\n                <div class=\"last" +
"\">\r\n                    <ul class=\"two-column-info-list\">\r\n");


            
            #line 59 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (Model.LimitedEnglishProficiency)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">Limited English Proficiency</span>\r\n                            </li>\r\n");


            
            #line 64 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        } 

            
            #line default
            #line hidden

            
            #line 65 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (Model.LimitedEnglishMonitoredFirstProficiency)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">Limited English Proficiency Monitored 1</span>\r\n                           " +
" </li>\r\n");


            
            #line 70 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden

            
            #line 71 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (Model.LimitedEnglishMonitoredSecondProficiency)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">Limited English Proficiency Monitored 2</span>\r\n                           " +
" </li>\r\n");


            
            #line 76 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden

            
            #line 77 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (Model.BilingualProgram)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">Bilingual Program</span>\r\n                            </li>\r\n");


            
            #line 82 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden

            
            #line 83 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (Model.EnglishAsSecondLanguage)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">English as Second Language</span>\r\n                            </li>\r\n");


            
            #line 88 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden

            
            #line 89 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (Model.GiftedAndTalented)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">Gifted/Talented</span>\r\n                            </li>\r\n");


            
            #line 94 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden

            
            #line 95 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (Model.SpecialEducation)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">Special Education</span>\r\n                            </li>\r\n");
            

            
            #line 100 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden

            
            #line 101 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                         if (Model.Designation)
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <li>\r\n                                <span class=\"la" +
"bel\">504 Designation</span>\r\n                            </li>\r\n");


            
            #line 106 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </ul>\r\n                </div>\r\n            </div>\n        </d" +
"iv>\n    </div>\n    <div class=\"l-metrics\">\n");


            
            #line 113 "..\..\Areas\StudentSchool\Views\Overview\Get.cshtml"
       Html.RenderAction("Get", "Metrics", new
                                          {
                                              renderingMode = Model.RenderingMode,
                                              studentUSI = Model.StudentUSI,
                                              metricVariantId = Model.MetricVariantId
                                          }); 

            
            #line default
            #line hidden
WriteLiteral("    </div>\n");


});

WriteLiteral("\n");


        }
    }
}
#pragma warning restore 1591
