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
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Audit;

[Component]
internal class DocumentLinksHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	internal const string CollectorUid = "58664D6D-48D1-42A2-AF08-AF41CE4D3C32";

	private readonly Guid collectorGuid = new Guid("58664D6D-48D1-42A2-AF08-AF41CE4D3C32");

	private DocumentHistoryProfileManager documentHistoryProfileManager;

	private DocumentLinkManager documentLinkManager;

	private EntityActionHistoryManager entityActionHistoryManager;

	public DocumentLinksHistoryCollector(DocumentHistoryProfileManager documentHistoryProfileManager, DocumentLinkManager documentLinkManager, EntityActionHistoryManager entityActionHistoryManager)
	{
		this.documentHistoryProfileManager = documentHistoryProfileManager;
		this.documentLinkManager = documentLinkManager;
		this.entityActionHistoryManager = entityActionHistoryManager;
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		if (!base.CanUse(id, actionObject))
		{
			return false;
		}
		if (!documentHistoryProfileManager.ChapterIsVisible(DocumentHistoryChapters.DocumentLinksHistoryChapterInfo.UID, actionObject))
		{
			return false;
		}
		if (!(MetadataServiceContext.Service.GetMetadata(actionObject) is EntityMetadata entityMetadata))
		{
			return false;
		}
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
		baseClasses.Add(entityMetadata);
		Guid typeUid = InterfaceActivator.UID<IDocument>();
		return baseClasses.Any((ClassMetadata c) => c.Uid == typeUid);
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		if (relatedEventList == null || relatedObjectList == null)
		{
			return Enumerable.Empty<EntityActionEventArgs>();
		}
		Type docLinkType = InterfaceActivator.TypeOf(typeof(IDocumentLink));
		bool documentCustomHistory = documentHistoryProfileManager.IsDocumentSupportCustomHistory(actionObject);
		return relatedEventList.Where((EntityActionEventArgs c) => c.Metadata != null && c.New != null && c.EntityType == docLinkType && c.Action != null && (!documentCustomHistory || documentHistoryProfileManager.ActionIsVisible(c.Action.Uid, DocumentHistoryChapters.DocumentLinksHistoryChapterInfo.UID, actionObject)) && relatedObjectList.Any((HistoryCollectorRelatedModel relatedObject) => relatedObject.CollectorGuid == collectorGuid && c.Metadata.Uid == relatedObject.EntityTypeUid && (long)c.New.GetId() == relatedObject.EntityId));
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		Guid typeGuid = InterfaceActivator.UID<IDocumentLink>();
		ICriteria allLinksCriteria = documentLinkManager.GetAllLinksCriteria(id);
		allLinksCriteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() });
		return from a in allLinksCriteria.List<long>()
			select new HistoryCollectorRelatedModel
			{
				CollectorGuid = collectorGuid,
				EntityId = a,
				EntityTypeUid = typeGuid
			};
	}
}
