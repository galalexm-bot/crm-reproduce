using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Components;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.IntegrationModules.BPMApps;
using EleWise.ELMA.IntegrationModules.Constants;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.IntegrationModules.Deplpoy.Components;

[Component(Order = 1000)]
internal sealed class IntegrationsChapterBuilder : BPMAppChapterBuilder
{
	private readonly IMetadataRuntimeService metadataService;

	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(IntegrationsConstants.ExportExtensionUid, SR.T("Интеграции"), "integration")
	};

	public IntegrationsChapterBuilder(IMetadataRuntimeService metadataService)
	{
		this.metadataService = metadataService;
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, "manifest");
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = IntegrationsConstants.ExportExtensionUid;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUid.ToString(), SR.T("Интеграции"), "integration");
		if (!(manifest.GetChapter(IntegrationsConstants.ExportExtensionUid) is IntegrationBAChapter integrationBAChapter) || integrationBAChapter.IntegrationModules == null || integrationBAChapter.IntegrationModules.Count == 0)
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
			}
			return list;
		}
		ICollection<DeployTreeNode> nodes = GetNodes(integrationBAChapter.IntegrationModules);
		if (parameters.WithEmptyChapters || nodes.Count > 0)
		{
			deployTreeNode.Children.AddRange(nodes.OrderBy((DeployTreeNode n) => n.Text, StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode.Count = nodes.Count;
			list.Add(deployTreeNode);
		}
		return list;
	}

	private ICollection<DeployTreeNode> GetNodes(IEnumerable<BPMAppManifestItem> items)
	{
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		foreach (BPMAppManifestItem item in items)
		{
			try
			{
				if (metadataService.GetMetadata(item.Uid) is NamedMetadata namedMetadata)
				{
					list.Add(CreateNode(namedMetadata.Uid.ToString(), namedMetadata.DisplayName, ""));
				}
			}
			catch (Exception exception)
			{
				Logger.Log.Error("Cannot load metadata with uid " + item.Uid, exception);
			}
		}
		return list;
	}
}
