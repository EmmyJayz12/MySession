using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySessionTest.Startup))]
namespace MySessionTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
