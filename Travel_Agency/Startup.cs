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
        }
    }
}
