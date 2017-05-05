using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(hw1.Startup))]
namespace hw1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
