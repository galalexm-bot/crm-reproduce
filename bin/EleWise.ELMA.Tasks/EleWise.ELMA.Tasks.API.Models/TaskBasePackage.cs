using System;
using System.Runtime.Serialization;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.Tasks.API.Service.v1;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract]
public abstract class TaskBasePackage : PackageBase
{
	protected TaskBasePackage(Guid typeUid)
		: base(TaskBaseUpdatePackageService.serviceUid, typeUid)
	{
	}

	protected TaskBasePackage(Guid serviceUid, Guid typeUid)
		: base(serviceUid, typeUid)
	{
	}

	public abstract long GetId();
}
