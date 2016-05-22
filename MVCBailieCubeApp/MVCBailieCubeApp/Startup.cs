using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCBailieCubeApp.Startup))]
namespace MVCBailieCubeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
