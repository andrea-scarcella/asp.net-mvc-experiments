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


			//TestVM t = new TestVM(new[] {
			//	new TestItemVM { 
			//		ItemId = 1, 
			//		Infinitive = "zijn", 

			//		AnswerPastParticiple = "", AnswerSimplePast = "" },
			//		new TestItemVM { 
			//		ItemId = 2, 
			//		Infinitive = "lopen", 

			//		AnswerPastParticiple = "", AnswerSimplePast = "" }
			//}
			//);
			return View(dto);
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
