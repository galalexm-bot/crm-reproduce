using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.ActorModel.Scheduling;

internal interface ISchedulerActor : IActorWithGuidKey, IActor
{
	Task Start();

	Task RunTrigger(Guid triggerUid);

	Task RunSchedulerJob(Guid triggerUid, DateTime currentDateTime, bool forceRun);

	Task ForceRunJob(Guid triggerUid, Guid jobUid, DateTime? now = null);
}
