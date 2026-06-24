using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.Security.Actors;

[FeatureFlagManaged("Scheduler.Actors.Enabled", true)]
internal interface IUpdateUserSecuritySetCacheQueueManagerActor : IActorWithIntegerKey, IActor
{
	Task Start();

	Task RegisterExecute(TimeSpan waitTimeSpan);

	Task TimerComplete(string reminderName);
}
