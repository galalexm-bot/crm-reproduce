using System;

namespace EleWise.ELMA.Messages.Models;

public class CanCreateQuestionItem
{
	public Guid ObjectUid { get; set; }

	public long ObjectId { get; set; }

	public bool CanCreateQuestion { get; set; }

	public CanCreateQuestionItem(Guid objectUid, long objectId)
	{
		ObjectUid = objectUid;
		ObjectId = objectId;
	}
}
