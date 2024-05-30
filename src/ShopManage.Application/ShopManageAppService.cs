using System;
using System.Collections.Generic;
using System.Text;
using ShopManage.Localization;
using Volo.Abp.Application.Services;

namespace ShopManage;

/* Inherit your application services from this class.
 */
public abstract class ShopManageAppService : ApplicationService
{
    protected ShopManageAppService()
    {
        LocalizationResource = typeof(ShopManageResource);
    }
}
