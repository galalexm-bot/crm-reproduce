using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Documents.Components.Feed;

[Component]
internal class DocumentVersionFeedUpdateProvider : FeedMessageUpdateProviderBase<IDocumentVersion>
{
	protected override IEntity GetParentEntity(IDocumentVersion tEntity, FeedModel model)
	{
		if (tEntity.Document == null)
		{
			return tEntity;
		}
		return tEntity.Document;
	}

	protected override FeedPriority GetPriorityForRecipient(FeedModel feedModel, IUser recipient, IDocumentVersion entity)
	{
		if (feedModel == null)
		{
			throw new ArgumentNullException("feedModel");
		}
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		return FeedPriority.Urgent;
	}
}
