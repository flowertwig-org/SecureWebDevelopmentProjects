using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A1_Injection.Startup))]
namespace A1_Injection
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
