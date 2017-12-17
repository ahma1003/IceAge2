using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IceAge.Startup))]
namespace IceAge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
