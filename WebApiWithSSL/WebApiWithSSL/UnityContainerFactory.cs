using Microsoft.Practices.Unity;

namespace WebApiWithSSL
{
	internal class UnityContainerFactory
	{
		public static IUnityContainer CreateConfiguredContainer()
		{
			return new UnityContainer();

		}
	}
}