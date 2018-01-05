using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inżynierka_v3.Startup))]
namespace Inżynierka_v3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
