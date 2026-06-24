using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class FeedComment
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public string Subject { get; set; }

	[DataMember]
	public string Text { get; set; }

	[DataMember]
	public Guid ActionObjectUid { get; set; }

	[DataMember]
	public Guid ActionUid { get; set; }

	[DataMember]
	public long ActionObjectId { get; set; }

	[DataMember]
	public EntityHeader Recipient { get; set; }

	[DataMember]
	public EntityHeader CreationAuthor { get; set; }

	[DataMember]
	public DateTime CreationDate { get; set; }

	[DataMember]
	public DateTime ChangeDate { get; set; }

	[DataMember]
	public int ChildCount { get; set; }

	[DataMember]
	[DefaultValue(FeedPriority.Normal)]
	public FeedPriority Priority { get; set; }

	[DataMember]
	[DefaultValue(false)]
	public bool IsRead { get; set; }

	[DataMember]
	public string RealHash { get; set; }

	[DataMember]
	public string ActionText { get; set; }

	[DataMember]
	public string Url { get; set; }

	[DataMember]
	public MessageAttachmentInfo[] MessageAttachments { get; set; }

	public static FeedComment CreateFeedComment(FeedModel model)
	{
		string actionText = "";
		IEnumerable<IFeedCommentActionNameExtension> enumerable = from p in ComponentManager.Current.GetExtensionPoints<IFeedCommentActionNameExtension>()
			where p.IsSupport(model.ActionObjectUid, model.ActionUid)
			select p;
		if (enumerable != null && enumerable.Any())
		{
			actionText = enumerable.First().ActionName(model);
		}
		return new FeedComment
		{
			Id = model.Id,
			Subject = model.Subject,
			Text = model.Text,
			ActionObjectUid = model.ActionObjectUid,
			ActionObjectId = model.ActionObjectId,
			ActionUid = model.ActionUid,
			CreationAuthor = EntityHeader.FromEntity(model.CreationAuthor),
			CreationDate = model.CreationDate,
			ChangeDate = model.ChangeDate,
			RealHash = model.ChangeDateHash,
			ChildCount = model.ChildCount,
			Priority = (FeedPriority)model.Priority,
			IsRead = model.IsRead,
			ActionText = actionText,
			Url = model.Url,
			MessageAttachments = ((model.MessageAttachments == null) ? null : model.MessageAttachments.Select(MessageAttachmentInfo.CreateMessageAttachmentInfo).ToArray())
		};
	}
}
