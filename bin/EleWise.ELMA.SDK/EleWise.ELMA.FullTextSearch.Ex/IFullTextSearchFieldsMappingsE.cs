using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFullTextSearchFieldsMappingsExtension : IModuleFullTextSearchExtension
{
	FieldIndexList MappingFields(ClassMetadata metadata);

	FieldIndexList MappingFields(Guid uid);

	FieldIndexList MappingFields(Type cardType);
}
