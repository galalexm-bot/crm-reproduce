using System;

namespace EleWise.ELMA.Documents.Metadata;

public class NeedAnswerAttribute : Attribute
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

	public NeedAnswerAttribute(bool value)
	{
		_value = value;
	}
}
