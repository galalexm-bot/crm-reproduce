using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Common.BulkDataImport.Mapping.Providers.Components;

[Component(Order = 100000)]
internal class EntityMapTypeExtension : IMapTypeExtension
{
	public bool Can(IMetadata metadata)
	{
		return metadata is EntityMetadata;
	}

	public string TableName(IMetadata metadata)
	{
		return ((EntityMetadata)metadata).TableName;
	}
}
