using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class TypeSettingsViewItem : ViewItem
{
	private TypeSettingsViewParams _003CTypeSettingsViewParams_003Ek__BackingField;

	private PropertyMetadata _003CPropertyMetadata_003Ek__BackingField;

	private ClassMetadata _003CMetadata_003Ek__BackingField;

	private ActionWithParam<TypeSettings> _003COnChange_003Ek__BackingField;

	private bool _003CDisabled_003Ek__BackingField;

	private bool _003CPublished_003Ek__BackingField;

	[DynamicProperty(false)]
	[JsonIgnore]
	public TypeSettingsViewParams TypeSettingsViewParams
	{
		get
		{
			return _003CTypeSettingsViewParams_003Ek__BackingField;
		}
		set
		{
			_003CTypeSettingsViewParams_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
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

	[JsonIgnore]
	[DynamicProperty(false)]
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

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<TypeSettings> OnChange
	{
		get
		{
			return _003COnChange_003Ek__BackingField;
		}
		set
		{
			_003COnChange_003Ek__BackingField = value;
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
