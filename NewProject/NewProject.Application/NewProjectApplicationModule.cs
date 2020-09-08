using NewProject.Application.Contracts;
using NewProject.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace NewProject.Application
{
    [DependsOn(typeof(AbpAutoMapperModule),
          typeof(NewProjectApplicationContractsModule),
        typeof(NewProjectDomainModule),
        typeof(AbpDddApplicationModule))]
    public class NewProjectApplicationModule:AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options => {
                options.AddMaps<NewProjectApplicationModule>();
            });
        }

    }
}
