using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "ApprovalTaskPackage")]
public class ApprovalTaskPackage : TaskBasePackage
{
	[DataMember]
	public ApprovalTaskWCF Data { get; set; }

	public ApprovalTaskPackage(Guid typeUid)
		: base(typeUid)
	{
	}

	public override long GetId()
	{
		return Data.Id;
	}
}
