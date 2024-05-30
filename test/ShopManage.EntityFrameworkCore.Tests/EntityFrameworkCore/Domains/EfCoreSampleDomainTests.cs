using ShopManage.Samples;
using Xunit;

namespace ShopManage.EntityFrameworkCore.Domains;

[Collection(ShopManageTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<ShopManageEntityFrameworkCoreTestModule>
{

}
