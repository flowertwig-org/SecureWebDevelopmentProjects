using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A4_InsecureDirectObjectReferences.Startup))]
namespace A4_InsecureDirectObjectReferences
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
