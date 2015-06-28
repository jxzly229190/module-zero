using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ModuleZeroSampleProject.WebMpa.Startup))]
namespace ModuleZeroSampleProject.WebMpa
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
