using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DamLevelReport.Startup))]
namespace DamLevelReport
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
