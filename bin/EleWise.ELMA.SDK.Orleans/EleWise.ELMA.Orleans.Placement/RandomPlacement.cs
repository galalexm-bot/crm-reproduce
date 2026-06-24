using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Exceptions;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;
using Orleans.Runtime.Placement;

namespace EleWise.ELMA.Orleans.Placements;

[Serializable]
internal class RandomPlacement : PlacementStrategy
{
	internal sealed class PlacementDirector : IPlacementDirector
	{
		private readonly SiloFilterService siloFilterService;

		private readonly ILogger<RandomPlacement> logger;

		private readonly Random random = new Random();

		public PlacementDirector(SiloFilterService siloFilterService, ILogger<RandomPlacement> logger)
		{
			this.siloFilterService = siloFilterService;
			this.logger = logger;
		}

		public async Task<SiloAddress> OnAddActivation(PlacementStrategy strategy, PlacementTarget target, IPlacementContext context)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			IList<SiloAddress> compatibleSilos = context.GetCompatibleSilos(target);
			SiloAddress[] array = await siloFilterService.FilterSilos(compatibleSilos, context.get_LocalSilo());
			if (array.Length == 0)
			{
				OrleansLoggerExtension.Trace((ILogger)(object)logger, $"{((PlacementTarget)(ref target)).get_GrainIdentity()} -> none");
				throw new NoServerCompatibleWithActorException($"No server compatible with actor {((PlacementTarget)(ref target)).get_GrainIdentity()}");
			}
			SiloAddress val = array[random.Next(array.Length)];
			OrleansLoggerExtension.Trace((ILogger)(object)logger, $"{((PlacementTarget)(ref target)).get_GrainIdentity()} -> {val}");
			return val;
		}
	}
}
