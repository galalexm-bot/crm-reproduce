using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy.Actors;

internal interface IImportExecutorActor : IActorWithGuidKey, IActor
{
	Task Import(IImportSettings settings);

	Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(int offset, int count);

	Task<IEnumerable<DeployLogMessage>> GetLog(int offset, int count);

	Task<IEnumerable<DeployLogMessage>> GetLastLog(int count);

	Task<bool> IsActive();

	Task ContinuedImport(IEnumerable<IConfigImportSettings> settings);

	Task ContinueImport();

	Task<IEnumerable<BPMAppFakeManifest>> GetFakeManifests();

	Task<IContinuedImportState> GetImportState();
}
