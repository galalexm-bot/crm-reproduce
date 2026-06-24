using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.History.Components;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Messages.Audit.History;

[Component]
internal sealed class DiscussionHistoryCollectorCachable : BaseHistoryCollectorCachable
{
	private const string CollectorUid = "9F0F2BAC-41C2-498F-A648-396A3FFC81FF";

	private static readonly Guid DiscussionObjectGuid = InterfaceActivator.UID<IDiscussionObject>();

	private static readonly Guid EntityTypeUid = InterfaceActivator.UID<IEntity>();

	private readonly DiscussionObjectManager discussionObjectManager;

	public override Guid OldCollectorGuid => new Guid("5AC2F8D4-F4B8-495E-B2FE-76BDDA7F78FA");

	public DiscussionHistoryCollectorCachable(DiscussionHistoryCollector collector, DiscussionObjectManager discussionObjectManager)
		: base(collector, new Guid("9F0F2BAC-41C2-498F-A648-396A3FFC81FF"), DiscussionObjectGuid, EntityTypeUid)
	{
		this.discussionObjectManager = discussionObjectManager;
	}

	public override ICriteria GetCriteria(long id, Guid entityTypeUid)
	{
		return discussionObjectManager.GetDiscussionCriteria(id, entityTypeUid).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() });
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(ICriteria criteria)
	{
		return from a in criteria.List<long>()
			select new HistoryCollectorRelatedModel
			{
				EntityId = a,
				CollectorGuid = OldCollectorGuid,
				EntityTypeUid = DiscussionObjectGuid
			};
	}
}
