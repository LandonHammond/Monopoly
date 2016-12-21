using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Monopoly.Startup))]

namespace Monopoly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            app.MapSignalR();
        }
    }
}
