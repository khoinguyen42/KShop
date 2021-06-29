using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KShop.Startup))]
namespace KShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
