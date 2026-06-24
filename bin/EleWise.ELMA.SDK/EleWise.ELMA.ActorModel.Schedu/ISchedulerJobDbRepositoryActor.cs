using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.ActorModel.Scheduling;

internal interface ISchedulerJobDbRepositoryActor : IActorWithGuidKey, IActor
{
	Task<IEnumerable<Guid>> GetSchedulerTasksUid(DateTime dateTimeToRun);

	Task AddForceRunTrigger(Guid triggerUid);

	Task Refresh();
}
