using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component]
internal class FeedUserUpdateProvider : FeedMessageUpdateProviderBase<EleWise.ELMA.Security.Models.IUser>
{
	protected override FeedPriority GetPriorityForRecipient(FeedModel feedModel, EleWise.ELMA.Security.IUser recipient, EleWise.ELMA.Security.Models.IUser entity)
	{
		return FeedPriority.Normal;
	}
}
