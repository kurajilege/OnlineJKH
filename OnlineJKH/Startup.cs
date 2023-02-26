using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OnlineJKH.Startup))]
namespace OnlineJKH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
