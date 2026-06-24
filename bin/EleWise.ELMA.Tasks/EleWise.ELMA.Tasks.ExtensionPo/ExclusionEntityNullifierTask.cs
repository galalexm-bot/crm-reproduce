using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Nullifier;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.ExtensionPoints;

[Component]
internal class ExclusionEntityNullifierTask : IExclusionEntityNullifier
{
	public List<Guid> SetExclusion()
	{
		return new List<Guid>
		{
			InterfaceActivator.UID<ITaskCategory>(),
			InterfaceActivator.UID<ITaskTimePlan>(),
			InterfaceActivator.UID<IWorkLogActivityObjectType>(),
			InterfaceActivator.UID<ITaskBasePermission>()
		};
	}
}
