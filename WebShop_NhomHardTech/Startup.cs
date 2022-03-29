using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebShop_NhomHardTech.Startup))]
namespace WebShop_NhomHardTech
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
