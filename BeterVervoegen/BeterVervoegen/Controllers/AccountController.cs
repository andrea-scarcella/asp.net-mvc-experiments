using System.Web.Mvc;
using BeterVervoegen.Models;

namespace BeterVervoegen.Controllers
{
	public class AccountController : Controller
	{
		//
		// GET: /Account/
		[AllowAnonymous]
		public ActionResult Index()
		{
			return View();
		}
		[HttpPost]
		public ActionResult Index(LoginVm loginData)
		{
			if (ModelState.IsValid)
			{

			}
			return View(loginData);
		}

	}
}
