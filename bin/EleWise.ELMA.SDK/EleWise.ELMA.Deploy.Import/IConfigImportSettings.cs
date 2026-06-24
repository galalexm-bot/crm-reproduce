using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Packaging.ElmaStoreManifest;

namespace EleWise.ELMA.Deploy.Import;

public interface IConfigImportSettings : IImportSettings
{
	string FileName { get; set; }

	ElmaStoreComponentManifest Manifest { get; set; }

	BPMAppFakeManifest FakeManifest { get; }
}
