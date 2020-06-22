using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CuisineLove.Startup))]
namespace CuisineLove
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
