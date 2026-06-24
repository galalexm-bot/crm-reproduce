using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

namespace Orchard.Data.Bags;

public class Bag : DynamicObject, IEnumerable<KeyValuePair<string, object>>, IEnumerable, ISItem, ICloneable
{
	internal readonly Dictionary<string, ISItem> _properties = new Dictionary<string, ISItem>();

	public static dynamic New()
	{
		return new Bag();
	}

	public override bool TrySetMember(SetMemberBinder binder, object value)
	{
		return SetMember(binder.Name, value);
	}

	public bool SetMember(string name, object value)
	{
		if (value == null && _properties.ContainsKey(name))
		{
			_properties.Remove(name);
		}
		else
		{
			_properties[name] = SConvert.ToSettings(value);
		}
		return true;
	}

	public override bool TryGetMember(GetMemberBinder binder, out object result)
	{
		return GetMember(binder.Name, out result);
	}

	public bool GetMember(string name, out object result)
	{
		if (!_properties.ContainsKey(name))
		{
			result = null;
			return true;
		}
		ISItem s = _properties[name];
		result = SConvert.ToObject(s);
		return true;
	}

	public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
	{
		return SetMember(indexes[0].ToString(), value);
	}

	public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
	{
		return GetMember(indexes[0].ToString(), out result);
	}

	public static Bag operator &(Bag o1, Bag o2)
	{
		if (o1 == null)
		{
			return o2;
		}
		Bag bag = (Bag)o1.Clone();
		dynamic val = bag;
		foreach (KeyValuePair<string, ISItem> property in o2._properties)
		{
			if (bag._properties.ContainsKey(property.Key))
			{
				if (property.Value == null)
				{
					val[property.Key] = null;
					continue;
				}
				dynamic val2 = bag._properties[property.Key];
				val[property.Key] = val2 & (dynamic)property.Value;
			}
			else if (property.Value != null)
			{
				val[property.Key] = property.Value;
			}
		}
		return bag;
	}

	public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
	{
		foreach (string key in _properties.Keys)
		{
			if (GetMember(key, out var result))
			{
				yield return new KeyValuePair<string, object>(key, result);
			}
		}
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public object Clone()
	{
		dynamic val = New();
		foreach (KeyValuePair<string, ISItem> property in _properties)
		{
			val[property.Key] = property.Value.Clone();
		}
		return val;
	}
}
