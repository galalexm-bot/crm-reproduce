using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.Model;

public sealed class ExtendMetadataModel
{
	private EntityMetadata _003CMetadata_003Ek__BackingField;

	private EntityMetadata _003CConfigExtMetadata_003Ek__BackingField;

	public EntityMetadata Metadata
	{
		get
		{
			return _003CMetadata_003Ek__BackingField;
		}
		set
		{
			_003CMetadata_003Ek__BackingField = value;
		}
	}

	public EntityMetadata ConfigExtMetadata
	{
		get
		{
			return _003CConfigExtMetadata_003Ek__BackingField;
		}
		set
		{
			_003CConfigExtMetadata_003Ek__BackingField = value;
		}
	}
}
