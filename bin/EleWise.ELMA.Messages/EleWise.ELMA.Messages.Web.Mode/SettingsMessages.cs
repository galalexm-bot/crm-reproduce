using System;

namespace EleWise.ELMA.Messages.Web.Models;

[Serializable]
[Obsolete("Класс устарел. Используйте вместо него класс EleWise.ELMA.Messages.Models.FeedMessagesSettings.")]
public class SettingsMessages
{
	public bool PostCommentEnterKey { get; set; }

	public SettingsMessages()
	{
		PostCommentEnterKey = true;
	}
}
