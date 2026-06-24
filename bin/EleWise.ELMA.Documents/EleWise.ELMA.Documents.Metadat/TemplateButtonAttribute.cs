using System;

namespace EleWise.ELMA.Documents.Metadata;

public class TemplateButtonAttribute : Attribute
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

	public TemplateButtonAttribute(bool value)
	{
		_value = value;
	}
}
