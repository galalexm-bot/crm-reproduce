using System;

namespace EleWise.ELMA.Model.Views;

public class ComputedValue : Reactive
{
	private string _003CName_003Ek__BackingField;

	private int _003CComputedValueType_003Ek__BackingField;

	private string _003CValue_003Ek__BackingField;

	private string _003CMethodName_003Ek__BackingField;

	private string _003CCalculateScript_003Ek__BackingField;

	private Guid _003CPropertyUid_003Ek__BackingField;

	private Guid[] _003CPropertyParents_003Ek__BackingField;

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

	public int ComputedValueType
	{
		get
		{
			return _003CComputedValueType_003Ek__BackingField;
		}
		set
		{
			_003CComputedValueType_003Ek__BackingField = value;
		}
	}

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

	public string MethodName
	{
		get
		{
			return _003CMethodName_003Ek__BackingField;
		}
		set
		{
			_003CMethodName_003Ek__BackingField = value;
		}
	}

	public string CalculateScript
	{
		get
		{
			return _003CCalculateScript_003Ek__BackingField;
		}
		set
		{
			_003CCalculateScript_003Ek__BackingField = value;
		}
	}

	public Guid PropertyUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CPropertyUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CPropertyUid_003Ek__BackingField = value;
		}
	}

	public Guid[] PropertyParents
	{
		get
		{
			return _003CPropertyParents_003Ek__BackingField;
		}
		set
		{
			_003CPropertyParents_003Ek__BackingField = value;
		}
	}
}
