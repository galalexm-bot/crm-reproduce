using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.ActorModel.Scheduling;

[FeatureFlagManaged("Scheduler.Actors.Enabled", true)]
internal interface ISchedulerJobActor : IActorWithGuidCompoundKey, IActor
{
	Task Run();

	Task ForceRunJob(Guid? jobUid = null, DateTime? now = null);
}
