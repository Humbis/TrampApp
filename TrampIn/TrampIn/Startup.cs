using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TrampIn.Startup))]
namespace TrampIn
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
