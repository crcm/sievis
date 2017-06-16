using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebIndiceSaludInt.Startup))]
namespace WebIndiceSaludInt
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
