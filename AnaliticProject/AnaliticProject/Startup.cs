using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnaliticProject.Startup))]
namespace AnaliticProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
