using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Audit;

[Component]
internal class DocumentVersionsHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	internal const string CollectorUid = "9A41C69F-81AB-4C7E-8C7F-4B89E98705CE";

	private readonly Guid collectorGuid;

	private DocumentHistoryProfileManager documentHistoryProfileManager;

	private DocumentVersionManager documentVersionManager;

	private EntityActionHistoryManager entityActionHistoryManager;

	public DocumentVersionsHistoryCollector(DocumentHistoryProfileManager documentHistoryProfileManager, DocumentVersionManager documentVersionManager, EntityActionHistoryManager entityActionHistoryManager)
	{
		this.documentHistoryProfileManager = documentHistoryProfileManager;
		this.documentVersionManager = documentVersionManager;
		this.entityActionHistoryManager = entityActionHistoryManager;
		collectorGuid = new Guid("9A41C69F-81AB-4C7E-8C7F-4B89E98705CE");
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		if (!base.CanUse(id, actionObject))
		{
			return false;
		}
		if (!documentHistoryProfileManager.ChapterIsVisible(DocumentHistoryChapters.DocumentVersionHistoryChapterInfo.UID, actionObject))
		{
			return false;
		}
		if (!(MetadataServiceContext.Service.GetMetadata(actionObject) is EntityMetadata entityMetadata))
		{
			return false;
		}
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
		baseClasses.Add(entityMetadata);
		Guid documentTypeUid = InterfaceActivator.UID<IDocument>();
		return baseClasses.Any((ClassMetadata c) => c.Uid == documentTypeUid);
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		if (relatedEventList == null || relatedObjectList == null)
		{
			return Enumerable.Empty<EntityActionEventArgs>();
		}
		bool customHistorySupport = documentHistoryProfileManager.IsDocumentSupportCustomHistory(actionObject);
		return relatedEventList.Where((EntityActionEventArgs relatedEvent) => relatedEvent.Metadata != null && relatedEvent.New != null && relatedEvent.Action != null && (!customHistorySupport || documentHistoryProfileManager.ActionIsVisible(relatedEvent.Action.Uid, DocumentHistoryChapters.DocumentVersionHistoryChapterInfo.UID, actionObject)) && relatedObjectList.Any((HistoryCollectorRelatedModel relatedObject) => relatedObject.CollectorGuid == collectorGuid && relatedEvent.Metadata.Uid == relatedObject.EntityTypeUid && (long)relatedEvent.New.GetId() == relatedObject.EntityId));
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		Guid typeGuid = InterfaceActivator.UID<IDocumentVersion>();
		return from a in documentVersionManager.GetDocumentVersionIdCriteria(id).List<long>()
			select new HistoryCollectorRelatedModel
			{
				CollectorGuid = collectorGuid,
				EntityId = a,
				EntityTypeUid = typeGuid
			};
	}
}
