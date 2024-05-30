using Xunit;

namespace ShopManage.EntityFrameworkCore;

[CollectionDefinition(ShopManageTestConsts.CollectionDefinitionName)]
public class ShopManageEntityFrameworkCoreCollection : ICollectionFixture<ShopManageEntityFrameworkCoreFixture>
{

}
