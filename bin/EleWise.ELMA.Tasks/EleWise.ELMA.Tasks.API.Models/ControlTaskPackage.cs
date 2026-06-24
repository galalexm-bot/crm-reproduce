using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "ControlTaskPackage")]
public class ControlTaskPackage : TaskBasePackage
{
	[DataMember]
	public ControlTaskWCF Data { get; set; }

	internal ControlTaskPackage(Guid serviceUid, Guid typeUid)
		: base(serviceUid, typeUid)
	{
	}

	public override long GetId()
	{
		return Data.Id;
	}
}
