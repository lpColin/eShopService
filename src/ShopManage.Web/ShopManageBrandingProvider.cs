using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace ShopManage.Web;

[Dependency(ReplaceServices = true)]
public class ShopManageBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ShopManage";
}
