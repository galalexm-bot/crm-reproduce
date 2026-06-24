using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

[Component]
internal class AnswerFeedUpdateProvider : FeedMessageUpdateProviderBase<IAnswer>
{
	protected override FeedPriority GetPriorityForRecipient([NotNull] FeedModel feedModel, [NotNull] IUser user, [NotNull] IAnswer entity)
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
			throw new ArgumentNullException("answer");
		}
		if (feedModel.CreationAuthor == user)
		{
			return FeedPriority.Urgent;
		}
		if (entity.Question.CreationAuthor == user)
		{
			return FeedPriority.Urgent;
		}
		return FeedPriority.Normal;
	}

	protected override IEntity GetParentEntity(IAnswer tEntity, FeedModel model)
	{
		return tEntity.Question;
	}

	protected override bool UpdateMessage(FeedModel messageModel, FeedModel parentModel, IAnswer entity, IEntity parentEntity)
	{
		bool num = base.UpdateMessage(messageModel, parentModel, entity, parentEntity);
		bool flag = UpdateMessage(parentEntity, parentModel);
		if (messageModel != null && entity != null && entity.Attachments != null && ((ICollection<IAttachment>)entity.Attachments).Count > 0)
		{
			messageModel.MessageAttachments = FeedMessageUpdateProviderBase<IAnswer>.GetMessageAttachments(entity);
		}
		return num || flag;
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
