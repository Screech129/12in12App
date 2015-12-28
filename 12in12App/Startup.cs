using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_12in12App.Startup))]
namespace _12in12App
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
