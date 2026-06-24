using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;
using EleWise.ELMA.BPMApps;

namespace EleWise.ELMA.Documents.BPMApps;

public class DocumentsBAChapter : BPMAppManifestChapter
{
	[XmlArray("DocumentTypes")]
	[DefaultValue(null)]
	public List<DocumentTypeBAItem> DocumentTypes { get; set; }

	[XmlArray("DocumentProfiles")]
	[DefaultValue(null)]
	public List<DocumentTypeBAItem> DocumentProfiles { get; set; }
}
