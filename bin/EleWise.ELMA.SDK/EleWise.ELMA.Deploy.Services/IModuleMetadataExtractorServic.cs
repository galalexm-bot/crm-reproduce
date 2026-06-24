using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Services;

internal interface IModuleMetadataExtractorService
{
	IEnumerable<ModuleVersion> ExtractModules(IConfigImportSettings importSettings);

	IEnumerable<ModuleVersion> ExtractModules(string filePath);
}
