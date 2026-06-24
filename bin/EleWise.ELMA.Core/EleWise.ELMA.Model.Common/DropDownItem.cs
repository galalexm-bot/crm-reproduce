using System;
using Bridge;
using EleWise.ELMA.Core;

namespace EleWise.ELMA.Model.Common;

public class DropDownItem : IComparable, IBridgeClass
{
	private readonly string _003CKey_003Ek__BackingField;

	private readonly string _003CValue_003Ek__BackingField;

	public string Key => _003CKey_003Ek__BackingField;

	public string Value => _003CValue_003Ek__BackingField;

	public DropDownItem(string key, string value)
	{
		_003CKey_003Ek__BackingField = key;
		_003CValue_003Ek__BackingField = value;
	}

	public DropDownItem(string stringValue)
	{
		_003CKey_003Ek__BackingField = null;
		_003CValue_003Ek__BackingField = "";
		if (string.IsNullOrEmpty(stringValue))
		{
			return;
		}
		if (!stringValue.StartsWith("{"))
		{
			_003CValue_003Ek__BackingField = stringValue;
			return;
		}
		int num = stringValue.IndexOf('}');
		if (num <= 0)
		{
			_003CValue_003Ek__BackingField = stringValue;
			return;
		}
		_003CKey_003Ek__BackingField = stringValue.Substring(1, num - 1);
		_003CValue_003Ek__BackingField = stringValue.Substring(num + 1);
	}

	public string GetLocalizedValue()
	{
		if (!string.IsNullOrEmpty(Key))
		{
			return SR.T(Value);
		}
		return Value;
	}

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		return string.Compare(((object)this).ToString(), obj.ToString(), (StringComparison)4);
	}

	public override string ToString()
	{
		return ((!string.IsNullOrEmpty(Key)) ? ("{" + Key + "}") : "") + Value;
	}

	public override int GetHashCode()
	{
		return ((object)((object)this).ToString()).GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		return (obj.ToString() ?? "").Equals(((object)this).ToString());
	}
}
