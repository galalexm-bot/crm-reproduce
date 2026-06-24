using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class FeedPost
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
	[DefaultValue(true)]
	public bool HasUnreadChild { get; set; }

	[DataMember]
	public LastCommentsData LastComments { get; set; }

	[DataMember]
	public MessageRecipientInfo[] ObjectRecipients { get; set; }

	[DataMember]
	public MessageAttachmentInfo[] MessageAttachments { get; set; }

	[DataMember]
	public MessageObjectInfo[] MessageObjects { get; set; }

	[DataMember]
	public bool CanCreateComment { get; set; }

	[DataMember]
	public bool CanCreateQuestion { get; set; }

	[DataMember]
	public string ObjectGroupClass { get; set; }

	[DataMember]
	public string ObjectGroupText { get; set; }

	[DataMember]
	public string AddCommentText { get; set; }

	[DataMember]
	public string Hash { get; set; }

	[DataMember]
	public string RealHash { get; set; }

	[DataMember]
	public string Url { get; set; }

	public static FeedPost CreateFeedPost(FeedModel model)
	{
		bool canCreateComment = false;
		if (model.ActionObjectUid != Guid.Empty)
		{
			List<CanCreateCommentItemMessage> list = new List<CanCreateCommentItemMessage>
			{
				new CanCreateCommentItemMessage(model)
			};
			FeedManager.Instance.CanCreateComment(list);
			canCreateComment = list.First().CanCreateComment;
		}
		bool canCreateQuestion = false;
		if (model.ActionObjectUid != Guid.Empty)
		{
			List<CanCreateQuestionItem> list2 = new List<CanCreateQuestionItem>
			{
				new CanCreateQuestionItem(model.ActionObjectUid, model.ActionObjectId)
			};
			FeedManager.Instance.CanCreateQuestion(list2);
			canCreateQuestion = list2.First().CanCreateQuestion;
		}
		IEnumerable<IFeedObjectGroupExtension> enumerable = from e in ComponentManager.Current.GetExtensionPoints<IFeedObjectGroupExtension>()
			where e.IsSupport(model.ActionObjectUid)
			select e;
		string objectGroupClass = "";
		string objectGroupText = "";
		string addCommentText = "";
		if (enumerable != null && enumerable.Any())
		{
			objectGroupClass = enumerable.First().MessageTypeCssClass;
			objectGroupText = enumerable.First().MessageTypeName(model.ActionObjectUid);
			addCommentText = enumerable.First().CommentaryDescription;
		}
		return new FeedPost
		{
			Id = model.Id,
			Subject = model.Subject,
			Text = model.Text,
			ActionObjectUid = model.ActionObjectUid,
			ActionObjectId = model.ActionObjectId,
			CreationAuthor = EntityHeader.FromEntity(model.CreationAuthor),
			CreationDate = model.CreationDate,
			ChangeDate = model.ChangeDate,
			RealHash = model.ChangeDateHash,
			Hash = MessageFeedService.ShuffleHash(model.ChangeDateHash),
			ChildCount = model.ChildCount,
			Priority = (FeedPriority)model.Priority,
			IsRead = model.IsRead,
			HasUnreadChild = model.HasUnreadChild,
			LastComments = LastCommentsData.CreateLastCommentsData(model),
			ObjectRecipients = ((model.ObjectRecipients == null) ? null : model.ObjectRecipients.Select(MessageRecipientInfo.CreateMessageRecipientInfo).ToArray()),
			MessageAttachments = ((model.MessageAttachments == null) ? null : model.MessageAttachments.Select(MessageAttachmentInfo.CreateMessageAttachmentInfo).ToArray()),
			MessageObjects = ((model.MessageObjects == null) ? null : model.MessageObjects.Select(MessageObjectInfo.CreateMessageObjectInfo).ToArray()),
			CanCreateComment = canCreateComment,
			CanCreateQuestion = canCreateQuestion,
			ObjectGroupClass = objectGroupClass,
			ObjectGroupText = objectGroupText,
			AddCommentText = addCommentText,
			Url = model.Url
		};
	}
}
