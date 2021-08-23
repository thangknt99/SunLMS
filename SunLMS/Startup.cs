using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunLMS.Startup))]
namespace SunLMS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
