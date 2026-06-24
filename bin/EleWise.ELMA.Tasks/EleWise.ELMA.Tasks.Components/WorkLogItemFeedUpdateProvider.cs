using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Component]
internal class WorkLogItemFeedUpdateProvider : FeedMessageUpdateProviderBase<IWorkLogItem>
{
	protected override FeedPriority GetPriorityForRecipient([NotNull] FeedModel feedModel, [NotNull] IUser user, [NotNull] IWorkLogItem entity)
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
		if (entity.CreationAuthor == user || entity.Harmonizator == user)
		{
			return FeedPriority.Urgent;
		}
		return FeedPriority.Normal;
	}
}
