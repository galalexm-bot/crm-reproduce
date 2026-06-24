using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Documents.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IConvertDocumentReferencesExtension
{
	List<EntityMetadata> GetAllEntitiesWithPossibleReferences();
}
