using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Orleans.Extensions;
using EleWise.ELMA.Services;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;
using Orleans.Runtime.Placement;

namespace EleWise.ELMA.Orleans.Placements;

[Serializable]
internal sealed class FeatureFlagManagedPlacement : PlacementStrategy
{
	internal sealed class PlacementDirector : IPlacementDirector
	{
		private readonly SiloFilterService siloFilterService;

		private readonly ILazy<IDistributedFeatureFlagService> distributedFeatureFlagService;

		private readonly ILogger<FeatureFlagManagedPlacement> logger;

		private readonly Random random = new Random();

		public PlacementDirector(SiloFilterService siloFilterService, ILazy<IDistributedFeatureFlagService> distributedFeatureFlagService, ILogger<FeatureFlagManagedPlacement> logger)
		{
			this.siloFilterService = siloFilterService;
			this.distributedFeatureFlagService = distributedFeatureFlagService;
			this.logger = logger;
		}

		public async Task<SiloAddress> OnAddActivation(PlacementStrategy strategy, PlacementTarget target, IPlacementContext context)
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			FeatureFlagManagedPlacement featureFlagManagedPlacement = (FeatureFlagManagedPlacement)(object)strategy;
			IList<SiloAddress> compatibleSilos = context.GetCompatibleSilos(target);
			SiloAddress[] source = await siloFilterService.FilterSilos(compatibleSilos, context.get_LocalSilo());
			IEnumerable<SiloAddress> source2 = ((!distributedFeatureFlagService.IsRegistered) ? Enumerable.Empty<SiloAddress>() : (await Task.WhenAll(source.Select((SiloAddress silo) => distributedFeatureFlagService.Value.Enabled(silo.ToGuid(), featureFlagManagedPlacement.featureFlagName, featureFlagManagedPlacement.defaultEnabled).ContinueWith((Func<Task<bool>, object, SiloAddress>)((Task<bool> task, object state) => task.Result ? ((SiloAddress)state) : ((SiloAddress)null)), (object)silo, TaskContinuationOptions.RunContinuationsAsynchronously | TaskContinuationOptions.NotOnFaulted)))).Where((SiloAddress silo) => silo != null));
			List<SiloAddress> list = source2.ToList();
			if (list.Count == 0)
			{
				OrleansLoggerExtension.Trace((ILogger)(object)logger, $"{((PlacementTarget)(ref target)).get_GrainIdentity()} -> none");
				throw new NoServerCompatibleWithActorException($"No server compatible with actor {((PlacementTarget)(ref target)).get_GrainIdentity()}");
			}
			SiloAddress val = list[random.Next(list.Count)];
			OrleansLoggerExtension.Trace((ILogger)(object)logger, $"{((PlacementTarget)(ref target)).get_GrainIdentity()} -> {val}");
			return val;
		}
	}

	private readonly string featureFlagName;

	private readonly bool defaultEnabled;

	public FeatureFlagManagedPlacement(string featureFlagName, bool defaultEnabled)
	{
		this.featureFlagName = featureFlagName;
		this.defaultEnabled = defaultEnabled;
	}
}
