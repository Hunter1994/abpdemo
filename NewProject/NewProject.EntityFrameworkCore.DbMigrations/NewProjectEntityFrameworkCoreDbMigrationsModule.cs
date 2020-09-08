using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace NewProject.EntityFrameworkCore.DbMigrations
{
    [DependsOn(typeof(NewProjectEntityFrameworkCoreModule))]
    public class NewProjectEntityFrameworkCoreDbMigrationsModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<NewProjectMigrationsDbContext>();
        }

    }
}
