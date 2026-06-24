using System;

namespace EleWise.ELMA.Documents.Metadata;

public class UploadButtonAttribute : Attribute
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

	public UploadButtonAttribute(bool value)
	{
		_value = value;
	}
}
