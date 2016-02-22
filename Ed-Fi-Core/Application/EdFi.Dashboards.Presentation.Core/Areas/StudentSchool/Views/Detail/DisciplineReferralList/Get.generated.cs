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

namespace EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Views.Detail.DisciplineReferralList
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
    
    #line 1 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    using EdFi.Dashboards.Presentation.Web.Architecture;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/StudentSchool/Views/Detail/DisciplineReferralList/Get.cshtml")]
    public class Get : System.Web.Mvc.WebViewPage<IList<EdFi.Dashboards.Resources.Models.Student.Detail.DisciplineReferralModel>>
    {
        public Get()
        {
        }
        public override void Execute()
        {


WriteLiteral("  \n  \n");


            
            #line 5 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
  
  var studentUSI = EdFiDashboardContext.Current.StudentUSI.GetValueOrDefault();
  var metricVariantId = EdFiDashboardContext.Current.MetricVariantId.GetValueOrDefault();


            
            #line default
            #line hidden
WriteLiteral("     \n<script>\r\n    analyticsManager.trackDrilldown(\'StudentDisciplineReferralLis" +
"t\', \'");


            
            #line 11 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
                                                                  Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 11 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
                                                                                        Write(studentUSI);

            
            #line default
            #line hidden
WriteLiteral("\');\n</script>\n");


            
            #line 13 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
 if (Model.Any())
{

            
            #line default
            #line hidden
WriteLiteral(@"    <table class=""standard-table standard-table-compressed"" summary=""Table displays data realted to discipline referral."">
        <thead>
            <tr>
                <th>Date</th>
                <th>Incident Code</th>
                <th>Incident Description</th>
                <th>Action</th>
            </tr>
        </thead>
");


            
            #line 24 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
         for (int i = 0; i < Model.Count(); i++)
        {
        var referral = Model[i];

            
            #line default
            #line hidden
WriteLiteral("            <tr class=\"");


            
            #line 27 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
                   Write((i % 2 ==0) ? "alt": "");

            
            #line default
            #line hidden
WriteLiteral("\">\n                <td>");


            
            #line 28 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
                Write(referral.Date.ToShortDateString());

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");


            
            #line 29 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
                Write(referral.IncidentCode);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");


            
            #line 30 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
                Write(referral.IncidentDescription);

            
            #line default
            #line hidden
WriteLiteral("</td>\n                <td>");


            
            #line 31 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
                Write(referral.Action);

            
            #line default
            #line hidden
WriteLiteral("</td>\n            </tr>\n");


            
            #line 33 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\n");


            
            #line 35 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <span class=\"MetricNoData\">No data available.</span>\n");


            
            #line 39 "..\..\Areas\StudentSchool\Views\Detail\DisciplineReferralList\Get.cshtml"
}

            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591