using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Dispatcher;

[ObjectLiteral]
public sealed class StartProcessModel
{
	private long _003CProcessHeaderId_003Ek__BackingField;

	private EntityMetadata _003CContextMetadata_003Ek__BackingField;

	private ComputedValue[] _003CDynamicProperties_003Ek__BackingField;

	public long ProcessHeaderId
	{
		get
		{
			return _003CProcessHeaderId_003Ek__BackingField;
		}
		set
		{
			_003CProcessHeaderId_003Ek__BackingField = value;
		}
	}

	public EntityMetadata ContextMetadata
	{
		get
		{
			return _003CContextMetadata_003Ek__BackingField;
		}
		set
		{
			_003CContextMetadata_003Ek__BackingField = value;
		}
	}

	public ComputedValue[] DynamicProperties
	{
		get
		{
			return _003CDynamicProperties_003Ek__BackingField;
		}
		set
		{
			_003CDynamicProperties_003Ek__BackingField = value;
		}
	}
}
