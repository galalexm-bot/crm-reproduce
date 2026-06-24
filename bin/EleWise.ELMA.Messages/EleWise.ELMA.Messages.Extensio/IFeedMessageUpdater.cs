using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messages.ExtensionPoints;

public interface IFeedMessageUpdater
{
	bool UpdateMessage(FeedModel messageModel);

	FeedPriority GetPriorityForRecipient(FeedModel messageModel, IUser recipient);
}
