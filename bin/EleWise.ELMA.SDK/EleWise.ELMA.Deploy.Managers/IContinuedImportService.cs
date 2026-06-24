using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Deploy.Managers;

public interface IContinuedImportService
{
	Task<Guid> Import(IEnumerable<Guid> testUids, CancellationToken cancellationToken);

	Task<IEnumerable<BPMAppFakeManifest>> GetImportManifests(Guid uid, CancellationToken cancellationToken);

	Task<IEnumerable<Guid>> Test(BinaryFile configFile, CancellationToken cancellationToken);

	Task<IEnumerable<Guid>> Test(BinaryFile configFile, string activationKey, CancellationToken cancellationToken);

	Task<List<TestImportMessages>> GetTestLog(Guid testUid, CancellationToken cancellationToken);

	Task<IEnumerable<IImportSettings>> GetImportSettings(Guid testUid);
}
