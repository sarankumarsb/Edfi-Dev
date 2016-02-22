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

namespace EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Views.Detail.LearningStandardsTable
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
    
    #line 1 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
    using EdFi.Dashboards.Common.Utilities;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 3 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Providers.Models;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Architecture;
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/StudentSchool/Views/Detail/LearningStandardsTable/Get.cshtml")]
    public partial class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Resources.Models.CustomGrid.GridTable>
    {
        public Get()
        {
        }
        public override void Execute()
        {




WriteLiteral("\n");


            
            #line 6 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
  
    var studentUSI = EdFiDashboardContext.Current.StudentUSI.GetValueOrDefault();
    var metricVariantId = EdFiDashboardContext.Current.MetricVariantId.GetValueOrDefault();
    var edFiGridModelProvider = IoC.Resolve<IEdFiGridModelProvider>();

    var edfiGridModel = edFiGridModelProvider.GetEdFiGridModel(false, true, 10, "Metric" + metricVariantId, metricVariantId,
        Model, null, null, false, null, new List<string> { "AssessmentDetail" }, null, false, null, false);



            
            #line default
            #line hidden
WriteLiteral("\n<div id=\"LearningStandardsTable");


            
            #line 16 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
                           Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\n    <script>\r\n        analyticsManager.trackDrilldown(\'StudentLearningStandard" +
"sTable\', \'");


            
            #line 18 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
                                                                      Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\', \'");


            
            #line 18 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
                                                                                            Write(studentUSI);

            
            #line default
            #line hidden
WriteLiteral("\');\n        $(\"#Metric");


            
            #line 19 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
              Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("-EdFiGrid-interaction-custom\").append($(\"#buttonExportAll-");


            
            #line 19 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
                                                                                          Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\"));\r\n        $(\"#buttonExportAll-");


            
            #line 20 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
                        Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\").show();\n    </script>\n    <a href=\"");


            
            #line 22 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
        Write(Url.Action("Get", "LearningStandardsExport"));

            
            #line default
            #line hidden
WriteLiteral("\" id=\"buttonExportAll-");


            
            #line 22 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
                                                                            Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\" class=\"btn\" style=\"display:none;\"><i class=\"icon-floppy\"></i> EXPORT ALL</a>\n  " +
"  <a href=\"");


            
            #line 23 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
        Write(Url.Action("Get", "LearningStandardsExport"));

            
            #line default
            #line hidden
WriteLiteral("\" class=\"hidden\">Export learning standards for metric ");


            
            #line 23 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
                                                                                                            Write(metricVariantId);

            
            #line default
            #line hidden
WriteLiteral(" to csv</a>\n");


            
            #line 24 "..\..\Areas\StudentSchool\Views\Detail\LearningStandardsTable\Get.cshtml"
      Html.RenderPartial("EdFiGrid", model: edfiGridModel);

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n\n");


        }
    }
}
#pragma warning restore 1591