using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messages.Components.Feed;

public sealed class FeedMessageUpdater : IFeedMessageUpdater
{
	private readonly Func<FeedModel, IEntity, bool> updateFunc;

	private readonly Func<FeedModel, IUser, IEntity, FeedPriority> getPriorityForRecipientFunc;

	private Tuple<Guid, long, IEntity> cachedEntityModel;

	public FeedMessageUpdater([NotNull] Func<FeedModel, IEntity, bool> updateFunc, [NotNull] Func<FeedModel, IUser, IEntity, FeedPriority> getPriorityForRecipientFunc)
	{
		if (updateFunc == null)
		{
			throw new ArgumentNullException("updateFunc");
		}
		if (getPriorityForRecipientFunc == null)
		{
			throw new ArgumentNullException("getRecipientFunc");
		}
		this.updateFunc = updateFunc;
		this.getPriorityForRecipientFunc = getPriorityForRecipientFunc;
	}

	bool IFeedMessageUpdater.UpdateMessage(FeedModel messageModel)
	{
		IEntity arg = InitEntity(messageModel);
		return updateFunc(messageModel, arg);
	}

	private IEntity InitEntity(FeedModel messageModel)
	{
		if (cachedEntityModel != null && cachedEntityModel.Item1 == messageModel.ActionObjectUid && cachedEntityModel.Item2 == messageModel.ActionObjectId)
		{
			return cachedEntityModel.Item3;
		}
		IEntity entity = ModelHelper.GetEntity(messageModel.ActionObjectUid, messageModel.ActionObjectId);
		cachedEntityModel = new Tuple<Guid, long, IEntity>(messageModel.ActionObjectUid, messageModel.ActionObjectId, entity);
		return entity;
	}

	FeedPriority IFeedMessageUpdater.GetPriorityForRecipient(FeedModel messageModel, IUser recipient)
	{
		IEntity arg = InitEntity(messageModel);
		return getPriorityForRecipientFunc(messageModel, recipient, arg);
	}
}
