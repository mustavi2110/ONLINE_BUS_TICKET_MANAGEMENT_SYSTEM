using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bus_Ticket_2.Startup))]
namespace Bus_Ticket_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
