﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using AutoMapper;
using BeterVervoegen.BL;
using BeterVervoegen.Models;
using System.Data.Entity;
using BeterVervoegen.DAL;

namespace BeterVervoegen
{
	// Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	// visit http://go.microsoft.com/?LinkId=9394801

	public class MvcApplication : System.Web.HttpApplication
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			
			filters.Add(new HandleErrorAttribute());
			filters.Add(new AuthorizeAttribute());
		}

		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

			routes.MapRoute(
				"Default", // Route name
				"{controller}/{action}/{id}", // URL with parameters
				new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
			);

		}

		protected void Application_Start()
		{
			AreaRegistration.RegisterAllAreas();

			RegisterGlobalFilters(GlobalFilters.Filters);
			RegisterRoutes(RouteTable.Routes);

			Mapper.CreateMap<TestItem, TestItemVM>();
			Mapper.CreateMap<Test, TestVM>();

            //Database.SetInitializer(new EntityFrameworkRepositoryInitializer());
            using (var ctx= new EntityFrameworkRepository())
            {
                var foo = ctx.Tests.Count();
            }
		}
	}
}