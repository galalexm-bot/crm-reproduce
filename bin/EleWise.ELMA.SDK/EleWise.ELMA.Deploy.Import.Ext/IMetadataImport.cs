using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IMetadataImport
{
	void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest);

	void MergeMetadataSettings(NamedMetadata mdBase, NamedMetadata mdImported, Dictionary<string, string> serviceData);
}
