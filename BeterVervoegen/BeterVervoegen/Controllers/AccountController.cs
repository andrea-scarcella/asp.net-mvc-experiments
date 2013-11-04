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
		public ActionResult LogOn(LoginVm loginData, string returnUrl)
		{
			if (ModelState.IsValid)
			{
				FormsAuthentication.SetAuthCookie(loginData.Username, false);
				return RedirectToLocal(returnUrl);
			}
			return View(loginData);
		}

		//[AllowAnonymous]
		public ActionResult LogOut()
		{
			FormsAuthentication.SignOut();
			TempData["logoutmessage"] = "U bent uitgelogd!";

			//return View();
			return RedirectToAction("Index", "Home");
		}

		public ActionResult SignUp()
		{
			return View();
		}
		private ActionResult RedirectToLocal(string returnUrl)
		{
			if (Url.IsLocalUrl(returnUrl))
			{
				return Redirect(returnUrl);
			}
			else
			{
				return RedirectToAction("Index", "Home");
			}
		}
	}
}
