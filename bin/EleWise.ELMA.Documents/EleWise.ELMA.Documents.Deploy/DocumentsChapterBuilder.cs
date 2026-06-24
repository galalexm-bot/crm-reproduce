using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Components;
using EleWise.ELMA.Deploy.Models;
using EleWise.ELMA.Documents.BPMApps;
using EleWise.ELMA.Documents.Deploy.Export;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Deploy.Components;

[Component(Order = 300)]
internal sealed class DocumentsChapterBuilder : MetadataHeaderChapterBuilder
{
	protected override IEnumerable<BPMAppChapterBuilderTemplate> BuilderTemplate => new List<BPMAppChapterBuilderTemplate>
	{
		new BPMAppChapterBuilderTemplate(DocumentsExportConsts.ExportExtensionUid, SR.T("Типы документов"), "document_type")
	};

	public DocumentsChapterBuilder(IMetadataRuntimeService metadataService, MetadataItemHeaderManager metadataItemHeaderManager)
		: base(metadataService, metadataItemHeaderManager)
	{
	}

	public override IEnumerable<DeployTreeNode> GetChapterNodes(BPMAppManifest manifest, IChapterParameters parameters)
	{
		Contract.ArgumentNotNull(manifest, "manifest");
		List<DeployTreeNode> list = new List<DeployTreeNode>();
		Guid exportExtensionUid = DocumentsExportConsts.ExportExtensionUid;
		DeployTreeNode deployTreeNode = CreateNode(exportExtensionUid.ToString(), SR.T("Типы документов"), "document_type");
		if (!(manifest.GetChapter(DocumentsExportConsts.ExportExtensionUid) is DocumentsBAChapter documentsBAChapter) || documentsBAChapter.DocumentTypes == null || documentsBAChapter.DocumentTypes.Count == 0)
		{
			if (parameters.WithEmptyChapters)
			{
				list.Add(deployTreeNode);
			}
			return list;
		}
		ICollection<DeployTreeNode> nodes = GetNodes(documentsBAChapter.DocumentTypes);
		if (parameters.WithEmptyChapters || nodes.Count > 0)
		{
			deployTreeNode.Children.AddRange(nodes.OrderBy((DeployTreeNode n) => n.Text, StringComparer.CurrentCultureIgnoreCase));
			deployTreeNode.Count = nodes.Count;
			list.Add(deployTreeNode);
		}
		return list;
	}
}
