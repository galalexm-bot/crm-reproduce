using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Messages.Extensions;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Audit;

[Component]
public class DiscussionHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	internal const string CollectorUid = "5AC2F8D4-F4B8-495E-B2FE-76BDDA7F78FA";

	private readonly Guid collectorGuid;

	private readonly Guid discussionObjectGuid;

	private EntityService entityService;

	private IEnumerable<IDiscussionAvailableProvider> discussionAvailableProvider;

	private IEnumerable<IDiscussionCollectHistoryResolver> discussionCollectHistoryResolver;

	private ChannelMessageManager channelMessageManager;

	private DiscussionObjectManager discussionObjectManager;

	public const string ParentObject = "PARENTOBJECT";

	public DiscussionHistoryCollector(EntityService entityService, IEnumerable<IDiscussionAvailableProvider> discussionAvailableProvider, IEnumerable<IDiscussionCollectHistoryResolver> discussionCollectHistoryResolver, ChannelMessageManager channelMessageManager, DiscussionObjectManager discussionObjectManager)
	{
		this.entityService = entityService;
		this.discussionAvailableProvider = discussionAvailableProvider;
		this.discussionCollectHistoryResolver = discussionCollectHistoryResolver;
		this.channelMessageManager = channelMessageManager;
		this.discussionObjectManager = discussionObjectManager;
		collectorGuid = new Guid("5AC2F8D4-F4B8-495E-B2FE-76BDDA7F78FA");
		discussionObjectGuid = InterfaceActivator.UID<IDiscussionObject>();
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		if (!base.CanUse(id, actionObject))
		{
			return false;
		}
		IEnumerable<Guid> source = discussionAvailableProvider.SelectMany((IDiscussionAvailableProvider p) => p.TypeUids);
		IDiscussionCollectHistoryResolver discussionCollectHistoryResolver = this.discussionCollectHistoryResolver.FirstOrDefault((IDiscussionCollectHistoryResolver c) => c.CheckType(actionObject));
		if (discussionCollectHistoryResolver != null && !discussionCollectHistoryResolver.IsCollect(id, actionObject))
		{
			return false;
		}
		return source.Any((Guid t) => t == actionObject);
	}

	private IEnumerable<EntityActionEventArgs> CollectDiscussionCommentHistory(IEnumerable<IChannelMessage> messages)
	{
		foreach (IChannelMessage message in messages)
		{
			if (message != null)
			{
				EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(message, message, DefaultEntityActions.CreateGuid);
				if (entityActionEventArgs != null)
				{
					entityActionEventArgs.ActionAuthor = message.CreationAuthor;
					entityActionEventArgs.ActionDate = (message.CreationDate.HasValue ? message.CreationDate.Value : DateTime.Now);
					yield return entityActionEventArgs;
				}
			}
		}
	}

	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		return relatedEventList.Where((EntityActionEventArgs relatedEvent) => relatedEvent.Action != null && relatedEvent.New != null && relatedEvent.Metadata != null && relatedEvent.Action.Uid == DefaultEntityActions.CreateGuid && relatedObjectList.Any((HistoryCollectorRelatedModel relatedObject) => relatedObject.CollectorGuid == collectorGuid && relatedEvent.Metadata.Uid == relatedObject.EntityTypeUid && (long)relatedEvent.New.GetId() == relatedObject.EntityId)).ToList();
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		return from a in discussionObjectManager.GetDiscussionObjects(id, actionObject)
			select new HistoryCollectorRelatedModel
			{
				EntityId = a.Id,
				EntityTypeUid = discussionObjectGuid,
				CollectorGuid = collectorGuid
			};
	}
}
