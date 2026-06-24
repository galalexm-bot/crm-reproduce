using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Scheduling;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ISchedulerJob
{
	Guid? OwnerUid { get; }

	[NotNull]
	ITrigger Trigger { get; }

	[NotNull]
	ICollection<IJob> Jobs { get; }
}
