using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CoffeeShopAuthentication.Startup))]
namespace CoffeeShopAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
