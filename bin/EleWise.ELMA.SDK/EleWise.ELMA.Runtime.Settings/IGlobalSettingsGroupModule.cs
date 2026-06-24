using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Runtime.Settings;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IGlobalSettingsGroupModule : IGlobalSettingsModule
{
	string GroupName { get; }
}
