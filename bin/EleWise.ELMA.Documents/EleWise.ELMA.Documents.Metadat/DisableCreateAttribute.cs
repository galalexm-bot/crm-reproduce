using System;

namespace EleWise.ELMA.Documents.Metadata;

public class DisableCreateAttribute : Attribute
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

	public DisableCreateAttribute(bool value)
	{
		_value = value;
	}
}
