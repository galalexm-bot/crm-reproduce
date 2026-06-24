using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components;

[Component]
internal class MessageAttachmentNotificationHandler : INotificationMessageHandler, IEventHandler
{
	public void ProcessNotificationToMessage(INotification notification, IMessage message)
	{
		if (notification == null || message == null || !message.ActionUid.HasValue || !message.ObjectUid.HasValue || (message.ActionUid != DefaultEntityActions.CreateGuid && message.ActionUid != ChannelMessageActions.CreateTestMessageGuid))
		{
			return;
		}
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(message.ObjectUid.Value);
		if (typeByUidOrNull == null || !typeof(IChannelMessage).IsAssignableFrom(typeByUidOrNull) || !long.TryParse(message.ObjectId, out var mId))
		{
			return;
		}
		IEntity entity = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			entity = ModelHelper.GetEntity(message.ObjectUid.Value, mId);
		});
		if (!(entity is IChannelMessage))
		{
			return;
		}
		IChannelMessage channelMessage = (IChannelMessage)entity;
		if (channelMessage.Attachments != null && ((ICollection<IAttachment>)channelMessage.Attachments).Count != 0)
		{
			Guid attachUid = InterfaceActivator.UID<IAttachment>();
			IEnumerable<MessageAttachment> second = ((IEnumerable<IAttachment>)channelMessage.Attachments).Select((IAttachment a) => new MessageAttachment(a.File.Name, attachUid, a.Uid.ToString()));
			IMessage message2 = message;
			IEnumerable<MessageAttachment> messageAttachments = message.MessageAttachments;
			message2.MessageAttachments = (messageAttachments ?? Enumerable.Empty<MessageAttachment>()).Union(second).ToArray();
		}
	}
}
