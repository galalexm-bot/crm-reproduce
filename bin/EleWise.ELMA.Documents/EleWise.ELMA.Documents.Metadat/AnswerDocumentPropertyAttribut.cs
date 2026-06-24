using System;

namespace EleWise.ELMA.Documents.Metadata;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class AnswerDocumentPropertyAttribute : Attribute
{
	private Guid _value;

	public Guid Value
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

	public AnswerDocumentPropertyAttribute(string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			_value = new Guid(value);
		}
	}

	public AnswerDocumentPropertyAttribute(Guid value)
	{
		_value = value;
	}
}
