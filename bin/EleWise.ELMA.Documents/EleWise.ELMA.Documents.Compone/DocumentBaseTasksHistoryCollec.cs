using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Audit;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Audit;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class DocumentBaseTasksHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	internal const string CollectorUid = "EFA288CF-B451-4641-BA2F-208D1B7F6BE9";

	private readonly Guid collectorGuid;

	private static DocumentHistoryProfileManager documentHistoryProfileManager;

	private static ISecurityService securityService;

	private static IAuditManager auditManager;

	private static TaskQuestionHistoryCollector taskQuestionHistoryCollector;

	private static EntityActionHistoryManager entityActionHistoryManager;

	private readonly AttachmentsTaskBaseManager AttachmentsTaskBaseManager;

	private static DocumentHistoryProfileManager DocumentHistoryProfileManager => documentHistoryProfileManager ?? (documentHistoryProfileManager = DocumentHistoryProfileManager.Instance);

	private static ISecurityService SecurityService => securityService ?? (securityService = Locator.GetServiceNotNull<ISecurityService>());

	private static IAuditManager AuditManager => auditManager ?? (auditManager = Locator.GetServiceNotNull<IAuditManager>());

	private static TaskQuestionHistoryCollector TaskQuestionHistoryCollector => taskQuestionHistoryCollector ?? (taskQuestionHistoryCollector = Locator.GetServiceNotNull<TaskQuestionHistoryCollector>());

	private static EntityActionHistoryManager EntityActionHistoryManager => entityActionHistoryManager ?? (entityActionHistoryManager = EntityActionHistoryManager.Instance);

	public DocumentBaseTasksHistoryCollector(AttachmentsTaskBaseManager attachmentsTaskBaseManager)
	{
		AttachmentsTaskBaseManager = attachmentsTaskBaseManager;
		collectorGuid = new Guid("EFA288CF-B451-4641-BA2F-208D1B7F6BE9");
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		if (!base.CanUse(id, actionObject))
		{
			return false;
		}
		if (!DocumentHistoryProfileManager.ChapterIsVisible(DocumentHistoryChapters.DocumentTaskHistoryChapterInfo.UID, actionObject))
		{
			return false;
		}
		if (!(MetadataServiceContext.Service.GetMetadata(actionObject) is EntityMetadata entityMetadata))
		{
			return false;
		}
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
		baseClasses.Add(entityMetadata);
		Guid documentUid = InterfaceActivator.UID<IDocument>();
		return baseClasses.Any((ClassMetadata c) => c.Uid == documentUid);
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		if (relatedEventList == null || relatedObjectList == null)
		{
			yield break;
		}
		Guid typeUid = InterfaceActivator.UID<IAttachmentsTaskBase>();
		bool historyVisibleCheck = documentHistoryProfileManager.IsDocumentSupportCustomHistory(actionObject);
		IAuditObject obj = AuditManager.GetObject(InterfaceActivator.UID<IDocument>());
		foreach (HistoryCollectorRelatedModel relatedObject in relatedObjectList)
		{
			if (relatedObject.CollectorGuid != collectorGuid)
			{
				continue;
			}
			if (typeUid.Equals(relatedObject.AdditionalInformation as Guid?))
			{
				IEnumerable<EntityActionEventArgs> enumerable = (historyVisibleCheck ? CollectHistoryForTaskRelated(relatedObject, actionObject, relatedEventList) : CollectHistoryForTaskRelatedWithoutCustomHistoryCheck(relatedObject, relatedEventList, obj));
				foreach (EntityActionEventArgs item in enumerable)
				{
					yield return item;
				}
				continue;
			}
			IEnumerable<EntityActionEventArgs> enumerable2 = (historyVisibleCheck ? CollectHistoryForTaskQuestionRelated(relatedObject, actionObject, relatedEventList) : CollectHistoryForTaskQuestionRelatedWithoutCustomHistoryCheck(relatedObject, relatedEventList));
			foreach (EntityActionEventArgs item2 in enumerable2)
			{
				yield return item2;
			}
		}
	}

	public static IEnumerable<EntityActionEventArgs> CollectHistoryForTaskRelated(HistoryCollectorRelatedModel task, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList)
	{
		IAuditObject obj = AuditManager.GetObject(InterfaceActivator.UID<IDocument>());
		foreach (EntityActionEventArgs relatedEvent in relatedEventList)
		{
			if (relatedEvent.Metadata != null && relatedEvent.Metadata.Uid == task.EntityTypeUid && relatedEvent.New != null && (long)relatedEvent.New.GetId() == task.EntityId && DocumentHistoryProfileManager.ActionIsVisible(relatedEvent.Action.Uid, DocumentHistoryChapters.DocumentTaskHistoryChapterInfo.UID, actionObject))
			{
				relatedEvent.Object = obj;
				relatedEvent.ExtendedProperties["EventType"] = "FromTask";
				yield return relatedEvent;
			}
		}
	}

	public static IEnumerable<EntityActionEventArgs> CollectHistoryForTaskQuestionRelated(HistoryCollectorRelatedModel taskQuestion, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList)
	{
		if (!DocumentHistoryProfileManager.ActionIsVisible(DocumentHistoryChapters.DocumentTaskHistoryChapterInfo.DocumentTaskQuestionCreateAction.ActionUID, DocumentHistoryChapters.DocumentTaskHistoryChapterInfo.UID, actionObject))
		{
			yield break;
		}
		IEnumerable<EntityActionEventArgs> enumerable = QuestionHistoryCollectorBase.CollectHistoryForRelatedObjects(taskQuestion.EntityId, taskQuestion.EntityTypeUid, relatedEventList);
		if (enumerable == null)
		{
			yield break;
		}
		foreach (EntityActionEventArgs item in enumerable)
		{
			item.ExtendedProperties["Theme"] = SR.T("Задан вопрос к задаче \"{0}\"", SR.T(taskQuestion.Name));
			yield return item;
		}
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		List<HistoryCollectorRelatedModel> result = new List<HistoryCollectorRelatedModel>();
		SecurityService.RunWithElevatedPrivilegies(delegate
		{
			Type type = InterfaceActivator.TypeOf<IAttachmentsTaskBase>();
			Guid guid = InterfaceActivator.UID<IAttachmentsTaskBase>();
			ICriteria tasksByDocumentCriteria = AttachmentsTaskBaseManager.GetTasksByDocumentCriteria(id);
			tasksByDocumentCriteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(NHibernateHelper.GetCriteriaTypeUidPropertyName(type)), "EntityTypeUid").Add((IProjection)(object)Projections.Property("Subject"), "Name")
				.Add((IProjection)(object)Projections.Id(), "EntityId") });
			foreach (HistoryCollectorRelatedModel item in tasksByDocumentCriteria.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(HistoryCollectorRelatedModel))).List<HistoryCollectorRelatedModel>())
			{
				item.CollectorGuid = collectorGuid;
				item.AdditionalInformation = guid;
				result.Add(item);
				result.AddRange(QuestionHistoryCollectorBase.RelatedObjects(item.EntityId, item.EntityTypeUid, collectorGuid, item.Name));
			}
		});
		return result;
	}

	internal static IEnumerable<EntityActionEventArgs> CollectHistoryForTaskRelatedWithoutCustomHistoryCheck(HistoryCollectorRelatedModel task, IEnumerable<EntityActionEventArgs> relatedEventList, IAuditObject obj)
	{
		foreach (EntityActionEventArgs relatedEvent in relatedEventList)
		{
			if (relatedEvent.Metadata != null && relatedEvent.Metadata.Uid == task.EntityTypeUid && relatedEvent.New != null && (long)relatedEvent.New.GetId() == task.EntityId)
			{
				relatedEvent.Object = obj;
				relatedEvent.ExtendedProperties["EventType"] = "FromTask";
				yield return relatedEvent;
			}
		}
	}

	internal static IEnumerable<EntityActionEventArgs> CollectHistoryForTaskQuestionRelatedWithoutCustomHistoryCheck(HistoryCollectorRelatedModel taskQuestion, IEnumerable<EntityActionEventArgs> relatedEventList)
	{
		IEnumerable<EntityActionEventArgs> enumerable = QuestionHistoryCollectorBase.CollectHistoryForRelatedObjects(taskQuestion.EntityId, taskQuestion.EntityTypeUid, relatedEventList);
		if (enumerable == null)
		{
			yield break;
		}
		foreach (EntityActionEventArgs item in enumerable)
		{
			item.ExtendedProperties["Theme"] = SR.T("Задан вопрос к задаче \"{0}\"", SR.T(taskQuestion.Name));
			yield return item;
		}
	}
}
