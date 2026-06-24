using System;
using System.Xml.Serialization;
using EleWise.ELMA.IntegrationModules.Metadata;

namespace EleWise.ELMA.IntegrationModules.Models;

[Serializable]
[XmlRoot("IMExternalEvent")]
public class ExternalEvent
{
	[XmlElement("Uid")]
	public Guid Uid { get; set; }

	[XmlElement("Name")]
	public string Name { get; set; }

	[XmlElement("ScriptName")]
	public string ScriptName { get; set; }

	[XmlIgnore]
	public IntegrationModuleMetadata IntegrationModuleMetadata { get; set; }
}
