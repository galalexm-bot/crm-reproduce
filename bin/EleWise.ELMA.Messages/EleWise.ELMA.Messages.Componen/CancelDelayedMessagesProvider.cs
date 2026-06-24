using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Components;

[Component]
internal class CancelDelayedMessagesProvider : IFeedSetReadProvider
{
	private IMessageManager _messageManager;

	public CancelDelayedMessagesProvider(IMessageManager messageManager)
	{
		if (messageManager == null)
		{
			throw new ArgumentNullException("messageManager");
		}
		_messageManager = messageManager;
	}

	public void SetAsReadForObject(Guid objectUid, long objectId, long? recipientId = null)
	{
		_messageManager.CancelSend(objectUid, objectId.ToString(), recipientId);
	}
}
