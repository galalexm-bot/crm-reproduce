using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Events;
using EleWise.ELMA.History.Components;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using NHibernate;

namespace EleWise.ELMA.Tasks.Audit.History;

public abstract class QuestionHistoryCollectorBaseCachable : BaseHistoryCollectorCachable
{
	private static Guid questionUid = InterfaceActivator.UID<IQuestion>();

	private static QuestionManager questionManager;

	private static QuestionManager QuestionManager => questionManager ?? (questionManager = QuestionManager.Instance);

	public QuestionHistoryCollectorBaseCachable(QuestionHistoryCollectorBase collectorRelated, Guid collectorGuid, Guid entityTypeGuid)
		: base(collectorRelated, collectorGuid, entityTypeGuid, collectorRelated.SupportTypeGuids.FirstOrDefault())
	{
	}

	public override ICriteria GetCriteria(long id, Guid entityTypeUid)
	{
		IUser user = (BaseHistoryCollectorCachable.StateCollecting ? null : questionManager.AuthenticationService.GetCurrentUser<IUser>());
		return QuestionManager.CreateQuestionsCriteria(user, ReferenceOnEntity.Create(entityTypeUid, id));
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(ICriteria criteria)
	{
		return from a in criteria.List<IQuestion>()
			select new HistoryCollectorRelatedModel
			{
				EntityId = a.Id,
				EntityTypeUid = a.TypeUid,
				CollectorGuid = OldCollectorGuid
			};
	}

	public static IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject, Guid collectorGuid, string name)
	{
		return from a in QuestionManager.CreateQuestionsCriteria(QuestionManager.AuthenticationService.GetCurrentUser<IUser>(), ReferenceOnEntity.Create(actionObject, id)).List<IQuestion>()
			select new HistoryCollectorRelatedModel
			{
				EntityId = a.Id,
				EntityTypeUid = a.TypeUid,
				CollectorGuid = collectorGuid,
				AdditionalInformation = questionUid,
				Name = name
			};
	}
}
