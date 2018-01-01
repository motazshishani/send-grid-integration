using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SendGridIntegration.Startup))]
namespace SendGridIntegration
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
