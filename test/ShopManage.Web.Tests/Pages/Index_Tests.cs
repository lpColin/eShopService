using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ShopManage.Pages;

public class Index_Tests : ShopManageWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
