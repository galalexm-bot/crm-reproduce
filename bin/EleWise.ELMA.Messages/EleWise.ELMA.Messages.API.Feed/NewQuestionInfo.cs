using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class NewQuestionInfo
{
	[DataMember]
	public string Text { get; set; }

	[DataMember]
	public Guid PostActionObjectUid { get; set; }

	[DataMember]
	public long PostActionObjectId { get; set; }

	[DataMember]
	public EntityHeader Executor { get; set; }

	[DataMember]
	public bool ShowAll { get; set; }

	[DataMember]
	public MessageAttachmentInfo[] MessageAttachments { get; set; }
}
