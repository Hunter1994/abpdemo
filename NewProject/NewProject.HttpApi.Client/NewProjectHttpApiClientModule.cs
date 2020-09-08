using Microsoft.Extensions.DependencyInjection;
using NewProject.Application.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Modularity;
using Volo.Abp.Http.Client;

namespace NewProject.HttpApi.Client
{
    [DependsOn(typeof(NewProjectApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class NewProjectHttpApiClientModule:AbpModule
    {
        public const string RemoteServiceName = "Default";
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(typeof(NewProjectApplicationContractsModule).Assembly, RemoteServiceName);
        }
    }
}
