using Microsoft.EntityFrameworkCore;
using ShopManage.EntityFrameworkCore.Entities;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;

namespace ShopManage.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class ShopManageDbContext :
    AbpDbContext<ShopManageDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion

    public DbSet<AddressInfo> AddressInfos { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Market> Markets { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<ProductCategory> ProductCategorys { get; set; }

    public DbSet<ProductSnap> ProductSnaps { get; set; }

    public DbSet<ProductMapMarket> ProductMapMarkets { get; set; }

    public ShopManageDbContext(DbContextOptions<ShopManageDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        /* Configure your own tables/entities inside here */

        builder.Entity<AddressInfo>(b =>
        {
            b.ToTable(ShopManageConsts.ShopPrefix + "AddressInfos", ShopManageConsts.DbSchema);
            b.ConfigureByConvention();
        });
        builder.Entity<Product>(b =>
        {
            b.ToTable(ShopManageConsts.ShopPrefix + "Products", ShopManageConsts.DbSchema);
            b.ConfigureByConvention();
        });
        builder.Entity<Market>(b =>
        {
            b.ToTable(ShopManageConsts.ShopPrefix + "Markets", ShopManageConsts.DbSchema);
            b.ConfigureByConvention();
        });
        builder.Entity<Order>(b =>
        {
            b.ToTable(ShopManageConsts.ShopPrefix + "Orders", ShopManageConsts.DbSchema);
            b.ConfigureByConvention();
        });
        builder.Entity<ProductCategory>(b =>
        {
            b.ToTable(ShopManageConsts.ShopPrefix + "ProductCategorys", ShopManageConsts.DbSchema);
            b.ConfigureByConvention();
        });
        builder.Entity<ProductSnap>(b =>
        {
            b.ToTable(ShopManageConsts.ShopPrefix + "ProductSnaps", ShopManageConsts.DbSchema);
            b.ConfigureByConvention();
        });
        builder.Entity<ProductMapMarket>(b =>
        {
            b.ToTable(ShopManageConsts.ShopPrefix + "ProductMapMarkets", ShopManageConsts.DbSchema);
            b.ConfigureByConvention();
        });
    }
}
