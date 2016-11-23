using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PraiaFacil.Startup))]
namespace PraiaFacil
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
