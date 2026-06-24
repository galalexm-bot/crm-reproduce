using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel.FeatureFlags;

internal sealed class FeatureFlagActor : Actor, IFeatureFlagActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly ILazy<FeatureFlagService> featureFlagService;

	private readonly ILazy<DistributedFeatureFlagService> distributedFeatureFlagService;

	public FeatureFlagActor(ILazy<FeatureFlagService> featureFlagService, ILazy<DistributedFeatureFlagService> distributedFeatureFlagService)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.featureFlagService = featureFlagService;
		this.distributedFeatureFlagService = distributedFeatureFlagService;
	}

	public Task<bool?> Enabled(string featureFlagName)
	{
		return Task.FromResult(featureFlagService.Value.Enabled(featureFlagName));
	}

	public Task UpdateCache(Guid serverUid, IDictionary<string, bool?> featureFlags)
	{
		if (!distributedFeatureFlagService.IsRegistered)
		{
			return Task.CompletedTask;
		}
		return distributedFeatureFlagService.Value.UpdateCache(serverUid, featureFlags);
	}
}
