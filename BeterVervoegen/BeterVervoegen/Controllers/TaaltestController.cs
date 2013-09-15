using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeterVervoegen.BL;
//using NSubstitute;
using BeterVervoegen.DAL;

namespace BeterVervoegen.Controllers
{
    public class TaaltestController : Controller
    {
        //
        // GET: /Taaltest/

        public ActionResult Index()
        {
            //IEnumerable<TestDeel> i = new List<TestDeel> { new TestDeel { ID = 0, tekst = "" } };
            ITaaltestRepository r = new Class1();
            var tt = r.get(DateTime.Now);

            return View(tt.First());
        }
        [HttpPost]
        public ActionResult Index(Taaltest taalTest)
        {
            if (ModelState.IsValid)
            {
                foreach (var item in taalTest.vragen)
                {
                    foreach (var item2 in item.antwoorden)
                    {
                        int u = 0;
                    }
                }
            }
            return View(taalTest);
        }
    }
}
