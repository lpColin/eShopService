using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManage.Data;
using Volo.Abp.DependencyInjection;

namespace ShopManage.EntityFrameworkCore;

public class EntityFrameworkCoreShopManageDbSchemaMigrator
    : IShopManageDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreShopManageDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ShopManageDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ShopManageDbContext>()
            .Database
            .MigrateAsync();
    }
}
