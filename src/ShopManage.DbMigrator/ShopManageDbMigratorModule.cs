using ShopManage.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ShopManage.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ShopManageEntityFrameworkCoreModule),
    typeof(ShopManageApplicationContractsModule)
    )]
public class ShopManageDbMigratorModule : AbpModule
{
}
