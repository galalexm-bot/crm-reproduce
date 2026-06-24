using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;

namespace EleWise.ELMA.Security.Actors;

[FeatureFlagManaged("Scheduler.Actors.Enabled", true)]
internal interface IExternalMembershipImportManagerActor : IActorWithIntegerKey, IActor
{
	Task Start();

	Task AddUsersToImport(ICollection<string> userNames, ICollection<long> groupIds, Guid authProviderUid);

	Task ImportComplete();
}
