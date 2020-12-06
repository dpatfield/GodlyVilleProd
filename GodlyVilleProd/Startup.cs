using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GodlyVilleProd.Startup))]
namespace GodlyVilleProd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
