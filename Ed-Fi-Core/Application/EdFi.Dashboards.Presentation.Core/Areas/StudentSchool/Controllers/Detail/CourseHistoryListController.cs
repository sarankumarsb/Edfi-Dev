﻿using System.Web.Mvc;
using EdFi.Dashboards.Common;
using EdFi.Dashboards.Core.Providers.Context;
using EdFi.Dashboards.Resources;
using EdFi.Dashboards.Resources.Models.Student.Detail.CourseHistory;
using EdFi.Dashboards.Resources.StudentSchool.Detail;

namespace EdFi.Dashboards.Presentation.Core.Areas.StudentSchool.Controllers
{
    public class CourseHistoryListController : Controller
    {
        private readonly IService<CourseHistoryListRequest, CourseHistoryModel> service;

        public CourseHistoryListController(IService<CourseHistoryListRequest, CourseHistoryModel> service)
        {
            this.service = service;
        }

        public ActionResult Get(EdFiDashboardContext context, string subjectArea)
        {
            var request = new CourseHistoryListRequest()
                              {
                                  StudentUSI = context.StudentUSI.GetValueOrDefault(),
                                  SchoolId = context.SchoolId.GetValueOrDefault()
                              };

            var model = service.Get(request);

            return View(model);
        }

    }
}
