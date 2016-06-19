using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Gestão_de_Projetos.Startup))]
namespace Gestão_de_Projetos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
