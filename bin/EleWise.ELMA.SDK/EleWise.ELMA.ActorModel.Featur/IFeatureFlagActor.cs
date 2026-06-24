using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.ActorModel.FeatureFlags;

internal interface IFeatureFlagActor : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task<bool?> Enabled(string featureFlagName);

	Task UpdateCache(Guid serverUid, IDictionary<string, bool?> featureFlags);
}
