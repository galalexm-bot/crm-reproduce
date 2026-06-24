using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class NewCommentInfo
{
	[DataMember]
	public string Text { get; set; }

	[DataMember]
	public Guid PostActionObjectUid { get; set; }

	[DataMember]
	public long PostActionObjectId { get; set; }

	[DataMember]
	public MessageAttachmentInfo[] MessageAttachments { get; set; }
}
