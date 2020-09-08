using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace demo.Web
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddApplication<demoWebModule>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.InitializeApplication();
        }
    }
}
