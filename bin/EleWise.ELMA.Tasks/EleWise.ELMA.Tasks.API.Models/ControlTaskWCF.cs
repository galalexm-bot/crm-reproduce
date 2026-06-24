using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using EleWise.ELMA.API.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Tasks.ExtensionPoints.API;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Service.v1;

namespace EleWise.ELMA.Tasks.API.Models;

[Serializable]
[DataContract(Name = "ControlTask")]
public class ControlTaskWCF
{
	[DataMember]
	public long Id { get; set; }

	[DataMember]
	public PackageBase Task { get; set; }

	public ControlTaskWCF(ITask task)
	{
		Id = task.Id;
		Task = (from service in ComponentManager.Current.GetExtensionPoints<ITaskUpdatePackages>()
			join guid in PackageChangesService.DataSets on service.ServiceUid equals guid
			select service into p
			where ((ICollection<Guid>)p.TypeUids).Contains(task.TypeUid)
			select p).SelectMany((ITaskUpdatePackages p) => p.ConvertPackages(new ITaskBase[1] { task.CastAsRealType() })).FirstOrDefault();
	}
}
