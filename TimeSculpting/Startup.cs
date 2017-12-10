using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TimeSculpting.Startup))]
namespace TimeSculpting
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
