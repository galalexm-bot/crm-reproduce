using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskAttachment")]
public class TaskAttachmentWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public Guid FileUid { get; set; }

	[DataMember]
	public long CreationAuthorId { get; set; }

	[DataMember]
	public DateTime CreationDate { get; set; }

	[DataMember]
	public string FileName { get; set; }

	[DataMember]
	public long FileSize { get; set; }
}
