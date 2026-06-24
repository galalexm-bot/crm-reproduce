using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.Web)]
public interface IModulePermissionsPageProvider : IModuleSettingsPageProvider
{
}
