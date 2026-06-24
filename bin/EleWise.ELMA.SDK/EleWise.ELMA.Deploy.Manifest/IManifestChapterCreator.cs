using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;

namespace EleWise.ELMA.Deploy.Manifest;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IManifestChapterCreator
{
	void Resolve(ConfigExportSettings settings, ExportedObjectsDescription desc);
}
