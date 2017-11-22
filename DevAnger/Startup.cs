using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(DevAnger.Startup))]

namespace DevAnger
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
