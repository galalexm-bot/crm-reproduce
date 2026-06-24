using System.Collections.Generic;
using System.ComponentModel;

namespace System.Reflection;

public static class GetReflectionTypeHelper
{
	internal static GetReflectionTypeHelper Aoo2iVGmSZfTqchnKhN;

	private static Type GetReflectionType(this Type type)
	{
		//Discarded unreachable code: IL_003a, IL_0044, IL_0053, IL_0093, IL_00a2
		int num = 1;
		int num2 = num;
		bool? dynamicPublicationEnable = default(bool?);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 3:
				return type;
			case 4:
				return g485lcGJCPPpHdNOJhZ(TypeDescriptor.GetProvider(type), type);
			case 1:
				dynamicPublicationEnable = ReflectionType.DynamicPublicationEnable;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (dynamicPublicationEnable.HasValue)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 5:
				if (dynamicPublicationEnable.GetValueOrDefault())
				{
					num2 = 4;
					break;
				}
				goto case 2;
			}
		}
	}

	public static IEnumerable<Attribute> GetReflectionCustomAttributes(this Type type)
	{
		return type.GetReflectionType().GetCustomAttributes();
	}

	public static IEnumerable<Attribute> GetReflectionCustomAttributes(this Type type, Type attributeType)
	{
		return type.GetReflectionType().GetCustomAttributes(attributeType);
	}

	public static object[] GetReflectionCustomAttributes(this Type type, bool inherit)
	{
		return (object[])fe3fSGGdVYjTcGHFyhc(FJKEEdG9nDNMoO3dI4u(type), inherit);
	}

	public static object[] GetReflectionCustomAttributes(this Type type, Type attributeType, bool inherit)
	{
		return (object[])WPmdZoGljGkPkag1bNJ(type.GetReflectionType(), attributeType, inherit);
	}

	public static PropertyInfo GetReflectionProperty(this Type type, string name, Type returnType)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, returnType);
	}

	public static PropertyInfo GetReflectionProperty(this Type type, string name, Type[] types)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, types);
	}

	public static PropertyInfo GetReflectionProperty(this Type type, string name, BindingFlags bindingAttr, Binder binder, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
	}

	public static PropertyInfo GetReflectionProperty(this Type type, string name, Type returnType, Type[] types, ParameterModifier[] modifiers)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, returnType, types, modifiers);
	}

	public static PropertyInfo GetReflectionProperty(this Type type, string name, BindingFlags bindingAttr)
	{
		return type.GetReflectionType().GetProperty(name, bindingAttr);
	}

	public static PropertyInfo GetReflectionProperty(this Type type, string name, Type returnType, Type[] types)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, returnType, types);
	}

	public static PropertyInfo GetReflectionProperty(this Type type, string name)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetProperty(name);
	}

	public static PropertyInfo[] GetReflectionProperties(this Type type)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetProperties();
	}

	public static PropertyInfo[] GetReflectionProperties(this Type type, BindingFlags bindingAttr)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetProperties(bindingAttr);
	}

	public static MethodInfo GetReflectionMethod(this Type type, string name)
	{
		return type.GetReflectionType().GetMethod(name);
	}

	public static MethodInfo GetReflectionMethod(this Type type, string name, BindingFlags bindingAttr)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetMethod(name, bindingAttr);
	}

	public static MethodInfo GetReflectionMethod(this Type type, string name, Type[] types, ParameterModifier[] modifiers)
	{
		return type.GetReflectionType().GetMethod(name, types, modifiers);
	}

	public static MethodInfo GetReflectionMethod(this Type type, string name, BindingFlags bindingAttr, Binder binder, Type[] types, ParameterModifier[] modifiers)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetMethod(name, bindingAttr, binder, types, modifiers);
	}

	public static MethodInfo GetReflectionMethod(this Type type, string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, Type[] types, ParameterModifier[] modifiers)
	{
		return type.GetReflectionType().GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
	}

	public static MethodInfo GetReflectionMethod(this Type type, string name, Type[] types)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetMethod(name, types);
	}

	public static MethodInfo[] GetReflectionMethods(this Type type)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetMethods();
	}

	public static MethodInfo[] GetReflectionMethods(this Type type, BindingFlags bindingAttr)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetMethods(bindingAttr);
	}

	public static FieldInfo GetReflectionField(this Type type, string name, BindingFlags bindingAttr)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetField(name, bindingAttr);
	}

	public static FieldInfo GetReflectionField(this Type type, string name)
	{
		return type.GetReflectionType().GetField(name);
	}

	public static FieldInfo[] GetReflectionFields(this Type type, BindingFlags bindingAttr)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetFields(bindingAttr);
	}

	public static FieldInfo[] GetReflectionFields(this Type type)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetFields();
	}

	public static MemberInfo[] GetReflectionMember(this Type type, string name)
	{
		return type.GetReflectionType().GetMember(name);
	}

	public static MemberInfo[] GetReflectionMember(this Type type, string name, BindingFlags bindingAttr)
	{
		return type.GetReflectionType().GetMember(name, bindingAttr);
	}

	public static MemberInfo[] GetReflectionMember(this Type type, string name, MemberTypes meberType, BindingFlags bindingAttr)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetMember(name, meberType, bindingAttr);
	}

	public static MemberInfo[] GetReflectionMembers(this Type type)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetMembers();
	}

	public static MemberInfo[] GetReflectionMembers(this Type type, BindingFlags bindingAttr)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetMembers(bindingAttr);
	}

	public static string GetReflectionEnumName(this Type type, object value)
	{
		return type.GetReflectionType().GetEnumName(value);
	}

	public static string[] GetReflectionEnumNames(this Type type)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetEnumNames();
	}

	public static Array GetReflectionEnumValues(this Type type)
	{
		return FJKEEdG9nDNMoO3dI4u(type).GetEnumValues();
	}

	public static bool IsReflectionEnumDefined(this Type type, object value)
	{
		return FJKEEdG9nDNMoO3dI4u(type).IsEnumDefined(value);
	}

	public static Attribute GetReflectionCustomAttribute(this Type type, Type attributeType, bool inherit)
	{
		return (Attribute)CraLmqGrbpZxDXGjtcy(type.GetReflectionType(), attributeType, inherit);
	}

	public static T GetReflectionCustomAttribute<T>(this Type type) where T : Attribute
	{
		return type.GetReflectionType().GetCustomAttribute<T>();
	}

	public static T GetReflectionCustomAttribute<T>(this Type type, bool inherit) where T : Attribute
	{
		return type.GetReflectionType().GetCustomAttribute<T>(inherit);
	}

	public static Attribute GetReflectionCustomAttribute(this Type type, Type attributeType)
	{
		return (Attribute)CJun72GglCfZsp2vZr2(FJKEEdG9nDNMoO3dI4u(type), attributeType);
	}

	public static IEnumerable<T> GetReflectionCustomAttributes<T>(this Type type, bool inherit) where T : Attribute
	{
		return type.GetReflectionType().GetCustomAttributes<T>(inherit);
	}

	public static IEnumerable<T> GetReflectionCustomAttributes<T>(this Type type) where T : Attribute
	{
		return type.GetReflectionType().GetCustomAttributes<T>();
	}

	public static bool IsReflectionDefined(this Type type, Type attributeType)
	{
		return FTVn15G5pnsWCbXf5B0(FJKEEdG9nDNMoO3dI4u(type), attributeType);
	}

	internal static Type g485lcGJCPPpHdNOJhZ(object P_0, Type P_1)
	{
		return ((TypeDescriptionProvider)P_0).GetReflectionType(P_1);
	}

	internal static bool weDZUsGyp9bFfZARcZo()
	{
		return Aoo2iVGmSZfTqchnKhN == null;
	}

	internal static GetReflectionTypeHelper FvkB9vGMtLVdtp5uKgC()
	{
		return Aoo2iVGmSZfTqchnKhN;
	}

	internal static Type FJKEEdG9nDNMoO3dI4u(Type type)
	{
		return type.GetReflectionType();
	}

	internal static object fe3fSGGdVYjTcGHFyhc(object P_0, bool P_1)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1);
	}

	internal static object WPmdZoGljGkPkag1bNJ(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttributes(P_1, P_2);
	}

	internal static object CraLmqGrbpZxDXGjtcy(object P_0, Type P_1, bool P_2)
	{
		return ((MemberInfo)P_0).GetCustomAttribute(P_1, P_2);
	}

	internal static object CJun72GglCfZsp2vZr2(object P_0, Type P_1)
	{
		return ((MemberInfo)P_0).GetCustomAttribute(P_1);
	}

	internal static bool FTVn15G5pnsWCbXf5B0(object P_0, Type P_1)
	{
		return ((MemberInfo)P_0).IsDefined(P_1);
	}
}
