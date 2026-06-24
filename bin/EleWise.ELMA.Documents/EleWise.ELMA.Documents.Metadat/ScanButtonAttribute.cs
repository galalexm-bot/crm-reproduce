using System;

namespace EleWise.ELMA.Documents.Metadata;

public class ScanButtonAttribute : Attribute
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

	public ScanButtonAttribute(bool value)
	{
		_value = value;
	}
}
