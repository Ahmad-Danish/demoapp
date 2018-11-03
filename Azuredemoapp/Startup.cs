using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Azuredemoapp.Startup))]
namespace Azuredemoapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
