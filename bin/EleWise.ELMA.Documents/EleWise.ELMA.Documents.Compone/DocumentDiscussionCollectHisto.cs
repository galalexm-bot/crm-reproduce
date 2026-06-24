using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Audit;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component(Order = 100)]
public class DocumentDiscussionCollectHistoryResolver : IDiscussionCollectHistoryResolver
{
	private DocumentHistoryProfileManager documentHistoryProfileManager;

	public DocumentDiscussionCollectHistoryResolver(DocumentHistoryProfileManager documentHistoryProfileManager)
	{
		this.documentHistoryProfileManager = documentHistoryProfileManager;
	}

	public bool CheckType(Guid actionObject)
	{
		EntityMetadata entityMetadata = (EntityMetadata)InterfaceActivator.LoadMetadata<IDocument>();
		List<ClassMetadata> childClasses = MetadataLoader.GetChildClasses(entityMetadata);
		childClasses.Add(entityMetadata);
		return childClasses.Select((ClassMetadata classMetadata) => classMetadata.Uid).Any((Guid t) => t == actionObject);
	}

	public bool IsCollect(long id, Guid actionObject)
	{
		if (!documentHistoryProfileManager.IsDocumentSupportCustomHistory(actionObject))
		{
			return true;
		}
		if (!documentHistoryProfileManager.ChapterIsVisible(DocumentHistoryChapters.DocumentGeneralHistoryChapterInfo.UID, actionObject))
		{
			return false;
		}
		return documentHistoryProfileManager.ActionIsVisible(DocumentHistoryChapters.DocumentGeneralHistoryChapterInfo.DocumentDiscussionAction.ActionUID, DocumentHistoryChapters.DocumentGeneralHistoryChapterInfo.UID, actionObject);
	}
}
