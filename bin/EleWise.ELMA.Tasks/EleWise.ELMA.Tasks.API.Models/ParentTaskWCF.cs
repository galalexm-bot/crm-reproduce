using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "ParentTask")]
public class ParentTaskWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public Guid TypeUid { get; set; }

	[DataMember]
	public string Subject { get; set; }
}
