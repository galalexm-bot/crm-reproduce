using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "UnknownTaskPackage")]
public class UnknownTaskPackage : TaskBasePackage
{
	[DataMember]
	public UnknownTaskWCF Data { get; set; }

	public UnknownTaskPackage(Guid typeUid)
		: base(typeUid)
	{
	}

	public override long GetId()
	{
		return Data.Id;
	}
}
