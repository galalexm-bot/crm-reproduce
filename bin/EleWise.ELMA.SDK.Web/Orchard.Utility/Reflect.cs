using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using Orchard.Validation;

namespace Orchard.Utility;

public static class Reflect
{
	internal class NameBuilder
	{
		private readonly StringBuilder _stringBuilder = new StringBuilder();

		private readonly LambdaExpression _expression;

		public bool DotNeeded => _stringBuilder.Length > 0;

		public NameBuilder(LambdaExpression expression)
		{
			_expression = expression;
		}

		public override string ToString()
		{
			return _stringBuilder.ToString();
		}

		public void Append(string s)
		{
			_stringBuilder.Append(s);
		}
	}

	public static MemberInfo GetMember(Expression<Action> expression)
	{
		Argument.ThrowIfNull(expression, "expression");
		return GetMemberInfo(expression);
	}

	public static MemberInfo GetMember<T>(Expression<Func<T>> expression)
	{
		Argument.ThrowIfNull(expression, "expression");
		return GetMemberInfo(expression);
	}

	public static MethodInfo GetMethod(Expression<Action> expression)
	{
		MethodInfo obj = GetMember(expression) as MethodInfo;
		Argument.ThrowIfNull(obj, "expression", "Expression is not a method call");
		return obj;
	}

	public static PropertyInfo GetProperty<T>(Expression<Func<T>> expression)
	{
		PropertyInfo obj = GetMember(expression) as PropertyInfo;
		Argument.ThrowIfNull(obj, "expression", "Expression is not a property");
		return obj;
	}

	public static FieldInfo GetField<T>(Expression<Func<T>> expression)
	{
		FieldInfo obj = GetMember(expression) as FieldInfo;
		Argument.ThrowIfNull(obj, "expression", "Expression is not a field access");
		return obj;
	}

	public static string NameOf<T>(T value, Expression<Action<T>> expression)
	{
		return GetNameOf(expression);
	}

	public static string NameOf<T, TResult>(T value, Expression<Func<T, TResult>> expression)
	{
		return GetNameOf(expression);
	}

	internal static MemberInfo GetMemberInfo(LambdaExpression lambda)
	{
		Argument.ThrowIfNull(lambda, "lambda");
		if (lambda.Body.NodeType == ExpressionType.Call)
		{
			return ((MethodCallExpression)lambda.Body).Method;
		}
		MemberExpression memberExpression = GetMemberExpression(lambda.Body);
		Argument.ThrowIfNull(memberExpression, "lambda", "Expression is not a member access");
		return memberExpression.Member;
	}

	internal static MemberExpression GetMemberExpression(Expression expression)
	{
		MemberExpression result = null;
		if (expression.NodeType == ExpressionType.Convert)
		{
			result = ((UnaryExpression)expression).Operand as MemberExpression;
		}
		else if (expression.NodeType == ExpressionType.MemberAccess)
		{
			result = expression as MemberExpression;
		}
		return result;
	}

	internal static void AddNames(Expression expression, NameBuilder nb)
	{
		if (expression == null)
		{
			return;
		}
		switch (expression.NodeType)
		{
		case ExpressionType.MemberAccess:
		{
			MemberExpression memberExpression = (MemberExpression)expression;
			AddNames(memberExpression.Expression, nb);
			if (nb.DotNeeded)
			{
				nb.Append(".");
			}
			nb.Append(memberExpression.Member.Name);
			return;
		}
		case ExpressionType.Call:
		{
			MethodCallExpression methodCallExpression = (MethodCallExpression)expression;
			MethodInfo method = methodCallExpression.Method;
			if (method.Name == "get_Item" && method.IsSpecialName)
			{
				AddNames(methodCallExpression.Object, nb);
				nb.Append("[" + string.Join("", GetArguments(methodCallExpression.Arguments)) + "]");
				return;
			}
			break;
		}
		case ExpressionType.Parameter:
			return;
		}
		throw new InvalidOperationException($"Unsupported expression type \"{Enum.GetName(typeof(ExpressionType), expression.NodeType)}\" in named expression");
	}

	private static IEnumerable<string> GetArguments(IEnumerable<Expression> expressions)
	{
		foreach (Expression expression in expressions)
		{
			yield return GetExpressionConstantValue(expression)?.ToString();
		}
	}

	private static object GetExpressionConstantValue(Expression expression)
	{
		switch (expression.NodeType)
		{
		case ExpressionType.Constant:
			return ((ConstantExpression)expression).Value;
		case ExpressionType.MemberAccess:
		{
			MemberExpression memberExpression = (MemberExpression)expression;
			object expressionConstantValue = GetExpressionConstantValue(memberExpression.Expression);
			if (expressionConstantValue == null)
			{
				throw new InvalidOperationException("Member access to \"null\" instance is not supported");
			}
			FieldInfo fieldInfo = memberExpression.Member as FieldInfo;
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(expressionConstantValue);
			}
			PropertyInfo propertyInfo = memberExpression.Member as PropertyInfo;
			if (propertyInfo != null)
			{
				return propertyInfo.GetValue(expressionConstantValue, null);
			}
			throw new InvalidOperationException($"Member access expression \"{memberExpression.GetType().FullName}\" not supported");
		}
		default:
			throw new InvalidOperationException($"Unsupported expression type\"{Enum.GetName(typeof(ExpressionType), expression.NodeType)}\" in method or indexer argument");
		}
	}

	internal static string GetNameOf(LambdaExpression expression)
	{
		NameBuilder nameBuilder = new NameBuilder(expression);
		AddNames(expression.Body, nameBuilder);
		return nameBuilder.ToString();
	}
}
