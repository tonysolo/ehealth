using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ehealth.Startup))]
namespace ehealth
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
