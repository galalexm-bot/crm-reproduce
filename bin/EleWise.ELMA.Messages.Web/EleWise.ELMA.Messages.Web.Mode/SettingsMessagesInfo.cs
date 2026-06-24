using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.Web.Models;

public class SettingsMessagesInfo
{
	public FeedMessagesSettings Settings { get; set; }

	public string PopupId { get; set; }

	public string RedirectUrl { get; set; }
}
