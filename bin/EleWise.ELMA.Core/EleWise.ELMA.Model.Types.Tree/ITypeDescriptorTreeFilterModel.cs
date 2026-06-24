using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.Model.Types.Tree;

public interface ITypeDescriptorTreeFilterModel
{
	IMetadata Metadata { get; }

	IMetadata RootMetadata { get; }

	bool WithDrafts { get; }

	bool WithDeleted { get; }

	bool ShowInCatalogList { get; }
}
