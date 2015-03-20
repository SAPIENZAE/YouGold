using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(YouGold.Startup))]
namespace YouGold
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
