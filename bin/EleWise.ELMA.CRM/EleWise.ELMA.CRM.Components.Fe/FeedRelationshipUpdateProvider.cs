using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Enums;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.CRM.Components.Feed;

[Component]
internal class FeedRelationshipUpdateProvider : FeedMessageUpdateProviderBase<IRelationship>
{
	protected override FeedPriority GetPriorityForRecipient(FeedModel feedModel, IUser recipient, IRelationship entity)
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
		if (feedModel.CreationAuthor == recipient)
		{
			return FeedPriority.Normal;
		}
		if (((IEnumerable<IRelationshipUser>)entity.RelationshipUsers).Any((IRelationshipUser u) => u.Status == RelationshipUserStatus.Participant && u.User == recipient))
		{
			return FeedPriority.High;
		}
		return FeedPriority.Normal;
	}
}
