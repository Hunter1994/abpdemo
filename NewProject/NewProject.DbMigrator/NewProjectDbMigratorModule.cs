using NewProject.Application.Contracts;
using NewProject.EntityFrameworkCore.DbMigrations;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NewProject.DbMigrator
{
    [DependsOn(typeof(NewProjectApplicationContractsModule),
        typeof(NewProjectEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpAutofacModule))]
    public class NewProjectDbMigratorModule:AbpModule
    {

    }
}
