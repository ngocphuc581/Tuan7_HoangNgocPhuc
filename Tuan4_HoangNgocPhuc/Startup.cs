using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tuan4_HoangNgocPhuc.Startup))]
namespace Tuan4_HoangNgocPhuc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
