using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoogleChartExample.Startup))]
namespace GoogleChartExample
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
