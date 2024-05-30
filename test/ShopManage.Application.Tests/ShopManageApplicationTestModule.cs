using Volo.Abp.Modularity;

namespace ShopManage;

[DependsOn(
    typeof(ShopManageApplicationModule),
    typeof(ShopManageDomainTestModule)
)]
public class ShopManageApplicationTestModule : AbpModule
{

}
