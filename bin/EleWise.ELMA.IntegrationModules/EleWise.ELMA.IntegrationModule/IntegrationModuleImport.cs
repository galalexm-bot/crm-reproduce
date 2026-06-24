using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.IntegrationModules.BPMApps;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.Deplpoy.Import;

[Component]
internal sealed class IntegrationModuleImport : MetadataImport
{
	public override void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest)
	{
		if (fakeManifest == null || namedMd == null || !(namedMd.GetType() == typeof(IntegrationModuleMetadata)))
		{
			return;
		}
		BPMAppManifestFakeChapter orCreateChapterByUid = fakeManifest.GetOrCreateChapterByUid(IntegrationsConstants.ExportExtensionUid);
		_ = namedMd.DisplayName;
		if (manifest != null && manifest.Chapters != null)
		{
			BPMAppManifestChapter bPMAppManifestChapter = manifest.Chapters.FirstOrDefault((BPMAppManifestChapter c) => c.Uid == IntegrationsConstants.ExportExtensionUid);
			if (bPMAppManifestChapter != null && bPMAppManifestChapter is IntegrationBAChapter integrationBAChapter && integrationBAChapter.IntegrationModules != null)
			{
				IntegrationBAItem integrationBAItem = integrationBAChapter.IntegrationModules.FirstOrDefault((IntegrationBAItem c) => c.Uid == namedMd.Uid);
				if (integrationBAItem != null && integrationBAItem.ExportData)
				{
					_ = namedMd.DisplayName + " (" + SR.T("с данными") + ')';
				}
			}
		}
		orCreateChapterByUid.GetOrCreateItemByUid(namedMd.Uid, namedMd.DisplayName);
	}

	public override void MergeMetadataSettings(NamedMetadata mdBase, NamedMetadata mdImported, Dictionary<string, string> serviceData)
	{
		IntegrationModuleMetadata integrationModuleMetadata = mdBase as IntegrationModuleMetadata;
		IntegrationModuleMetadata integrationModuleMetadata2 = mdBase as IntegrationModuleMetadata;
		if (integrationModuleMetadata != null && integrationModuleMetadata2 != null)
		{
			integrationModuleMetadata.Prefix = integrationModuleMetadata2.Prefix;
			integrationModuleMetadata.Logging = integrationModuleMetadata2.Logging;
			integrationModuleMetadata.IntegrationModuleType = integrationModuleMetadata2.IntegrationModuleType;
			integrationModuleMetadata.AuthenticationAttemptCount = integrationModuleMetadata2.AuthenticationAttemptCount;
			integrationModuleMetadata.AuthenticationAttemptInterval = integrationModuleMetadata2.AuthenticationAttemptInterval;
			integrationModuleMetadata.Color = integrationModuleMetadata2.Color;
			integrationModuleMetadata.IntegrationModuleActivity = integrationModuleMetadata2.IntegrationModuleActivity;
			integrationModuleMetadata.ExternalEvents = integrationModuleMetadata2.ExternalEvents;
			integrationModuleMetadata.BeforeAuthenticationScriptName = integrationModuleMetadata2.BeforeAuthenticationScriptName;
			integrationModuleMetadata.AfterAuthenticationScriptName = integrationModuleMetadata2.AfterAuthenticationScriptName;
		}
	}
}
