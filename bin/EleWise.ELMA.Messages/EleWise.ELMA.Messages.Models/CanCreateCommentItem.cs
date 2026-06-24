using System;

namespace EleWise.ELMA.Messages.Models;

public class CanCreateCommentItem
{
	public Guid ObjectUid { get; set; }

	public long ObjectId { get; set; }

	public bool CanAddCommentAttachment { get; set; }

	public bool CanCreateComment { get; set; }

	public CanCreateCommentItem(Guid objectUid, long objectId)
	{
		ObjectUid = objectUid;
		ObjectId = objectId;
	}
}
