using EleWise.ELMA.Core.Engine.Models;

namespace EleWise.ELMA.Api.Models;

internal sealed class SystemInitData
{
	private MetadataReference[] _003CMetadataReferences_003Ek__BackingField;

	private ItemRuntimeModelDto[] _003CItemRuntimeModels_003Ek__BackingField;

	public MetadataReference[] MetadataReferences
	{
		get
		{
			return _003CMetadataReferences_003Ek__BackingField;
		}
		set
		{
			_003CMetadataReferences_003Ek__BackingField = value;
		}
	}

	public ItemRuntimeModelDto[] ItemRuntimeModels
	{
		get
		{
			return _003CItemRuntimeModels_003Ek__BackingField;
		}
		set
		{
			_003CItemRuntimeModels_003Ek__BackingField = value;
		}
	}
}
