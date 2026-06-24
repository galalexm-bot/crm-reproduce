using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents.Components.Feed;

[Component]
internal class DocumentFeedUpdateProvider : FeedMessageUpdateProviderBase<IDocument>
{
	protected override FeedPriority GetPriorityForRecipient(FeedModel feedModel, IUser recipient, IDocument entity)
	{
		if (feedModel == null)
		{
			throw new ArgumentNullException("feedModel");
		}
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		if (entity == null)
		{
			throw new ArgumentNullException("entity");
		}
		return FeedPriority.Urgent;
	}
}
