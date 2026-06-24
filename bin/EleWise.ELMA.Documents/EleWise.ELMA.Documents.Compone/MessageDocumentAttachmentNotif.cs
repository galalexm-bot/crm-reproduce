using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Documents.Models.Messages;
using EleWise.ELMA.Events;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Notifications;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
internal class MessageDocumentAttachmentNotificationHandler : INotificationMessageHandler, IEventHandler
{
	public void ProcessNotificationToMessage(INotification notification, IMessage message)
	{
		if (notification == null || message == null || !message.ActionUid.HasValue || !message.ObjectUid.HasValue || message.ActionUid != DefaultEntityActions.CreateGuid)
		{
			return;
		}
		Type typeByUidOrNull = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(message.ObjectUid.Value);
		if (typeByUidOrNull == null || !typeof(IChannelMessageDocumentsExtension).IsAssignableFrom(typeByUidOrNull) || !long.TryParse(message.ObjectId, out var mId))
		{
			return;
		}
		IEntity entity = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			entity = ModelHelper.GetEntity(message.ObjectUid.Value, mId);
		});
		if (!(entity is IChannelMessageDocumentsExtension))
		{
			return;
		}
		IChannelMessageDocumentsExtension channelMessageDocumentsExtension = (IChannelMessageDocumentsExtension)entity;
		if (channelMessageDocumentsExtension.Attachments != null && ((ICollection<IAttachment>)channelMessageDocumentsExtension.Attachments).Count != 0)
		{
			Guid attachUid = InterfaceActivator.UID<IDocumentAttachment>();
			IEnumerable<MessageAttachment> second = from a in (IEnumerable<IDocumentAttachment>)channelMessageDocumentsExtension.DocumentAttachments
				where a.Document != null
				select new MessageAttachment(a.Document.Name, attachUid, a.Uid.ToString());
			IMessage message2 = message;
			IEnumerable<MessageAttachment> messageAttachments = message.MessageAttachments;
			message2.MessageAttachments = (messageAttachments ?? Enumerable.Empty<MessageAttachment>()).Union(second).ToArray();
		}
	}
}
