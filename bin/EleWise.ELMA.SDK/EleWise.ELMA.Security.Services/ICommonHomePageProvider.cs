using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Security.Services;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICommonHomePageProvider : IModuleSettingsPageProvider
{
}
