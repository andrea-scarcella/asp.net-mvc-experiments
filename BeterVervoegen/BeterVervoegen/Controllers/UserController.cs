using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BeterVervoegen.Models;

namespace BeterVervoegen.Controllers
{
	public class UserController : Controller
	{
		[ChildActionOnly]
		public PartialViewResult UserInfo()
		{
			//  var userInfo = System.Threading.Thread.CurrentPrincipal.Identity.
			var u = HttpContext.User;
			// .. get the user information from session or db
			LoginVm l0 = null;
			if (u.Identity.IsAuthenticated)
			{
				l0 = new LoginVm();
				l0.Username = u.Identity.Name; 
			}
			return PartialView(l0);
		}

	}
}
