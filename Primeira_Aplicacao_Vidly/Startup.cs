using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Primeira_Aplicacao_Vidly.Startup))]
namespace Primeira_Aplicacao_Vidly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
