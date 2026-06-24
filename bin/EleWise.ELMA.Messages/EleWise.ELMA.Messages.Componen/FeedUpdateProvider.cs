using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component]
internal class FeedUpdateProvider : IFeedMessageUpdateProvider
{
	public bool CanUpdateMessage(Guid actionType, Guid objectType, long objectId)
	{
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectType);
		if (typeByUidOrNull == null)
		{
			return false;
		}
		if (!typeof(IChannelMessage).IsAssignableFrom(typeByUidOrNull))
		{
			return false;
		}
		if (actionType == DefaultEntityActions.CreateGuid || actionType == ChannelMessageActions.AddRecipientsGuid)
		{
			return true;
		}
		return false;
	}

	public IFeedMessageUpdater GetMessageUpdater(Guid actionType, Guid objectType, long objectId)
	{
		return new FeedMessageUpdater(UpdateMessage, GetPriorityForRecipient);
	}

	private static FeedPriority GetPriorityForRecipient(FeedModel feedModel, EleWise.ELMA.Security.IUser user, IEntity entity)
	{
		if (!(entity is IChannelMessage channelMessage))
		{
			return FeedPriority.Normal;
		}
		if (((IEnumerable<EleWise.ELMA.Security.IUser>)channelMessage.Recipients).Contains(user))
		{
			return FeedPriority.Urgent;
		}
		if (((IEnumerable<IInformationChannel>)channelMessage.Channels).Any())
		{
			ChannelMessageManager service = ChannelMessageManager.Instance;
			return ((IEnumerable<IInformationChannel>)channelMessage.Channels).Select((IInformationChannel ch) => service.GetPriority((EleWise.ELMA.Security.Models.IUser)user, ch)).Max();
		}
		return FeedPriority.Normal;
	}

	private static bool UpdateMessage(FeedModel messageModel, IEntity entity)
	{
		if (!(entity is IChannelMessage channelMessage))
		{
			return false;
		}
		FeedMessageRecipientList messageRecipients = GetMessageRecipients(channelMessage.Parent ?? channelMessage);
		if (channelMessage.Parent != null)
		{
			FeedModel parentFeedModel = GetParentFeedModel(channelMessage.Parent);
			parentFeedModel.ObjectRecipients = messageRecipients;
			messageModel.Parent = parentFeedModel;
			messageModel.IsParent = false;
			if (channelMessage.CreationAuthor != null)
			{
				messageModel.CreationAuthor = channelMessage.CreationAuthor;
			}
			messageModel.ParentObjectUid = parentFeedModel.ActionObjectUid;
			messageModel.ParentObjectId = parentFeedModel.ActionObjectId;
			messageModel.MessageAttachments = GetMessageAttachments(channelMessage);
			messageModel.MessageObjects = GetMessageObjects(channelMessage);
		}
		else
		{
			FeedModel parentFeedModel2 = GetParentFeedModel(channelMessage);
			if (messageModel.ActionUid == ChannelMessageActions.AddRecipientsGuid)
			{
				messageModel.Text = SR.T("Вы добавлены в получатели сообщения");
				parentFeedModel2.ObjectRecipients = messageRecipients;
				messageModel.Parent = parentFeedModel2;
				messageModel.IsParent = false;
				messageModel.ParentObjectUid = parentFeedModel2.ActionObjectUid;
				messageModel.ParentObjectId = parentFeedModel2.ActionObjectId;
			}
			else
			{
				messageModel.Parent = null;
				messageModel.IsParent = true;
				if (parentFeedModel2.CreationAuthor != null)
				{
					messageModel.CreationAuthor = parentFeedModel2.CreationAuthor;
				}
				messageModel.ParentObjectId = parentFeedModel2.ActionObjectId;
				messageModel.ParentObjectUid = parentFeedModel2.ActionObjectUid;
				messageModel.Subject = parentFeedModel2.Subject;
				messageModel.Text = parentFeedModel2.Text;
				messageModel.TextHtml = parentFeedModel2.TextHtml;
				messageModel.MessageAttachments = parentFeedModel2.MessageAttachments;
				messageModel.MessageObjects = parentFeedModel2.MessageObjects;
				messageModel.ChangeDate = parentFeedModel2.ChangeDate;
				messageModel.CreationDate = parentFeedModel2.CreationDate;
				messageModel.Url = parentFeedModel2.Url;
			}
			messageModel.ObjectRecipients = messageRecipients;
		}
		return true;
	}

	private static FeedModel GetParentFeedModel(IChannelMessage message)
	{
		Guid typeUid = message.TypeUid;
		return new FeedModel
		{
			ActionObjectId = message.Id,
			ActionObjectUid = typeUid,
			ActionUid = DefaultEntityActions.CreateGuid,
			ParentObjectId = message.Id,
			ParentObjectUid = typeUid,
			ChangeDate = DateTime.Now,
			CreationAuthor = message.CreationAuthor,
			CreationDate = (message.CreationDate ?? DateTime.Now),
			IsParent = true,
			Subject = message.Subject,
			Text = message.FullMessage,
			MessageObjects = GetMessageObjects(message),
			MessageAttachments = GetMessageAttachments(message),
			Url = "/Messages/ChannelMessage/Info/" + message.Id
		};
	}

	private static FeedMessageRecipientList GetMessageRecipients(IChannelMessage message)
	{
		List<MessageRecipient> list = new List<MessageRecipient>();
		list.AddRange(((IEnumerable<EleWise.ELMA.Security.Models.IUser>)message.Recipients).Select(FeedUpdateProviderHelper.RecipientFromUser));
		list.AddRange(((IEnumerable<IInformationChannel>)message.Channels).Select(FeedUpdateProviderHelper.RecipientFromChannel));
		return new FeedMessageRecipientList((list.Count > 0) ? list.ToArray() : null);
	}

	private static FeedMessageObjectList GetMessageObjects(IChannelMessage message)
	{
		List<MessageObject> list = new List<MessageObject>();
		if (message.DiscussionObjects != null && ((ICollection<IDiscussionObject>)message.DiscussionObjects).Count != 0)
		{
			list.AddRange(((IEnumerable<IDiscussionObject>)message.DiscussionObjects).Select(FromDiscussions));
		}
		if (!list.Any())
		{
			return null;
		}
		return new FeedMessageObjectList(list.ToArray());
	}

	private static FeedMessageAttachmentList GetMessageAttachments(IChannelMessage message)
	{
		IEnumerable<IFeedMessageAttachmentProvider> serviceNotNull = Locator.GetServiceNotNull<IEnumerable<IFeedMessageAttachmentProvider>>();
		List<MessageAttachment> list = new List<MessageAttachment>();
		list.AddRange(serviceNotNull.SelectMany((IFeedMessageAttachmentProvider p) => p.GetMessageAtachments(message)));
		return new FeedMessageAttachmentList((list.Count > 0) ? list.ToArray() : null);
	}

	private static MessageObject FromDiscussions(IDiscussionObject arg)
	{
		return new MessageObject(ModelHelper.GetEntity(arg.ObjectType, arg.ObjectId).ToString(), arg.ObjectType, arg.ObjectId.ToString(CultureInfo.InvariantCulture));
	}
}
