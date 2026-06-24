using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Scheduling;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
[ExtensionPoint(ComponentType.WebServer)]
public interface ISchedulerJobRepository
{
	ICollection<ISchedulerJob> GetSchedulerJobs();
}
