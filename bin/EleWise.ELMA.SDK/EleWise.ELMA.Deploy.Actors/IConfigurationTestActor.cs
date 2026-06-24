using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy.Actors;

internal interface IConfigurationTestActor : IActorWithGuidKey, IActor
{
	Task Test(IConfigImportSettings settings, string activateKey, bool storeSettings);

	Task TestModules(IEnumerable<IConfigImportSettings> settings, string activateKey, bool storeSettings);

	Task<IEnumerable<DeploySystemMessage>> GetSystemMessages(int offset, int count);

	Task<IEnumerable<TestImportMessages>> GetLog(int offset, int count);

	Task<IConfigImportSettings[]> GetTestedSettings();

	Task<IConfigImportSettings[]> GetTestedSettingsWithCheck();

	Task<BPMAppFakeManifest[]> GetFakeManifest();

	Task Clear();

	Task<string> GetAppId();
}
