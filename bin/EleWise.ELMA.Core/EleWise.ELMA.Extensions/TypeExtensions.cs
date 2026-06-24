using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Collections;

namespace EleWise.ELMA.Extensions;

public static class TypeExtensions
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<System.Type, bool> _003C_003E9__7_0;

		internal bool _003CGetTypeElementFromEnumerable_003Eb__7_0(System.Type a)
		{
			return a.get_FullName() == typeof(System.Collections.Generic.IEnumerable<>).get_FullName();
		}
	}

	public static bool IsAssignableFromNull(this System.Type type)
	{
		if (!type.get_IsClass() && !type.get_IsInterface() && type != typeof(string))
		{
			return type.IsNullableType();
		}
		return true;
	}

	public static object GetDefault(this System.Type type)
	{
		if (!type.get_IsValueType())
		{
			return null;
		}
		return Activator.CreateInstance(type);
	}

	public static bool IsNullableType(this System.Type theType)
	{
		if (theType.get_IsGenericType())
		{
			return theType.GetGenericTypeDefinition() == typeof(System.Nullable<>);
		}
		return false;
	}

	public static System.Type GetNonNullableType(this System.Type type)
	{
		if (!type.IsNullableType())
		{
			return type;
		}
		return type.GetGenericArguments()[0];
	}

	public static bool CanBeNullableType(this System.Type sourceType)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		if (sourceType == null)
		{
			throw new ArgumentNullException("sourceType");
		}
		if (sourceType == typeof(void))
		{
			return false;
		}
		if (sourceType.get_IsValueType())
		{
			if (sourceType.get_IsGenericType())
			{
				return sourceType.GetGenericTypeDefinition() != typeof(System.Nullable<>);
			}
			return true;
		}
		return false;
	}

	public static bool IsIEnumerableTOrArray(this System.Type type)
	{
		if (type.get_IsArray())
		{
			return true;
		}
		if (type.IsIEnumerableT())
		{
			return true;
		}
		return false;
	}

	public static bool IsIEnumerableT(this System.Type type)
	{
		if (type.get_IsGenericType())
		{
			return type.GetGenericTypeDefinition() == typeof(System.Collections.Generic.IEnumerable<>);
		}
		return false;
	}

	public static System.Type GetTypeElementFromEnumerable(this System.Type type)
	{
		if (type.get_IsArray())
		{
			return type.GetElementType();
		}
		if (type.IsIEnumerableT())
		{
			System.Type[] genericArguments = type.GetGenericArguments();
			if (genericArguments.Length != 0)
			{
				return genericArguments[0];
			}
		}
		if (type.get_IsGenericType())
		{
			System.Type type2 = Enumerable.FirstOrDefault<System.Type>((System.Collections.Generic.IEnumerable<System.Type>)type.GetInterfaces(), (Func<System.Type, bool>)((System.Type a) => a.get_FullName() == typeof(System.Collections.Generic.IEnumerable<>).get_FullName()));
			if (type2 != null)
			{
				System.Type[] genericArguments2 = type2.GetGenericArguments();
				if (genericArguments2.Length != 0)
				{
					return genericArguments2[0];
				}
			}
		}
		return null;
	}

	public static System.Collections.IEnumerable CreateEmptyEnumerable(this System.Type type)
	{
		if (type.get_IsArray())
		{
			return (System.Collections.IEnumerable)System.Array.CreateInstance(type.GetElementType(), new int[0]);
		}
		return ObjectExtensions.As<System.Collections.IEnumerable>(Activator.CreateInstance(typeof(ReactiveCollection<>).MakeGenericType(type.GetGenericArguments())));
	}

	public static bool IsSimpleType(this System.Type type)
	{
		if (!type.get_IsPrimitive() && type != typeof(string))
		{
			return type == typeof(Guid);
		}
		return true;
	}
}
