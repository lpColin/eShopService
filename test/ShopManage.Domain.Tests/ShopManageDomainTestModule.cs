using Volo.Abp.Modularity;

namespace ShopManage;

[DependsOn(
    typeof(ShopManageDomainModule),
    typeof(ShopManageTestBaseModule)
)]
public class ShopManageDomainTestModule : AbpModule
{

}
