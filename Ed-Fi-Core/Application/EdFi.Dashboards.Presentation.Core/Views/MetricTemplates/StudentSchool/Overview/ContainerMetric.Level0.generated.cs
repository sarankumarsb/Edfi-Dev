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

namespace EdFi.Dashboards.Presentation.Core.Views.MetricTemplates.StudentSchool.Overview
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
    using EdFi.Dashboards.Presentation.Web.Utilities;
    using EdFi.Dashboards.Resources.Navigation;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.5.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/MetricTemplates/StudentSchool/Overview/ContainerMetric.Level0.cshtml")]
    public class ContainerMetric_Level0 : System.Web.Mvc.WebViewPage<ContainerMetric>
    {
        public ContainerMetric_Level0()
        {
        }
        public override void Execute()
        {

WriteLiteral("<!-- Inline Style is left intentionally in the MetricTemplate to provide a easyer" +
" way to override.-->\r\n<table summary=\"This table displays metrics regarding ");


            
            #line 3 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level0.cshtml"
                                                  Write(Model.DisplayName);

            
            #line default
            #line hidden
WriteLiteral(".\">\r\n<thead>\r\n<tr id=\"vMetric");


            
            #line 5 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level0.cshtml"
           Write(Model.MetricVariantId);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n    <th title=\"");


            
            #line 6 "..\..\Views\MetricTemplates\StudentSchool\Overview\ContainerMetric.Level0.cshtml"
          Write(Model.ToolTip);

            
            #line default
            #line hidden
WriteLiteral("\" style=\"width:45%\">\r\n        Metric Category\r\n    </th>\r\n    <th  style=\"width:3" +
"0%\">\r\n        Performance Summary\r\n    </th>\r\n    <th style=\"text-align:left\">\r\n" +
"        Metric Status\r\n    </th>\r\n</tr>\r\n</thead>\r\n<tbody>\r\n");


        }
    }
}
#pragma warning restore 1591
