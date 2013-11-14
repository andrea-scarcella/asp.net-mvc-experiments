using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace WebApiWithSSL
{
	public class ApiServiceConfiguration : IApiApplication
	{
		private readonly HttpConfiguration _configuration;
		private static IUnityContainer container;

		public ApiServiceConfiguration(HttpConfiguration configuration)
		{
			_configuration = configuration;
		}
		public void Configure()
		{
			ConfigureRoutes();
			ConfigureDependencies();
		}
		static IUnityContainer Container
		{
			get { return container ?? (container = UnityContainerFactory.CreateConfiguredContainer()); }
		}

		private void ConfigureDependencies()
		{
			Container.LoadConfiguration("container");
			//throw new NotImplementedException();
		}

		private void ConfigureRoutes()
		{
			_configuration.Routes.MapHttpRoute(
				name: "DefaultApi",
				routeTemplate: "api/{controller}/{id}",
				defaults: new { id = RouteParameter.Optional }
			);

		}
	}

}