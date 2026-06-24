using System.Collections.Generic;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Model.Services;

internal interface IModulePublishDataProvider
{
	IReadOnlyCollection<ModuleVersion> PrepareData(ModuleInfoMetadata module, IEnumerable<ModuleVersion> extendedModuleContext = null);
}
