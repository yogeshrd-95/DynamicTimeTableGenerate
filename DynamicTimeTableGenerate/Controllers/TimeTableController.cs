using DynamicTimeTableGenerate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicTimeTableGenerate.Controllers
{
    public class TimeTableController : Controller
    {
        // GET: TimeTable
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(WorkingDays workingDays)
        {
            int intTotalHoursForWeek = 0, intTotalSubjects = 0;
            TempData["WorkingDays"] = workingDays.NoOfWorkingDays;
            TempData["SubjectsPerDay"] = workingDays.NoOfSubjectsPerDay;
            intTotalSubjects = workingDays.TotalSubjects;
            intTotalHoursForWeek = workingDays.NoOfWorkingDays * workingDays.NoOfSubjectsPerDay;
            return RedirectToAction("Index", "GenerateTimeTable", new
            {
                intTotalSubjects,
                intTotalHoursForWeek,
            });

        }
    }
}