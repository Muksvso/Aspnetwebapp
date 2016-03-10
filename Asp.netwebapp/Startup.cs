using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Asp.netwebapp.Startup))]
namespace Asp.netwebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
