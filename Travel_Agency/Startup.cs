using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Travel_Agency.Startup))]
namespace Travel_Agency
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
