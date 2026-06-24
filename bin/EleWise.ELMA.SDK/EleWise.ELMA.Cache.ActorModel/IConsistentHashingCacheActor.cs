using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.Cache.ActorModel.Actors;

internal interface IConsistentHashingCacheActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task Set(string key, string region, byte[] value, TimeSpan duration, bool replica = false);

	Task Accept((string key, string region, byte[] value, TimeSpan duration)[] entries, bool replica = false);

	Task<bool> Contains(string key, string region);

	Task<CacheResult> Get(string key, string region);

	Task Remove(string key, string region, bool replica = false);

	Task ClearRegion(string region, bool forward = true);

	Task UpdateMembershipTable(string node, bool added);
}
