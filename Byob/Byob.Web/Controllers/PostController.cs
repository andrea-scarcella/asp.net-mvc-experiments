using Byob.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Byob.Web.Controllers
{
    public class PostController : Controller
    {
        private Domain.IPostService postSvc;

        public PostController(Domain.IPostService postSvc)
        {
            // TODO: Complete member initialization
            this.postSvc = postSvc;
        }
        //
        // GET: /Post/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult NewPost(PostVM postVM)
        {
            if (!ModelState.IsValid)
            {
                return View("NewPost");
            }
            return View();
        }
    }
}