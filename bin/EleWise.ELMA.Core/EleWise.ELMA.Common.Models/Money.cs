using System;
using Bridge;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Common.Models;

public struct Money : System.IFormattable, IBridgeClass, IComparable
{
	private double value;

	private bool _003CHasValue_003Ek__BackingField;

	public double Value
	{
		get
		{
			return value;
		}
		set
		{
			this.value = value;
			HasValue = true;
		}
	}

	public bool HasValue
	{
		get
		{
			return _003CHasValue_003Ek__BackingField;
		}
		set
		{
			_003CHasValue_003Ek__BackingField = value;
		}
	}

	public Money(double value)
	{
		this.value = value;
		HasValue = true;
	}

	public Money(double? value)
	{
		this = default(Money);
		if (!value.get_HasValue())
		{
			this.value = 0.0;
			return;
		}
		this.value = value.get_Value();
		HasValue = true;
	}

	[Convention(/*Could not decode attribute arguments.*/)]
	public static Money Parse(string s)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		double num = default(double);
		if (double.TryParse(s, ref num))
		{
			return new Money(num);
		}
		throw new FormatException(SR.T("Входная строка имела неверный формат"));
	}

	[Convention(/*Could not decode attribute arguments.*/)]
	public static Money Parse(string s, IFormatProvider provider)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		double num = default(double);
		if (double.TryParse(s, provider, ref num))
		{
			return new Money(num);
		}
		throw new FormatException(SR.T("Входная строка имела неверный формат"));
	}

	[Convention(/*Could not decode attribute arguments.*/)]
	public static bool TryParse(string s, out Money result)
	{
		double num = default(double);
		if (double.TryParse(s, ref num))
		{
			result = new Money(num);
			return true;
		}
		result = default(Money);
		return false;
	}

	public override string ToString()
	{
		return Value.ToString();
	}

	public string ToString(string format, IFormatProvider formatProvider)
	{
		return Value.ToString(format, formatProvider);
	}

	public static implicit operator double(Money m)
	{
		return m.Value;
	}

	public static implicit operator Money(double d)
	{
		Money result = default(Money);
		result.Value = d;
		return result;
	}

	public int CompareTo(object obj)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		if (obj == null)
		{
			throw new InvalidOperationException(SR.T("Невозможно сравнить значение типа \"{0}\" с NULL", SR.T("Деньги")));
		}
		System.Type type = obj.GetType();
		if (type == typeof(Money))
		{
			return Compare(((Money)obj).HasValue ? new double?(((Money)obj).Value) : null);
		}
		if (type == typeof(double?))
		{
			return Compare((double?)obj);
		}
		if (type == typeof(double))
		{
			return Compare((double)obj);
		}
		throw new InvalidOperationException(string.Format(SR.T("Невозможно сравнить значение типа \"{0}\" со значением типа \"{1}\""), (object)SR.T("Деньги"), (object)obj.GetType().get_FullName()));
	}

	private int Compare(double? val)
	{
		int num = HasValue.CompareTo(val.get_HasValue());
		if (num == 0 && HasValue)
		{
			return Value.CompareTo((object)val);
		}
		return num;
	}
}
