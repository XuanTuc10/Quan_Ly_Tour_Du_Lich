using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Quan_Ly_Tour_Du_Lich.Startup))]
namespace Quan_Ly_Tour_Du_Lich
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
