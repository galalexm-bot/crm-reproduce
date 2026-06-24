namespace System.Web;

public sealed class HtmlString
{
	private string _003CValue_003Ek__BackingField;

	public string Value
	{
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		set
		{
			_003CValue_003Ek__BackingField = value;
		}
	}

	public HtmlString(string value)
	{
		Value = value;
	}

	public override string ToString()
	{
		return Value;
	}
}
