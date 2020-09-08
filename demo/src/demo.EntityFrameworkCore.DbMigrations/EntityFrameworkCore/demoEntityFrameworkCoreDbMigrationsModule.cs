using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace demo.EntityFrameworkCore
{
    [DependsOn(
        typeof(demoEntityFrameworkCoreModule)
        )]
    public class demoEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<demoMigrationsDbContext>();
        }
    }
}
