// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ObjectExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Metadata;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  public static class ObjectExtensions
  {
    internal static ObjectExtensions NcEoO8GHG5CdwGZy4eit;

    public static void CopyFrom([NotNull] this object @this, object other)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        System.Reflection.PropertyInfo propertyInfo;
        System.Reflection.PropertyInfo reflectionProperty;
        int index;
        object obj;
        System.Reflection.PropertyInfo[] propertyInfoArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_22;
            case 2:
            case 16:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 8 : 7;
              continue;
            case 3:
              index = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 11;
              continue;
            case 4:
              ObjectExtensions.q2raAZGHV6E8IE3Wpso0((object) reflectionProperty, @this, obj, (object) null);
              num2 = 2;
              continue;
            case 5:
              obj = ObjectExtensions.WgBGeEGHIbrbmQUdSA2f((object) propertyInfo, other, (object) null);
              num2 = 4;
              continue;
            case 6:
            case 12:
              goto label_15;
            case 7:
              if (ObjectExtensions.BqtPD4GHvsKa8gy76WLr((object) propertyInfo))
              {
                num2 = 13;
                continue;
              }
              goto case 2;
            case 8:
            case 11:
              if (index < propertyInfoArray.Length)
              {
                num2 = 6;
                continue;
              }
              goto label_5;
            case 9:
              propertyInfoArray = (System.Reflection.PropertyInfo[]) ObjectExtensions.nuZX9hGHCcRc3iW4QePy(other.GetType());
              num2 = 3;
              continue;
            case 10:
              goto label_6;
            case 13:
              goto label_3;
            case 14:
              if (!ObjectExtensions.gtg69eGHuNXxYe2vFIoc((object) reflectionProperty).IsAssignableFrom(ObjectExtensions.gtg69eGHuNXxYe2vFIoc((object) propertyInfo)))
              {
                num2 = 16;
                continue;
              }
              goto case 5;
            case 15:
              if (!(reflectionProperty == (System.Reflection.PropertyInfo) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            default:
              if (ObjectExtensions.GXtZOnGHZfkmP34bZuaQ((object) reflectionProperty))
              {
                num2 = 14;
                continue;
              }
              goto case 2;
          }
        }
label_3:
        reflectionProperty = @this.GetType().GetReflectionProperty((string) ObjectExtensions.yrk9u5GH8Bs4IAlE4ee5((object) propertyInfo));
        num1 = 15;
        continue;
label_6:
        Contract.ArgumentNotNull(@this, (string) ObjectExtensions.iaRvGoGHQf0OvnxNxuog(1470440286 ^ 1470529600));
        num1 = 9;
        continue;
label_15:
        propertyInfo = propertyInfoArray[index];
        num1 = 7;
      }
label_22:
      return;
label_5:;
    }

    public static object InvokeMethod([NotNull] this object @this, string methodName, params object[] args)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (args.Length == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 3:
            if (args != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 2 : 1;
              continue;
            }
            goto label_8;
          case 4:
            Contract.ArgumentNotNull(@this, (string) ObjectExtensions.iaRvGoGHQf0OvnxNxuog(~541731958 ^ -541691753));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 3;
            continue;
          default:
            goto label_8;
        }
      }
label_7:
      return @this.GetType().GetMethod(methodName, ((IEnumerable<object>) args).Select<object, Type>((Func<object, Type>) (a => a.GetType())).ToArray<Type>()).Invoke(@this, args);
label_8:
      return ObjectExtensions.qkqFPPGHSyemR1ZjP15K((object) @this.GetType().GetMethod(methodName, Enumerable.Empty<Type>().ToArray<Type>()), @this, (object) args);
    }

    /// <summary>Получить представление объекта в Dictionary</summary>
    /// <param name="instance">Объект</param>
    /// <returns>Dictionary</returns>
    public static IDictionary<string, object> ToDictionary(this object instance)
    {
      Dictionary<string, object> dictionary1 = new Dictionary<string, object>();
      if (instance != null)
      {
        if (instance is Dictionary<string, object> dictionary2)
        {
          dictionary1 = dictionary2;
        }
        else
        {
          foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(instance))
            dictionary1.Add(property.Name, property.GetValue(instance));
        }
      }
      return (IDictionary<string, object>) dictionary1;
    }

    /// <summary>Расширение для получения свойства объекта</summary>
    /// <param name="obj">Объект</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Свойство объекта</returns>
    public static System.Reflection.PropertyInfo GetProperty(
      this object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!(obj is DataClass dataClass))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return dataClass.GetProperty(metadata, propertyMetadata);
label_3:
      return obj.GetType().GetPropertyCached((string) ObjectExtensions.LgWYZ8GHinAOT4NARYaM((object) propertyMetadata));
    }

    internal static object iaRvGoGHQf0OvnxNxuog(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object nuZX9hGHCcRc3iW4QePy(Type type) => (object) type.GetReflectionProperties();

    internal static bool BqtPD4GHvsKa8gy76WLr([In] object obj0) => ((System.Reflection.PropertyInfo) obj0).CanRead;

    internal static object yrk9u5GH8Bs4IAlE4ee5([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool GXtZOnGHZfkmP34bZuaQ([In] object obj0) => ((System.Reflection.PropertyInfo) obj0).CanWrite;

    internal static Type gtg69eGHuNXxYe2vFIoc([In] object obj0) => ((System.Reflection.PropertyInfo) obj0).PropertyType;

    internal static object WgBGeEGHIbrbmQUdSA2f([In] object obj0, [In] object obj1, [In] object obj2) => ((System.Reflection.PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void q2raAZGHV6E8IE3Wpso0([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((System.Reflection.PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool ro8UudGHECsrnx0Uh4Vu() => ObjectExtensions.NcEoO8GHG5CdwGZy4eit == null;

    internal static ObjectExtensions SJv8D5GHfe8AGl1TbSpc() => ObjectExtensions.NcEoO8GHG5CdwGZy4eit;

    internal static object qkqFPPGHSyemR1ZjP15K([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static object LgWYZ8GHinAOT4NARYaM([In] object obj0) => (object) ((NamedMetadata) obj0).Name;
  }
}
