using Owin;
using Microsoft.Owin;

[assembly: OwinStartup(typeof(ASPNetIdentity.Startup))]
namespace ASPNetIdentity
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
