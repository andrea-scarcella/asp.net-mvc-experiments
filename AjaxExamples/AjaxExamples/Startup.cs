using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxExamples.Startup))]
namespace AjaxExamples
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
