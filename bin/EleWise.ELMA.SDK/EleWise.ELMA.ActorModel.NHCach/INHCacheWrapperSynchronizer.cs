using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;

namespace EleWise.ELMA.ActorModel.NHCacheWrapper;

internal interface INHCacheWrapperSynchronizer : IServerPlacementActor, IActorWithGuidKey, IActor
{
	Task EnableCache(IList<string> regions);

	Task DisableCache(IList<string> regions);
}
