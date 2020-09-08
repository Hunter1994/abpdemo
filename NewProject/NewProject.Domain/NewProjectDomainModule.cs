using NewProject.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace NewProject.Domain
{
    [DependsOn(typeof(NewProjectDomainSharedModule),
        typeof(AbpAutoMapperModule))]
    public class NewProjectDomainModule : AbpModule
    {
    }
}
