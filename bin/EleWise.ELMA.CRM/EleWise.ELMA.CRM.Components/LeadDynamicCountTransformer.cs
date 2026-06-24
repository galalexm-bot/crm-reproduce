using System;
using System.Collections;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using NHibernate.Transform;

namespace EleWise.ELMA.CRM.Components;

[Serializable]
internal class LeadDynamicCountTransformer : IResultTransformer
{
	private readonly int count;

	public LeadDynamicCountTransformer(int count)
	{
		this.count = count;
	}

	public IList TransformList(IList collection)
	{
		return collection;
	}

	public object TransformTuple(object[] tuple, string[] aliases)
	{
		LeadDynamicCount leadDynamicCount = new LeadDynamicCount
		{
			MarketingGroup = Value<IMarketingGroup>(tuple, aliases, "MarketingGroup", null),
			MarketingActivity = Value<IMarketingActivity>(tuple, aliases, "MarketingActivity", null),
			MarketingEffect = Value<IMarketingEffect>(tuple, aliases, "MarketingEffect", null)
		};
		leadDynamicCount.AllCountMonth = new long[count];
		leadDynamicCount.ConvertedCountMonth = new long[count];
		for (int i = 0; i < count; i++)
		{
			leadDynamicCount.AllCountMonth[i] = Value(tuple, aliases, "AllCountMonth" + i, 0L, Convert.ToInt64);
			leadDynamicCount.ConvertedCountMonth[i] = Value(tuple, aliases, "ConvertedCountMonth" + i, 0L, Convert.ToInt64);
		}
		return leadDynamicCount;
	}

	public T Value<T>(object[] tuple, string[] aliases, string name, T defaultValue, Func<object, T> converter = null)
	{
		int num = aliases.ToList().FindIndex((string a) => a.Equals(name, StringComparison.OrdinalIgnoreCase));
		object obj = ((num == -1) ? null : tuple[num]);
		if (obj == null)
		{
			return defaultValue;
		}
		if (converter == null)
		{
			return (T)obj;
		}
		return converter(obj);
	}
}
