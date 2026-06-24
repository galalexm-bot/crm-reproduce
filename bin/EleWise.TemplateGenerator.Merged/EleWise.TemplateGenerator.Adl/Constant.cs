using System.Globalization;

namespace EleWise.TemplateGenerator.Adl.Tree;

public class Constant : Expression
{
	public object Value { get; set; }

	public static Constant ParseNumberConstant(string value)
	{
		if (value.Contains(".") || value.Contains(","))
		{
			value = value.Replace(".", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator).Replace(",", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
			return new Constant
			{
				Value = double.Parse(value)
			};
		}
		return new Constant
		{
			Value = int.Parse(value)
		};
	}

	public static Constant ParseStringConstant(string value)
	{
		string text = value.Substring(1, value.Length - 2);
		for (int num = text.Length - 1; num > 0; num--)
		{
			if (text[num] == '\'' && text[num - 1] == '\'')
			{
				text = text.Remove(num, 1);
				num--;
			}
			else if (text[num] == '‘' && text[num - 1] == '‘')
			{
				text = text.Remove(num, 1);
				num--;
			}
			else if (text[num] == '’' && text[num - 1] == '’')
			{
				text = text.Remove(num, 1);
				num--;
			}
		}
		return new Constant
		{
			Value = text
		};
	}

	public override string ToString()
	{
		if (Value == null)
		{
			return string.Empty;
		}
		return Value.ToString();
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		Constant obj = (Constant)base.CreateCopy(parent);
		obj.Value = Value;
		return obj;
	}
}
