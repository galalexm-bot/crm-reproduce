using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Services;

internal interface IEntityMetadataDependencyService
{
	void CollectDependencies(EntityMetadata metadata, IMetadataItem metadataItem);
}
