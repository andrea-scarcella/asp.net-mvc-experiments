using System;

namespace WebApiWithSSL.Infrastructure.Logging
{
	//factory method pattern implementation
	public static class LogManager
	{
		//http://stackoverflow.com/a/166477/741695
		public static ILogger GetLogger(Type type)
		{
			return new Log4Net(type);
		}
	}
}
