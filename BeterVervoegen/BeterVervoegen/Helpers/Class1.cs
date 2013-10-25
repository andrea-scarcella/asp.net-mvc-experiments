using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeterVervoegen.Helpers
{
	public static class MyHelper
	{
		public static MvcHtmlString TimedRedirectToUrl(this HtmlHelper h, long seconds, string action, string controller)
		{
			var urlHelper = new UrlHelper(h.ViewContext.RequestContext);
			var url = urlHelper.Action(controller, action);
			//<META HTTP-EQUIV="Refresh" CONTENT="3000;URL=/Index/Home;
			var outp = new MvcHtmlString("<META HTTP-EQUIV=\"Refresh\" CONTENT=\"" + seconds + ";URL=\"" + url+"\">");
			return outp;
		}
	}

}