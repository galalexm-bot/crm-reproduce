using System;

namespace EleWise.ELMA.Documents.Metadata;

public class TemplateNameAttribute : Attribute
{
	private string _value;

	public string Value
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

	public TemplateNameAttribute(string value)
	{
		_value = value;
	}
}
