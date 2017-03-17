using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstMVC.Startup))]
namespace FirstMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
