using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Modules;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IModuleEvents
{
	void Installing(IWebModuleUnit module);

	void Installed(IWebModuleUnit module);

	void Enabling(IWebModuleUnit module);

	void Enabled(IWebModuleUnit module);

	void Disabling(IWebModuleUnit module);

	void Disabled(IWebModuleUnit module);

	void Uninstalling(IWebModuleUnit module);

	void Uninstalled(IWebModuleUnit module);
}
