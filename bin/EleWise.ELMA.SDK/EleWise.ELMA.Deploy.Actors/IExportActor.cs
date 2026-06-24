using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Export;

namespace EleWise.ELMA.Deploy.Actors;

internal interface IExportActor : IActorWithGuidKey, IActor
{
	Task Export(ConfigExportSettings settings);

	Task Export(ConfigExportSettings settings, byte[] certificate, string password);

	Task<IEnumerable<DeployLogMessage>> GetLog(int offset, int count);
}
