using System;
using System.Linq;

namespace Orchard.Data.Bags;

public class SValue : ISItem, ICloneable
{
	public object Value { get; set; }

	public SValue(object value)
	{
		Value = value;
	}

	public object Clone()
	{
		return new SValue(Value);
	}

	public static SValue operator &(SValue o1, SValue o2)
	{
		return o2;
	}

	public static SArray operator &(SValue o1, SArray o2)
	{
		return new SArray(new SValue[1] { o1 }.Union(o2.Values).ToArray());
	}

	public static Bag operator &(SValue o1, Bag o2)
	{
		return o2;
	}
}
