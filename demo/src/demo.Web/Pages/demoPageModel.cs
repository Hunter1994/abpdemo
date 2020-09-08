using demo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace demo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class demoPageModel : AbpPageModel
    {
        protected demoPageModel()
        {
            LocalizationResourceType = typeof(demoResource);
        }
    }
}