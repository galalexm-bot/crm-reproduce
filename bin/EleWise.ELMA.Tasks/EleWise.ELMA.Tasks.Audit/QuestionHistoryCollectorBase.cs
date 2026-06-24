using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit;

public abstract class QuestionHistoryCollectorBase : BaseEntityActionHistoryCollectorRelated
{
	private Guid? questionHistoryCollectorGuid;

	private static Guid questionUid = InterfaceActivator.UID<IQuestion>();

	private static QuestionManager questionManager;

	private static QuestionManager QuestionManager => questionManager ?? (questionManager = QuestionManager.Instance);

	public virtual IEnumerable<Guid> SupportTypeGuids => Enumerable.Empty<Guid>();

	public virtual Guid CollectorGuid
	{
		get
		{
			Guid? guid = questionHistoryCollectorGuid;
			if (!guid.HasValue)
			{
				Guid? guid2 = (questionHistoryCollectorGuid = new Guid("710F5459-176C-458B-8BB9-030A90A0E684"));
				return guid2.Value;
			}
			return guid.GetValueOrDefault();
		}
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		if (!base.CanUse(id, actionObject))
		{
			return false;
		}
		if (!(MetadataServiceContext.Service.GetMetadata(actionObject) is EntityMetadata entityMetadata))
		{
			return false;
		}
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
		baseClasses.Add(entityMetadata);
		return baseClasses.Any((ClassMetadata c) => SupportTypeGuids.Contains(c.Uid));
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		return relatedEventList.Where((EntityActionEventArgs relatedEvent) => relatedEvent.Metadata != null && relatedEvent.New != null && relatedEvent.Action != null && relatedEvent.Action.Uid == DefaultEntityActions.CreateGuid && relatedObjectList.Any((HistoryCollectorRelatedModel relatedObject) => relatedObject.CollectorGuid == CollectorGuid && relatedEvent.Metadata.Uid == relatedObject.EntityTypeUid && (long)relatedEvent.New.GetId() == relatedObject.EntityId));
	}

	public static IEnumerable<EntityActionEventArgs> CollectHistoryForRelatedObjects(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList)
	{
		return relatedEventList.Where((EntityActionEventArgs relatedEvent) => relatedEvent.Metadata != null && relatedEvent.New != null && relatedEvent.Action != null && relatedEvent.Action.Uid == DefaultEntityActions.CreateGuid && relatedEvent.Metadata.Uid == actionObject && (long)relatedEvent.New.GetId() == id);
	}

	public static IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject, Guid collectorGuid, string name = null)
	{
		return from a in QuestionManager.GetQuestions(id, actionObject)
			select new HistoryCollectorRelatedModel
			{
				EntityId = a.Id,
				EntityTypeUid = a.TypeUid,
				CollectorGuid = collectorGuid,
				AdditionalInformation = questionUid,
				Name = name
			};
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		return from a in QuestionManager.GetQuestions(id, actionObject)
			select new HistoryCollectorRelatedModel
			{
				EntityId = a.Id,
				EntityTypeUid = a.TypeUid,
				CollectorGuid = CollectorGuid
			};
	}
}
