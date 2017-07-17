using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ImageTookit.Startup))]
namespace ImageTookit
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
