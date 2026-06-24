using System;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component(Type = ComponentType.Server)]
public class DocumentHeadsCreatorHandler : IInitHandler
{
	public void Init()
	{
	}

	public void InitComplete()
	{
		IDocumentMetadataGroup group = DocumentMetadataGroupManager.Instance.Load(new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}"), DocumentConstants.RootMetadataFolderUid);
		if (group == null)
		{
			return;
		}
		(from m in Locator.GetService<IMetadataRuntimeService>()?.GetMetadataList().OfType<DocumentMetadata>()
			where m.Type == EntityMetadataType.Interface
			select m).ToList().ForEach(delegate(DocumentMetadata d)
		{
			InstanceOf<IDocumentMetadataHeadFilter> instanceOf = new InstanceOf<IDocumentMetadataHeadFilter>();
			instanceOf.New.DocumentTypeUid = d.Uid;
			IDocumentMetadataHeadFilter @new = instanceOf.New;
			if (!AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Exists(@new))
			{
				InstanceOf<IDocumentMetadataHead> instanceOf2 = new InstanceOf<IDocumentMetadataHead>();
				instanceOf2.New.DocumentTypeUid = d.Uid;
				instanceOf2.New.Group = group;
				instanceOf2.New.MetadataType = new Guid("{C40FD1D3-F5D9-4323-9E51-42EBFA77E6DC}");
				instanceOf2.New.Save();
			}
		});
	}
}
