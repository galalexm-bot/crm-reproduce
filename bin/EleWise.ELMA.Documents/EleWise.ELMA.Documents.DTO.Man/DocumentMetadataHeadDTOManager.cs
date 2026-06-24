using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Metadata;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.DTO.Managers;

public class DocumentMetadataHeadDTOManager : DTOManager, IDocumentMetadataHeadDTOManager, IConfigurationService
{
	private readonly RunWithSoftDeletableService runWithSoftDeletableService;

	public DocumentMetadataHeadDTOManager(RunWithSoftDeletableService runWithSoftDeletableService)
	{
		this.runWithSoftDeletableService = runWithSoftDeletableService;
	}

	public virtual DocumentMetadataHeadDTO Save(DocumentMetadataHeadDTO head)
	{
		IDocumentMetadataHead documentMetadataHead = Mapper.Map<DocumentMetadataHeadDTO, IDocumentMetadataHead>(head, AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Create());
		documentMetadataHead.Save();
		documentMetadataHead.Refresh();
		return Mapper.Map<IDocumentMetadataHead, DocumentMetadataHeadDTO>(documentMetadataHead, new DocumentMetadataHeadDTO());
	}

	public virtual List<DocumentMetadataHeadDTO> FindAll(Guid metadataType)
	{
		InstanceOf<IDocumentMetadataHeadFilter> instanceOf = new InstanceOf<IDocumentMetadataHeadFilter>();
		instanceOf.New.MetadataType = metadataType;
		IDocumentMetadataHeadFilter @new = instanceOf.New;
		return (from h in DocumentMetadataHeadManager.Instance.Find(@new, FetchOptions.All)
			select Mapper.Map<IDocumentMetadataHead, DocumentMetadataHeadDTO>(h, new DocumentMetadataHeadDTO())).ToList();
	}

	public virtual DocumentMetadataHeadDTO Create(EntityMetadata metadata, DocumentMetadataGroupDTO group, Guid metadataType)
	{
		InstanceOf<IDocumentMetadataHeadFilter> instanceOf = new InstanceOf<IDocumentMetadataHeadFilter>();
		instanceOf.New.DocumentTypeUid = metadata.Uid;
		IDocumentMetadataHeadFilter @new = instanceOf.New;
		IDocumentMetadataHead documentMetadataHead = AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Find(@new, new FetchOptions(0, 1)).FirstOrDefault();
		if (documentMetadataHead == null)
		{
			InstanceOf<IDocumentMetadataHead> instanceOf2 = new InstanceOf<IDocumentMetadataHead>();
			instanceOf2.New.DocumentTypeUid = metadata.Uid;
			instanceOf2.New.Group = AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Load(group.Id);
			instanceOf2.New.MetadataType = metadataType;
			documentMetadataHead = instanceOf2.New;
			documentMetadataHead.Save();
		}
		return Mapper.Map<IDocumentMetadataHead, DocumentMetadataHeadDTO>(documentMetadataHead, new DocumentMetadataHeadDTO());
	}

	public virtual void Move(DocumentMetadataHeadDTO head, DocumentMetadataGroupDTO group)
	{
		IDocumentMetadataHead documentMetadataHead = AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Load(head.Id);
		IDocumentMetadataGroup documentMetadataGroup2 = (documentMetadataHead.Group = AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Load(group.Id));
		documentMetadataHead.Save();
	}

	public virtual void Delete(DocumentMetadataHeadDTO head)
	{
		IDocumentMetadataHead documentMetadataHead = AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Load(head.Id);
		documentMetadataHead.BeforeDeleteGroup = documentMetadataHead.Group;
		((ICollection<IDocumentMetadataHead>)documentMetadataHead.Group.DocumentTypes).Remove(documentMetadataHead);
		documentMetadataHead.Group = DocumentMetadataGroupManager.Instance.Load(head.MetadataType, DocumentConstants.RecycleMetadataFolderUid);
		documentMetadataHead.Save();
		documentMetadataHead.Delete();
	}

	public virtual void Restore(DocumentMetadataHeadDTO head)
	{
		bool turned = runWithSoftDeletableService.Turned;
		runWithSoftDeletableService.Turned = true;
		try
		{
			InstanceOf<IDocumentMetadataHeadFilter> instanceOf = new InstanceOf<IDocumentMetadataHeadFilter>();
			instanceOf.New.Id = head.Id;
			instanceOf.New.DisableSoftDeletable = true;
			IDocumentMetadataHeadFilter @new = instanceOf.New;
			IDocumentMetadataHead documentMetadataHead = AbstractNHEntityManager<IDocumentMetadataHead, long>.Instance.Find(@new, new FetchOptions(0, 1)).FirstOrDefault();
			IDocumentMetadataGroup documentMetadataGroup = DocumentMetadataGroupManager.Instance.Load(head.MetadataType, DocumentConstants.RecycleMetadataFolderUid);
			((ICollection<IDocumentMetadataHead>)documentMetadataGroup.DocumentTypes).Remove(documentMetadataHead);
			documentMetadataGroup.Save();
			IDocumentMetadataGroup documentMetadataGroup3 = (documentMetadataHead.Group = DocumentMetadataGroupManager.Instance.Load(head.MetadataType, DocumentConstants.RootMetadataFolderUid));
			documentMetadataHead.IsDeleted = false;
			documentMetadataHead.Save();
		}
		finally
		{
			runWithSoftDeletableService.Turned = turned;
		}
	}

	public virtual List<Guid> ActiveUids(Guid metadataUid)
	{
		IDocumentMetadataHeadFilter documentMetadataHeadFilter = InterfaceActivator.Create<IDocumentMetadataHeadFilter>();
		documentMetadataHeadFilter.MetadataType = metadataUid;
		return (from m in DocumentMetadataHeadManager.Instance.Find(documentMetadataHeadFilter, FetchOptions.All)
			select m.DocumentTypeUid).ToList();
	}

	public virtual void SaveControlOnSendingChanges(ControlOnSendingItem item)
	{
		DocumentMetadataHeadManager.Instance.SaveControlOnSendingChanges(item);
	}
}
