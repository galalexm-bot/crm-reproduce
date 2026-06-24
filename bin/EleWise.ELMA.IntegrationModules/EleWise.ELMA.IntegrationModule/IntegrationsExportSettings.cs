using System;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.IntegrationModules.Deplpoy.Export;

[Serializable]
public class IntegrationsExportSettings
{
	public SerializableDictionary<Guid, bool> Integrations { get; set; }

	public IntegrationsExportSettings()
	{
		Integrations = new SerializableDictionary<Guid, bool>();
	}
}
