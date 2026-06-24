using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "ApprovalSubTask")]
public class ApprovalSubTaskWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public ApprovalStatusEnum Status { get; set; }

	[DataMember]
	public string Comment { get; set; }

	[DataMember]
	public DateTime? ApprovalDate { get; set; }

	[DataMember]
	public long ExecutorId { get; set; }
}
