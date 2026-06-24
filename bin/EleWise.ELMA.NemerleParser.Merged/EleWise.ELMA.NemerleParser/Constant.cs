using System.Globalization;

namespace EleWise.ELMA.NemerleParser;

public class Constant : Expression
{
	public object Value { get; set; }

	public static Constant ParseNumberConstant(string value)
	{
		bool flag = false;
		string text = null;
		Constant result;
		if (value.Contains(".") || value.Contains(","))
		{
			text = value.Replace(".", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator).Replace(",", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator);
			Constant constant = new Constant();
			constant.Value = double.Parse(text);
			result = constant;
		}
		else
		{
			Constant constant = new Constant();
			constant.Value = long.Parse(value);
			result = constant;
		}
		return result;
	}

	public static Constant ParseStringConstant(string value)
	{
		int num = 0;
		string text = null;
		checked
		{
			text = value.Substring(1, value.Length - 2);
			for (num = text.Length - 1; num > 0; num--)
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
				else if (text[num] == '`' && text[num - 1] == '`')
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
			Constant constant = new Constant();
			constant.Value = text;
			return constant;
		}
	}

	public override string ToString()
	{
		object result;
		if (Value != null)
		{
			object value = Value;
			result = ((!(value is string)) ? Value.ToString() : $"'{Value}'");
		}
		else
		{
			result = "NULL";
		}
		return (string)result;
	}

	public override TreeItem CreateCopy(TreeItem parent)
	{
		Constant constant = null;
		constant = (Constant)base.CreateCopy(parent);
		constant.Value = Value;
		return constant;
	}
}
