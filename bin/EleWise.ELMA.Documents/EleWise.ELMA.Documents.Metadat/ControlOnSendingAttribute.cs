using System;

namespace EleWise.ELMA.Documents.Metadata;

[Obsolete("Использовать ControlOnSendingValueAttribute")]
public class ControlOnSendingAttribute : Attribute
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

	public ControlOnSendingAttribute(bool value)
	{
		_value = value;
	}
}
