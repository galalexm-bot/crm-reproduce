using System;
using System.Linq;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Web.Components;

namespace EleWise.ELMA.Messages.Components.Hubs;

public class FeedCommentModel
{
	public bool IsRead { get; set; }

	public long ActionObjectId { get; }

	public Guid ActionObjectUid { get; }

	public string Text { get; }

	public FeedUserModel User { get; set; }

	public string Date { get; }

	public string ChangeDateHash { get; }

	public MessageAttachment[] MessageAttachments { get; }

	public FeedCommentModel(FeedModel model)
	{
		ActionObjectId = model.Parent.ActionObjectId;
		ActionObjectUid = model.ActionObjectUid;
		Date = FormattingHelper.DateToString(model.ChangeDate);
		Text = model.TextHtml;
		User = new FeedUserModel(model.CreationAuthor);
		ChangeDateHash = model.ChangeDateHash;
		IsRead = false;
		MessageAttachments = model.MessageAttachments.ToArray();
	}
}
