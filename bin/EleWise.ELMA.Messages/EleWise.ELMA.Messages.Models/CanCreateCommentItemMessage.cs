namespace EleWise.ELMA.Messages.Models;

public class CanCreateCommentItemMessage
{
	public FeedModel Message { get; set; }

	public bool CanCreateComment { get; set; }

	public bool CanAddCommentAttachment { get; set; }

	public CanCreateCommentItemMessage(FeedModel message)
	{
		Message = message;
	}

	public CanCreateCommentItem ToCanCreateCommentItem()
	{
		return new CanCreateCommentItem(Message.ParentObjectUid.Value, Message.ParentObjectId.Value)
		{
			CanCreateComment = CanCreateComment,
			CanAddCommentAttachment = CanAddCommentAttachment
		};
	}
}
