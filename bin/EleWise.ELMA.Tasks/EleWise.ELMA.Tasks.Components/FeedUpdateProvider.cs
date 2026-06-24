using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component]
internal class FeedUpdateProvider : FeedMessageUpdateProviderBase<ITaskBase>
{
	protected override FeedPriority GetPriorityForRecipient([NotNull] FeedModel feedModel, [NotNull] EleWise.ELMA.Security.IUser user, [NotNull] ITaskBase entity)
	{
		if (feedModel == null)
		{
			throw new ArgumentNullException("feedModel");
		}
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("task");
		}
		if (feedModel.CreationAuthor == user)
		{
			return FeedPriority.Normal;
		}
		if (entity.Executor == user)
		{
			return FeedPriority.Urgent;
		}
		if ((feedModel.ActionUid == TaskBaseActions.CompleteGuid || feedModel.ActionUid == TaskBaseActions.IncompleteGuid) && entity.CreationAuthor == user)
		{
			return FeedPriority.Urgent;
		}
		if (entity is ITask)
		{
			ITask task = (ITask)entity;
			if ((feedModel.ActionUid == TaskBaseActions.CompleteGuid || feedModel.ActionUid == TaskBaseActions.IncompleteGuid) && task.ControlType == TaskControlType.Execution && task.ControlUser == user)
			{
				return FeedPriority.Urgent;
			}
			if (task.ControlUser == user || ((ICollection<EleWise.ELMA.Security.Models.IUser>)task.CurrentControllers).Contains((EleWise.ELMA.Security.Models.IUser)user) || ((ICollection<EleWise.ELMA.Security.Models.IUser>)task.InformTo).Contains((EleWise.ELMA.Security.Models.IUser)user))
			{
				return FeedPriority.High;
			}
		}
		if (entity.CreationAuthor == user)
		{
			return FeedPriority.High;
		}
		return FeedPriority.Normal;
	}

	protected override bool UpdateMessage(FeedModel messageModel, FeedModel parentModel, ITaskBase entity, IEntity parentEntity)
	{
		bool num = base.UpdateMessage(messageModel, parentModel, entity, parentEntity);
		bool flag = UpdateMessage(entity, messageModel);
		bool flag2 = UpdateMessage(parentEntity, parentModel);
		return num || flag || flag2;
	}

	private static bool UpdateMessage(IEntity entity, FeedModel messageModel)
	{
		if (messageModel == null)
		{
			return false;
		}
		if (!(entity is IQuestion question))
		{
			return false;
		}
		List<MessageObject> list = messageModel.MessageObjects.ToList();
		Guid implementationUid = (InterfaceActivator.LoadMetadata(question.RefObject.ObjectType) as EntityMetadata)?.ImplementationUid ?? Guid.Empty;
		MessageObject messageObject = new MessageObject(question.RefObject.Object.ToString(), question.RefObject.ObjectTypeUId, question.RefObject.ObjectId.ToString(CultureInfo.InvariantCulture));
		if (list.All((MessageObject m) => m.TypeUid != messageObject.TypeUid && m.TypeUid != implementationUid))
		{
			list.Add(messageObject);
			messageModel.MessageObjects = new FeedMessageObjectList(list);
			return true;
		}
		return false;
	}
}
