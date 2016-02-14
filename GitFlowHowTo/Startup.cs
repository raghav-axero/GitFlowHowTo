using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GitFlowHowTo.Startup))]
namespace GitFlowHowTo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
