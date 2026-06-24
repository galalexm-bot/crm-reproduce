using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata.Services;

internal interface IModuleMetadataLoader
{
	ModuleVersion GetDefaultModuleVersion(Guid moduleUid, bool published = true);

	ModuleVersion GetSpecificModuleVersion(Guid moduleUid, Guid versionUid);

	IReadOnlyCollection<ModuleVersionHeader> GetModuleVersionHeaders(Guid moduleUid, bool published = true);

	[Obsolete("TODO: ELMA4-6475 Убрать после оптимизации загрузки модулей для поиска точек расширения и реализаций", false)]
	IReadOnlyCollection<ModuleVersion> GetAllDefaultVersions(IEnumerable<Guid> excluded, bool published = true);

	IEnumerable<ModuleMetadataItemWrapper> GetLastPublishedHeaders(IEnumerable<Guid> notLoaded);

	bool IsSystemModule(Guid moduleUid);
}
