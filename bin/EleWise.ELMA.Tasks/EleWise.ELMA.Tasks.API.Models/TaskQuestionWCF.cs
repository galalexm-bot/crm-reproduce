using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskQuestion")]
public class TaskQuestionWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string Question { get; set; }

	[DataMember]
	public long CreationAuthorId { get; set; }

	[DataMember]
	public long ExecutorId { get; set; }

	[DataMember]
	public DateTime CreationDate { get; set; }

	[DataMember]
	public TaskAttachmentWCF[] Attachments { get; set; }

	[DataMember]
	public TaskAnswerWCF Answer { get; set; }
}
