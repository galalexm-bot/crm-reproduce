using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Runtime.Settings;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IGlobalSettingsModule
{
	string ModuleNamespace { get; }

	Guid ModuleGuid { get; }

	string ModuleName { get; }

	object Settings { get; set; }

	void SaveSettings();

	void ClearCache();
}
