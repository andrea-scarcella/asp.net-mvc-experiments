using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Byob.Web.Startup))]
namespace Byob.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
