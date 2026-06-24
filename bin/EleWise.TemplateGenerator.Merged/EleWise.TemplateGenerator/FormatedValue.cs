namespace EleWise.TemplateGenerator;

public class FormatedValue
{
	public object Value { get; set; }

	public BaseFormat Format { get; set; }

	public BlockInfo BlockInfo { get; set; }

	public FormatedValue()
	{
	}

	public FormatedValue(object value, BaseFormat format = null)
	{
		Value = value;
		Format = format;
	}

	public override string ToString()
	{
		if (Value == null)
		{
			return string.Empty;
		}
		return Value.ToString();
	}
}
