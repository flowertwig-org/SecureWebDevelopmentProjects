using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A6_SensitiveDataExposure.Startup))]
namespace A6_SensitiveDataExposure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
