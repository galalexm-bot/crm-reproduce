using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "TaskPackage")]
public class TaskPackage : TaskBasePackage
{
	[DataMember]
	public TaskWCF Data { get; set; }

	public TaskPackage(Guid typeUid)
		: base(typeUid)
	{
	}

	internal TaskPackage(Guid serviceUid, Guid typeUid)
		: base(serviceUid, typeUid)
	{
	}

	public override long GetId()
	{
		return Data.Id;
	}
}
