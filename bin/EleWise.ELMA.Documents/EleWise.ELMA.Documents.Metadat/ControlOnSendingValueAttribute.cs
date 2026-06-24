using System;

namespace EleWise.ELMA.Documents.Metadata;

public class ControlOnSendingValueAttribute : Attribute
{
	private bool _value;

	public bool Value
	{
		get
		{
			return _value;
		}
		set
		{
			_value = value;
		}
	}

	public ControlOnSendingValueAttribute(bool value)
	{
		_value = value;
	}
}
