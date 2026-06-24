using System.Collections.Generic;
using System.Linq.Expressions;

namespace System.Linq.Dynamic;

public static class DynamicExpression
{
	internal static DynamicExpression QUr4lbbylougZgBfITT;

	public static Expression Parse(Type resultType, string expression, params object[] values)
	{
		return (Expression)T80HJWb9UamySHCNitv(new ExpressionParser(null, expression, values), resultType);
	}

	public static LambdaExpression ParseLambda(Type itType, Type resultType, string expression, params object[] values)
	{
		return ParseLambda(new ParameterExpression[1] { (ParameterExpression)vVlfNqbdPeXu3iWDnjT(itType, "") }, resultType, expression, values);
	}

	public static LambdaExpression ParseLambda(ParameterExpression[] parameters, Type resultType, string expression, params object[] values)
	{
		return Expression.Lambda((Expression)T80HJWb9UamySHCNitv(new ExpressionParser(parameters, expression, values), resultType), parameters);
	}

	public static Expression<Func<T, S>> ParseLambda<T, S>(string expression, params object[] values)
	{
		return (Expression<Func<T, S>>)ParseLambda(typeof(T), typeof(S), expression, values);
	}

	public static Type CreateClass(params DynamicProperty[] properties)
	{
		return ClassFactory.Instance.GetDynamicClass(properties);
	}

	public static Type CreateClass(IEnumerable<DynamicProperty> properties)
	{
		return ClassFactory.Instance.GetDynamicClass(properties);
	}

	internal static object T80HJWb9UamySHCNitv(object P_0, Type resultType)
	{
		return ((ExpressionParser)P_0).Parse(resultType);
	}

	internal static bool FhNCD7bMcmITMMv5Ucf()
	{
		return QUr4lbbylougZgBfITT == null;
	}

	internal static DynamicExpression w81283bJGlTexX2n0YP()
	{
		return QUr4lbbylougZgBfITT;
	}

	internal static object vVlfNqbdPeXu3iWDnjT(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}
}
