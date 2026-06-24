using System;

namespace EleWise.ELMA.Documents.Metadata;

public class MultipleRegistrationAttribute : Attribute
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

	public MultipleRegistrationAttribute(bool value)
	{
		_value = value;
	}
}
