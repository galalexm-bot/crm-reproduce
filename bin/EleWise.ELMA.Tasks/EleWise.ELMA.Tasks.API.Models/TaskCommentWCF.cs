using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskComment")]
public class TaskCommentWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid Uid { get; set; }

	[DataMember]
	public string Text { get; set; }

	[DataMember]
	public long CreationAuthorId { get; set; }

	[DataMember]
	public DateTime CreationDate { get; set; }
}
