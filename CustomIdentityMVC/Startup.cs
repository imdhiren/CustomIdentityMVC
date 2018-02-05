using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomIdentityMVC.Startup))]

namespace CustomIdentityMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
