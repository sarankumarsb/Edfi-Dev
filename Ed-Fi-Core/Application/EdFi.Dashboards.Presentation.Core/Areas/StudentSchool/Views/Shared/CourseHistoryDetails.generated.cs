﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
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
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 1 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
    using EdFi.Dashboards.Presentation.Core.Models.Shared;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
    using EdFi.Dashboards.Presentation.Core.Utilities.ExtensionMethods.HtmlHelper;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Architecture;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/StudentSchool/Views/Shared/CourseHistoryDetails.cshtml")]
    public partial class _Areas_StudentSchool_Views_Shared_CourseHistoryDetails_cshtml : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Models.Shared.CourseHistoryModel>
    {
        public _Areas_StudentSchool_Views_Shared_CourseHistoryDetails_cshtml()
        {
        }
        public override void Execute()
        {



WriteLiteral("\r\n");



WriteLiteral("\r\n<div class=\"credit-accumulation-grid\">\r\n    ");



WriteLiteral("\r\n");


            
            #line 24 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
       var courseCount = 0; 

            
            #line default
            #line hidden

            
            #line 25 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
     foreach (var subjectArea in Model.Model.SubjectAreas)
    {

            
            #line default
            #line hidden
WriteLiteral("        <div class=\"expand-collapse hide\">\r\n            <div class=\"expand-collap" +
"se-row hide\">\r\n");


            
            #line 29 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                  
        var subjectAreaDivId = subjectArea.Name.Replace(" ", "");
        subjectAreaDivId = subjectAreaDivId.Replace("/", "");
        subjectAreaDivId = String.Format("CourseHistoryList{0}_{1}", Model.MetricVariantId, subjectAreaDivId);
        var subjectAreaId = subjectAreaDivId.ToLower();
                

            
            #line default
            #line hidden
WriteLiteral("\r\n                <span class=\"subject-area\">\r\n                    ");


            
            #line 37 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
               Write(Html.Partial("ExpandCollapse", new ExpandCollapseModel { CollapseExpandInitialState = Model.CollapseExpandInitialState, Title = subjectArea.Name, TitleCSS = "MetricTitle", DivId = subjectAreaDivId }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <a id=\"");


            
            #line 38 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                      Write(subjectArea.Name);

            
            #line default
            #line hidden
WriteLiteral("\">&nbsp;</a>\r\n                </span>\r\n");


            
            #line 40 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                 if (Model.CollapseExpandInitialState == ExpandCollapseModel.InitialState.Collapsed)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <script>\r\n                        document.onready($(\".icon-c" +
"ollapse\").hide());\r\n                    </script>\r\n");


            
            #line 45 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <span class=\"credits-earned\">\r\n                    ");


            
            #line 47 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
               Write(Html.FormatCredits(subjectArea.TotalCreditsEarned));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </span>\r\n            </div>\r\n        </div>\r\n");


            
            #line 51 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"

        if (courseCount == 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <table class=\"standard-table tabular history_course_table\" summary=\"C" +
"ourse History for ");


            
            #line 54 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                              Write(subjectArea.Name);

            
            #line default
            #line hidden
WriteLiteral("\" id=\"");


            
            #line 54 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                                                      Write(subjectAreaDivId);

            
            #line default
            #line hidden
WriteLiteral(@""">
                <thead>
                    <tr>
                        <th colspan=""2"" id=""course_history"">
                            <a class=""accordion-toggle"" data-target=""#HistoryCoursePart1,#HistoryCourseSub"" href=""#"" id=""historyToggle"">
                                <h4>Course History</h4>
                            </a>
                        </th>
                        ");



WriteLiteral("\r\n                        <th id=\"subject-area-");


            
            #line 64 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                        Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-semester\" style=\"width:16%;\">\r\n                            <div class=\"label_wra" +
"p\">Semester<img class=\"arrow\" src=\"");


            
            #line 65 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                               Write(Url.Content("~/App_Themes/Theme1/img/th_down_arrow.png"));

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Downarrow\" /></div>\r\n                        </th>\r\n                      " +
"  <th id=\"subject-area-");


            
            #line 67 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                        Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-grade-level\" style=\"width:16%;\">\r\n                            <div class=\"label_" +
"wrap\">Grade Level<img class=\"arrow\" src=\"");


            
            #line 68 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                  Write(Url.Content("~/App_Themes/Theme1/img/th_down_arrow.png"));

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Downarrow\" /></div>\r\n                        </th>\r\n                      " +
"  <th id=\"subject-area-");


            
            #line 70 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                        Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-final-course-grade\" style=\"width:16%;\">\r\n                            <div class=" +
"\"label_wrap\">Final Course Grade<img class=\"arrow\" src=\"");


            
            #line 71 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                         Write(Url.Content("~/App_Themes/Theme1/img/th_down_arrow.png"));

            
            #line default
            #line hidden
WriteLiteral("\" alt=\"Downarrow\" /></div>\r\n                        </th>\r\n                      " +
"  <th id=\"subject-area-");


            
            #line 73 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                        Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-credits-earned\" style=\"width:16%;\">\r\n                            <div class=\"lab" +
"el_wrap\">Credits Earned<img class=\"arrow\" src=\"");


            
            #line 74 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                     Write(Url.Content("~/App_Themes/Theme1/img/th_down_arrow.png"));

            
            #line default
            #line hidden
WriteLiteral(@""" alt=""Downarrow"" /></div>
                        </th>
                    </tr>
                </thead>
                <tbody id=""HistoryCoursePart1"">
                    <tr>
                        <td class=""heading"" colspan=""6"">
                            <span class=""title"">");


            
            #line 81 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                           Write(subjectArea.Name);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            <h4 class=\"sub\">Course # And Descriptions</h" +
"4>\r\n                        </td>\r\n                    </tr>\r\n                </" +
"tbody>\r\n                <tbody id=\"HistoryCoursePart1\">\r\n");


            
            #line 87 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                       var rowCount = 0; 

            
            #line default
            #line hidden

            
            #line 88 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                     foreach (var course in subjectArea.Courses)
                    {
                        rowCount++;

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td headers=\"subject-ar" +
"ea-");


            
            #line 92 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-course-number\">");


            
            #line 92 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                               Write(course.LocalCourseCode);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 93 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-description\">");


            
            #line 93 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                             Write(course.CourseTitle);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 94 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-semester\">");


            
            #line 94 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                          Write(course.ActualSemester.TermType);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 95 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-grade-level\" style=\"text-align:center\">");


            
            #line 95 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                                       Write(course.GradeLevel);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 96 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-final-course-grade\" style=\"text-align:center\" class=\"center\">");


            
            #line 96 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                                                             Write(course.FinalGrade.Value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 97 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-credits-earned\" style=\"text-align:center\">");


            
            #line 97 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                                          Write(Html.FormatCredits(course.CreditsEarned));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");


            
            #line 99 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n");


            
            #line 102 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
        }
        else
        {

            
            #line default
            #line hidden
WriteLiteral("            <table class=\"standard-table tabular history_course_table\" summary=\"C" +
"ourse History for ");


            
            #line 105 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                              Write(subjectArea.Name);

            
            #line default
            #line hidden
WriteLiteral("\" id=\"HistoryCourseSub\">\r\n                ");



WriteLiteral("\r\n                <tbody>\r\n                    <tr>\r\n                        <td " +
"class=\"heading\" colspan=\"6\">\r\n                            <span class=\"title\">");


            
            #line 119 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                           Write(subjectArea.Name);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                            <h4 class=\"sub\">Course # And Descriptions</h" +
"4>\r\n                        </td>\r\n                    </tr>\r\n                </" +
"tbody>\r\n                <tbody>\r\n");


            
            #line 125 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                       var rowCount = 0; 

            
            #line default
            #line hidden

            
            #line 126 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                     foreach (var course in subjectArea.Courses)
                    {
                        rowCount++;

            
            #line default
            #line hidden
WriteLiteral("                        <tr>\r\n                            <td headers=\"subject-ar" +
"ea-");


            
            #line 130 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-course-number\">");


            
            #line 130 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                               Write(course.LocalCourseCode);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 131 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-description\">");


            
            #line 131 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                             Write(course.CourseTitle);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 132 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-semester\" style=\"width:16%;\">");


            
            #line 132 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                             Write(course.ActualSemester.TermType);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 133 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-grade-level\" style=\"text-align:center;width:16%;\">");


            
            #line 133 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                                                  Write(course.GradeLevel);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 134 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-final-course-grade\" style=\"text-align:center;width:16%;\" class=\"center\">");


            
            #line 134 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                                                                        Write(course.FinalGrade.Value);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                            <td headers=\"subject-area-");


            
            #line 135 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                 Write(subjectAreaId);

            
            #line default
            #line hidden
WriteLiteral("-credits-earned\" style=\"text-align:center;width:16%;\">");


            
            #line 135 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                                                                                                                     Write(Html.FormatCredits(course.CreditsEarned));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                        </tr>\r\n");


            
            #line 137 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </tbody>\r\n            </table>\r\n");


            
            #line 140 "..\..\Areas\StudentSchool\Views\Shared\CourseHistoryDetails.cshtml"
        }
        courseCount++;
    }

            
            #line default
            #line hidden
WriteLiteral("</div>");


        }
    }
}
#pragma warning restore 1591
