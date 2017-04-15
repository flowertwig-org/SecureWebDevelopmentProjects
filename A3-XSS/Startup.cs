using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A3_XSS.Startup))]
namespace A3_XSS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
