// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.LocalizableAttributeHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Globalization
{
  /// <summary>
  /// Осуществляет локализацию свойств, помеченных атрибутом <see cref="T:EleWise.ELMA.Globalization.LocalizableAttribute" />
  /// </summary>
  public static class LocalizableAttributeHelper
  {
    private static readonly Dictionary<Type, LocalizableAttributeHelper.TypeLocalizer> localizers;
    internal static LocalizableAttributeHelper tPQoR9GfoRCNfkMRlFVw;

    /// <summary>Локализовать объект</summary>
    /// <param name="obj"></param>
    public static void Localize(object obj)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_3;
          case 2:
            LocalizableAttributeHelper.lQT5qcGfEPcefkjTyc2s(LocalizableAttributeHelper.WiJs7SGfGTiB1WPmBDpF(obj), (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
            continue;
          case 3:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
          default:
            goto label_8;
        }
      }
label_5:
      return;
label_3:
      return;
label_8:
      return;
label_2:;
    }

    /// <summary>Получить из объекта список строк для локализации</summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static IEnumerable<string> GetStrings(object obj) => obj == null ? (IEnumerable<string>) new string[0] : LocalizableAttributeHelper.GetLocalizable(obj).GetStrings((ILocalizable) null);

    private static ILocalizable GetLocalizable(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
              continue;
            }
            if (!(obj is ILocalizable localizable))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_8;
          case 3:
            goto label_7;
          default:
            goto label_4;
        }
      }
label_4:
      return (ILocalizable) null;
label_7:
      return localizable;
label_8:
      return (ILocalizable) new LocalizableAttributeHelper.ObjectLocalizer(obj, (LocalizableAttributeHelper.TypeLocalizer) LocalizableAttributeHelper.JpcLKgGffM1CXZTtFRrc(obj.GetType()));
    }

    private static LocalizableAttributeHelper.TypeLocalizer GetLocalizer(Type type)
    {
      int num1 = 2;
      bool lockTaken;
      LocalizableAttributeHelper.TypeLocalizer localizer;
      Dictionary<Type, LocalizableAttributeHelper.TypeLocalizer> localizers;
      while (true)
      {
        switch (num1)
        {
          case 1:
            localizers = LocalizableAttributeHelper.localizers;
            num1 = 3;
            continue;
          case 2:
            if (!LocalizableAttributeHelper.localizers.TryGetValue(type, out localizer))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          case 3:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 4;
            continue;
          case 4:
            goto label_4;
          default:
            goto label_3;
        }
      }
label_3:
      return localizer;
label_4:
      try
      {
        Monitor.Enter((object) localizers, ref lockTaken);
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              LocalizableAttributeHelper.localizers[type] = localizer;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            case 2:
              localizer = new LocalizableAttributeHelper.TypeLocalizer(type);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
              continue;
            default:
              goto label_3;
          }
        }
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = 2;
        else
          goto label_11;
label_10:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_11:
        LocalizableAttributeHelper.ku2hLeGfQkQX7QEYF5Ei((object) localizers);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        {
          num3 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    static LocalizableAttributeHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            LocalizableAttributeHelper.Xk2x0sGfCxXE2gCA1m2L();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            LocalizableAttributeHelper.localizers = new Dictionary<Type, LocalizableAttributeHelper.TypeLocalizer>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object WiJs7SGfGTiB1WPmBDpF([In] object obj0) => (object) LocalizableAttributeHelper.GetLocalizable(obj0);

    internal static void lQT5qcGfEPcefkjTyc2s([In] object obj0, [In] object obj1) => ((ILocalizable) obj0).Localize((ILocalizable) obj1);

    internal static bool rqnwgCGfbtpflSNRfhmk() => LocalizableAttributeHelper.tPQoR9GfoRCNfkMRlFVw == null;

    internal static LocalizableAttributeHelper HDKBodGfhinnZGbcCqSJ() => LocalizableAttributeHelper.tPQoR9GfoRCNfkMRlFVw;

    internal static object JpcLKgGffM1CXZTtFRrc(Type type) => (object) LocalizableAttributeHelper.GetLocalizer(type);

    internal static void ku2hLeGfQkQX7QEYF5Ei([In] object obj0) => Monitor.Exit(obj0);

    internal static void Xk2x0sGfCxXE2gCA1m2L() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class TypeLocalizer
    {
      /// <summary>Список локализуемых свойств</summary>
      /// <remarks>
      /// Ключ - имя свойства, Значение - информация о свойстве через рефлексию
      /// </remarks>
      internal readonly Dictionary<string, PropertyInfo> LocalizableProperties;
      internal static object uUX4PMvgLBnJPAv6tdph;

      /// <summary>Ctor</summary>
      /// <param name="type">Тип</param>
      internal TypeLocalizer(Type type)
      {
        LocalizableAttributeHelper.TypeLocalizer.pCVpnnvgc566yK7cFI9H();
        this.LocalizableProperties = new Dictionary<string, PropertyInfo>();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num1 = 2;
        IEnumerator<PropertyInfo> enumerator;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_21;
            case 1:
              goto label_2;
            case 2:
              object source = LocalizableAttributeHelper.TypeLocalizer.Y8nlXLvgzEnJLsWS9mhr(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy);
              // ISSUE: reference to a compiler-generated field
              Func<PropertyInfo, bool> func = LocalizableAttributeHelper.TypeLocalizer.\u003C\u003Ec.\u003C\u003E9__0_0;
              Func<PropertyInfo, bool> predicate;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                LocalizableAttributeHelper.TypeLocalizer.\u003C\u003Ec.\u003C\u003E9__0_0 = predicate = (Func<PropertyInfo, bool>) (p =>
                {
                  int num2 = 4;
                  while (true)
                  {
                    switch (num2)
                    {
                      case 1:
                      case 3:
                        goto label_3;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        if (!LocalizableAttributeHelper.TypeLocalizer.\u003C\u003Ec.wct7H6Zks7YW3wpQOkIa((object) p))
                        {
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
                          continue;
                        }
                        goto label_2;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        if (LocalizableAttributeHelper.TypeLocalizer.\u003C\u003Ec.jdgLmVZkUspP7E33OCsG((object) p).Length != 0)
                        {
                          num2 = 3;
                          continue;
                        }
                        goto case 2;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  // ISSUE: reference to a compiler-generated method
                  return LocalizableAttributeHelper.TypeLocalizer.\u003C\u003Ec.hFSK8nZkcOZsyRCyXO7E((object) p);
label_3:
                  return false;
                });
              }
              else
                goto label_24;
label_23:
              enumerator = ((IEnumerable<PropertyInfo>) source).Where<PropertyInfo>(predicate).GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
              continue;
label_24:
              predicate = func;
              goto label_23;
            default:
              goto label_18;
          }
        }
label_21:
        return;
label_18:
        return;
label_2:
        try
        {
label_7:
          if (enumerator.MoveNext())
            goto label_9;
          else
            goto label_8;
label_3:
          PropertyInfo current;
          int num3;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_15;
              case 1:
                goto label_9;
              case 2:
                // ISSUE: type reference
                if (!LocalizableAttributeHelper.TypeLocalizer.VWvCuYv5BKtl2HssOp5M((object) current, LocalizableAttributeHelper.TypeLocalizer.d6naJRv5FYFA3Qoxnq8j(__typeref (LocalizableAttribute)), true))
                {
                  num3 = 3;
                  continue;
                }
                goto case 4;
              case 3:
              case 5:
                goto label_7;
              case 4:
                this.LocalizableProperties.Add((string) LocalizableAttributeHelper.TypeLocalizer.qYvwCJv5WebdAPH8hkdt((object) current), current);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 4 : 5;
                continue;
              default:
                goto label_11;
            }
          }
label_15:
          return;
label_11:
          return;
label_8:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
          goto label_3;
label_9:
          current = enumerator.Current;
          num3 = 2;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
          {
            num3 = 2;
            goto label_3;
          }
          else
            goto label_3;
        }
        finally
        {
          int num4;
          if (enumerator == null)
            num4 = 2;
          else
            goto label_16;
label_14:
          switch (num4)
          {
            case 1:
            case 2:
          }
label_16:
          LocalizableAttributeHelper.TypeLocalizer.zg6DdMv5o7s0Awm5LTSr((object) enumerator);
          num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
          {
            num4 = 0;
            goto label_14;
          }
          else
            goto label_14;
        }
      }

      /// <summary>Локализовать</summary>
      /// <param name="objectLocalizer">Локализуемый объект</param>
      internal void Localize(
        LocalizableAttributeHelper.ObjectLocalizer objectLocalizer)
      {
        int num1 = 2;
        Dictionary<string, PropertyInfo>.ValueCollection.Enumerator enumerator1;
        object refObject;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_42;
            case 1:
              enumerator1 = this.LocalizableProperties.Values.GetEnumerator();
              num1 = 3;
              continue;
            case 2:
              refObject = objectLocalizer.RefObject;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_38;
          }
        }
label_42:
        return;
label_38:
        return;
label_2:
        try
        {
label_4:
          if (enumerator1.MoveNext())
            goto label_13;
          else
            goto label_5;
label_3:
          object obj1;
          string str;
          PropertyInfo current;
          IEnumerator enumerator2;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                LocalizableAttributeHelper.TypeLocalizer.akALn1v5QxjdwuN7iM6I((object) current, refObject, LocalizableAttributeHelper.TypeLocalizer.m40Z2Dv5fy2tdXpxvdk4((object) str), (object) null);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 8 : 12;
                continue;
              case 2:
                str = (string) LocalizableAttributeHelper.TypeLocalizer.mPXexiv5G1ywkd1daw3l((object) current, refObject, (object) null);
                num2 = 16;
                continue;
              case 3:
                object obj2 = LocalizableAttributeHelper.TypeLocalizer.vvt1LTv58hl3fvOIYPhh(obj1);
                if (obj2 == null)
                {
                  num2 = 5;
                  continue;
                }
                LocalizableAttributeHelper.TypeLocalizer.E4Lbdav5ZEYXG0PeElCr(obj2, (object) objectLocalizer);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 10 : 1;
                continue;
              case 4:
                obj1 = current.GetValue(refObject, (object[]) null);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              case 5:
              case 7:
              case 8:
              case 10:
              case 12:
                goto label_4;
              case 6:
                goto label_13;
              case 9:
                goto label_16;
              case 11:
                if (LocalizableAttributeHelper.TypeLocalizer.cbl6Kuv5hSZ9hbEGKlTT(LocalizableAttributeHelper.TypeLocalizer.CBCLXmv5bcTXKBrWCCxW((object) current), typeof (string)))
                {
                  num2 = 2;
                  continue;
                }
                goto case 4;
              case 13:
                if (obj1 is IEnumerable enumerable)
                {
                  num2 = 14;
                  continue;
                }
                goto case 3;
              case 14:
                enumerator2 = (IEnumerator) LocalizableAttributeHelper.TypeLocalizer.c3Th3pv5COfBgqQOKnDt((object) enumerable);
                num2 = 9;
                continue;
              case 15:
                goto label_36;
              case 16:
                if (LocalizableAttributeHelper.TypeLocalizer.HuK4l2v5EE6R4yKuwjLx((object) str))
                {
                  num2 = 8;
                  continue;
                }
                goto case 1;
              default:
                if (obj1 == null)
                {
                  num2 = 7;
                  continue;
                }
                goto case 13;
            }
          }
label_36:
          return;
label_16:
          try
          {
label_18:
            if (enumerator2.MoveNext())
              goto label_20;
            else
              goto label_19;
label_17:
            int num3;
            switch (num3)
            {
              case 2:
                goto label_20;
              case 3:
                goto label_4;
              default:
                goto label_18;
            }
label_19:
            num3 = 3;
            goto label_17;
label_20:
            ILocalizable localizable = LocalizableAttributeHelper.GetLocalizable(LocalizableAttributeHelper.TypeLocalizer.Qx3CGuv5vy94mkqkMqHG((object) enumerator2));
            if (localizable == null)
            {
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 0;
              goto label_17;
            }
            else
            {
              localizable.Localize((ILocalizable) objectLocalizer);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
              {
                num3 = 0;
                goto label_17;
              }
              else
                goto label_17;
            }
          }
          finally
          {
            IDisposable disposable = enumerator2 as IDisposable;
            int num4 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  if (disposable == null)
                  {
                    num4 = 2;
                    continue;
                  }
                  break;
                case 2:
                case 3:
                  goto label_30;
              }
              LocalizableAttributeHelper.TypeLocalizer.zg6DdMv5o7s0Awm5LTSr((object) disposable);
              num4 = 3;
            }
label_30:;
          }
label_5:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 15 : 15;
          goto label_3;
label_13:
          current = enumerator1.Current;
          num2 = 11;
          goto label_3;
        }
        finally
        {
          enumerator1.Dispose();
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
            num5 = 0;
          switch (num5)
          {
            default:
          }
        }
      }

      /// <summary>
      /// Получить список локализуемых строк (ресурсы для перевода)
      /// </summary>
      /// <param name="objectLocalizer">Локализуемый объект</param>
      /// <returns>Список локализуемых строк (ресурсы для перевода)</returns>
      internal IEnumerable<string> GetStrings(
        LocalizableAttributeHelper.ObjectLocalizer objectLocalizer)
      {
        HashSet<string> strings = new HashSet<string>();
        object refObject = objectLocalizer.RefObject;
        foreach (PropertyInfo propertyInfo in this.LocalizableProperties.Values)
        {
          if (propertyInfo.PropertyType == typeof (string))
          {
            string str = (string) propertyInfo.GetValue(refObject, (object[]) null);
            if (!string.IsNullOrEmpty(str))
              strings.Add(str);
          }
          else
          {
            object obj1 = propertyInfo.GetValue(refObject, (object[]) null);
            if (obj1 != null)
            {
              if (obj1 is IEnumerable enumerable)
              {
                foreach (object obj2 in enumerable)
                {
                  ILocalizable localizable = LocalizableAttributeHelper.GetLocalizable(obj2);
                  if (localizable != null)
                  {
                    foreach (string str in localizable.GetStrings((ILocalizable) objectLocalizer))
                      strings.Add(str);
                  }
                }
              }
              else
              {
                ILocalizable localizable = LocalizableAttributeHelper.GetLocalizable(obj1);
                if (localizable != null)
                {
                  foreach (string str in localizable.GetStrings((ILocalizable) objectLocalizer))
                    strings.Add(str);
                }
              }
            }
          }
        }
        return (IEnumerable<string>) strings;
      }

      internal static void pCVpnnvgc566yK7cFI9H() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object Y8nlXLvgzEnJLsWS9mhr(Type type, BindingFlags bindingAttr) => (object) type.GetReflectionProperties(bindingAttr);

      internal static Type d6naJRv5FYFA3Qoxnq8j([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static bool VWvCuYv5BKtl2HssOp5M([In] object obj0, [In] Type obj1, [In] bool obj2) => ((MemberInfo) obj0).IsDefined(obj1, obj2);

      internal static object qYvwCJv5WebdAPH8hkdt([In] object obj0) => (object) ((MemberInfo) obj0).Name;

      internal static void zg6DdMv5o7s0Awm5LTSr([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static bool EW70u2vgUspFxLFHpMw5() => LocalizableAttributeHelper.TypeLocalizer.uUX4PMvgLBnJPAv6tdph == null;

      internal static LocalizableAttributeHelper.TypeLocalizer V0kc1cvgsIjYENwo6HRi() => (LocalizableAttributeHelper.TypeLocalizer) LocalizableAttributeHelper.TypeLocalizer.uUX4PMvgLBnJPAv6tdph;

      internal static Type CBCLXmv5bcTXKBrWCCxW([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

      internal static bool cbl6Kuv5hSZ9hbEGKlTT([In] Type obj0, [In] Type obj1) => obj0 == obj1;

      internal static object mPXexiv5G1ywkd1daw3l([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

      internal static bool HuK4l2v5EE6R4yKuwjLx([In] object obj0) => string.IsNullOrEmpty((string) obj0);

      internal static object m40Z2Dv5fy2tdXpxvdk4([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static void akALn1v5QxjdwuN7iM6I(
        [In] object obj0,
        [In] object obj1,
        [In] object obj2,
        [In] object obj3)
      {
        ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);
      }

      internal static object c3Th3pv5COfBgqQOKnDt([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

      internal static object Qx3CGuv5vy94mkqkMqHG([In] object obj0) => ((IEnumerator) obj0).Current;

      internal static object vvt1LTv58hl3fvOIYPhh([In] object obj0) => (object) LocalizableAttributeHelper.GetLocalizable(obj0);

      internal static void E4Lbdav5ZEYXG0PeElCr([In] object obj0, [In] object obj1) => ((ILocalizable) obj0).Localize((ILocalizable) obj1);
    }

    /// <summary>Локализуемый объект</summary>
    private class ObjectLocalizer : ILocalizable
    {
      private readonly object obj;
      private readonly object typeLocalizer;
      private static object sJR7Dxv5uTOtE3Is8xuL;

      /// <summary>Ctor</summary>
      /// <param name="obj">Объект</param>
      /// <param name="typeLocalizer">Локализатор типа</param>
      internal ObjectLocalizer(
        object obj,
        LocalizableAttributeHelper.TypeLocalizer typeLocalizer)
      {
        LocalizableAttributeHelper.ObjectLocalizer.nO1OeOv5S0HySNHxDWw7();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.obj = obj;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            default:
              this.typeLocalizer = (object) typeLocalizer;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
          }
        }
label_2:;
      }

      /// <summary>Ссылка на объект</summary>
      internal object RefObject => this.obj;

      /// <inheritdoc />
      public IDictionary<string, PropertyInfo> LocalizableProperties => (IDictionary<string, PropertyInfo>) ((LocalizableAttributeHelper.TypeLocalizer) this.typeLocalizer).LocalizableProperties;

      /// <inheritdoc />
      public void Localize(ILocalizable parent)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              LocalizableAttributeHelper.ObjectLocalizer.MfyfF7v5i9fAWPwyTZRo(this.typeLocalizer, (object) this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public IEnumerable<string> GetStrings(ILocalizable parent) => ((LocalizableAttributeHelper.TypeLocalizer) this.typeLocalizer).GetStrings(this);

      internal static void nO1OeOv5S0HySNHxDWw7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool dZJgibv5IUsJS0MexefW() => LocalizableAttributeHelper.ObjectLocalizer.sJR7Dxv5uTOtE3Is8xuL == null;

      internal static LocalizableAttributeHelper.ObjectLocalizer aAkqdFv5VNNi9ALYnThp() => (LocalizableAttributeHelper.ObjectLocalizer) LocalizableAttributeHelper.ObjectLocalizer.sJR7Dxv5uTOtE3Is8xuL;

      internal static void MfyfF7v5i9fAWPwyTZRo([In] object obj0, [In] object obj1) => ((LocalizableAttributeHelper.TypeLocalizer) obj0).Localize((LocalizableAttributeHelper.ObjectLocalizer) obj1);
    }
  }
}
