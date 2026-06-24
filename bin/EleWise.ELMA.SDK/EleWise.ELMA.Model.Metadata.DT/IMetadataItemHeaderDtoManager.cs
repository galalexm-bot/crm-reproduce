using System;
using System.Collections.Generic;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers;

public interface IMetadataItemHeaderDtoManager : IConfigurationService
{
	IEnumerable<string> GetGlobalModuleNames(IEnumerable<EntityMetadata> mds);

	IDictionary<Guid, string> GetObjectsUidsFromDependencies(Guid uid);
}
