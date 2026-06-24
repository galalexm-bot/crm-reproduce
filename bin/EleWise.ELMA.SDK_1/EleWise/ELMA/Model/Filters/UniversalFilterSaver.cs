// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Filters.UniversalFilterSaver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Filters
{
  /// <summary>Помощник для сохранения фильтра сущности</summary>
  public class UniversalFilterSaver
  {
    private static Func<Type, Dictionary<Guid, string>> getUniversalFilter;
    internal static UniversalFilterSaver twwEdSWYYOaT4pc0BSaA;

    private static void SetValue(object obj, object property, object value)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        Type enumType;
        while (true)
        {
          object obj1;
          object obj2;
          switch (num2)
          {
            case 1:
            case 2:
              if (UniversalFilterSaver.t5BWe8WYspFxTi9F4NK3(property).IsEnum)
              {
                num2 = 4;
                continue;
              }
              UniversalFilterSaver.WrbSdTWLBqY949w1mU3o(property, obj, value, (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 4 : 6;
              continue;
            case 3:
              goto label_11;
            case 4:
              obj2 = UniversalFilterSaver.qIlRhXWLFXZ4LJ0O4nGB(((PropertyInfo) property).PropertyType, value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 8 : 11;
              continue;
            case 5:
              goto label_6;
            case 6:
              goto label_3;
            case 7:
              ((PropertyInfo) property).SetValue(obj, obj1, (object[]) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 3 : 0;
              continue;
            case 8:
              if (!UniversalFilterSaver.qBHDTlWYzHcmrqxhGq0j(enumType, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                continue;
              }
              goto case 10;
            case 9:
              goto label_9;
            case 10:
              if (!enumType.IsEnum)
              {
                num2 = 2;
                continue;
              }
              break;
            case 11:
              UniversalFilterSaver.WrbSdTWLBqY949w1mU3o(property, obj, obj2, (object) null);
              num2 = 5;
              continue;
          }
          obj1 = Enum.ToObject(enumType, value);
          num2 = 7;
        }
label_9:
        enumType = UniversalFilterSaver.oKrjyQWYcD1pcUh65Z4d(UniversalFilterSaver.t5BWe8WYspFxTi9F4NK3(property));
        num1 = 8;
      }
label_11:
      return;
label_6:
      return;
label_3:;
    }

    private static void PackProperty(
      object item,
      object value,
      List<FilterProperty> result,
      string collection = "")
    {
      PropertyMetadata item1 = (PropertyMetadata) item;
      Type valueType = value.GetType().GetTypeWithoutProxy();
      object obj1 = (object) null;
      switch (value)
      {
        case QueryParameters queryParameters:
          QueryParametersListInfo parametersListInfo = (QueryParametersListInfo) null;
          using (IEnumerator<KeyValuePair<string, object>> enumerator = queryParameters.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              KeyValuePair<string, object> current = enumerator.Current;
              List<FilterProperty> result1 = new List<FilterProperty>()
              {
                new FilterProperty() { Uid = item1.Uid }
              };
              if (current.Value != null)
              {
                Type type = current.Value.GetType();
                if (typeof (IEnumerable).IsAssignableFrom(type) && type.IsGenericType)
                {
                  foreach (object obj2 in (IEnumerable) current.Value)
                  {
                    if (obj2 != null)
                      UniversalFilterSaver.PackProperty((object) item1, obj2, result1, type.AssemblyQualifiedName);
                  }
                }
                else
                  UniversalFilterSaver.PackProperty((object) item1, current.Value, result1);
              }
              if (parametersListInfo == null)
                obj1 = (object) (parametersListInfo = new QueryParametersListInfo());
              parametersListInfo.Objects.Add(new QueryParameterInfo()
              {
                Name = current.Key,
                Object = result1[0].Value
              });
            }
            break;
          }
        case IEntityFilter _:
          ITypeWrapperResolver resolver = (ITypeWrapperResolver) null;
          if (item1.TypeResolver != Guid.Empty)
          {
            // ISSUE: reference to a compiler-generated method
            resolver = ComponentManager.Current.GetExtensionPoints<ITypeWrapperResolver>().FirstOrDefault<ITypeWrapperResolver>((Func<ITypeWrapperResolver, bool>) (r => UniversalFilterSaver.\u003C\u003Ec__DisplayClass1_0.hpFQWuCF391PH50iGHHj(r.Uid, item1.TypeResolver)));
          }
          obj1 = UniversalFilterSaver.Pack((IEntityFilter) value, resolver);
          break;
        default:
          ITypeWrapperDescriptor wrapperDescriptor = ComponentManager.Current.GetExtensionPoints<ITypeWrapperDescriptor>().FirstOrDefault<ITypeWrapperDescriptor>((Func<ITypeWrapperDescriptor, bool>) (e =>
          {
            int num = 1;
            while (true)
            {
              switch (num)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (!UniversalFilterSaver.\u003C\u003Ec__DisplayClass1_0.n9TmibCFafEDfk06hj5G(UniversalFilterSaver.\u003C\u003Ec__DisplayClass1_0.UkHN4RCFp8wKEtFosryn((object) e), (Type) null))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
                    continue;
                  }
                  goto case 2;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  if (!UniversalFilterSaver.\u003C\u003Ec__DisplayClass1_0.UkHN4RCFp8wKEtFosryn((object) e).IsAssignableFrom(valueType))
                  {
                    num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 3 : 3;
                    continue;
                  }
                  goto label_7;
                default:
                  goto label_6;
              }
            }
label_6:
            // ISSUE: reference to a compiler-generated method
            return UniversalFilterSaver.\u003C\u003Ec__DisplayClass1_0.K0lelmCFDOswG01R7rK1((object) e, valueType);
label_7:
            return true;
          }));
          if (wrapperDescriptor != null)
          {
            object wrapper = wrapperDescriptor.CreateWrapper(value);
            if (wrapper != null)
            {
              obj1 = wrapper;
              break;
            }
            break;
          }
          obj1 = value;
          break;
      }
      if (obj1 == null)
        return;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      FilterProperty filterProperty1 = result.FirstOrDefault<FilterProperty>((Func<FilterProperty, bool>) (r => UniversalFilterSaver.\u003C\u003Ec__DisplayClass1_0.NGqAC5CFt3rOY27rpvjC((object) r) == UniversalFilterSaver.\u003C\u003Ec__DisplayClass1_0.dBFHqYCFwtNwZMK9UqnJ((object) item1)));
      if (filterProperty1 == null)
        filterProperty1 = new FilterProperty()
        {
          Uid = item1.Uid
        };
      FilterProperty filterProperty2 = filterProperty1;
      if (string.IsNullOrEmpty(collection))
      {
        filterProperty2.Value = obj1;
      }
      else
      {
        if (filterProperty2.Value == null)
          filterProperty2.Value = (object) new ListInfo();
        ListInfo listInfo = (ListInfo) filterProperty2.Value;
        listInfo.ListClass = collection;
        listInfo.Objects.Add(obj1);
      }
      // ISSUE: reference to a compiler-generated method
      if (!result.All<FilterProperty>((Func<FilterProperty, bool>) (r => r.Uid != UniversalFilterSaver.\u003C\u003Ec__DisplayClass1_0.dBFHqYCFwtNwZMK9UqnJ((object) item1))))
        return;
      result.Add(filterProperty2);
    }

    private static QueryParameters UnPackQueryParameters(object info, object queryParameters)
    {
      int num1 = 1;
      List<QueryParameterInfo>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator1 = ((QueryParametersListInfo) info).Objects.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (QueryParameters) queryParameters;
label_3:
      try
      {
label_9:
        if (enumerator1.MoveNext())
          goto label_7;
        else
          goto label_10;
label_5:
        List<object>.Enumerator enumerator2;
        QueryParameterInfo current;
        object instance;
        MethodInfo methodInfo;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 11:
              UniversalFilterSaver.B8l7WeWLGpKRtYw21wO2(queryParameters, UniversalFilterSaver.ogiFwZWLEZ24JGKYCFnN((object) current), UniversalFilterSaver.F4NSn5WLf9UcHCWQb04v(UniversalFilterSaver.Its9pXWLWuCE61X6bqMA((object) current)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 6 : 9;
              continue;
            case 2:
              try
              {
label_20:
                if (enumerator2.MoveNext())
                  goto label_17;
                else
                  goto label_21;
label_16:
                object obj;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_17;
                    case 2:
                      goto label_13;
                    case 3:
                      goto label_20;
                    case 4:
                      if (obj != null)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_20;
                    default:
                      UniversalFilterSaver.I2iaW6WLhIZZVnj3beUI((object) methodInfo, instance, (object) new object[1]
                      {
                        obj
                      });
                      num3 = 3;
                      continue;
                  }
                }
label_17:
                obj = UniversalFilterSaver.aIatDlWLb8BxDTrPA5y0(UniversalFilterSaver.UnPackProperty(enumerator2.Current), ((IEnumerable<Type>) instance.GetType().GetGenericArguments()).First<Type>());
                num3 = 4;
                goto label_16;
label_21:
                num3 = 2;
                goto label_16;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
            case 3:
              goto label_7;
            case 4:
            case 9:
              goto label_9;
            case 5:
              goto label_2;
            case 6:
              instance = Activator.CreateInstance(ReflectionType.GetType((string) UniversalFilterSaver.hiVPGMWLowblxYKJrZoY((object) listInfo)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 4 : 7;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              methodInfo = ((IEnumerable<MethodInfo>) instance.GetType().GetMethods()).FirstOrDefault<MethodInfo>((Func<MethodInfo, bool>) (m => (string) UniversalFilterSaver.\u003C\u003Ec.NcgtM7CF7SjHPQDLOr7E((object) m) == (string) UniversalFilterSaver.\u003C\u003Ec.pYovRgCFxfnb89JHSJ1p(-1426456882 ^ 2009939514 ^ -583768888)));
              num2 = 8;
              continue;
            case 8:
              enumerator2 = listInfo.Objects.GetEnumerator();
              num2 = 2;
              continue;
            case 10:
label_13:
              UniversalFilterSaver.B8l7WeWLGpKRtYw21wO2(queryParameters, (object) current.Name, instance);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 1;
              continue;
            default:
              if (!(UniversalFilterSaver.Its9pXWLWuCE61X6bqMA((object) current) is ListInfo listInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 0;
                continue;
              }
              goto case 6;
          }
        }
label_7:
        current = enumerator1.Current;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
label_10:
        num2 = 5;
        goto label_5;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    private static object UnPackProperty(object propertyValue)
    {
      int num1 = 4;
      object obj1;
      while (true)
      {
        int num2 = num1;
        Type valueType;
        while (true)
        {
          ITypeWrapperDescriptor wrapperDescriptor;
          object obj2;
          switch (num2)
          {
            case 1:
              obj1 = (object) UniversalFilterSaver.UnPack(propertyValue);
              num2 = 13;
              continue;
            case 2:
              obj1 = (object) UniversalFilterSaver.UnPackQueryParameters((object) info, (object) new QueryParameters());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            case 3:
              if (propertyValue is QueryParametersListInfo info)
              {
                num2 = 2;
                continue;
              }
              goto case 9;
            case 4:
              if (propertyValue != null)
              {
                num2 = 3;
                continue;
              }
              goto label_8;
            case 5:
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 11 : 12;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated method
              wrapperDescriptor = ((ComponentManager) UniversalFilterSaver.fGxwSwWLQtPTK3JvhwRk()).GetExtensionPoints<ITypeWrapperDescriptor>().FirstOrDefault<ITypeWrapperDescriptor>((Func<ITypeWrapperDescriptor, bool>) (e => UniversalFilterSaver.\u003C\u003Ec__DisplayClass3_0.qtvnWGCF9rPp78rTvHjH((object) e).IsAssignableFrom(valueType)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 10 : 11;
              continue;
            case 7:
              obj2 = propertyValue;
              break;
            case 8:
              goto label_8;
            case 9:
              if (!(propertyValue is SerializableFilter))
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            case 11:
              if (wrapperDescriptor == null)
              {
                num2 = 7;
                continue;
              }
              obj2 = wrapperDescriptor.GetObject(propertyValue);
              break;
            case 12:
              goto label_3;
            default:
              goto label_6;
          }
          obj1 = obj2;
          num2 = 14;
        }
label_3:
        valueType = propertyValue.GetType().GetTypeWithoutProxy();
        num1 = 6;
      }
label_6:
      return obj1;
label_8:
      return (object) null;
    }

    /// <summary>Упаковать фильтр в сериализуемый объект</summary>
    /// <param name="filter">Фильтр доя сериализации</param>
    /// <returns></returns>
    public static object Pack(IEntityFilter filter, ITypeWrapperResolver resolver = null)
    {
      int num1 = 2;
      Type type1;
      SerializableFilter serializableFilter1;
      List<PropertyMetadata>.Enumerator enumerator1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (filter != null)
            {
              type1 = filter.GetType();
              num1 = 4;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_6;
          case 4:
            ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(type1);
            SerializableFilter serializableFilter2 = new SerializableFilter();
            UniversalFilterSaver.qE0FAuWLCNhGqRQ6XFsn((object) serializableFilter2, (object) type1.AssemblyQualifiedName);
            serializableFilter1 = serializableFilter2;
            if (resolver != null)
            {
              string str = (string) UniversalFilterSaver.adw4h0WLv4o644SvSoI8((object) resolver, (object) filter);
              if (!UniversalFilterSaver.hV38WSWL8ZRTg4EypeVG((object) str))
              {
                UniversalFilterSaver.PjxwK1WLu8S2NtnAXmow((object) serializableFilter1, (object) UniversalFilterSaver.xpGFxJWLZxf4ARi1Viwp((object) resolver).ToString());
                UniversalFilterSaver.qE0FAuWLCNhGqRQ6XFsn((object) serializableFilter1, (object) str);
              }
            }
            enumerator1 = classMetadata.Properties.GetEnumerator();
            num1 = 3;
            continue;
          default:
            goto label_45;
        }
      }
label_2:
      return (object) null;
label_6:
      try
      {
label_32:
        if (enumerator1.MoveNext())
          goto label_34;
        else
          goto label_33;
label_7:
        IEnumerator enumerator2;
        Type type2;
        PropertyMetadata current1;
        int num2;
        while (true)
        {
          IEnumerable enumerable;
          object obj;
          switch (num2)
          {
            case 1:
              enumerable = obj as IEnumerable;
              num2 = 3;
              continue;
            case 2:
            case 4:
              UniversalFilterSaver.PackProperty((object) current1, obj, serializableFilter1.Properties);
              num2 = 11;
              continue;
            case 3:
              if (enumerable == null)
              {
                num2 = 13;
                continue;
              }
              break;
            case 5:
            case 11:
            case 13:
              goto label_32;
            case 6:
              // ISSUE: type reference
              if (UniversalFilterSaver.yO4AAKWLRYR2LnBbmw6t(__typeref (IEnumerable)).IsAssignableFrom(type2))
              {
                num2 = 12;
                continue;
              }
              goto case 2;
            case 7:
              obj = UniversalFilterSaver.IUnGtIWLSmJKILIPCw1r(UniversalFilterSaver.Ql5CPiWLVSv9wy9bulXW(filter.GetType(), UniversalFilterSaver.VWfPw9WLIU0bLKLQj0CP((object) current1)), (object) filter, (object) null);
              num2 = 9;
              continue;
            case 8:
              goto label_34;
            case 9:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 10;
                continue;
              }
              goto label_32;
            case 10:
              type2 = obj.GetType();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 14 : 14;
              continue;
            case 12:
              if (!type2.IsGenericType)
              {
                num2 = 4;
                continue;
              }
              goto case 1;
            case 14:
              if (UniversalFilterSaver.R1UOx1WLi0bluoOFybaV((object) filter.GetType().GetReflectionProperty((string) UniversalFilterSaver.VWfPw9WLIU0bLKLQj0CP((object) current1)), (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 5 : 0;
                continue;
              }
              goto case 6;
            case 15:
              goto label_45;
            case 16:
              goto label_13;
          }
          enumerator2 = (IEnumerator) UniversalFilterSaver.e2looTWLqVQ22bNf1kQj((object) enumerable);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 16 : 16;
        }
label_13:
        try
        {
label_19:
          if (enumerator2.MoveNext())
            goto label_16;
          else
            goto label_20;
label_14:
          object current2;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_16;
              case 2:
                if (current2 != null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                  continue;
                }
                goto label_19;
              case 3:
                goto label_32;
              case 4:
                goto label_19;
              default:
                UniversalFilterSaver.PackProperty((object) current1, current2, serializableFilter1.Properties, type2.AssemblyQualifiedName);
                num3 = 4;
                continue;
            }
          }
label_16:
          current2 = enumerator2.Current;
          num3 = 2;
          goto label_14;
label_20:
          num3 = 3;
          goto label_14;
        }
        finally
        {
          IDisposable disposable = enumerator2 as IDisposable;
          int num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
            num4 = 0;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_27;
              case 2:
                disposable.Dispose();
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
                continue;
              default:
                if (disposable != null)
                {
                  num4 = 2;
                  continue;
                }
                goto label_27;
            }
          }
label_27:;
        }
label_33:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 2 : 15;
        goto label_7;
label_34:
        current1 = enumerator1.Current;
        num2 = 7;
        goto label_7;
      }
      finally
      {
        enumerator1.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_45:
      return (object) serializableFilter1;
    }

    public static Dictionary<Guid, string> UniversalFilterUnPackFromDictionary(Type type) => UniversalFilterSaver.getUniversalFilter(type);

    private static Dictionary<Guid, string> GetUniversalFilter(Type type)
    {
      PropertyInfo[] reflectionProperties = type.GetReflectionProperties();
      // ISSUE: object of a compiler-generated type is created
      Dictionary<Guid, string> universalFilter = ((IEnumerable<PropertyInfo>) reflectionProperties).SelectMany(p => p.GetCustomAttributes(typeof (UniversalFilterUnPackFromAttribute), true).OfType<UniversalFilterUnPackFromAttribute>().Select(a => new \u003C\u003Ef__AnonymousType14<Guid, string>(a.PropertyUid, p.Name))).ToDictionary(p => p.Key, p => p.Value);
      ((IEnumerable<PropertyInfo>) reflectionProperties).Each<PropertyInfo>((Action<PropertyInfo>) (p =>
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          Guid deterministicGuid;
          while (true)
          {
            switch (num2)
            {
              case 1:
                deterministicGuid = p.Name.GetDeterministicGuid();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              case 2:
                goto label_8;
              case 3:
                goto label_5;
              case 4:
                goto label_3;
              default:
                if (universalFilter.ContainsKey(deterministicGuid))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 2;
                  continue;
                }
                goto label_8;
            }
          }
label_8:
          // ISSUE: reference to a compiler-generated method
          universalFilter.Add(deterministicGuid, (string) UniversalFilterSaver.\u003C\u003Ec__DisplayClass7_0.a5kDvHCF5lgDO4jSTdfg((object) p));
          num1 = 4;
        }
label_5:
        return;
label_3:;
      }));
      return universalFilter;
    }

    /// <summary>Получить фильтр из сериализуемого объекта</summary>
    /// <param name="datafilter">Объект сериализации фильтра</param>
    /// <param name="filterType">Тип фильтра</param>
    /// <returns></returns>
    public static IEntityFilter UnPack(
      object datafilter,
      ReferenceOnEntityType filterType = null,
      IEntityFilter filter = null,
      ITypeWrapperResolver resolver = null)
    {
      int num1 = 12;
      List<FilterProperty>.Enumerator enumerator1;
      IEntityFilter entityFilter1;
      Dictionary<Guid, string> dictionary;
      ClassMetadata classMetadata;
      while (true)
      {
        int num2 = num1;
        SerializableFilter serializableFilter;
        while (true)
        {
          IEntityFilter entityFilter2;
          Type t;
          switch (num2)
          {
            case 1:
              dictionary = UniversalFilterSaver.UniversalFilterUnPackFromDictionary(entityFilter1.GetType());
              num2 = 16;
              continue;
            case 2:
              goto label_15;
            case 3:
            case 6:
              goto label_91;
            case 4:
              if (resolver != null)
                goto case 15;
              else
                goto label_13;
            case 5:
              t = ReflectionType.GetType((string) UniversalFilterSaver.KZ5W4MWLXlbIfKA9hGDN((object) serializableFilter));
              break;
            case 7:
              if (datafilter is SerializableFilter)
              {
                num2 = 18;
                continue;
              }
              goto label_91;
            case 8:
              // ISSUE: type reference
              t = UniversalFilterSaver.yO4AAKWLRYR2LnBbmw6t(__typeref (Filter));
              break;
            case 9:
              goto label_10;
            case 10:
              if (filterType != null)
              {
                Type type = UniversalFilterSaver.OpN6fdWLk6Jc8QUYWf2w(UniversalFilterSaver.mtMI34WLT6AbFspTdC4l((object) filterType));
                if ((object) type == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 8 : 0;
                  continue;
                }
                t = type;
                break;
              }
              goto label_5;
            case 11:
              if (datafilter != null)
                goto case 7;
              else
                goto label_94;
            case 12:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 10 : 11;
              continue;
            case 13:
              if (UniversalFilterSaver.hV38WSWL8ZRTg4EypeVG(UniversalFilterSaver.nPlChVWLKaQb3XWrKtJM((object) serializableFilter)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 2 : 17;
                continue;
              }
              goto case 19;
            case 14:
              if (resolver == null)
              {
                num2 = 10;
                continue;
              }
              entityFilter2 = (IEntityFilter) UniversalFilterSaver.cFudYVWLOH1EpNoveI4y((object) resolver, (object) serializableFilter.FilterType);
              goto label_104;
            case 15:
            case 17:
              entityFilter2 = filter;
              if (entityFilter2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 13 : 14;
                continue;
              }
              goto label_104;
            case 16:
              enumerator1 = serializableFilter.Properties.GetEnumerator();
              num2 = 2;
              continue;
            case 18:
              goto label_92;
            case 19:
              // ISSUE: reference to a compiler-generated method
              resolver = ComponentManager.Current.GetExtensionPoints<ITypeWrapperResolver>().FirstOrDefault<ITypeWrapperResolver>((Func<ITypeWrapperResolver, bool>) (w => UniversalFilterSaver.\u003C\u003Ec__DisplayClass8_0.DS7dQoCBBYfPo10TTm0Q((object) w) == new Guid(serializableFilter.ResolverType)));
              num2 = 15;
              continue;
            default:
              classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entityFilter1.GetType());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
              continue;
          }
          entityFilter2 = (IEntityFilter) UniversalFilterSaver.tfCgqbWLnZLv9TKTqCmw(t);
label_104:
          entityFilter1 = entityFilter2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
        }
label_5:
        num1 = 5;
        continue;
label_13:
        num1 = 13;
        continue;
label_92:
        serializableFilter = (SerializableFilter) datafilter;
        num1 = 4;
        continue;
label_94:
        num1 = 6;
      }
label_10:
      return entityFilter1;
label_15:
      try
      {
label_26:
        if (enumerator1.MoveNext())
          goto label_44;
        else
          goto label_27;
label_17:
        MethodInfo methodInfo;
        FilterProperty current;
        object obj1;
        List<object>.Enumerator enumerator2;
        int num3;
        while (true)
        {
          int num4;
          PropertyInfo reflectionProperty;
          object obj2;
          object obj3;
          PropertyMetadata propertyMetadata1;
          object obj4;
          PropertyMetadata propertyMetadata2;
          string propertyName;
          Guid propertyUid;
          switch (num3)
          {
            case 1:
              if (!UniversalFilterSaver.tA40aqWL1KVvKsnsH1mo((object) methodInfo, (object) null))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 36 : 32;
                continue;
              }
              goto label_26;
            case 2:
              reflectionProperty = entityFilter1.GetType().GetReflectionProperty((string) UniversalFilterSaver.VWfPw9WLIU0bLKLQj0CP((object) propertyMetadata1), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
              num4 = 30;
              break;
            case 3:
              UniversalFilterSaver.I2iaW6WLhIZZVnj3beUI((object) methodInfo, obj1, (object) new object[1]
              {
                obj3
              });
              num3 = 6;
              continue;
            case 4:
              goto label_32;
            case 5:
              goto label_62;
            case 6:
            case 13:
            case 15:
            case 32:
              goto label_26;
            case 7:
              obj4 = Activator.CreateInstance(reflectionProperty.PropertyType);
              goto label_80;
            case 8:
              if (obj3 != null)
              {
                num3 = 3;
                continue;
              }
              goto label_26;
            case 9:
              goto label_44;
            case 10:
              MethodInfo[] methods = obj1.GetType().GetMethods();
              // ISSUE: reference to a compiler-generated field
              Func<MethodInfo, bool> func = UniversalFilterSaver.\u003C\u003Ec.\u003C\u003E9__8_3;
              Func<MethodInfo, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                UniversalFilterSaver.\u003C\u003Ec.\u003C\u003E9__8_3 = predicate = (Func<MethodInfo, bool>) (m => UniversalFilterSaver.\u003C\u003Ec.cCxJbjCF0fxeijuWuucd(UniversalFilterSaver.\u003C\u003Ec.NcgtM7CF7SjHPQDLOr7E((object) m), UniversalFilterSaver.\u003C\u003Ec.pYovRgCFxfnb89JHSJ1p(272623989 ^ 272584009)));
              }
              else
                goto label_105;
label_83:
              methodInfo = ((IEnumerable<MethodInfo>) methods).FirstOrDefault<MethodInfo>(predicate);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
              continue;
label_105:
              predicate = func;
              goto label_83;
            case 11:
              // ISSUE: reference to a compiler-generated method
              propertyMetadata2 = classMetadata.Properties.Find((Predicate<PropertyMetadata>) (m => UniversalFilterSaver.\u003C\u003Ec__DisplayClass8_1.GYMAIyCBfx1uIV6BBlX3((object) m) == propertyUid));
              goto label_78;
            case 12:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 29 : 22;
              continue;
            case 14:
              if (obj1 == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 6 : 26;
                continue;
              }
              goto case 10;
            case 16:
            case 23:
              if (typeof (QueryParameters).IsAssignableFrom(reflectionProperty.PropertyType))
              {
                num3 = 24;
                continue;
              }
              goto case 27;
            case 17:
              if (!reflectionProperty.PropertyType.IsGenericType)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 23 : 6;
                continue;
              }
              goto case 20;
            case 18:
              if (propertyMetadata1 != null)
              {
                num3 = 2;
                continue;
              }
              goto label_26;
            case 19:
              // ISSUE: type reference
              if (UniversalFilterSaver.yO4AAKWLRYR2LnBbmw6t(__typeref (IEnumerable)).IsAssignableFrom(reflectionProperty.PropertyType))
              {
                num3 = 17;
                continue;
              }
              goto case 16;
            case 20:
              obj1 = UniversalFilterSaver.IUnGtIWLSmJKILIPCw1r((object) reflectionProperty, (object) entityFilter1, (object) null);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 14 : 5;
              continue;
            case 21:
              propertyUid = UniversalFilterSaver.NJ8ZH6WLeqbTW4lX2nOu((object) current);
              num3 = 37;
              continue;
            case 22:
              enumerator2 = ((ListInfo) UniversalFilterSaver.QyMASiWL2BcXqu8xorl3((object) current)).Objects.GetEnumerator();
              num3 = 5;
              continue;
            case 24:
              if (!(UniversalFilterSaver.IUnGtIWLSmJKILIPCw1r((object) reflectionProperty, (object) entityFilter1, (object) null) is QueryParameters queryParameters))
              {
                num4 = 4;
                break;
              }
              if (current.Value is QueryParametersListInfo info)
              {
                num3 = 28;
                continue;
              }
              goto label_26;
            case 25:
              UniversalFilterSaver.SetValue((object) entityFilter1, (object) reflectionProperty, obj1);
              num3 = 10;
              continue;
            case 26:
              if (!(current.Value is ListInfo))
              {
                num3 = 7;
                continue;
              }
              obj4 = UniversalFilterSaver.bfA0f0WLPfO0wcQlYhw3(ReflectionType.GetType((string) UniversalFilterSaver.hiVPGMWLowblxYKJrZoY((object) (ListInfo) UniversalFilterSaver.QyMASiWL2BcXqu8xorl3((object) current))));
              goto label_80;
            case 27:
              obj2 = UniversalFilterSaver.Convert(UniversalFilterSaver.F4NSn5WLf9UcHCWQb04v(UniversalFilterSaver.QyMASiWL2BcXqu8xorl3((object) current)), UniversalFilterSaver.t5BWe8WYspFxTi9F4NK3((object) reflectionProperty));
              num3 = 34;
              continue;
            case 28:
              UniversalFilterSaver.UnPackQueryParameters((object) info, (object) queryParameters);
              num3 = 32;
              continue;
            case 29:
              if (UniversalFilterSaver.QyMASiWL2BcXqu8xorl3((object) current) == null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 13 : 13;
                continue;
              }
              goto case 21;
            case 30:
              if (!UniversalFilterSaver.R1UOx1WLi0bluoOFybaV((object) reflectionProperty, (object) null))
              {
                num3 = 19;
                continue;
              }
              goto label_26;
            case 31:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              propertyMetadata2 = classMetadata.Properties.Find((Predicate<PropertyMetadata>) (m => UniversalFilterSaver.\u003C\u003Ec__DisplayClass8_1.UsmFHDCBEASeMWIwn6hl(UniversalFilterSaver.\u003C\u003Ec__DisplayClass8_1.PmPYGcCBG0MM78c83sgT((object) m), (object) propertyName)));
              goto label_78;
            case 33:
              obj3 = UniversalFilterSaver.Convert(UniversalFilterSaver.F4NSn5WLf9UcHCWQb04v(current.Value), ((IEnumerable<Type>) obj1.GetType().GetGenericArguments()).First<Type>());
              num3 = 8;
              continue;
            case 34:
              UniversalFilterSaver.RSrS89WL3YAeVrekekQb((object) entityFilter1, (object) reflectionProperty, obj2);
              num3 = 15;
              continue;
            case 35:
              if (propertyName != null)
              {
                num3 = 31;
                continue;
              }
              goto case 11;
            case 36:
              if (UniversalFilterSaver.QyMASiWL2BcXqu8xorl3((object) current) is ListInfo)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 22 : 17;
                continue;
              }
              goto case 33;
            case 37:
              propertyName = dictionary.ContainsKey(propertyUid) ? dictionary[propertyUid] : (string) null;
              num3 = 35;
              continue;
            default:
              goto label_10;
          }
          num3 = num4;
          continue;
label_78:
          propertyMetadata1 = propertyMetadata2;
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 18 : 2;
          continue;
label_80:
          obj1 = obj4;
          num3 = 25;
        }
label_32:
        throw new Exception(EleWise.ELMA.SR.T((string) UniversalFilterSaver.ohupIUWLNNf7hyZ7JppR(-105199646 ^ -105347968)));
label_62:
        try
        {
label_69:
          if (enumerator2.MoveNext())
            goto label_68;
          else
            goto label_70;
label_63:
          int num5;
          int num6 = num5;
label_64:
          object obj5;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_68;
              case 3:
                goto label_26;
              case 4:
                goto label_65;
              case 5:
                if (obj5 == null)
                {
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
                  continue;
                }
                goto label_65;
              default:
                goto label_69;
            }
          }
label_65:
          UniversalFilterSaver.I2iaW6WLhIZZVnj3beUI((object) methodInfo, obj1, (object) new object[1]
          {
            obj5
          });
          num5 = 2;
          goto label_63;
label_68:
          obj5 = UniversalFilterSaver.aIatDlWLb8BxDTrPA5y0(UniversalFilterSaver.F4NSn5WLf9UcHCWQb04v(enumerator2.Current), ((IEnumerable<Type>) obj1.GetType().GetGenericArguments()).First<Type>());
          num5 = 5;
          goto label_63;
label_70:
          num6 = 3;
          goto label_64;
        }
        finally
        {
          enumerator2.Dispose();
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
            num7 = 0;
          switch (num7)
          {
            default:
          }
        }
label_27:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
        goto label_17;
label_44:
        current = enumerator1.Current;
        num3 = 12;
        goto label_17;
      }
      finally
      {
        enumerator1.Dispose();
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
          num8 = 0;
        switch (num8)
        {
          default:
        }
      }
label_91:
      return (IEntityFilter) null;
    }

    public static object Convert(object obj, Type type)
    {
      int num1 = 1;
      IConvertTypeWrapper convertTypeWrapper;
      object obj1;
      while (true)
      {
        int num2 = num1;
        Type type1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            case 2:
              type1 = type;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 6 : 8;
              continue;
            case 3:
            case 6:
              goto label_11;
            case 4:
              goto label_10;
            case 5:
              if (convertTypeWrapper == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 3;
                continue;
              }
              goto label_10;
            case 7:
              convertTypeWrapper = ComponentManager.Current.GetExtensionPoints<IConvertTypeWrapper>().FirstOrDefault<IConvertTypeWrapper>((Func<IConvertTypeWrapper, bool>) (c =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (UniversalFilterSaver.\u003C\u003Ec__DisplayClass9_0.TBsgsMCBZgeUhrFvmn5C(UniversalFilterSaver.\u003C\u003Ec__DisplayClass9_0.nbmJtXCB84PnJgw7F26Q((object) c), obj1.GetType()))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_3;
                    default:
                      goto label_2;
                  }
                }
label_2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                return UniversalFilterSaver.\u003C\u003Ec__DisplayClass9_0.TBsgsMCBZgeUhrFvmn5C(UniversalFilterSaver.\u003C\u003Ec__DisplayClass9_0.YUlk6qCBu3L3W1JuybJG((object) c), type1);
label_3:
                return false;
              }));
              num2 = 5;
              continue;
            case 8:
              goto label_5;
            case 9:
              if (!UniversalFilterSaver.qBHDTlWYzHcmrqxhGq0j(type1, obj1.GetType()))
              {
                num2 = 6;
                continue;
              }
              goto case 7;
            default:
              obj1 = obj;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 2;
              continue;
          }
        }
label_5:
        if (obj1 != null)
          num1 = 9;
        else
          goto label_11;
      }
label_10:
      return UniversalFilterSaver.HU58jcWLpkfk8EgadIu2((object) convertTypeWrapper, obj1);
label_11:
      return obj1;
    }

    /// <summary>Создать фильтр по другому фильтру</summary>
    /// <param name="source"></param>
    /// <param name="filterType"></param>
    /// <returns></returns>
    public static IEntityFilter Create(IEntityFilter source, ReferenceOnEntityType filterType) => UniversalFilterSaver.UnPack(UniversalFilterSaver.Pack(source), filterType);

    public UniversalFilterSaver()
    {
      UniversalFilterSaver.WlSqFhWLaAr8hYOdWIJF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UniversalFilterSaver()
    {
      int num = 1;
      ParameterExpression parameterExpression;
      while (true)
      {
        switch (num)
        {
          case 1:
            UniversalFilterSaver.WlSqFhWLaAr8hYOdWIJF();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            // ISSUE: method reference
            UniversalFilterSaver.getUniversalFilter = MetadataLoader.UseCachingForFunc<Type, Dictionary<Guid, string>>(Expression.Lambda<Func<Type, Dictionary<Guid, string>>>((Expression) Expression.Call((Expression) null, (MethodInfo) UniversalFilterSaver.lH8rcbWLtO6HbNTYOka5(__methodref (UniversalFilterSaver.GetUniversalFilter)), (Expression) parameterExpression), parameterExpression));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 2;
            continue;
          default:
            // ISSUE: type reference
            parameterExpression = (ParameterExpression) UniversalFilterSaver.SBH0hvWLDQKEMQAMxvN6(UniversalFilterSaver.yO4AAKWLRYR2LnBbmw6t(__typeref (Type)), UniversalFilterSaver.ohupIUWLNNf7hyZ7JppR(1319452732 ^ 1319455774));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 3;
            continue;
        }
      }
label_2:;
    }

    internal static Type t5BWe8WYspFxTi9F4NK3([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type oKrjyQWYcD1pcUh65Z4d([In] Type obj0) => Nullable.GetUnderlyingType(obj0);

    internal static bool qBHDTlWYzHcmrqxhGq0j([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object qIlRhXWLFXZ4LJ0O4nGB([In] Type obj0, [In] object obj1) => Enum.ToObject(obj0, obj1);

    internal static void WrbSdTWLBqY949w1mU3o([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static bool zneReLWYLRGB6WMsxfeT() => UniversalFilterSaver.twwEdSWYYOaT4pc0BSaA == null;

    internal static UniversalFilterSaver Y0PNU8WYU9SPKlXU02bg() => UniversalFilterSaver.twwEdSWYYOaT4pc0BSaA;

    internal static object Its9pXWLWuCE61X6bqMA([In] object obj0) => ((QueryParameterInfo) obj0).Object;

    internal static object hiVPGMWLowblxYKJrZoY([In] object obj0) => (object) ((ListInfo) obj0).ListClass;

    internal static object aIatDlWLb8BxDTrPA5y0([In] object obj0, Type type) => UniversalFilterSaver.Convert(obj0, type);

    internal static object I2iaW6WLhIZZVnj3beUI([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static void B8l7WeWLGpKRtYw21wO2([In] object obj0, [In] object obj1, [In] object obj2) => ((QueryParameters) obj0)[(string) obj1] = obj2;

    internal static object ogiFwZWLEZ24JGKYCFnN([In] object obj0) => (object) ((QueryParameterInfo) obj0).Name;

    internal static object F4NSn5WLf9UcHCWQb04v([In] object obj0) => UniversalFilterSaver.UnPackProperty(obj0);

    internal static object fGxwSwWLQtPTK3JvhwRk() => (object) ComponentManager.Current;

    internal static void qE0FAuWLCNhGqRQ6XFsn([In] object obj0, [In] object obj1) => ((SerializableFilter) obj0).FilterType = (string) obj1;

    internal static object adw4h0WLv4o644SvSoI8([In] object obj0, [In] object obj1) => (object) ((ITypeWrapperResolver) obj0).GetObjectInstanceDescriptor(obj1);

    internal static bool hV38WSWL8ZRTg4EypeVG([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Guid xpGFxJWLZxf4ARi1Viwp([In] object obj0) => ((ITypeWrapperResolver) obj0).Uid;

    internal static void PjxwK1WLu8S2NtnAXmow([In] object obj0, [In] object obj1) => ((SerializableFilter) obj0).ResolverType = (string) obj1;

    internal static object VWfPw9WLIU0bLKLQj0CP([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object Ql5CPiWLVSv9wy9bulXW(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static object IUnGtIWLSmJKILIPCw1r([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool R1UOx1WLi0bluoOFybaV([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static Type yO4AAKWLRYR2LnBbmw6t([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object e2looTWLqVQ22bNf1kQj([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object nPlChVWLKaQb3XWrKtJM([In] object obj0) => (object) ((SerializableFilter) obj0).ResolverType;

    internal static object KZ5W4MWLXlbIfKA9hGDN([In] object obj0) => (object) ((SerializableFilter) obj0).FilterType;

    internal static Guid mtMI34WLT6AbFspTdC4l([In] object obj0) => ((ReferenceOnEntityType) obj0).TypeUid;

    internal static Type OpN6fdWLk6Jc8QUYWf2w(Guid uid) => MetadataLoader.GetFilterType(uid);

    internal static object tfCgqbWLnZLv9TKTqCmw(Type t) => InterfaceActivator.Create(t);

    internal static object cFudYVWLOH1EpNoveI4y([In] object obj0, [In] object obj1) => ((ITypeWrapperResolver) obj0).GetObjectInstance((string) obj1);

    internal static object QyMASiWL2BcXqu8xorl3([In] object obj0) => ((FilterProperty) obj0).Value;

    internal static Guid NJ8ZH6WLeqbTW4lX2nOu([In] object obj0) => ((FilterProperty) obj0).Uid;

    internal static object bfA0f0WLPfO0wcQlYhw3([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static bool tA40aqWL1KVvKsnsH1mo([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object ohupIUWLNNf7hyZ7JppR(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void RSrS89WL3YAeVrekekQb([In] object obj0, [In] object obj1, [In] object obj2) => UniversalFilterSaver.SetValue(obj0, obj1, obj2);

    internal static object HU58jcWLpkfk8EgadIu2([In] object obj0, [In] object obj1) => ((IConvertTypeWrapper) obj0).ConvertWrapper(obj1);

    internal static void WlSqFhWLaAr8hYOdWIJF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object SBH0hvWLDQKEMQAMxvN6([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object lH8rcbWLtO6HbNTYOka5([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);
  }
}
