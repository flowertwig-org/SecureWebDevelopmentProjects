using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A2_BrokenAuthenticationAndSessionManagement.Startup))]
namespace A2_BrokenAuthenticationAndSessionManagement
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
