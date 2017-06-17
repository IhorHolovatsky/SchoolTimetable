using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolTimetable.WEB.Controllers
{
    public class TimeTableController : Controller
    {
        // GET: TimeTable
        public ActionResult Index()
        {
            return View();
        }
    }
}