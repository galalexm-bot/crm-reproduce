using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Models;

internal class FeedLoadSettings
{
	public IUser Recipient { get; set; }

	public string ChangeDateHash { get; set; }

	public FeedPriority Priority { get; set; }

	public int MaxCount { get; set; }

	public int MaxChildCount { get; set; }

	public FeedLoadSettings()
	{
		FeedMessagesSettings feedMessagesSettings = BaseMessageManager.Instance.LoadSettings();
		MaxCount = feedMessagesSettings.MessagesCount;
		MaxChildCount = feedMessagesSettings.CommentsCount;
		Priority = FeedPriority.Normal;
	}
}
