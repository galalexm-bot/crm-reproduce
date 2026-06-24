// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Accessors.Accessors
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Properties;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Accessors
{
  /// <summary>Свойства сущностей</summary>
  [EditorBrowsable(EditorBrowsableState.Never)]
  public static class Accessors
  {
    /// <summary>Имя метода для получения свойств</summary>
    internal const string GetAccessors͏ = "GetAccessors͏";
    private static readonly IDictionary<Type, IDictionary<string, IDictionary<Type, IAccessor>>> accessorsRecursive;
    private static readonly IDictionary<Type, EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary> accessors;
    private static EleWise.ELMA.Model.Accessors.Accessors SubpNjhmVXuZSD6v87if;

    /// <summary>
    /// Получить геттер свойства <paramref name="propertyName" /> типа <paramref name="type" /> с учетом дельта-публикации
    /// </summary>
    /// <param name="type">Тип владельца свойства</param>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="declaredOnly">Только объявленные в типе</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IGetter GetGetter(this Type type, string propertyName, bool declaredOnly) => EleWise.ELMA.Model.Accessors.Accessors.gNvHNdhmRBrBFXImqJMM(type, (object) propertyName, declaredOnly) as IGetter;

    /// <summary>
    /// Получить сеттер свойства <paramref name="propertyName" /> типа <paramref name="type" /> с учетом дельта-публикации
    /// </summary>
    /// <param name="type">Тип владельца свойства</param>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="declaredOnly">Только объявленные в типе</param>
    internal static ISetter GetSetter(this Type type, string propertyName, bool declaredOnly) => type.GetAccessor(propertyName, declaredOnly) as ISetter;

    /// <summary>
    /// Получить свойство <paramref name="propertyName" /> типа <paramref name="type" /> с учетом дельта-публикации
    /// </summary>
    /// <param name="type">Тип владельца свойства</param>
    /// <param name="propertyName">Имя свойства</param>
    /// <param name="declaredOnly">Только объявленные в типе</param>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public static IAccessor GetAccessor(this Type type, string propertyName, bool declaredOnly)
    {
      int num = 1;
      IAccessor accessor;
      KeyValuePair<Type, IAccessor> keyValuePair;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EleWise.ELMA.Model.Accessors.Accessors.iec1t5hmqFqycKE0p8AG((object) type.Assembly))
            {
              type = EleWise.ELMA.Model.Accessors.Accessors.d4yUFqhmKSqBIySOikGt(type);
              num = 8;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_15;
          case 3:
            goto label_6;
          case 4:
            goto label_12;
          case 5:
            goto label_7;
          case 6:
            if (((EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary) EleWise.ELMA.Model.Accessors.Accessors.lkLDjYhmXBCnefWPZr9J(type)).TryGetValue(propertyName, out accessor))
            {
              num = 5;
              continue;
            }
            goto label_6;
          case 7:
            IDictionary<Type, IAccessor> source;
            if (!EleWise.ELMA.Model.Accessors.Accessors.GetAccessorsRecursive(type).TryGetValue(propertyName, out source))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 1;
              continue;
            }
            keyValuePair = source.Single<KeyValuePair<Type, IAccessor>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 4;
            continue;
          case 8:
            if (declaredOnly)
            {
              num = 6;
              continue;
            }
            goto case 7;
          default:
            goto label_2;
        }
      }
label_2:
      return (IAccessor) null;
label_6:
      return (IAccessor) null;
label_7:
      return accessor;
label_12:
      return keyValuePair.Value;
label_15:
      return (IAccessor) null;
    }

    /// <summary>Добавить кастомные свойства типу</summary>
    /// <param name="type">Тип</param>
    /// <param name="accessors">Кастомные свойства</param>
    internal static void AddAccessors(this Type type, IEnumerable accessors)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary) EleWise.ELMA.Model.Accessors.Accessors.lkLDjYhmXBCnefWPZr9J(type)).AddAccessors(accessors.Cast<IAccessor>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    private static EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary GetAccessorsInternal(
      Type type)
    {
      int num1 = 2;
      Type type1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            type1 = type;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return EleWise.ELMA.Model.Accessors.Accessors.accessors.GetOrAdd<Type, EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary>(type1, (Func<Type, EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary>) (t =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!type1.IsEnum)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              // ISSUE: reference to a compiler-generated method
              if (!EleWise.ELMA.Model.Accessors.Accessors.\u003C\u003Ec__DisplayClass7_0.nkvmgpv6QCbhLHOd4P3c((object) type1.Assembly))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 2;
                continue;
              }
              goto label_5;
          }
        }
label_4:
        return (EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary) null;
label_5:
        return new EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary(t);
      }));
    }

    private static IDictionary<string, IDictionary<Type, IAccessor>> GetAccessorsRecursive(Type type) => EleWise.ELMA.Model.Accessors.Accessors.accessorsRecursive.GetOrAdd<Type, IDictionary<string, IDictionary<Type, IAccessor>>>(type, (Func<Type, IDictionary<string, IDictionary<Type, IAccessor>>>) (t =>
    {
      EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary accessorsInternal1 = EleWise.ELMA.Model.Accessors.Accessors.GetAccessorsInternal(t);
      Dictionary<string, IDictionary<Type, IAccessor>> dictionary1 = accessorsInternal1 != null ? accessorsInternal1.ToDictionary<IAccessor, string, IDictionary<Type, IAccessor>>((Func<IAccessor, string>) (a => a.PropertyName), (Func<IAccessor, IDictionary<Type, IAccessor>>) (p => (IDictionary<Type, IAccessor>) new Dictionary<Type, IAccessor>()
      {
        [p.PropertyType] = p
      })) : (Dictionary<string, IDictionary<Type, IAccessor>>) null;
      if (dictionary1 != null)
      {
        while (t.BaseType != (Type) null)
        {
          t = t.BaseType;
          EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary accessorsInternal2 = EleWise.ELMA.Model.Accessors.Accessors.GetAccessorsInternal(t);
          if (accessorsInternal2 != null)
          {
            foreach (IAccessor accessor in accessorsInternal2)
            {
              IDictionary<Type, IAccessor> dictionary2;
              if (!dictionary1.TryGetValue(accessor.PropertyName, out dictionary2))
                dictionary1[accessor.PropertyName] = (IDictionary<Type, IAccessor>) new Dictionary<Type, IAccessor>()
                {
                  [accessor.PropertyType] = accessor
                };
              else if (!dictionary2.ContainsKey(accessor.PropertyType))
                dictionary2[accessor.PropertyType] = accessor;
            }
          }
          else
            break;
        }
      }
      return (IDictionary<string, IDictionary<Type, IAccessor>>) dictionary1;
    }));

    /// <summary>Получить данные объекта</summary>
    /// <param name="value">Объект</param>
    /// <param name="dataIndex">Индекс данных</param>
    /// <returns>Данные объекта</returns>
    internal static object GetData(IValueContainerObjectInternal value, int dataIndex) => value.GetData().ElementAt<object>(dataIndex);

    static Accessors()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            EleWise.ELMA.Model.Accessors.Accessors.accessorsRecursive = PublishCacheContext.CreateCache<Type, IDictionary<string, IDictionary<Type, IAccessor>>>((Action<IDictionary<Type, IDictionary<string, IDictionary<Type, IAccessor>>>, Type, Guid>) ((c, _, __) => c.Clear()));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 3:
            EleWise.ELMA.Model.Accessors.Accessors.DQG4LjhmTQfGOEHBl7hT();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 2 : 2;
            continue;
          default:
            EleWise.ELMA.Model.Accessors.Accessors.accessors = PublishCacheContext.CreateCache<Type, EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object gNvHNdhmRBrBFXImqJMM(Type type, [In] object obj1, bool declaredOnly) => (object) type.GetAccessor((string) obj1, declaredOnly);

    internal static bool cOut4MhmSqvqYWXos9Pf() => EleWise.ELMA.Model.Accessors.Accessors.SubpNjhmVXuZSD6v87if == null;

    internal static EleWise.ELMA.Model.Accessors.Accessors bvu1Qfhmiy0RPyRVU98Z() => EleWise.ELMA.Model.Accessors.Accessors.SubpNjhmVXuZSD6v87if;

    internal static bool iec1t5hmqFqycKE0p8AG([In] object obj0) => ((Assembly) obj0).IsDynamicAssembly();

    internal static Type d4yUFqhmKSqBIySOikGt(Type t) => InterfaceActivator.TypeOf(t);

    internal static object lkLDjYhmXBCnefWPZr9J(Type type) => (object) EleWise.ELMA.Model.Accessors.Accessors.GetAccessorsInternal(type);

    internal static void DQG4LjhmTQfGOEHBl7hT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class AccessorsDictionary : IEnumerable<IAccessor>, IEnumerable
    {
      private readonly IDictionary<string, IAccessor> accessors;
      private readonly IDictionary<string, IAccessor> deltaAccessors;
      internal static object j5yi17v4sykQPZ7EQ7L3;

      public AccessorsDictionary(Type type)
      {
        EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.uHAwbfv6FTL3kHcBa8Hi();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
          num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.deltaAccessors = PublishCacheContext.CreateCache<string, IAccessor>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 1;
              continue;
            case 2:
              goto label_8;
            case 3:
              if (type.IsInterface)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                continue;
              }
              IEnumerable<IAccessor> source = ((IEnumerable) EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.wBJ1mmv6o5i1cL71aYBn((object) type.GetMethod((string) EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.dw9eo0v6BGgk1Rast2hv(1470440286 ^ 1470143778)), (object) null, (object) null)).Cast<IAccessor>();
              // ISSUE: reference to a compiler-generated field
              Func<IAccessor, string> func = EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.\u003C\u003Ec.\u003C\u003E9__2_0;
              Func<IAccessor, string> keySelector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.\u003C\u003Ec.\u003C\u003E9__2_0 = keySelector = (Func<IAccessor, string>) (a => (string) EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.\u003C\u003Ec.b0PZZ4ZTZHdenrdoqq5Y((object) a));
              }
              else
                goto label_11;
label_10:
              this.accessors = (IDictionary<string, IAccessor>) source.ToDictionary<IAccessor, string>(keySelector);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 1;
              continue;
label_11:
              keySelector = func;
              goto label_10;
            default:
              goto label_6;
          }
        }
label_8:
        return;
label_6:
        throw new ArgumentException((string) EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.LpJ2Ziv6WnLGCteqMX8b(EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.dw9eo0v6BGgk1Rast2hv(1253244298 - 1829393894 ^ -575837864), (object) type), (string) EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.dw9eo0v6BGgk1Rast2hv(-70007027 ^ -70005969));
      }

      public bool TryGetValue(string propertyName, out IAccessor accessor)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              if (this.accessors.TryGetValue(propertyName, out accessor))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        return this.deltaAccessors.TryGetValue(propertyName, out accessor);
label_5:
        return true;
      }

      public void AddAccessors(IEnumerable<IAccessor> newAccessors) => newAccessors.ForEach<IAccessor>((Action<IAccessor>) (a =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.deltaAccessors[a.PropertyName] = a;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 2:
              this.accessors.Remove((string) EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.zsBrv6v6bK7yv1ilw6wJ((object) a));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }));

      public IEnumerator<IAccessor> GetEnumerator() => this.accessors.Values.Concat<IAccessor>((IEnumerable<IAccessor>) this.deltaAccessors.Values).GetEnumerator();

      IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) this.GetEnumerator();

      internal static void uHAwbfv6FTL3kHcBa8Hi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object dw9eo0v6BGgk1Rast2hv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object LpJ2Ziv6WnLGCteqMX8b([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

      internal static object wBJ1mmv6o5i1cL71aYBn([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

      internal static bool GdlwjVv4c1pxWKget6km() => EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.j5yi17v4sykQPZ7EQ7L3 == null;

      internal static EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary cCYemSv4zijPcbWSaDaS() => (EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary) EleWise.ELMA.Model.Accessors.Accessors.AccessorsDictionary.j5yi17v4sykQPZ7EQ7L3;

      internal static object zsBrv6v6bK7yv1ilw6wJ([In] object obj0) => (object) ((IAccessor) obj0).PropertyName;
    }
  }
}
