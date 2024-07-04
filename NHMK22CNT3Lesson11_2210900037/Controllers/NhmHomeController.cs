using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NhmK22CNT3Lesson11_2210900037.Controllers
{
    public class NhmHomeController : Controller
    {
        public ActionResult NhmIndex()
        {
            return View();
        }

        public ActionResult NhmAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NhmContact()
        {
            ViewBag.msv = "2210900037";
            ViewBag.fullname = "NGOHOANGMINH";
            return View();
        }
    }
}