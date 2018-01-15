using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PVM_Trading_v1.Startup))]
namespace PVM_Trading_v1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
