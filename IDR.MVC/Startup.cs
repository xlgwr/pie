using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IDR.MVC.Startup))]
namespace IDR.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
