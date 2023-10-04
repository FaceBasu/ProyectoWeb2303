using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PRUEBA_USUARIOS.Startup))]
namespace PRUEBA_USUARIOS
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
