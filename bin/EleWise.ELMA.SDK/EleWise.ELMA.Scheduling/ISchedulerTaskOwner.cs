using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Scheduling;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ComponentType.All)]
public interface ISchedulerTaskOwner
{
	Guid Uid { get; }

	string Name { get; }
}
