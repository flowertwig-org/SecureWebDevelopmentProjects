using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A9_UsingComponentsWithKnownVulnerabilities.Startup))]
namespace A9_UsingComponentsWithKnownVulnerabilities
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
