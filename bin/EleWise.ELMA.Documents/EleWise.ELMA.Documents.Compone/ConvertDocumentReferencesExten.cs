using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Documents.Components;

[Component]
public class ConvertDocumentReferencesExtension : IConvertDocumentReferencesExtension
{
	public List<EntityMetadata> GetAllEntitiesWithPossibleReferences()
	{
		return (from m in MetadataServiceContext.Service.GetMetadataList().OfType<EntityMetadata>()
			where m.Type == EntityMetadataType.InterfaceImplementation
			select m).ToList();
	}
}
