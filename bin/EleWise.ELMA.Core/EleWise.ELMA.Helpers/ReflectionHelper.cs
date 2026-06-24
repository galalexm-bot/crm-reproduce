using System;
using System.Reflection;

namespace EleWise.ELMA.Helpers;

public static class ReflectionHelper
{
	public const string ObsoleteAttributeFullName = "System.ObsoleteAttribute";

	public static object GetPropertyValue(this object target, string fieldName, object defaultValue)
	{
		if (target == null)
		{
			return defaultValue;
		}
		if (string.IsNullOrEmpty(fieldName))
		{
			return defaultValue;
		}
		PropertyInfo property = target.GetType().GetProperty(fieldName, (BindingFlags)28);
		if (property != null)
		{
			return property.GetValue(target, (object[])null);
		}
		return defaultValue;
	}

	public static void SetPropertyValue(this object target, string fieldName, object value)
	{
		PropertyInfo obj = target?.GetType().GetProperty(fieldName, (BindingFlags)28);
		if (obj != null)
		{
			obj.SetValue(target, value, (object[])null);
		}
	}

	public static bool IsInheritOrSame<T>(this System.Type child)
	{
		return child.IsInheritOrSame(typeof(T));
	}

	public static bool IsInheritOrSame(this System.Type child, System.Type parent)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		if (child == null)
		{
			throw new ArgumentNullException("child");
		}
		if (parent == null)
		{
			throw new ArgumentNullException("parent");
		}
		if (parent.get_IsInterface())
		{
			if (child != parent)
			{
				return ArrayExtensions.Contains<System.Type>(child.GetInterfaces(), parent);
			}
			return true;
		}
		if (child != parent)
		{
			return child.IsSubclassOf(parent);
		}
		return true;
	}
}
