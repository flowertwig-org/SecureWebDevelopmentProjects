using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(A8_CrossSiteRequestForgery.Startup))]
namespace A8_CrossSiteRequestForgery
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
