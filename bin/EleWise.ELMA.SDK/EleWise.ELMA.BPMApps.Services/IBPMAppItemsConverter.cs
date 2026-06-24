using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;

namespace EleWise.ELMA.BPMApps.Services;

[ExtensionPoint(ComponentType.All)]
public interface IBPMAppItemsConverter
{
	void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest);

	void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings);
}
