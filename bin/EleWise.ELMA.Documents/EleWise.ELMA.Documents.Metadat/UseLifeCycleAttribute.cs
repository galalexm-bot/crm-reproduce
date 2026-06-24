using System;

namespace EleWise.ELMA.Documents.Metadata;

public class UseLifeCycleAttribute : Attribute
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

	public UseLifeCycleAttribute(bool value)
	{
		_value = value;
	}
}
