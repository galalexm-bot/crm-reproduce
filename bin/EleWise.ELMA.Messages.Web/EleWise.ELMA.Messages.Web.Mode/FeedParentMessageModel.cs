using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Web.Models;

public class FeedParentMessageModel
{
	public IFeedObjectGroupExtension RenderExtension;

	public bool CanCreateComment { get; set; }

	public bool CanAddCommentAttachment { get; set; }

	public bool CanCreateQuestion { get; set; }

	public FeedModel Message { get; set; }

	public bool OnlyUnread { get; set; }

	public Dictionary<MessageAttachment, object> FeedAttachments { get; set; }

	public Dictionary<MessageObject, object> FeedMessageObject { get; set; }

	public bool IsFavorite { get; set; }

	public List<FeedMessageInfoModel> FeedMessageInfoAllMessages { get; set; }

	public string PrefixId { get; set; }

	public bool IsSearch { get; set; }

	public List<FeedMessageInfoModel> FeedMessageInfo()
	{
		if (FeedMessageInfoAllMessages == null)
		{
			return new List<FeedMessageInfoModel>();
		}
		return FeedMessageInfoAllMessages.Where((FeedMessageInfoModel m) => m.ActionObjectUid == Message.ActionObjectUid && m.ActionObjectId == Message.ActionObjectId).ToList();
	}
}
