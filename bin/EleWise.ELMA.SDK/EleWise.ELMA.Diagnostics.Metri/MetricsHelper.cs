using System;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Diagnostics.Metrics;

public static class MetricsHelper<T>
{
	public static string GetDisplayName<TValue>(Expression<Func<T, TValue>> f)
	{
		DisplayNameAttribute attribute = AttributeHelper<DisplayNameAttribute>.GetAttribute(LinqUtils.MemberOf(f), inherited: true);
		if (attribute == null)
		{
			return LinqUtils.NameOf(f);
		}
		return attribute.Value;
	}

	public static long GetOrder<TValue>(Expression<Func<T, TValue>> f)
	{
		return AttributeHelper<OrderAttribute>.GetAttribute(LinqUtils.MemberOf(f), inherited: true)?.Order ?? 0;
	}
}
