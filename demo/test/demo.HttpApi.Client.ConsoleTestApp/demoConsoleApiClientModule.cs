using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace demo.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(demoHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class demoConsoleApiClientModule : AbpModule
    {
        
    }
}
