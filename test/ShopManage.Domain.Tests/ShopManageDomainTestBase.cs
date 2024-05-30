using Volo.Abp.Modularity;

namespace ShopManage;

/* Inherit from this class for your domain layer tests. */
public abstract class ShopManageDomainTestBase<TStartupModule> : ShopManageTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
