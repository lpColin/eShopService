using Microsoft.AspNetCore.Builder;
using ShopManage;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ShopManageWebTestModule>();

public partial class Program
{
}
