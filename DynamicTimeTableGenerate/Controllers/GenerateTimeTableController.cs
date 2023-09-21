using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicTimeTableGenerate.Controllers
{
    public class GenerateTimeTableController : Controller
    {
        // GET: GenerateTimeTable

        public ActionResult Index(int? intTotalSubjects, int? intTotalHoursForWeek)
        {
            ViewBag.TotalSubjects = intTotalSubjects;

            ViewBag.TotalHoursForWeek = intTotalHoursForWeek;
            return View();
        }
    }
}