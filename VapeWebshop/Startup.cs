using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VapeWebshop.Startup))]
namespace VapeWebshop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
