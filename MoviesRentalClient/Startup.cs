using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MoviesRentalClient.Startup))]
namespace MoviesRentalClient
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
