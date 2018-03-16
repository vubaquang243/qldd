using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(QLDD_2018.Startup))]
namespace QLDD_2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
