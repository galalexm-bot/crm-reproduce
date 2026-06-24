using System;
using System.Dynamic;
using System.Linq;
using System.Reflection;

namespace Orchard.Data.Bags;

public class SArray : DynamicObject, ISItem, ICloneable
{
	public ISItem[] Values { get; private set; }

	public SArray(Array array)
	{
		Values = new ISItem[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			Values[i] = SConvert.ToSettings(array.GetValue(i));
		}
	}

	public override bool TrySetIndex(SetIndexBinder binder, object[] indexes, object value)
	{
		if (typeof(long).IsAssignableFrom(indexes[0].GetType()))
		{
			Values[(long)indexes[0]] = SConvert.ToSettings(value);
			return true;
		}
		return false;
	}

	public override bool TryGetIndex(GetIndexBinder binder, object[] indexes, out object result)
	{
		if (typeof(long).IsAssignableFrom(indexes[0].GetType()))
		{
			result = SConvert.ToObject(Values[(long)indexes[0]]);
			return true;
		}
		result = null;
		return false;
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		try
		{
			result = typeof(Array).InvokeMember(binder.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, Values, args);
			return true;
		}
		catch
		{
			result = null;
			return false;
		}
	}

	public object Clone()
	{
		return Values.Select((ISItem x) => x.Clone()).Cast<ISItem>().ToArray();
	}

	public static SArray operator &(SArray o1, SArray o2)
	{
		return new SArray(o1.Values.Union(o2.Values).ToArray());
	}

	public static SArray operator &(SArray o1, SValue o2)
	{
		return new SArray(o1.Values.Union(new SArray[1] { o1 }).ToArray());
	}

	public static Bag operator &(SArray o1, Bag o2)
	{
		return o2;
	}
}
