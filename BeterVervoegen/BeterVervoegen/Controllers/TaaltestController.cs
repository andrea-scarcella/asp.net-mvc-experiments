using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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


			TestVM t = new TestVM(new[] {
				new TestItemVM { 
					ItemId = 1, 
					Infinitive = "zijn", 
					
					AnswerPastParticiple = "", AnswerSimplePast = "" },
					new TestItemVM { 
					ItemId = 2, 
					Infinitive = "lopen", 
					 
					AnswerPastParticiple = "", AnswerSimplePast = "" }
			}
			);
			return View(t);
		}
		[HttpPost]
		public ActionResult Index(TestVM taalTest)
		{
			if (ModelState.IsValid)
			{
				foreach (var item in taalTest.Items)
				{
					int i = 0;
				}
			}
			return View(taalTest);
		}
	}
}
