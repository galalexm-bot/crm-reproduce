using System;
using System.Linq.Expressions;
using NHibernate.Criterion;
using NHibernate.Impl;

namespace EleWise.ELMA.Extensions;

public static class ProjectionsExtensions
{
	public static PropertyProjection Group<T, TResult>(Expression<Func<T, TResult>> expression)
	{
		return Projections.GroupProperty(ExpressionProcessor.FindMemberExpression(expression.Body));
	}
}
