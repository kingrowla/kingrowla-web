using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(kingrowla.Startup))]
namespace kingrowla
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
