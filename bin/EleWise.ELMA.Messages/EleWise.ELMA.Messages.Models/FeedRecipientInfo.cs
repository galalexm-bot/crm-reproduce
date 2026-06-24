using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models;

internal struct FeedRecipientInfo
{
	public IUser User { get; set; }

	public FeedPriority Priority { get; set; }
}
