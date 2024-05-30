using Volo.Abp.Settings;

namespace ShopManage.Settings;

public class ShopManageSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ShopManageSettings.MySetting1));
    }
}
