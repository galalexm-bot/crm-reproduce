using System;
using Bridge;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Extensions;

public static class ObjectExtensions
{
	public static object GetPlainPropertyValue(this object target, PropertyInfoExpression expression, object defaultValue = null)
	{
		return target.GetPlainPropertyValue(expression.ObjectExpression, defaultValue);
	}

	public static object GetPlainPropertyValue(this object target, string propertyName, object defaultValue = null)
	{
		if (target == null)
		{
			return defaultValue;
		}
		if (string.IsNullOrWhiteSpace(propertyName))
		{
			return defaultValue;
		}
		if (!target.HasProperty(propertyName))
		{
			return defaultValue;
		}
		return target.get_Item(propertyName);
	}

	public static T GetPlainPropertyValue<T>(this object target, PropertyInfoExpression expression)
	{
		return target.GetPlainPropertyValue<T>(expression.ObjectExpression);
	}

	public static T GetPlainPropertyValue<T>(this object target, string propertyName)
	{
		return (T)target.GetPlainPropertyValue(propertyName);
	}

	public static void SetPlainPropertyValue(this object target, PropertyInfoExpression expression, object value)
	{
		target.SetPlainPropertyValue(expression.ObjectExpression, value);
	}

	public static void SetPlainPropertyValue(this object target, string propertyName, object value)
	{
		Contract.ArgumentNotNull(target, "target");
		Contract.ArgumentNotNullOrEmpty(propertyName, "propertyName");
		if (!target.HasProperty(propertyName))
		{
			throw new System.Exception(SR.T("Свойство \"{0}\" отсутствует в типе \"{1}\"", propertyName, target.GetType()));
		}
		target.set_Item(propertyName, value);
	}

	public static void SetAndCreatePlainPropertyValue(this object target, string propertyName, object value)
	{
		Contract.ArgumentNotNull(target, "target");
		Contract.ArgumentNotNullOrEmpty(propertyName, "propertyName");
		target.set_Item(propertyName, value);
	}

	public static bool HasProperty(this object target, string propertyName)
	{
		if (target.IsObjectOrFunction())
		{
			return Script.In(target, propertyName);
		}
		return false;
	}

	public static bool IsObject(this object target)
	{
		return Script.Write<bool>("target && typeof target === 'object'", new object[0]);
	}

	public static bool IsObjectOrFunction(this object target)
	{
		return Script.Write<bool>("target && (typeof target === 'object' || typeof target === 'function')", new object[0]);
	}

	public static object GetOwnPropertyDescriptors(this object obj)
	{
		return Script.Write<object>("Object.getOwnPropertyDescriptors(obj)", new object[0]);
	}
}
