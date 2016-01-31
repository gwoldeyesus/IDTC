using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IDTC.MVC.Startup))]
namespace IDTC.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
