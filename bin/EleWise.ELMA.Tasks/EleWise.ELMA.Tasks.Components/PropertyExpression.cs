using System;
using System.Linq.Expressions;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Tasks.Components;

public static class PropertyExpression<TModel>
{
	public static string Name<TValue>([NotNull] Expression<Func<TModel, TValue>> propertyExpr)
	{
		if (propertyExpr == null)
		{
			throw new ArgumentNullException("propertyExpr");
		}
		return ((MemberExpression)propertyExpr.Body).Member.Name;
	}
}
