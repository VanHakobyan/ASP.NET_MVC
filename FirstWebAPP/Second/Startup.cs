using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Second.Startup))]
namespace Second
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
