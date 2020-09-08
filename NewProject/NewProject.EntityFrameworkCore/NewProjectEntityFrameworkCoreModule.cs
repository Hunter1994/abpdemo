using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.MySQL;
using Volo.Abp.Modularity;

namespace NewProject.EntityFrameworkCore
{
    [DependsOn(typeof(AbpEntityFrameworkCoreMySQLModule),
        typeof(NewProjectDomainModule))]
    public class NewProjectEntityFrameworkCoreModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbContextOptions>(options => { options.UseMySQL(); });
        }
    }
}
