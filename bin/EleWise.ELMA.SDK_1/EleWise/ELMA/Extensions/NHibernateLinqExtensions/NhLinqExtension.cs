// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.NHibernateLinqExtensions.NhLinqExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Linq;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Dynamic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions.NHibernateLinqExtensions
{
  /// <summary>Методы-расширения для Nhibenate Linq API</summary>
  public static class NhLinqExtension
  {
    internal static NhLinqExtension xR2uGCGmBkFrTYr1SBjY;

    private static Dictionary<string, MethodInfo> FetchMethodInfo { get; set; }

    /// <summary>Жадная загрузка свойства-ссылки</summary>
    /// <typeparam name="TOriginating">Тип запрашиваемых объектов</typeparam>
    /// <param name="query">Запрос</param>
    /// <param name="relatedObjectSelector">Путь до свойства, поддерживается многократная вложенность (напр. WorkflowInstance.Process.Header)</param>
    /// <returns></returns>
    public static IQueryable<TOriginating> Fetch<TOriginating>(
      this IQueryable<TOriginating> query,
      string relatedObjectSelector)
    {
      return query.ApplyFetch<TOriginating>((object) relatedObjectSelector);
    }

    /// <summary>Выполнение запроса с учетом параметров выборки</summary>
    /// <typeparam name="TOriginating"></typeparam>
    /// <param name="query">Запрос</param>
    /// <param name="fetchOptions">Параметры выборки, учитываются следующие поля:
    /// 1. FirstResult;
    /// 2. MaxResults;
    /// 3. FetchRelations, в т.ч. вложенные свойства и коллекции
    /// 4. OrderBy, в виде "имя_свойства направление_сортировки", напр. "prop1 desc, prop2 asc, prop3"
    /// Прочие параметры выборки игнорируются
    /// </param>
    /// <returns>Коллекцию - результат выборки</returns>
    public static IQueryable<TOriginating> SetupFetchOptions<TOriginating>(
      this IQueryable<TOriginating> query,
      FetchOptions fetchOptions)
    {
      if (fetchOptions == (FetchOptions) null)
        return query;
      if (fetchOptions.FetchRelations != null && fetchOptions.FetchRelations.Any<string>())
      {
        foreach (string fetchRelation in fetchOptions.FetchRelations)
          query = query.Fetch<TOriginating>(fetchRelation);
      }
      query = NhLinqExtension.SetupSortOptionsLinq<TOriginating>(query, (object) fetchOptions);
      if (fetchOptions.FirstResult > 0)
        query = Queryable.Skip<TOriginating>(query, fetchOptions.FirstResult);
      if (fetchOptions.MaxResults > 0)
        query = Queryable.Take<TOriginating>(query, fetchOptions.MaxResults);
      return query;
    }

    private static IQueryable<TOriginating> SetupSortOptionsLinq<TOriginating>(
      IQueryable<TOriginating> query,
      object fetchOptions)
    {
      IEnumerable<string> strings;
      if (string.IsNullOrEmpty(((FetchOptions) fetchOptions).SortExpression))
        strings = Enumerable.Empty<string>();
      else
        strings = (IEnumerable<string>) ((FetchOptions) fetchOptions).SortExpression.Split(new char[1]
        {
          ','
        }, StringSplitOptions.RemoveEmptyEntries);
      foreach (object sortExpression in strings)
      {
        string ordering = NhLinqExtension.AddOrderIfNeeded(sortExpression, ((FetchOptions) fetchOptions).SortDirection);
        query = query.OrderBy<TOriginating>(ordering);
      }
      return query;
    }

    private static string AddOrderIfNeeded(object sortExpression, ListSortDirection sortDirection)
    {
      int num = 1;
      string str;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            if (NhLinqExtension.GJG6UJGmh45kciBQBZj2(sortExpression, NhLinqExtension.JiG9NJGmbc2uZacRBbd3(-441065788 ^ -2092910478 ^ 1727408294), StringComparison.OrdinalIgnoreCase))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            if (!NhLinqExtension.GJG6UJGmh45kciBQBZj2(sortExpression, NhLinqExtension.JiG9NJGmbc2uZacRBbd3(-53329496 >> 4 ^ -3249660), StringComparison.OrdinalIgnoreCase))
            {
              num = 6;
              continue;
            }
            goto label_3;
          case 3:
            goto label_2;
          case 4:
            obj = NhLinqExtension.JiG9NJGmbc2uZacRBbd3(-951514650 ^ -951433226);
            break;
          case 6:
            if (sortDirection != ListSortDirection.Ascending)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 1 : 4;
              continue;
            }
            obj = NhLinqExtension.JiG9NJGmbc2uZacRBbd3(~1767720452 ^ -1767770139);
            break;
          default:
            goto label_3;
        }
        str = (string) obj;
        num = 3;
      }
label_2:
      return (string) NhLinqExtension.qeYKGYGmGMMRcp8ZhvMD(sortExpression, (object) str);
label_3:
      return (string) sortExpression;
    }

    private static IQueryable<T> ApplyFetch<T>(this IQueryable<T> source, object property)
    {
      Type type1 = typeof (T);
      Type type2 = type1;
      NhLinqExtension.InvokeInfo invokeInfo = new NhLinqExtension.InvokeInfo();
      int num = 0;
      IQueryable queryable = (IQueryable) source;
      object obj = property;
      char[] chArray = new char[1]{ '.' };
      foreach (string str in ((string) obj).Split(chArray))
      {
        PropertyInfo property1 = NhLinqExtension.GetProperty(type2, (object) str);
        List<Type> typeList;
        if (num == 0)
        {
          invokeInfo.MethodName = string.Empty;
          typeList = new List<Type>() { type2 };
        }
        else
        {
          invokeInfo.MethodName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120898285);
          typeList = new List<Type>() { type1, type2 };
        }
        bool? nullable = NhLinqExtension.CheckRelation(type2, (object) str);
        if (nullable.HasValue)
        {
          Type type3;
          Type resultType;
          if (nullable.Value)
          {
            invokeInfo.MethodName += z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121737968);
            type3 = property1.PropertyType;
            resultType = type3;
          }
          else
          {
            invokeInfo.MethodName += z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841646256);
            type3 = property1.PropertyType.GetGenericArguments()[0];
            resultType = typeof (IEnumerable<>).MakeGenericType(type3);
          }
          typeList.Add(type3);
          invokeInfo.GenericArguments = typeList.ToArray();
          LambdaExpression lambda = NhLinqExtension.GetLambda(type2, resultType, (object) property1);
          invokeInfo.Parameters = new object[2]
          {
            (object) queryable,
            (object) lambda
          };
          queryable = NhLinqExtension.ApplyFetchMethod((object) invokeInfo);
          type2 = type3;
          ++num;
        }
        else
          break;
      }
      return (IQueryable<T>) queryable;
    }

    private static IQueryable ApplyFetchMethod(object invokeInfo) => (IQueryable) NhLinqExtension.cWGuOuGmvZZdIvufbfB1(NhLinqExtension.H3tggZGmQy2PJMblHjE2(NhLinqExtension.MnGKrBGmErOtl379l6PN(invokeInfo), NhLinqExtension.CoPA0IGmfgAWwB54xT4t(invokeInfo)), (object) null, NhLinqExtension.zBwYlpGmCb9M3gOgLBgb(invokeInfo));

    private static bool? CheckRelation(Type type, object property)
    {
      string property1 = (string) property;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      PropertyMetadata propertyMetadata = (MetadataLoader.LoadMetadata(type) as EntityMetadata).Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => NhLinqExtension.\u003C\u003Ec__DisplayClass15_0.Dm0WRU8CntmSvjZARPVY(NhLinqExtension.\u003C\u003Ec__DisplayClass15_0.m6Jbj18CkLSoD2npU1ao((object) p), (object) property1)));
      if (propertyMetadata == null || propertyMetadata.SubTypeUid == Guid.Empty)
        return new bool?();
      if (!(propertyMetadata.Settings is EntitySettings settings))
        return new bool?();
      CacheEntityAttribute attribute = AttributeHelper<CacheEntityAttribute>.GetAttribute(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(propertyMetadata.SubTypeUid), true);
      return attribute != null && attribute.Enabled ? new bool?() : new bool?(settings.RelationType == RelationType.OneToOne);
    }

    private static PropertyInfo GetProperty(Type type, object propName)
    {
      int num1 = 3;
      IEnumerator<Type> enumerator;
      PropertyInfo propertyCached;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_26;
          case 2:
            propertyCached = type.GetPropertyCached((string) propName);
            num1 = 4;
            continue;
          case 3:
            if (!NhLinqExtension.Nmra8eGm8JEPxJOjQpeJ(type, (Type) null))
            {
              num1 = 2;
              continue;
            }
            goto label_22;
          case 4:
            if (NhLinqExtension.ikC0s1GmZS5b3O8rIoPg((object) propertyCached, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 1;
              continue;
            }
            enumerator = type.SelfAndBaseTypes().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_22;
          case 6:
            goto label_24;
          default:
            goto label_2;
        }
      }
label_2:
      PropertyInfo property;
      try
      {
label_5:
        if (NhLinqExtension.ldtXj1GmuMqCj6AWkAta((object) enumerator))
          goto label_7;
        else
          goto label_6;
label_4:
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (propertyCached != (PropertyInfo) null)
              {
                num2 = 3;
                continue;
              }
              goto label_5;
            case 2:
              goto label_25;
            case 3:
              property = propertyCached;
              num2 = 2;
              continue;
            case 4:
              goto label_5;
            case 5:
              goto label_7;
            default:
              goto label_24;
          }
        }
label_6:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
        goto label_4;
label_7:
        propertyCached = enumerator.Current.GetPropertyCached((string) propName);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_17;
              default:
                NhLinqExtension.xN2rJpGmIIEGDVfeBl0t((object) enumerator);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_17:;
      }
label_25:
      return property;
label_22:
      return (PropertyInfo) null;
label_24:
      return (PropertyInfo) null;
label_26:
      return propertyCached;
    }

    private static LambdaExpression GetLambda(Type sourceType, Type resultType, object pi)
    {
      int num = 1;
      ParameterExpression parameterExpression;
      Expression body;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameterExpression = (ParameterExpression) NhLinqExtension.GWOfwoGmVKPkQauyuyj4(sourceType, NhLinqExtension.JiG9NJGmbc2uZacRBbd3(1199946765 ^ 1200069949));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            body = (Expression) NhLinqExtension.D6sxYCGmSdavfdTgIxv0((object) parameterExpression, pi);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 1;
            continue;
        }
      }
label_3:
      return Expression.Lambda(typeof (Func<,>).MakeGenericType(sourceType, resultType), body, parameterExpression);
    }

    private static MethodInfo GetFetchMethodInfo(object invokeInfo)
    {
      int num1 = 4;
      string key;
      MethodInfo fetchMethodInfo;
      NhLinqExtension.InvokeInfo invokeInfo1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            // ISSUE: explicit non-virtual call
            fetchMethodInfo = ((IEnumerable<MethodInfo>) __nonvirtual (NhLinqExtension.jWPx4XGmRPLBDJIhtRUQ(__typeref (EagerFetchingExtensionMethods)).GetMethods())).Single<MethodInfo>((Func<MethodInfo, bool>) (method =>
            {
              int num2 = 3;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    if (NhLinqExtension.\u003C\u003Ec__DisplayClass18_0.fdMYol8Cayp01vrr5U63((object) method).Length == invokeInfo1.GenericArguments.Length)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                      continue;
                    }
                    goto label_7;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    if (!NhLinqExtension.\u003C\u003Ec__DisplayClass18_0.BjiuWN8CpsDlR7bWh3SD((object) method))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 4 : 2;
                      continue;
                    }
                    goto case 1;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    if (NhLinqExtension.\u003C\u003Ec__DisplayClass18_0.JhGl7D8C3AyJNTyPXwnE(NhLinqExtension.\u003C\u003Ec__DisplayClass18_0.qsEEDQ8C1capTTZiedEP((object) method), NhLinqExtension.\u003C\u003Ec__DisplayClass18_0.zcsOlm8CN3uXLGm928Vl((object) invokeInfo1)))
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 2;
                      continue;
                    }
                    goto label_7;
                  case 4:
                    goto label_7;
                  default:
                    goto label_6;
                }
              }
label_6:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              return NhLinqExtension.\u003C\u003Ec__DisplayClass18_0.StR0DM8CDYkVRMpBxqbN((object) method).Length == NhLinqExtension.\u003C\u003Ec__DisplayClass18_0.NwNCS28Ct7nsx702Iy28((object) invokeInfo1).Length;
label_7:
              return false;
            }));
            num1 = 2;
            continue;
          case 2:
            NhLinqExtension.FetchMethodInfo.Add(key, fetchMethodInfo);
            num1 = 5;
            continue;
          case 3:
            invokeInfo1 = (NhLinqExtension.InvokeInfo) invokeInfo;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 2 : 3;
            continue;
          case 5:
            goto label_7;
          case 6:
            if (!NhLinqExtension.FetchMethodInfo.TryGetValue(key, out fetchMethodInfo))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          default:
            key = (string) NhLinqExtension.TFGP54GmiFPbDebEOhuP((object) invokeInfo1);
            num1 = 6;
            continue;
        }
      }
label_7:
      return fetchMethodInfo;
    }

    private static string GetMethodKey(object invokeInfo) => string.Format((string) NhLinqExtension.JiG9NJGmbc2uZacRBbd3(979449278 ^ 979712168), NhLinqExtension.Xq3UBEGmqAUULs9yA3uU(invokeInfo), (object) NhLinqExtension.zBwYlpGmCb9M3gOgLBgb(invokeInfo).Length, (object) ((NhLinqExtension.InvokeInfo) invokeInfo).GenericArguments.Length);

    internal static object JiG9NJGmbc2uZacRBbd3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool GJG6UJGmh45kciBQBZj2([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).EndsWith((string) obj1, obj2);

    internal static object qeYKGYGmGMMRcp8ZhvMD([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static bool R6Lk14GmWvqo5poTeobe() => NhLinqExtension.xR2uGCGmBkFrTYr1SBjY == null;

    internal static NhLinqExtension BdxQ8eGmo6iLeJCH6Vus() => NhLinqExtension.xR2uGCGmBkFrTYr1SBjY;

    internal static object MnGKrBGmErOtl379l6PN([In] object obj0) => (object) NhLinqExtension.GetFetchMethodInfo(obj0);

    internal static object CoPA0IGmfgAWwB54xT4t([In] object obj0) => (object) ((NhLinqExtension.InvokeInfo) obj0).GenericArguments;

    internal static object H3tggZGmQy2PJMblHjE2([In] object obj0, [In] object obj1) => (object) ((MethodInfo) obj0).MakeGenericMethod((Type[]) obj1);

    internal static object zBwYlpGmCb9M3gOgLBgb([In] object obj0) => (object) ((NhLinqExtension.InvokeInfo) obj0).Parameters;

    internal static object cWGuOuGmvZZdIvufbfB1([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static bool Nmra8eGm8JEPxJOjQpeJ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool ikC0s1GmZS5b3O8rIoPg([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static bool ldtXj1GmuMqCj6AWkAta([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void xN2rJpGmIIEGDVfeBl0t([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object GWOfwoGmVKPkQauyuyj4([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object D6sxYCGmSdavfdTgIxv0([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (PropertyInfo) obj1);

    internal static object TFGP54GmiFPbDebEOhuP([In] object obj0) => (object) NhLinqExtension.GetMethodKey(obj0);

    internal static Type jWPx4XGmRPLBDJIhtRUQ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Xq3UBEGmqAUULs9yA3uU([In] object obj0) => (object) ((NhLinqExtension.InvokeInfo) obj0).MethodName;

    private class InvokeInfo
    {
      internal static object LQTrDe8CV1r50uXNyP7g;

      public Type[] GenericArguments
      {
        get => this.\u003CGenericArguments\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CGenericArguments\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public object[] Parameters
      {
        get => this.\u003CParameters\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CParameters\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public string MethodName
      {
        get => this.\u003CMethodName\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CMethodName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public InvokeInfo()
      {
        NhLinqExtension.InvokeInfo.A6nrbc8CRWlcA5bVl7oo();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool bSJn6W8CSPt5udBrWrwL() => NhLinqExtension.InvokeInfo.LQTrDe8CV1r50uXNyP7g == null;

      internal static NhLinqExtension.InvokeInfo Me5In18CiZyueGxBpM1t() => (NhLinqExtension.InvokeInfo) NhLinqExtension.InvokeInfo.LQTrDe8CV1r50uXNyP7g;

      internal static void A6nrbc8CRWlcA5bVl7oo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
