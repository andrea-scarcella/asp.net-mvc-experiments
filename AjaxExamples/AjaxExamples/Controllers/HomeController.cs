using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxExamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public PartialViewResult Index(dynamic dummy) {
            ViewBag.Foo = Guid.NewGuid().ToString()+":Index";
            return PartialView("_simpleAjaxActionPartialView");
        }
        public PartialViewResult simpleAjaxAction()
        {
            ViewBag.Foo = Guid.NewGuid().ToString();
            return PartialView("_simpleAjaxActionPartialView");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}