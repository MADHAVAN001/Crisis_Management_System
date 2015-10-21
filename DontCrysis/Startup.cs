using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DontCrysis.Startup))]
namespace DontCrysis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
