using System;

namespace EleWise.ELMA.Api.Models;

public class PropertyViewInfoDto
{
	private Guid _003CUid_003Ek__BackingField;

	private bool? _003CReadOnly_003Ek__BackingField;

	private bool? _003CVisible_003Ek__BackingField;

	private bool? _003CRequired_003Ek__BackingField;

	private bool? _003CIsValid_003Ek__BackingField;

	private string _003CValidationMessage_003Ek__BackingField;

	private object _003CSettings_003Ek__BackingField;

	public Guid Uid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CUid_003Ek__BackingField = value;
		}
	}

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

	public bool? Visible
	{
		get
		{
			return _003CVisible_003Ek__BackingField;
		}
		set
		{
			_003CVisible_003Ek__BackingField = value;
		}
	}

	public bool? Required
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

	public bool? IsValid
	{
		get
		{
			return _003CIsValid_003Ek__BackingField;
		}
		set
		{
			_003CIsValid_003Ek__BackingField = value;
		}
	}

	public string ValidationMessage
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

	public object Settings
	{
		get
		{
			return _003CSettings_003Ek__BackingField;
		}
		set
		{
			_003CSettings_003Ek__BackingField = value;
		}
	}
}
