using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskAnswer")]
public class TaskAnswerWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string Answer { get; set; }

	[DataMember]
	public long CreationAuthorId { get; set; }

	[DataMember]
	public DateTime CreationDate { get; set; }

	[DataMember]
	public TaskAttachmentWCF[] Attachments { get; set; }
}
