using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;

namespace EleWise.ELMA.Deploy.Services;

public interface IExportImportService
{
	Task<Guid> Test(IConfigImportSettings settings, string activateKey = null, bool storeSettings = false);

	Task<Guid> TestModules(Guid testUid, IEnumerable<IConfigImportSettings> settings, string activateKey = null, bool storeSettings = false);

	Task<Guid> Import(IImportSettings settings);

	Task<Guid> Export(ConfigExportSettings settings);

	Task<Guid> Export(ConfigExportSettings settings, byte[] certificate, string password);

	Task<IEnumerable<DeploySystemMessage>> GetImportSystemMessages(Guid importUid, int offset, int count = 0);

	Task<IEnumerable<DeploySystemMessage>> GetTestSystemMessages(Guid testUid, int offset, int count = 0);

	Task<IEnumerable<TestImportMessages>> GetTestLog(Guid testUid, int offset, int count = 0);

	Task<IEnumerable<DeployLogMessage>> GetImportLog(Guid importUid, int offset, int count = 0);

	Task<IEnumerable<DeployLogMessage>> GetExportLog(Guid exportUid, int offset, int count = 0);

	Task<Guid> GetCurrentImportId();

	Task<Guid> ContinuedImport(IEnumerable<IConfigImportSettings> settings);

	Task<Guid> ContinuedImport(IEnumerable<Guid> testUids);

	Task<IEnumerable<BPMAppFakeManifest>> GetImportManifests(Guid importUid);

	Task<IEnumerable<BPMAppFakeManifest>> GetTestManifests(IEnumerable<Guid> testUids);

	Task<bool> ImportNeedRestart(Guid importUid);

	void ClearTestData(Guid testUid);

	Task<IEnumerable<IImportSettings>> GetImportSettings(Guid testUid);

	Task<string> GetTestedAppId(Guid testUid);

	Task<IContinuedImportState> GetImportState(Guid importUid);

	Task<IReadOnlyCollection<Guid>> GetTestedModules();

	Task ContinueImport();
}
