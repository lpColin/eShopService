using ShopManage.Samples;
using Xunit;

namespace ShopManage.EntityFrameworkCore.Applications;

[Collection(ShopManageTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<ShopManageEntityFrameworkCoreTestModule>
{

}
