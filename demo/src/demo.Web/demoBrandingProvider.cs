using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace demo.Web
{
    [Dependency(ReplaceServices = true)]
    public class demoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "demo";
    }
}
