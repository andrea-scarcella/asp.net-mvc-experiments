using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class BaseController : Controller
    {
        //
        // GET: /Base/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        protected override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            //is it a view?
            ViewResultBase view = filterContext.Result as ViewResultBase;
            if (view == null)
            {
                return; //niks te doen :)
            }
            //use culture-specific view (not implemented in this case)
            base.OnActionExecuted(filterContext);
        }
        protected override void ExecuteCore()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Thread.CurrentThread.CurrentUICulture = System.Globalization.CultureInfo.InvariantCulture;

            base.ExecuteCore();
        }

    }
}
