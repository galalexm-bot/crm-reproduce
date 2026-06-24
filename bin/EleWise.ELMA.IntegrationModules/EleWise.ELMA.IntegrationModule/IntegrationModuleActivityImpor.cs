using System.Collections.Generic;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.IntegrationModules.Metadata;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.IntegrationModules.Deplpoy.Import;

internal class IntegrationModuleActivityImport : MetadataImport
{
	public override void CreateFakeChapter(NamedMetadata namedMd, BPMAppFakeManifest fakeManifest, BPMAppManifest manifest)
	{
	}

	public override void MergeMetadataSettings(NamedMetadata mdBase, NamedMetadata mdImported, Dictionary<string, string> serviceData)
	{
		IntegrationModuleActivityMetadata integrationModuleActivityMetadata = mdBase as IntegrationModuleActivityMetadata;
		IntegrationModuleActivityMetadata integrationModuleActivityMetadata2 = mdBase as IntegrationModuleActivityMetadata;
		if (integrationModuleActivityMetadata != null && integrationModuleActivityMetadata2 != null)
		{
			integrationModuleActivityMetadata.OnEnterScript = integrationModuleActivityMetadata2.OnEnterScript;
			integrationModuleActivityMetadata.OnCompleteScript = integrationModuleActivityMetadata2.OnCompleteScript;
			integrationModuleActivityMetadata.OnEnter = integrationModuleActivityMetadata2.OnEnter;
			integrationModuleActivityMetadata.OnComplete = integrationModuleActivityMetadata2.OnComplete;
		}
	}
}
