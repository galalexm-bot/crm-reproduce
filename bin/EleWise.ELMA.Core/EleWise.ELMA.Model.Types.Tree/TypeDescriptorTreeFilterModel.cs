using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.Model.Types.Tree;

internal sealed class TypeDescriptorTreeFilterModel : ITypeDescriptorTreeFilterModel
{
	private readonly IMetadata _003CMetadata_003Ek__BackingField;

	private readonly IMetadata _003CRootMetadata_003Ek__BackingField;

	private readonly bool _003CWithDrafts_003Ek__BackingField;

	private readonly bool _003CWithDeleted_003Ek__BackingField;

	private readonly bool _003CShowInCatalogList_003Ek__BackingField;

	public IMetadata Metadata => _003CMetadata_003Ek__BackingField;

	public IMetadata RootMetadata => _003CRootMetadata_003Ek__BackingField;

	public bool WithDrafts => _003CWithDrafts_003Ek__BackingField;

	public bool WithDeleted => _003CWithDeleted_003Ek__BackingField;

	public bool ShowInCatalogList => _003CShowInCatalogList_003Ek__BackingField;

	public TypeDescriptorTreeFilterModel(IMetadata metadata, IMetadata rootMetadata, bool withDrafts, bool withDeleted = true, bool showInCatalogList = false)
	{
		_003CMetadata_003Ek__BackingField = metadata;
		_003CRootMetadata_003Ek__BackingField = rootMetadata;
		_003CWithDrafts_003Ek__BackingField = withDrafts;
		_003CWithDeleted_003Ek__BackingField = withDeleted;
		_003CShowInCatalogList_003Ek__BackingField = showInCatalogList;
	}
}
