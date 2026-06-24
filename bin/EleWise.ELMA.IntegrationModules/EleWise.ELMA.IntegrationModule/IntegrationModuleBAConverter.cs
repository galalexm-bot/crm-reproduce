using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.Deplpoy.Export;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.IntegrationModules.BPMApps;

[Component]
internal sealed class IntegrationModuleBAConverter : IBPMAppItemsConverter
{
	private readonly Guid exportIntegrationsUid = new Guid("{8A8EB433-74AC-4F46-8F05-C047926F924F}");

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		Contract.ArgumentNotNull(bpmAppManifest, "bpmAppManifest");
		Contract.ArgumentNotNull(settings, "settings");
		if (settings.CustomSettings.TryGetValue(IntegrationsConstants.ExportExtensionUid, out var value) && value is IntegrationsExportSettings integrationsExportSettings && integrationsExportSettings.Integrations != null && integrationsExportSettings.Integrations.Count != 0)
		{
			IntegrationBAChapter integrationBAChapter = new IntegrationBAChapter
			{
				Uid = IntegrationsConstants.ExportExtensionUid
			};
			bpmAppManifest.SetFlag(exportIntegrationsUid, value: true);
			integrationBAChapter.IntegrationModules = integrationsExportSettings.Integrations.Select((KeyValuePair<Guid, bool> p) => new IntegrationBAItem
			{
				Uid = p.Key,
				ExportData = p.Value
			}).ToList();
			bpmAppManifest.SetChapter(integrationBAChapter);
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		Contract.ArgumentNotNull(bpmAppManifest, "bpmAppManifest");
		Contract.ArgumentNotNull(settings, "settings");
		IntegrationsExportSettings integrationsExportSettings = new IntegrationsExportSettings();
		if (bpmAppManifest.GetChapter(IntegrationsConstants.ExportExtensionUid) is IntegrationBAChapter integrationBAChapter && integrationBAChapter.IntegrationModules != null)
		{
			integrationsExportSettings.Integrations = new SerializableDictionary<Guid, bool>();
			foreach (IntegrationBAItem integrationModule in integrationBAChapter.IntegrationModules)
			{
				integrationsExportSettings.Integrations[integrationModule.Uid] = integrationModule.ExportData;
			}
		}
		settings.CustomSettings[IntegrationsConstants.ExportExtensionUid] = integrationsExportSettings;
	}
}
