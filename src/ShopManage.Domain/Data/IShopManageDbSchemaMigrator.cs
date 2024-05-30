using System.Threading.Tasks;

namespace ShopManage.Data;

public interface IShopManageDbSchemaMigrator
{
    Task MigrateAsync();
}
