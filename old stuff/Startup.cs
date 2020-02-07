using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sg160815MIS4200.Startup))]
namespace sg160815MIS4200
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
