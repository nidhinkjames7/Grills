using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(grills.Startup))]
namespace grills
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
