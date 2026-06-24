using System;

namespace EleWise.ELMA.Documents.Metadata;

public class IsAllowRenameAttribute : Attribute
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

	public IsAllowRenameAttribute(bool value)
	{
		_value = value;
	}
}
