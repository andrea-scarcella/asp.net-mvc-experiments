using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerStateLoadBalancingTest.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Welcome/

        public ActionResult Index()
        {

            if (Session["Test"] == null)
            {
                Session["Test"] = Guid.NewGuid().ToString();
            }
            ViewBag.MyToken = Session["Test"];
            return View();
        }

    }
}
