using NewProject.Domain.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace NewProject.Application.Contracts
{
    [DependsOn(typeof(AbpDddApplicationContractsModule),
        typeof(NewProjectDomainSharedModule))]
    public class NewProjectApplicationContractsModule: AbpModule
    {
    }
}
