using Byob.Dal;
using Byob.Domain;
using Byob.Domain.Services;
using Byob.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Byob.Web.Controllers
{
    public class HomeController : Controller
    {
        private IPostService postSvc;

        public HomeController(IPostService svc)
        {
            this.postSvc = svc;
        }
        public ActionResult Index()
        {
            IEnumerable<PostPreviewVM> posts = postSvc.getPosts().ToList()
               .Select(el => new PostPreviewVM
               {
                   date = el.date,
                   tags = new List<string>(el.tags),
                   commentCount = el.comments.Count(),
                   permalink = el.permalink,
                   preview = el.preview
               });
            return View(posts);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}