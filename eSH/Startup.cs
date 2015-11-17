using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eSH.Startup))]
namespace eSH
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
