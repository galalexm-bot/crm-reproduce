using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.Modules;

internal interface IModuleFileDeployServiceExtended : IModuleFileDeployService
{
	bool HasModules(IReadOnlyCollection<IConfigImportSettings> importSettings);
}
