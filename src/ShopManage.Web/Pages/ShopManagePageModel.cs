using ShopManage.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ShopManage.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class ShopManagePageModel : AbpPageModel
{
    protected ShopManagePageModel()
    {
        LocalizationResourceType = typeof(ShopManageResource);
    }
}
