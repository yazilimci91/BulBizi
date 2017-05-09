using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bulbizi.Startup))]
namespace Bulbizi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
