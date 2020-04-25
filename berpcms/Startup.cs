using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(berpcms.Startup))]
namespace berpcms
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
