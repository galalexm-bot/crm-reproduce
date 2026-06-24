using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Messages.API.Feed.Models;

[DataContract]
public class NewPostInfo
{
	[DataMember]
	public string Subject { get; set; }

	[DataMember]
	public string Text { get; set; }

	[DataMember]
	public Guid ActionObjectUid { get; set; }

	[DataMember]
	public Guid ActionUid { get; set; }

	[DataMember]
	public MessageRecipientInfo[] ObjectRecipients { get; set; }

	[DataMember]
	public MessageAttachmentInfo[] MessageAttachments { get; set; }

	[DataMember]
	public MessageObjectInfo[] MessageObjects { get; set; }
}
