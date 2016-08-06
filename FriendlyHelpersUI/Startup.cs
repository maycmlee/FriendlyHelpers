using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FriendlyHelpersUI.Startup))]
namespace FriendlyHelpersUI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
