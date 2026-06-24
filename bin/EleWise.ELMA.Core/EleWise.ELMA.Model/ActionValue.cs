using System;

namespace EleWise.ELMA.Model;

public sealed class ActionValue : Reactive
{
	private string _003CMethodName_003Ek__BackingField;

	private Guid _003CFunctionHeaderUid_003Ek__BackingField;

	private int _003CCodeType_003Ek__BackingField;

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

	public Guid FunctionHeaderUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CFunctionHeaderUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CFunctionHeaderUid_003Ek__BackingField = value;
		}
	}

	public int CodeType
	{
		get
		{
			return _003CCodeType_003Ek__BackingField;
		}
		set
		{
			_003CCodeType_003Ek__BackingField = value;
		}
	}
}
