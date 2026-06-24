// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.ReflectionHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Helpers
{
  public static class ReflectionHelper
  {
    internal static ReflectionHelper UR9uwehzMWMMwIbvWohe;

    public static T GetFieldValue<T>(this object target, string fieldName, T defaultValue)
    {
      if (target == null)
        return defaultValue;
      FieldInfo field = target.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
      return field == (FieldInfo) null ? defaultValue : (T) field.GetValue(target);
    }

    public static IEnumerable<FieldInfo> GetAllFields(Type t)
    {
      if (t == (Type) null)
        return Enumerable.Empty<FieldInfo>();
      BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
      return ((IEnumerable<FieldInfo>) t.GetReflectionFields(bindingAttr)).Union<FieldInfo>(ReflectionHelper.GetAllFields(t.BaseType));
    }

    /// <summary>Получить значение свойства объекта</summary>
    /// <param name="target"></param>
    /// <param name="fieldName"></param>
    /// <param name="defaultValue"></param>
    /// <returns></returns>
    public static object GetPropertyValue(
      this object target,
      string fieldName,
      object defaultValue)
    {
      int num = 4;
      PropertyInfo propertyInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (propertyInfo == (PropertyInfo) null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            }
            goto label_9;
          case 3:
            if (!string.IsNullOrEmpty(fieldName))
            {
              propertyInfo = (PropertyInfo) ReflectionHelper.wHc5AGhzdZLtw38Q6RGm(target.GetType(), (object) fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty);
              num = 2;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
            continue;
          case 4:
            if (target != null)
            {
              num = 3;
              continue;
            }
            goto label_10;
          case 5:
            goto label_10;
          default:
            goto label_8;
        }
      }
label_6:
      return defaultValue;
label_8:
      return defaultValue;
label_9:
      return ReflectionHelper.l9R1WPhzlZUanwp87fCP((object) propertyInfo, target, (object) null);
label_10:
      return defaultValue;
    }

    /// <summary>Установить значение свойства объекта</summary>
    /// <param name="target"></param>
    /// <param name="fieldName"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static void SetPropertyValue(this object target, string fieldName, object value)
    {
      int num = 5;
      PropertyInfo reflectionProperty;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (!(reflectionProperty == (PropertyInfo) null))
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 2:
            reflectionProperty.SetValue(target, value, (object[]) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_5;
          case 4:
            goto label_9;
          case 5:
            if (target != null)
            {
              reflectionProperty = target.GetType().GetReflectionProperty(fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.SetProperty);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
              continue;
            }
            num = 4;
            continue;
          default:
            goto label_12;
        }
      }
label_7:
      return;
label_5:
      return;
label_9:
      return;
label_12:
      return;
label_2:;
    }

    public static bool IsInheritOrSame<T>(this Type child) => child.IsInheritOrSame(typeof (T));

    public static bool IsInheritOrSame(this Type child, Type parent)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (ReflectionHelper.na7U9lhzrDe2eV5Ig4cp(child, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
              continue;
            }
            if (!ReflectionHelper.na7U9lhzrDe2eV5Ig4cp(parent, (Type) null))
            {
              if (!parent.IsInterface)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 7 : 8;
                continue;
              }
              goto case 5;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            }
          case 3:
            goto label_5;
          case 4:
            goto label_12;
          case 5:
            if (ReflectionHelper.na7U9lhzrDe2eV5Ig4cp(child, parent))
            {
              num = 7;
              continue;
            }
            goto label_12;
          case 6:
            goto label_6;
          case 7:
            goto label_13;
          case 8:
            if (ReflectionHelper.na7U9lhzrDe2eV5Ig4cp(child, parent))
            {
              num = 6;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) ReflectionHelper.htXchFhzg6gVSVlIVpke(-2107978722 ^ -2108059950));
label_5:
      return child.IsSubclassOf(parent);
label_6:
      return true;
label_9:
      throw new ArgumentNullException((string) ReflectionHelper.htXchFhzg6gVSVlIVpke(1242972401 >> 4 ^ 77780723));
label_12:
      return ((IEnumerable<Type>) child.GetInterfaces()).Contains<Type>(parent);
label_13:
      return true;
    }

    /// <summary>Является ли текущий тип наследником generic-типа</summary>
    /// <param name="type">Текущий тип</param>
    /// <param name="genericType">generic-тип</param>
    /// <returns></returns>
    public static bool IsAssignableToGenericType(this Type type, Type genericType)
    {
      int num1 = 1;
      Type baseType;
      Type genericType1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Type[] interfaces;
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            case 2:
              interfaces = type.GetInterfaces();
              num2 = 7;
              continue;
            case 3:
              if (ReflectionHelper.na7U9lhzrDe2eV5Ig4cp(type.GetGenericTypeDefinition(), genericType1))
              {
                num2 = 8;
                continue;
              }
              break;
            case 4:
              if (!(baseType != (Type) null))
              {
                num2 = 6;
                continue;
              }
              goto label_10;
            case 5:
              goto label_17;
            case 6:
              goto label_11;
            case 7:
              if (type.IsGenericType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 3;
                continue;
              }
              break;
            case 8:
              goto label_14;
            case 9:
              goto label_10;
            default:
              genericType1 = genericType;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 1;
              continue;
          }
          if (!((IEnumerable<Type>) interfaces).Any<Type>((Func<Type, bool>) (it =>
          {
            int num3 = 2;
            while (true)
            {
              switch (num3)
              {
                case 1:
                  goto label_3;
                case 2:
                  if (!it.IsGenericType)
                  {
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                    continue;
                  }
                  goto label_2;
                default:
                  goto label_2;
              }
            }
label_2:
            // ISSUE: reference to a compiler-generated method
            return ReflectionHelper.\u003C\u003Ec__DisplayClass6_0.xM7BTKv92hNBi5lBY9kA(it.GetGenericTypeDefinition(), genericType1);
label_3:
            return false;
          })))
          {
            baseType = type.BaseType;
            num2 = 4;
          }
          else
            break;
        }
        num1 = 5;
      }
label_10:
      return ReflectionHelper.c1t8nHhz5G7XlDLLeFAx(baseType, genericType1);
label_11:
      return false;
label_14:
      return true;
label_17:
      return true;
    }

    /// <summary>Вычислить значение свойства</summary>
    /// <param name="name">Название свойства, например WorkflowInstance.Id</param>
    /// <param name="obj">Объект</param>
    /// <returns></returns>
    public static object GetPropertyValue(string name, object obj)
    {
      int num1 = 1;
      List<string>.Enumerator enumerator;
      object propertyValue1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (obj == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 2:
            goto label_20;
          case 3:
            goto label_2;
          case 5:
            if (!ReflectionHelper.MdEqoWhzj7woNaKCZaiP((object) name))
            {
              List<string> list = ((IEnumerable<string>) name.Split('.')).ToList<string>();
              propertyValue1 = obj;
              enumerator = list.GetEnumerator();
              num1 = 3;
              continue;
            }
            num1 = 4;
            continue;
          default:
            goto label_16;
        }
      }
label_2:
      object propertyValue2;
      try
      {
label_8:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_9;
label_3:
        string current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              propertyValue1 = ReflectionHelper.HZiKNvhzYIfTrWRTs9Wi(propertyValue1, (object) current, (object) null);
              num2 = 6;
              continue;
            case 2:
              goto label_20;
            case 3:
              goto label_21;
            case 4:
              goto label_5;
            case 5:
              goto label_8;
            case 6:
              if (propertyValue1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            default:
              propertyValue2 = (object) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 3 : 2;
              continue;
          }
        }
label_5:
        current = enumerator.Current;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        {
          num2 = 1;
          goto label_3;
        }
        else
          goto label_3;
label_9:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 2;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_21:
      return propertyValue2;
label_16:
      return (object) null;
label_20:
      return propertyValue1;
    }

    internal static object wHc5AGhzdZLtw38Q6RGm(Type type, [In] object obj1, BindingFlags bindingAttr) => (object) type.GetReflectionProperty((string) obj1, bindingAttr);

    internal static object l9R1WPhzlZUanwp87fCP([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool Wi7xQJhzJkJwlt86nV2c() => ReflectionHelper.UR9uwehzMWMMwIbvWohe == null;

    internal static ReflectionHelper BTp7bwhz9qUQb3HWd9vh() => ReflectionHelper.UR9uwehzMWMMwIbvWohe;

    internal static bool na7U9lhzrDe2eV5Ig4cp([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object htXchFhzg6gVSVlIVpke(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool c1t8nHhz5G7XlDLLeFAx(Type type, Type genericType) => type.IsAssignableToGenericType(genericType);

    internal static bool MdEqoWhzj7woNaKCZaiP([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object HZiKNvhzYIfTrWRTs9Wi([In] object obj0, [In] object obj1, [In] object obj2) => obj0.GetPropertyValue((string) obj1, obj2);
  }
}
