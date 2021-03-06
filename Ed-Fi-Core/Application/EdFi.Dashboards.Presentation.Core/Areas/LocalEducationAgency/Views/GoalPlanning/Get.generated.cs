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

namespace EdFi.Dashboards.Presentation.Core.Areas.LocalEducationAgency.Views.GoalPlanning
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
    
    #line 2 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
    using System.Web.Script.Serialization;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
    using EdFi.Dashboards.Common;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
    using EdFi.Dashboards.Core.Providers.Context;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
    using EdFi.Dashboards.Metric.Rendering;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Metric.Resources.Models;
    using EdFi.Dashboards.Presentation.Architecture.Mvc.Extensions;
    
    #line 6 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
    using EdFi.Dashboards.Presentation.Core.Areas.LocalEducationAgency.Controllers;
    
    #line default
    #line hidden
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    #line 7 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
    using EdFi.Dashboards.Resources.Navigation.Mvc;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/LocalEducationAgency/Views/GoalPlanning/Get.cshtml")]
    public class Get : System.Web.Mvc.WebViewPage<EdFi.Dashboards.Application.Resources.Models.LocalEducationAgency.GoalPlanningModel>
    {
        public Get()
        {
        }
        public override void Execute()
        {







WriteLiteral("\n");


            
            #line 9 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
  
    var jss = new JavaScriptSerializer { MaxJsonLength = 50000000 };
    var jsonGoalData = jss.Serialize(Model);

    var localEducationAgencyId = EdFiDashboardContext.Current.LocalEducationAgencyId.GetValueOrDefault();
    var metricVariantId = EdFiDashboardContext.Current.MetricVariantId.GetValueOrDefault();
    ViewBag.Title = "Local Education Agency Goal Planning";


            
            #line default
            #line hidden
WriteLiteral("\n");


DefineSection("ContentPlaceHolderHead", () => {

WriteLiteral("\n    <title>");


            
            #line 19 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
       Write(Html.Action("Title", typeof(LocalEducationAgencyLayoutController).GetControllerName(), new { subTitle = "Goal Planning" }));

            
            #line default
            #line hidden
WriteLiteral("</title>\n    <script>\r\n        var pageArea = { Area: \'local education agency\', P" +
"age: \'Goal Planning\' };\n        \n        var goalPlanningPost = \'");


            
            #line 23 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
                            Write(EdFiDashboards.Site.LocalEducationAgency.GoalPlanning(localEducationAgencyId, metricVariantId, new{format="json"}));

            
            #line default
            #line hidden
WriteLiteral("\';\n        var goalPublishPost = \'");


            
            #line 24 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
                           Write(EdFiDashboards.Site.LocalEducationAgency.PublishGoals(localEducationAgencyId, new{format="json"}));

            
            #line default
            #line hidden
WriteLiteral("\';\n        var goalPlanningSchoolListPost = \'");


            
            #line 25 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
                                      Write(EdFiDashboards.Site.LocalEducationAgency.Resource(localEducationAgencyId, "GoalPlanningSchoolList", new{format="json"}));

            
            #line default
            #line hidden
WriteLiteral("\';\n        jQuery[\'goalData\'] = ");


            
            #line 26 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
                         Write(Html.Raw(jsonGoalData));

            
            #line default
            #line hidden
WriteLiteral(";\n        var goals = new goalPlanning(");


            
            #line 27 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
                                Write(localEducationAgencyId);

            
            #line default
            #line hidden
WriteLiteral(@", 'goalData', goalPlanningPost, goalPublishPost, goalPlanningSchoolListPost);
        $(function () {
            $('a[id|=""mainmoreActions""]').on(""click keypress focus"", openMoreMenu);

            goals.initialize(true);
            
            var tdId = requestQuerystring(""tdId"");
            if (tdId != null) {
                $(""[data-tdid='"" + tdId + ""']"").click();
            }

            var jump = requestQuerystring(""jump"");
            if (jump != null && jump != '') {
                window.location.hash = ""#"" + jump;
            }
            
            highlightMetric();
        });
    </script>
");


});

WriteLiteral("\n\n");


DefineSection("ContentPlaceHolder1", () => {

WriteLiteral("\n<div class=\"l-metrics\">\n");


            
            #line 50 "..\..\Areas\LocalEducationAgency\Views\GoalPlanning\Get.cshtml"
       Html.RenderAction("Get", "Metrics", RenderingMode.GoalPlanning); 

            
            #line default
            #line hidden
WriteLiteral("</div>\n");


});

WriteLiteral("\n");


        }
    }
}
#pragma warning restore 1591
