using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FuelTankWebUI.Startup))]
namespace FuelTankWebUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
