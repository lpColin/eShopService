using ShopManage.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ShopManage.Permissions;

public class ShopManagePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ShopManagePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ShopManagePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ShopManageResource>(name);
    }
}
