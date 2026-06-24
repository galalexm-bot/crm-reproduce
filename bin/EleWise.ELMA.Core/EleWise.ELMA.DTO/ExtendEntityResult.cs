using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;

namespace EleWise.ELMA.DTO;

internal sealed class ExtendEntityResult : IExtendEntityResult
{
	private bool _003CExtended_003Ek__BackingField;

	private IPropertyMetadata[] _003CExtendedProperties_003Ek__BackingField;

	public bool Extended
	{
		get
		{
			return _003CExtended_003Ek__BackingField;
		}
		set
		{
			_003CExtended_003Ek__BackingField = value;
		}
	}

	public IPropertyMetadata[] ExtendedProperties
	{
		get
		{
			return _003CExtendedProperties_003Ek__BackingField;
		}
		set
		{
			_003CExtendedProperties_003Ek__BackingField = value;
		}
	}

	public ExtendEntityResult()
	{
		ExtendedProperties = (IPropertyMetadata[])(object)new IPropertyMetadata[0];
	}
}
