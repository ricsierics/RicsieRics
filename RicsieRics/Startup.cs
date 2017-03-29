using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RicsieRics.Startup))]
namespace RicsieRics
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
