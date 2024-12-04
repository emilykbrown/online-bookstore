using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(online_bookstore.Startup))]
namespace online_bookstore
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
