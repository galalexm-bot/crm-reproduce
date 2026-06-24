using System;
using System.Collections.Generic;
using AutoMapper;
using EleWise.ELMA.Documents.DTO.Models;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.DTO.Managers;

public class DocumentMetadataGroupDTOManager : DTOManager, IDocumentMetadataGroupDTOManager, IConfigurationService
{
	private readonly RunWithSoftDeletableService runWithSoftDeletableService;

	public DocumentMetadataGroupDTOManager(RunWithSoftDeletableService runWithSoftDeletableService)
	{
		this.runWithSoftDeletableService = runWithSoftDeletableService;
	}

	public virtual DocumentMetadataGroupDTO LoadRootGroup(Guid metadataType)
	{
		return Mapper.Map<IDocumentMetadataGroup, DocumentMetadataGroupDTO>(DocumentMetadataGroupManager.Instance.Load(metadataType, DocumentConstants.RootMetadataFolderUid), new DocumentMetadataGroupDTO());
	}

	public virtual DocumentMetadataGroupDTO LoadRecycleGroup(Guid metadataType)
	{
		bool turned = runWithSoftDeletableService.Turned;
		runWithSoftDeletableService.Turned = true;
		try
		{
			return Mapper.Map<IDocumentMetadataGroup, DocumentMetadataGroupDTO>(DocumentMetadataGroupManager.Instance.Load(metadataType, DocumentConstants.RecycleMetadataFolderUid), new DocumentMetadataGroupDTO());
		}
		finally
		{
			runWithSoftDeletableService.Turned = turned;
		}
	}

	public virtual DocumentMetadataGroupDTO Save(DocumentMetadataGroupDTO group)
	{
		IDocumentMetadataGroup documentMetadataGroup = Mapper.Map<DocumentMetadataGroupDTO, IDocumentMetadataGroup>(group, AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Create());
		documentMetadataGroup?.Save();
		return Mapper.Map<IDocumentMetadataGroup, DocumentMetadataGroupDTO>(documentMetadataGroup, new DocumentMetadataGroupDTO());
	}

	public virtual void SaveGroupName(long id, string name)
	{
		IDocumentMetadataGroup documentMetadataGroup = AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.LoadOrNull(id);
		if (documentMetadataGroup != null)
		{
			documentMetadataGroup.Name = name;
			documentMetadataGroup.Save();
		}
	}

	public virtual DocumentMetadataGroupDTO Load(long id)
	{
		return Mapper.Map<IDocumentMetadataGroup, DocumentMetadataGroupDTO>(AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Load(id), new DocumentMetadataGroupDTO());
	}

	public virtual void Delete(DocumentMetadataGroupDTO group)
	{
		IDocumentMetadataGroup documentMetadataGroup = AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.LoadOrNull(group.Id);
		if (documentMetadataGroup != null)
		{
			((ICollection<IDocumentMetadataGroup>)documentMetadataGroup.ParentGroup.Groups).Remove(documentMetadataGroup);
			documentMetadataGroup.ParentGroup = null;
			documentMetadataGroup.Save();
			documentMetadataGroup.Delete();
		}
	}

	public virtual bool HasDocumentsTypesInGroup(DocumentMetadataGroupDTO group)
	{
		return FindDocumentType(group);
	}

	protected bool FindDocumentType(DocumentMetadataGroupDTO group)
	{
		bool flag = false;
		if (group.DocumentTypes.Count > 0)
		{
			return true;
		}
		foreach (DocumentMetadataGroupDTO group2 in group.Groups)
		{
			if (!flag)
			{
				flag = FindDocumentType(group2);
				continue;
			}
			return flag;
		}
		return flag;
	}

	public virtual bool ValidateMove(DocumentMetadataGroupDTO group, DocumentMetadataGroupDTO destGroup, out string error)
	{
		error = string.Empty;
		if (group.Id == destGroup.Id)
		{
			error = SR.T("Нельзя переместить папку в себя");
			return false;
		}
		if (DocumentMetadataGroupManager.Instance.IsChildGroup(group.Id, destGroup.Id))
		{
			error = SR.T("Нельзя переместить папку в себя");
			return false;
		}
		return true;
	}

	public virtual void Move(DocumentMetadataGroupDTO group, DocumentMetadataGroupDTO destGroup)
	{
		if (group.Id != destGroup.Id)
		{
			group.ParentGroupId = destGroup.Id;
			IDocumentMetadataGroup documentMetadataGroup = AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Load(group.Id);
			IDocumentMetadataGroup documentMetadataGroup3 = (documentMetadataGroup.ParentGroup = AbstractNHEntityManager<IDocumentMetadataGroup, long>.Instance.Load(destGroup.Id));
			documentMetadataGroup.Save();
		}
	}
}
