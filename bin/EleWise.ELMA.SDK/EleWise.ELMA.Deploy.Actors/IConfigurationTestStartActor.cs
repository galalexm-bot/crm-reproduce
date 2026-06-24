using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy.Actors;

internal interface IConfigurationTestStartActor : IActorWithGuidKey, IActor
{
	Task Test(Guid testUid, IConfigImportSettings settings, string activateKey, bool storeSettings);

	Task TestModules(Guid testUid, IEnumerable<IConfigImportSettings> settings, string activateKey, bool storeSettings);

	Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(Guid testUid, int offset, int count);

	Task<IEnumerable<TestImportMessages>> GetLog(Guid testUid, int offset, int count);

	Task<IConfigImportSettings[]> GetTestedSettings(Guid testUid);

	Task<IConfigImportSettings[]> GetTestedSettingsWithCheck(Guid testUid);

	Task<BPMAppFakeManifest[]> GetFakeManifest(Guid testUid);

	Task Clear(Guid testUid);

	Task<string> GetAppId(Guid testUid);

	Task<IReadOnlyCollection<Guid>> GetTestedModules();
}
