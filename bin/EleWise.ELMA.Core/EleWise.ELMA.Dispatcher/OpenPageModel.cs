using Bridge;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Dispatcher;

[ObjectLiteral]
public sealed class OpenPageModel
{
	private string _003CBaseUrl_003Ek__BackingField;

	private ClassMetadata _003CContextMetadata_003Ek__BackingField;

	private ComputedValue[] _003CDynamicProperties_003Ek__BackingField;

	public string BaseUrl
	{
		get
		{
			return _003CBaseUrl_003Ek__BackingField;
		}
		set
		{
			_003CBaseUrl_003Ek__BackingField = value;
		}
	}

	public ClassMetadata ContextMetadata
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
