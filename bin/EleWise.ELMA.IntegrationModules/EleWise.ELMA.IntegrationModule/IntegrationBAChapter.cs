using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using EleWise.ELMA.BPMApps;

namespace EleWise.ELMA.IntegrationModules.BPMApps;

public sealed class IntegrationBAChapter : BPMAppManifestChapter
{
	[XmlArray("IntegrationModules")]
	[DefaultValue(null)]
	public List<IntegrationBAItem> IntegrationModules { get; set; }
}
