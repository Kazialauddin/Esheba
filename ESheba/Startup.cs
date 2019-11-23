using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ESheba.Startup))]
namespace ESheba
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
