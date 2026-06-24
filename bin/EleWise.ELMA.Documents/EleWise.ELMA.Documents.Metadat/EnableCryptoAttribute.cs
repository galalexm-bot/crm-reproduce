using System;

namespace EleWise.ELMA.Documents.Metadata;

public class EnableCryptoAttribute : Attribute
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

	public EnableCryptoAttribute(bool value)
	{
		_value = value;
	}
}
