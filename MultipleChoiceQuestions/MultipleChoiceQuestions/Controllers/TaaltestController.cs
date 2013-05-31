using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultipleChoiceQuestions.BL;

namespace MultipleChoiceQuestions.Controllers
{
    public class TaaltestController : Controller
    {
        //
        // GET: /Taaltest/

        public ActionResult Index()
        {
            ITaaltestRepository repo = null;
            Taaltest t = null;
            t = new Taaltest();
            //t = repo.getTest(DateTime.Now);

            return View(t);
        }
        [HttpPost]
        public ActionResult Index(Taaltest taalTest)
        {
            if (ModelState.IsValid)
            {
                foreach (var v in taalTest.vragen)
                {
                    var vraagID = v.ID;
                    var gekozenAntwoordId = v.gekozenAntwoord;
                }
            }
            return View();
        }

    }
}
