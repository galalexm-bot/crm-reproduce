using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IEntityMetadataSearcher
{
	string DisplayName { get; }

	EntityMetadata FindEntityMetadata(Guid uid);

	EntityMetadata FindEntityMetadata(string className);

	IEnumerable<EntityMetadata> GetEntityMetadataList();
}
