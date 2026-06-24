using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.References;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

internal sealed class DefaultValueViewItem : ViewItem, IFocusable
{
	private TypeSettings _003CTypeSettings_003Ek__BackingField;

	private ReferenceOnType _003CReferenceOnType_003Ek__BackingField;

	private string _003CValue_003Ek__BackingField;

	private bool _003CReadOnly_003Ek__BackingField;

	private bool _003CMultiple_003Ek__BackingField;

	private bool _003CNullable_003Ek__BackingField;

	private ActionWithParam<string> _003COnChange_003Ek__BackingField;

	private FocusableType _003CFocusableType_003Ek__BackingField;

	[DynamicProperty(false)]
	[JsonIgnore]
	public TypeSettings TypeSettings
	{
		get
		{
			return _003CTypeSettings_003Ek__BackingField;
		}
		set
		{
			_003CTypeSettings_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ReferenceOnType ReferenceOnType
	{
		get
		{
			return _003CReferenceOnType_003Ek__BackingField;
		}
		set
		{
			_003CReferenceOnType_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public string Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		set
		{
			_003CValue_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool ReadOnly
	{
		get
		{
			return _003CReadOnly_003Ek__BackingField;
		}
		set
		{
			_003CReadOnly_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Multiple
	{
		get
		{
			return _003CMultiple_003Ek__BackingField;
		}
		set
		{
			_003CMultiple_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Nullable
	{
		get
		{
			return _003CNullable_003Ek__BackingField;
		}
		set
		{
			_003CNullable_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<string> OnChange
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
	public FocusableType FocusableType
	{
		get
		{
			return _003CFocusableType_003Ek__BackingField;
		}
		set
		{
			_003CFocusableType_003Ek__BackingField = value;
		}
	}

	public bool FocusableEnabled => true;
}
