using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A5_SecurityMisconfiguration.Startup))]
namespace A5_SecurityMisconfiguration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
