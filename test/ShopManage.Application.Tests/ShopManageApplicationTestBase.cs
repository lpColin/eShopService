using Volo.Abp.Modularity;

namespace ShopManage;

public abstract class ShopManageApplicationTestBase<TStartupModule> : ShopManageTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
