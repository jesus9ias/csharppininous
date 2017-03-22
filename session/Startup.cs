using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(session.Startup))]
namespace session
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
