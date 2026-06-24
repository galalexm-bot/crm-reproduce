using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EleWise.ELMA.Files;
using EleWise.ELMA.Logging;

namespace EleWise.ELMA.Deploy.Import.Modules;

public interface IModuleFileDeployService
{
	Task Deploy(BinaryFile container, ILogger logger = null);

	bool IsModule(IReadOnlyCollection<IConfigImportSettings> importSettings);

	Task<IEnumerable<Guid>> Test(IReadOnlyCollection<IConfigImportSettings> importSettings);

	Task Import(IReadOnlyCollection<IConfigImportSettings> importSettings);
}
