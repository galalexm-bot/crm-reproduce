using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class TypeSettingsAdditionalViewItem : ViewItem
{
	private PropertyMetadata _003CPropertyMetadata_003Ek__BackingField;

	private ClassMetadata _003CMetadata_003Ek__BackingField;

	private bool _003CDisabled_003Ek__BackingField;

	private bool _003CPublished_003Ek__BackingField;

	[DynamicProperty(false)]
	[JsonIgnore]
	public PropertyMetadata PropertyMetadata
	{
		get
		{
			return _003CPropertyMetadata_003Ek__BackingField;
		}
		set
		{
			_003CPropertyMetadata_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	[JsonIgnore]
	public ClassMetadata Metadata
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

	[DynamicProperty(false)]
	public bool Disabled
	{
		get
		{
			return _003CDisabled_003Ek__BackingField;
		}
		set
		{
			_003CDisabled_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Published
	{
		get
		{
			return _003CPublished_003Ek__BackingField;
		}
		set
		{
			_003CPublished_003Ek__BackingField = value;
		}
	}
}
