using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using Microsoft.Web.WebPages.OAuth;
using OAuthMVC.Models;

namespace OAuthMVC
{
	public static class AuthConfig
	{
		public static void RegisterAuth()
		{
			// To let users of this site log in using their accounts from other sites such as Microsoft, Facebook, and Twitter,
			// you must update this site. For more information visit http://go.microsoft.com/fwlink/?LinkID=252166

			//OAuthWebSecurity.RegisterMicrosoftClient(
			//    clientId: "",
			//    clientSecret: "");

			//OAuthWebSecurity.RegisterTwitterClient(
			//    consumerKey: "",
			//    consumerSecret: "");

			string appid = "";
			string appsecret = "";
			//appid = WebConfigurationManager.AppSettings["FacebookAppId"].ToString();
			//appsecret = WebConfigurationManager.AppSettings["FacebookAppSecret"].ToString();

			System.Configuration.Configuration rootWebConfig1 =
				System.Web.Configuration.WebConfigurationManager.OpenWebConfiguration("~/");
			if (rootWebConfig1.AppSettings.Settings.Count > 0)
			{
				System.Configuration.KeyValueConfigurationElement FacebookAppSetting =
					rootWebConfig1.AppSettings.Settings["FacebookAppId"];
				if (FacebookAppSetting != null)
				{
					appid = FacebookAppSetting.Value;
				}

				else
				{ Console.WriteLine("No FacebookAppId application string"); }

				FacebookAppSetting =
					rootWebConfig1.AppSettings.Settings["FacebookAppSecret"];
				if (FacebookAppSetting != null)
				{
					appsecret = FacebookAppSetting.Value;
				}

				else
				{ Console.WriteLine("No FacebookAppSecret application string"); }
			}


			OAuthWebSecurity.RegisterFacebookClient(
				appId: appid,
				appSecret: appsecret);

			//OAuthWebSecurity.RegisterGoogleClient();
		}
	}
}
