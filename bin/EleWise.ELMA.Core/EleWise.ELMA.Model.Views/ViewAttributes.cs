using System;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.ViewModel;
using EleWise.ELMA.Scripts.Models;
using Newtonsoft.Json;

namespace EleWise.ELMA.Model.Views;

public class ViewAttributes : Reactive
{
	private string _003CName_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private bool? _003CReadOnly_003Ek__BackingField;

	private bool _003CHide_003Ek__BackingField;

	private bool _003CRequired_003Ek__BackingField;

	private bool _003CDisabled_003Ek__BackingField;

	private bool _003CValidationMessage_003Ek__BackingField;

	private string _003CValidationError_003Ek__BackingField;

	private string _003CValidationScriptName_003Ek__BackingField;

	private bool _003CHideValidation_003Ek__BackingField;

	private TypeSettings _003CTypeSettings_003Ek__BackingField;

	private Guid _003CEntityFilterProvider_003Ek__BackingField;

	private string _003CEntityFilterData_003Ek__BackingField;

	private string _003COnChangeScriptName_003Ek__BackingField;

	private CodeType _003COnChangeCodeType_003Ek__BackingField;

	private ActionWithParam<IKeyboardEventTyped> _003COnKeyPress_003Ek__BackingField;

	private ActionWithParam<IFocusEventTyped> _003COnFocus_003Ek__BackingField;

	private string _003COnViewLoadScriptName_003Ek__BackingField;

	private int _003CPopupWidth_003Ek__BackingField;

	private string _003CPlaceholder_003Ek__BackingField;

	private string _003CTooltip_003Ek__BackingField;

	[DynamicProperty(false)]
	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string Description
	{
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		set
		{
			_003CDescription_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool? ReadOnly
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
	internal bool Hide
	{
		get
		{
			return _003CHide_003Ek__BackingField;
		}
		set
		{
			_003CHide_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool Required
	{
		get
		{
			return _003CRequired_003Ek__BackingField;
		}
		set
		{
			_003CRequired_003Ek__BackingField = value;
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

	public bool ValidationMessage
	{
		get
		{
			return _003CValidationMessage_003Ek__BackingField;
		}
		set
		{
			_003CValidationMessage_003Ek__BackingField = value;
		}
	}

	public string ValidationError
	{
		get
		{
			return _003CValidationError_003Ek__BackingField;
		}
		set
		{
			_003CValidationError_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string ValidationScriptName
	{
		get
		{
			return _003CValidationScriptName_003Ek__BackingField;
		}
		set
		{
			_003CValidationScriptName_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public bool HideValidation
	{
		get
		{
			return _003CHideValidation_003Ek__BackingField;
		}
		set
		{
			_003CHideValidation_003Ek__BackingField = value;
		}
	}

	[DynamicPropertyContainer]
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

	public Guid EntityFilterProvider
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CEntityFilterProvider_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CEntityFilterProvider_003Ek__BackingField = value;
		}
	}

	public string EntityFilterData
	{
		get
		{
			return _003CEntityFilterData_003Ek__BackingField;
		}
		set
		{
			_003CEntityFilterData_003Ek__BackingField = value;
		}
	}

	public string OnChangeScriptName
	{
		get
		{
			return _003COnChangeScriptName_003Ek__BackingField;
		}
		set
		{
			_003COnChangeScriptName_003Ek__BackingField = value;
		}
	}

	public CodeType OnChangeCodeType
	{
		get
		{
			return _003COnChangeCodeType_003Ek__BackingField;
		}
		set
		{
			_003COnChangeCodeType_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<IKeyboardEventTyped> OnKeyPress
	{
		get
		{
			return _003COnKeyPress_003Ek__BackingField;
		}
		set
		{
			_003COnKeyPress_003Ek__BackingField = value;
		}
	}

	[JsonIgnore]
	[DynamicProperty(false)]
	public ActionWithParam<IFocusEventTyped> OnFocus
	{
		get
		{
			return _003COnFocus_003Ek__BackingField;
		}
		set
		{
			_003COnFocus_003Ek__BackingField = value;
		}
	}

	public string OnViewLoadScriptName
	{
		get
		{
			return _003COnViewLoadScriptName_003Ek__BackingField;
		}
		set
		{
			_003COnViewLoadScriptName_003Ek__BackingField = value;
		}
	}

	public int PopupWidth
	{
		get
		{
			return _003CPopupWidth_003Ek__BackingField;
		}
		set
		{
			_003CPopupWidth_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string Placeholder
	{
		get
		{
			return _003CPlaceholder_003Ek__BackingField;
		}
		set
		{
			_003CPlaceholder_003Ek__BackingField = value;
		}
	}

	[DynamicProperty(false)]
	public string Tooltip
	{
		get
		{
			return _003CTooltip_003Ek__BackingField;
		}
		set
		{
			_003CTooltip_003Ek__BackingField = value;
		}
	}

	public ViewAttributes()
	{
		ValidationMessage = true;
		OnChangeScriptName = "";
		Disabled = false;
		Placeholder = "";
		Tooltip = "";
		ValidationError = "";
	}
}
