using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GABENweb.Startup))]
namespace GABENweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
