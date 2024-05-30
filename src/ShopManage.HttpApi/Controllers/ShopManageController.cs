using ShopManage.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ShopManage.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ShopManageController : AbpControllerBase
{
    protected ShopManageController()
    {
        LocalizationResource = typeof(ShopManageResource);
    }
}
