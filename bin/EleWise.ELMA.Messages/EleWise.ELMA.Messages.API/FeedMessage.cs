using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API;

public class FeedMessage
{
	public long Id { get; set; }

	public string Subject { get; set; }

	public string Text { get; set; }

	public Guid ActionObjectUid { get; set; }

	public Guid ActionUid { get; set; }

	public long ActionObjectId { get; set; }

	public Guid ParentObjectUid { get; set; }

	public long ParentObjectId { get; set; }

	public long Recipient { get; set; }

	public long CreationAuthor { get; set; }

	public DateTime CreationDate { get; set; }

	public DateTime ChangeDate { get; set; }

	public int Order { get; set; }

	public int Priority { get; set; }

	public bool IsRead { get; set; }

	public bool HasUnreadChild { get; set; }

	[IgnoreDataMember]
	public string Hash { get; set; }
}
