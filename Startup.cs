using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LASTP.Startup))]
namespace LASTP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
