using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component]
internal class FeedSetReadProvider : IFeedSetReadProvider
{
	public void SetAsReadForObject(Guid objectUid, long objectId, long? recipientId = null)
	{
		IUser recipient = null;
		if (recipientId.HasValue)
		{
			recipient = UserManager.Instance.LoadOrNull(recipientId.Value);
		}
		FeedManager.Instance.SetAsReadForObject(objectUid, objectId, recipient);
	}
}
