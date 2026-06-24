// Decompiled with JetBrains decompiler
// Type: System.Reflection.GetReflectionTypeHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace System.Reflection
{
  /// <summary>
  /// Хелпер для получение ReflectionType у экземпляра объекта
  /// </summary>
  public static class GetReflectionTypeHelper
  {
    internal static GetReflectionTypeHelper Aoo2iVGmSZfTqchnKhN;

    /// <summary>
    /// Получить тип изменяемой при публикации сущности для рефлексии
    /// </summary>
    private static Type GetReflectionType(this Type type)
    {
      int num1 = 1;
      while (true)
      {
        bool? publicationEnable;
        int num2;
        switch (num1)
        {
          case 1:
            publicationEnable = ReflectionType.DynamicPublicationEnable;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          case 2:
            num2 = 0;
            break;
          case 3:
            goto label_3;
          case 4:
            goto label_4;
          case 5:
            num2 = publicationEnable.GetValueOrDefault() ? 1 : 0;
            break;
          default:
            if (publicationEnable.HasValue)
            {
              num1 = 5;
              continue;
            }
            goto case 2;
        }
        if (num2 != 0)
          num1 = 4;
        else
          break;
      }
label_3:
      return type;
label_4:
      return GetReflectionTypeHelper.g485lcGJCPPpHdNOJhZ((object) TypeDescriptor.GetProvider(type), type);
    }

    /// <Summary>
    /// Retrieves a collection of custom attributes that are applied to a specified member.
    /// </Summary>
    public static IEnumerable<Attribute> GetReflectionCustomAttributes(this Type type) => type.GetReflectionType().GetCustomAttributes();

    /// <Summary>
    /// Retrieves a collection of custom attributes of a specified type that are applied to a specified member.
    /// </Summary>
    public static IEnumerable<Attribute> GetReflectionCustomAttributes(
      this Type type,
      Type attributeType)
    {
      return type.GetReflectionType().GetCustomAttributes(attributeType);
    }

    /// <Summary>
    /// When overridden in a derived class, returns an array of all custom attributes applied to this member.
    /// </Summary>
    public static object[] GetReflectionCustomAttributes(this Type type, bool inherit) => (object[]) GetReflectionTypeHelper.fe3fSGGdVYjTcGHFyhc((object) GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type), inherit);

    /// <Summary>
    /// When overridden in a derived class, returns an array of custom attributes applied to this member and identified by System.Type.
    /// </Summary>
    public static object[] GetReflectionCustomAttributes(
      this Type type,
      Type attributeType,
      bool inherit)
    {
      return (object[]) GetReflectionTypeHelper.WPmdZoGljGkPkag1bNJ((object) type.GetReflectionType(), attributeType, inherit);
    }

    /// <Summary>
    /// Searches for the public property with the specified name and return type.
    /// </Summary>
    public static PropertyInfo GetReflectionProperty(this Type type, string name, Type returnType) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, returnType);

    /// <Summary>
    /// Searches for the specified public property whose parameters match the specified argument types.
    /// </Summary>
    public static PropertyInfo GetReflectionProperty(this Type type, string name, Type[] types) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, types);

    /// <Summary>
    /// Searches for the specified property whose parameters match the specified argument types and modifiers, using the specified binding constraints.
    /// </Summary>
    public static PropertyInfo GetReflectionProperty(
      this Type type,
      string name,
      BindingFlags bindingAttr,
      Binder binder,
      Type returnType,
      Type[] types,
      ParameterModifier[] modifiers)
    {
      return GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, bindingAttr, binder, returnType, types, modifiers);
    }

    /// <Summary>
    /// Searches for the specified public property whose parameters match the specified argument types and modifiers.
    /// </Summary>
    public static PropertyInfo GetReflectionProperty(
      this Type type,
      string name,
      Type returnType,
      Type[] types,
      ParameterModifier[] modifiers)
    {
      return GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, returnType, types, modifiers);
    }

    /// <Summary>
    /// Searches for the specified property, using the specified binding constraints.
    /// </Summary>
    public static PropertyInfo GetReflectionProperty(
      this Type type,
      string name,
      BindingFlags bindingAttr)
    {
      return type.GetReflectionType().GetProperty(name, bindingAttr);
    }

    /// <Summary>
    /// Searches for the specified public property whose parameters match the specified argument types.
    /// </Summary>
    public static PropertyInfo GetReflectionProperty(
      this Type type,
      string name,
      Type returnType,
      Type[] types)
    {
      return GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetProperty(name, returnType, types);
    }

    /// <Summary>
    /// Searches for the public property with the specified name.
    /// </Summary>
    public static PropertyInfo GetReflectionProperty(this Type type, string name) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetProperty(name);

    /// <Summary>
    /// Returns all the public properties of the current System.Type.
    /// </Summary>
    public static PropertyInfo[] GetReflectionProperties(this Type type) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetProperties();

    /// <Summary>
    /// When overridden in a derived class, searches for the properties of the current System.Type, using the specified binding constraints.
    /// </Summary>
    public static PropertyInfo[] GetReflectionProperties(this Type type, BindingFlags bindingAttr) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetProperties(bindingAttr);

    /// <Summary>
    /// Searches for the public method with the specified name.
    /// </Summary>
    public static MethodInfo GetReflectionMethod(this Type type, string name) => type.GetReflectionType().GetMethod(name);

    /// <Summary>
    /// Searches for the specified method, using the specified binding constraints.
    /// </Summary>
    public static MethodInfo GetReflectionMethod(
      this Type type,
      string name,
      BindingFlags bindingAttr)
    {
      return GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetMethod(name, bindingAttr);
    }

    /// <Summary>
    /// Searches for the specified public method whose parameters match the specified argument types and modifiers.
    /// </Summary>
    public static MethodInfo GetReflectionMethod(
      this Type type,
      string name,
      Type[] types,
      ParameterModifier[] modifiers)
    {
      return type.GetReflectionType().GetMethod(name, types, modifiers);
    }

    /// <Summary>
    /// Searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints.
    /// </Summary>
    public static MethodInfo GetReflectionMethod(
      this Type type,
      string name,
      BindingFlags bindingAttr,
      Binder binder,
      Type[] types,
      ParameterModifier[] modifiers)
    {
      return GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetMethod(name, bindingAttr, binder, types, modifiers);
    }

    /// <Summary>
    /// Searches for the specified method whose parameters match the specified argument types and modifiers, using the specified binding constraints and the specified calling convention.
    /// </Summary>
    public static MethodInfo GetReflectionMethod(
      this Type type,
      string name,
      BindingFlags bindingAttr,
      Binder binder,
      CallingConventions callConvention,
      Type[] types,
      ParameterModifier[] modifiers)
    {
      return type.GetReflectionType().GetMethod(name, bindingAttr, binder, callConvention, types, modifiers);
    }

    /// <Summary>
    /// Searches for the specified public method whose parameters match the specified argument types.
    /// </Summary>
    public static MethodInfo GetReflectionMethod(this Type type, string name, Type[] types) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetMethod(name, types);

    /// <Summary>
    /// Returns all the public methods of the current System.Type.
    /// </Summary>
    public static MethodInfo[] GetReflectionMethods(this Type type) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetMethods();

    /// <Summary>
    /// When overridden in a derived class, searches for the methods defined for the current System.Type, using the specified binding constraints.
    /// </Summary>
    public static MethodInfo[] GetReflectionMethods(this Type type, BindingFlags bindingAttr) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetMethods(bindingAttr);

    /// <Summary>
    /// Searches for the specified field, using the specified binding constraints.
    /// </Summary>
    public static FieldInfo GetReflectionField(
      this Type type,
      string name,
      BindingFlags bindingAttr)
    {
      return GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetField(name, bindingAttr);
    }

    /// <Summary>
    /// Searches for the public field with the specified name.
    /// </Summary>
    public static FieldInfo GetReflectionField(this Type type, string name) => type.GetReflectionType().GetField(name);

    /// <Summary>
    /// When overridden in a derived class, searches for the fields defined for the current System.Type, using the specified binding constraints.
    /// </Summary>
    public static FieldInfo[] GetReflectionFields(this Type type, BindingFlags bindingAttr) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetFields(bindingAttr);

    /// <Summary>
    /// Returns all the public fields of the current System.Type.
    /// </Summary>
    public static FieldInfo[] GetReflectionFields(this Type type) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetFields();

    /// <Summary>
    /// Searches for the public members with the specified name.
    /// </Summary>
    public static MemberInfo[] GetReflectionMember(this Type type, string name) => type.GetReflectionType().GetMember(name);

    /// <Summary>
    /// Searches for the specified members, using the specified binding constraints.
    /// </Summary>
    public static MemberInfo[] GetReflectionMember(
      this Type type,
      string name,
      BindingFlags bindingAttr)
    {
      return type.GetReflectionType().GetMember(name, bindingAttr);
    }

    /// <Summary>
    /// Searches for the specified members of the specified member type, using the specified binding constraints.
    /// </Summary>
    public static MemberInfo[] GetReflectionMember(
      this Type type,
      string name,
      MemberTypes meberType,
      BindingFlags bindingAttr)
    {
      return GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetMember(name, meberType, bindingAttr);
    }

    /// <Summary>
    /// Returns all the public members of the current System.Type.
    /// </Summary>
    public static MemberInfo[] GetReflectionMembers(this Type type) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetMembers();

    /// <Summary>
    /// When overridden in a derived class, searches for the members defined for the current System.Type, using the specified binding constraints.
    /// </Summary>
    public static MemberInfo[] GetReflectionMembers(this Type type, BindingFlags bindingAttr) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetMembers(bindingAttr);

    /// <Summary>
    /// Returns the name of the constant that has the specified value, for the current enumeration type.
    /// </Summary>
    public static string GetReflectionEnumName(this Type type, object value) => type.GetReflectionType().GetEnumName(value);

    /// <Summary>
    /// Returns the names of the members of the current enumeration type.
    /// </Summary>
    public static string[] GetReflectionEnumNames(this Type type) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetEnumNames();

    /// <Summary>
    /// Returns an array of the values of the constants in the current enumeration type.
    /// </Summary>
    public static Array GetReflectionEnumValues(this Type type) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).GetEnumValues();

    /// <Summary>
    /// Returns a value that indicates whether the specified value exists in the current enumeration type.
    /// </Summary>
    public static bool IsReflectionEnumDefined(this Type type, object value) => GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type).IsEnumDefined(value);

    /// <summary>
    /// Retrieves a custom attribute of a specified type that is applied to a specified member, and optionally inspects the ancestors of that member.
    /// </summary>
    public static Attribute GetReflectionCustomAttribute(
      this Type type,
      Type attributeType,
      bool inherit)
    {
      return (Attribute) GetReflectionTypeHelper.CraLmqGrbpZxDXGjtcy((object) type.GetReflectionType(), attributeType, inherit);
    }

    /// <summary>
    /// Retrieves a custom attribute of a specified type that is applied to a specified member.
    /// </summary>
    public static T GetReflectionCustomAttribute<T>(this Type type) where T : Attribute => type.GetReflectionType().GetCustomAttribute<T>();

    /// <summary>
    /// Retrieves a custom attribute of a specified type that is applied to a specified member, and optionally inspects the ancestors of that member.
    /// </summary>
    public static T GetReflectionCustomAttribute<T>(this Type type, bool inherit) where T : Attribute => type.GetReflectionType().GetCustomAttribute<T>(inherit);

    /// <summary>
    /// Retrieves a custom attribute of a specified type that is applied to a specified member.
    /// </summary>
    public static Attribute GetReflectionCustomAttribute(this Type type, Type attributeType) => (Attribute) GetReflectionTypeHelper.CJun72GglCfZsp2vZr2((object) GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type), attributeType);

    /// <summary>
    /// Retrieves a collection of custom attributes of a specified type that are applied to a specified member, and optionally inspects the ancestors of that member.
    /// </summary>
    public static IEnumerable<T> GetReflectionCustomAttributes<T>(this Type type, bool inherit) where T : Attribute => type.GetReflectionType().GetCustomAttributes<T>(inherit);

    /// <summary>
    /// Retrieves a collection of custom attributes of a specified type that are applied to a specified member.
    /// </summary>
    public static IEnumerable<T> GetReflectionCustomAttributes<T>(this Type type) where T : Attribute => type.GetReflectionType().GetCustomAttributes<T>();

    /// <summary>
    /// Indicates whether custom attributes of a specified type are applied to a specified member.
    /// </summary>
    public static bool IsReflectionDefined(this Type type, Type attributeType) => GetReflectionTypeHelper.FTVn15G5pnsWCbXf5B0((object) GetReflectionTypeHelper.FJKEEdG9nDNMoO3dI4u(type), attributeType);

    internal static Type g485lcGJCPPpHdNOJhZ([In] object obj0, [In] Type obj1) => ((TypeDescriptionProvider) obj0).GetReflectionType(obj1);

    internal static bool weDZUsGyp9bFfZARcZo() => GetReflectionTypeHelper.Aoo2iVGmSZfTqchnKhN == null;

    internal static GetReflectionTypeHelper FvkB9vGMtLVdtp5uKgC() => GetReflectionTypeHelper.Aoo2iVGmSZfTqchnKhN;

    internal static Type FJKEEdG9nDNMoO3dI4u(Type type) => type.GetReflectionType();

    internal static object fe3fSGGdVYjTcGHFyhc([In] object obj0, [In] bool obj1) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1);

    internal static object WPmdZoGljGkPkag1bNJ([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttributes(obj1, obj2);

    internal static object CraLmqGrbpZxDXGjtcy([In] object obj0, [In] Type obj1, [In] bool obj2) => (object) ((MemberInfo) obj0).GetCustomAttribute(obj1, obj2);

    internal static object CJun72GglCfZsp2vZr2([In] object obj0, [In] Type obj1) => (object) ((MemberInfo) obj0).GetCustomAttribute(obj1);

    internal static bool FTVn15G5pnsWCbXf5B0([In] object obj0, [In] Type obj1) => ((MemberInfo) obj0).IsDefined(obj1);
  }
}
