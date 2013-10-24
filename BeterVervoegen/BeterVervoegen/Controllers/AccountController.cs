using System.Web.Mvc;
using System.Web.Security;
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
		[AllowAnonymous]
		public ActionResult LogOn(LoginVm loginData)
		{
			if (ModelState.IsValid)
			{
				//var t = System.Threading.Thread;

				var p = System.Threading.Thread.CurrentPrincipal;

				FormsAuthentication.SetAuthCookie(loginData.Username, false);
				
			}
			return View(loginData);
		}

		public ActionResult SignUp()
		{
			return View();
		}
	}
}
