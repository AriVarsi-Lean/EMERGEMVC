using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Emerge.Startup))]
namespace Emerge
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
