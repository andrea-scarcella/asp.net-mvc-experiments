using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using BeterVervoegen.BL;
//using NSubstitute;
using BeterVervoegen.DAL;
using BeterVervoegen.Models;

namespace BeterVervoegen.Controllers
{
    public class TaaltestController : Controller
    {
        //
        // GET: /Taaltest/
        public ActionResult Index()
        {

            Test t0 = new Test(
                new[] {
					new TestItem{
						ItemId=1,
						Infinitive="zijn",
						SimplePast="was",
						PastParticiple="geweest"},new TestItem{
						ItemId=2,
						Infinitive="lopen",
						SimplePast="liep",
						PastParticiple="gelopen"}});

            TestVM dto = Mapper.Map<TestVM>(t0);



            return View(dto);
        }
        [HttpPost]
        public ActionResult Index(TestVM taalTest)
        {
            if (ModelState.IsValid)
            {

                Test t = testService_getTest(taalTest.Id);
                foreach (var item in taalTest.Items)
                {
                    //quick and dirty solution
                    var testItem = t.Items.First(el => el.ItemId == item.ItemId);
                    testItem.AnswerPastParticiple = item.AnswerPastParticiple;
                    testItem.AnswerSimplePast = item.AnswerSimplePast;
                }
                t.Evaluate();
                testService_saveTest(t);
            }
            return View(taalTest);
        }

        private void testService_saveTest(Test t)
        {
            //to be refactored
        }

        private Test testService_getTest(Guid guid)
        {

            Test t0 = new Test(
                new[] {
					new TestItem{
						ItemId=1,
						Infinitive="zijn",
						SimplePast="was",
						PastParticiple="geweest"},new TestItem{
						ItemId=2,
						Infinitive="lopen",
						SimplePast="liep",
						PastParticiple="gelopen"}});
            return t0;
        }
    }
}
