using System.Web.Mvc;
using BeterVervoegen.Models;

namespace BeterVervoegen.Controllers
{
	public class AccountController : Controller
	{
		//
		// GET: /Account/
		[AllowAnonymous]
		public ActionResult LogOn()
		{
			return View();
		}
		[HttpPost]
		public ActionResult LogOn(LoginVm loginData)
		{
			if (ModelState.IsValid)
			{

			}
			return View(loginData);
		}

	}
}
