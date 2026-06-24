using System;
using System.Linq.Expressions;
using System.Reflection;
using Orchard.Validation;

namespace Orchard.Utility;

public static class ReflectOn<T>
{
	public static MemberInfo GetMember(Expression<Action<T>> expression)
	{
		Argument.ThrowIfNull(expression, "expression");
		return Reflect.GetMemberInfo(expression);
	}

	public static MemberInfo GetMember<TResult>(Expression<Func<T, TResult>> expression)
	{
		Argument.ThrowIfNull(expression, "expression");
		return Reflect.GetMemberInfo(expression);
	}

	public static MethodInfo GetMethod(Expression<Action<T>> expression)
	{
		MethodInfo obj = GetMember(expression) as MethodInfo;
		Argument.ThrowIfNull(obj, "expression", "Expression is not a method call");
		return obj;
	}

	public static PropertyInfo GetProperty<TResult>(Expression<Func<T, TResult>> expression)
	{
		PropertyInfo obj = GetMember(expression) as PropertyInfo;
		Argument.ThrowIfNull(obj, "expression", "Expression is not a property access");
		return obj;
	}

	public static FieldInfo GetField<TResult>(Expression<Func<T, TResult>> expression)
	{
		FieldInfo obj = GetMember(expression) as FieldInfo;
		Argument.ThrowIfNull(obj, "expression", "Expression is not a field access");
		return obj;
	}

	public static string NameOf(Expression<Action<T>> expression)
	{
		return Reflect.GetNameOf(expression);
	}

	public static string NameOf<TResult>(Expression<Func<T, TResult>> expression)
	{
		return Reflect.GetNameOf(expression);
	}
}
