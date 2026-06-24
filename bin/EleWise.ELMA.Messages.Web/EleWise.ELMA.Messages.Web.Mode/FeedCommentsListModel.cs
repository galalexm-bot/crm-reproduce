using System.Collections.Generic;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Web.Models;

public class FeedCommentsListModel
{
	public IFeedObjectGroupExtension RenderExtension { get; set; }

	public Dictionary<MessageAttachment, object> FeedAttachments { get; set; }

	public FeedModel ParentMessage { get; set; }

	public long ParentChildCount { get; set; }

	public long ParentChildUnreadCount { get; set; }

	public long LoadCommentCount { get; set; }

	public bool IsAjax { get; set; }

	public bool IsSearch { get; set; }

	public FeedCommentsListType CommentsType { get; set; }

	public bool SystemMessage { get; set; }

	public FeedCommentsListModel()
	{
		CommentsType = FeedCommentsListType.Normal;
	}
}
