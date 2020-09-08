using NewProject.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;

namespace NewProject.HttpApi
{
    [DependsOn(typeof(NewProjectApplicationContractsModule))]
    public class NewProjectHttpApiModule:AbpModule
    {

    }
}
