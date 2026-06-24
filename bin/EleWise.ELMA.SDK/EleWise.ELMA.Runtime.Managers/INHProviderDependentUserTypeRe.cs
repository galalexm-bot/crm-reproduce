using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Runtime.Managers;

[ExtensionPoint(ComponentType.Server)]
internal interface INHProviderDependentUserTypeRegistrar
{
	Guid ProviderUid { get; }

	void Register();
}
