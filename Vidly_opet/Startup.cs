using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_opet.Startup))]
namespace Vidly_opet
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
