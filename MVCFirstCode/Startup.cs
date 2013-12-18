using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFirstCode.Startup))]
namespace MVCFirstCode
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
