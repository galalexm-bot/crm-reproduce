using System;

namespace EleWise.ELMA.Model.Validation;

public class ModelError
{
	private string _003CErrorMessage_003Ek__BackingField;

	private string _003CComponentName_003Ek__BackingField;

	private System.Exception _003CException_003Ek__BackingField;

	public string ErrorMessage
	{
		get
		{
			return _003CErrorMessage_003Ek__BackingField;
		}
		set
		{
			_003CErrorMessage_003Ek__BackingField = value;
		}
	}

	public string ComponentName
	{
		get
		{
			return _003CComponentName_003Ek__BackingField;
		}
		set
		{
			_003CComponentName_003Ek__BackingField = value;
		}
	}

	public System.Exception Exception
	{
		get
		{
			return _003CException_003Ek__BackingField;
		}
		set
		{
			_003CException_003Ek__BackingField = value;
		}
	}
}
