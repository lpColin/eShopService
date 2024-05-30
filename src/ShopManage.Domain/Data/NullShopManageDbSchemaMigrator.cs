using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ShopManage.Data;

/* This is used if database provider does't define
 * IShopManageDbSchemaMigrator implementation.
 */
public class NullShopManageDbSchemaMigrator : IShopManageDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
