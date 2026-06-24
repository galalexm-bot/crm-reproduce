using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IProvider : IConfigurableProvider, IDisposable
{
	Guid Uid { get; }

	string Name { get; }

	ProviderSettingsSection CreateSettings();

	void Init();

	void InitComplete();

	string GuidQuerySintaxis(Guid guid);
}
