using System;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Orleans.Extensions;
using Microsoft.Extensions.Logging;
using Orleans.Runtime;
using Orleans.Runtime.Placement;

namespace EleWise.ELMA.Orleans.Placements;

[Serializable]
internal class SiloPlacement : PlacementStrategy
{
	public class PlacementDirector : IPlacementDirector
	{
		private readonly ISiloStatusOracle siloStatusOracle;

		private readonly ILogger logger;

		public PlacementDirector(ISiloStatusOracle siloStatusOracle, ILogger<SiloPlacement> logger)
		{
			this.siloStatusOracle = siloStatusOracle;
			this.logger = (ILogger)(object)logger;
		}

		public async Task<SiloAddress> OnAddActivation(PlacementStrategy strategy, PlacementTarget target, IPlacementContext context)
		{
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			Guid serverUid = ((PlacementTarget)(ref target)).get_GrainIdentity().get_PrimaryKey();
			SiloAddress val = ((context.get_LocalSilo().ToGuid() == serverUid) ? context.get_LocalSilo() : (siloStatusOracle.GetApproximateSiloStatuses(false).Keys.FirstOrDefault((SiloAddress siloAddress) => siloAddress.ToGuid() == serverUid) ?? SiloAddress.get_Zero()));
			if (val.Equals(SiloAddress.get_Zero()))
			{
				if (logger.IsEnabled((LogLevel)4))
				{
					OrleansLoggerExtension.Error(logger, 0, string.Format("{0} -> none\r\n    serverUid: {1}\r\n    LocalSilo: {2}: {3}\r\n    AllSilos:  {4}", ((PlacementTarget)(ref target)).get_GrainIdentity(), serverUid, context.get_LocalSilo().ToGuid(), context.get_LocalSilo(), string.Join("\r\n               ", siloStatusOracle.GetApproximateSiloStatuses(false).Keys.Select((SiloAddress siloAddress) => $"{siloAddress.ToGuid()}: {siloAddress}"))), (Exception)null);
				}
				else
				{
					OrleansLoggerExtension.Trace(logger, $"{((PlacementTarget)(ref target)).get_GrainIdentity()} -> none");
				}
				throw new NoServerCompatibleWithActorException($"No server compatible with actor {((PlacementTarget)(ref target)).get_GrainIdentity()}");
			}
			OrleansLoggerExtension.Trace(logger, $"{((PlacementTarget)(ref target)).get_GrainIdentity()} -> {val}");
			return val;
		}
	}

	internal static SiloPlacement Singleton { get; } = new SiloPlacement();

}
