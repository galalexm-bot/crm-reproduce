// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.UntypedISetProxy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Collections
{
  /// <summary>
  /// Нетипизированная обертка для типизированного <see cref="T:System.Collections.Generic.ISet`1" />
  /// </summary>
  public class UntypedISetProxy : IUntypedCollectionProxy, IEnumerable
  {
    private readonly object typedISet;
    private readonly MethodInfo addMethod;
    private readonly MethodInfo removeMethod;
    private readonly MethodInfo clearMethod;
    private readonly MethodInfo getEnumeratorMethod;
    private readonly PropertyInfo countProperty;
    private readonly MethodInfo containsMethod;
    private static UntypedISetProxy ixVCvOm53qUXvUJKble;

    /// <summary>Ctor</summary>
    /// <param name="typedISet">Значение с типом <see cref="T:System.Collections.Generic.ISet`1" /></param>
    public UntypedISetProxy(object typedISet)
    {
      UntypedISetProxy.IHI3kEmLWgQjJGwe1ib();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 20;
      Type type1;
      while (true)
      {
        int num2 = num1;
        Type type2;
        Type type3;
        Type type4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!UntypedISetProxy.Ry8sQgmzOafDQ3hq5Xs((object) this.removeMethod, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 15 : 2;
                continue;
              }
              goto label_12;
            case 2:
              if (!UntypedISetProxy.Ry8sQgmzOafDQ3hq5Xs((object) this.clearMethod, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 4 : 1;
                continue;
              }
              goto label_10;
            case 3:
              goto label_12;
            case 4:
              // ISSUE: type reference
              type2 = typedISet.GetType().GetInterface(UntypedISetProxy.miMk9mmUE3Ry9Hi8w84(__typeref (IEnumerable)).FullName);
              num2 = 23;
              continue;
            case 5:
              goto label_20;
            case 6:
              this.typedISet = typedISet;
              num2 = 8;
              continue;
            case 7:
              // ISSUE: type reference
              type3 = typedISet.GetType().GetInterface(UntypedISetProxy.miMk9mmUE3Ry9Hi8w84(__typeref (ICollection<>)).FullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 5 : 2;
              continue;
            case 8:
              // ISSUE: type reference
              type1 = typedISet.GetType().GetInterface(UntypedISetProxy.miMk9mmUE3Ry9Hi8w84(__typeref (Iesi.Collections.Generic.ISet<>)).FullName);
              num2 = 14;
              continue;
            case 9:
              if (!UntypedISetProxy.Ry8sQgmzOafDQ3hq5Xs((object) this.getEnumeratorMethod, (object) null))
              {
                num2 = 11;
                continue;
              }
              goto label_27;
            case 10:
              goto label_33;
            case 11:
              this.countProperty = type3.GetProperty((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(-488881205 ^ -488880091));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 15 : 18;
              continue;
            case 12:
              goto label_29;
            case 13:
              goto label_21;
            case 14:
              if (UntypedISetProxy.UHBiw7ms77VSyXx9Akm(type1, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 24;
                continue;
              }
              // ISSUE: type reference
              type4 = typedISet.GetType().GetInterface(UntypedISetProxy.miMk9mmUE3Ry9Hi8w84(__typeref (System.Collections.Generic.ISet<>)).FullName);
              num2 = 7;
              continue;
            case 15:
              this.clearMethod = type3.GetMethod((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(-1487388570 ^ -1487353316));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 2;
              continue;
            case 16:
              goto label_10;
            case 17:
              goto label_27;
            case 18:
              if (!UntypedISetProxy.hm84dDyBjcm4gjAE5YP((object) this.countProperty, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 17 : 22;
                continue;
              }
              goto label_21;
            case 19:
              if (UntypedISetProxy.Ry8sQgmzOafDQ3hq5Xs((object) this.containsMethod, (object) null))
              {
                num2 = 10;
                continue;
              }
              goto label_34;
            case 20:
              Contract.ArgumentNotNull(typedISet, z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408935822));
              num2 = 6;
              continue;
            case 21:
              if (!UntypedISetProxy.Ry8sQgmzOafDQ3hq5Xs((object) this.addMethod, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                continue;
              }
              goto label_29;
            case 22:
              this.containsMethod = type3.GetMethod((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(44884861 ^ 44844711));
              num2 = 19;
              continue;
            case 23:
              this.getEnumeratorMethod = type2.GetMethod((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(-105199646 ^ -105225548));
              num2 = 9;
              continue;
            case 24:
              goto label_31;
            default:
              this.removeMethod = type3.GetMethod((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(-740338220 ^ -740298420));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
              continue;
          }
        }
label_20:
        this.addMethod = type4.GetMethod((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(-542721635 ^ -542761567));
        num1 = 21;
      }
label_10:
      throw new InvalidOperationException((string) UntypedISetProxy.CetoHGyFUbWUC9wUy44((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516879882), (object) type1.FullName));
label_12:
      throw new InvalidOperationException((string) UntypedISetProxy.CetoHGyFUbWUC9wUy44(UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(516838154 ^ 516880290), (object) type1.FullName));
label_34:
      return;
label_21:
      throw new InvalidOperationException(string.Format((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(--1418440330 ^ 1418397970), (object) type1.FullName));
label_27:
      throw new InvalidOperationException((string) UntypedISetProxy.CetoHGyFUbWUC9wUy44(UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(1581325282 << 3 ^ -234325404), (object) type1.FullName));
label_29:
      throw new InvalidOperationException((string) UntypedISetProxy.CetoHGyFUbWUC9wUy44(UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(-105199646 ^ -105225308), (object) type1.FullName));
label_31:
      throw new ArgumentException((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(323422137 << 2 ^ 1293728178), (string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(1819636893 << 3 ^ 1672151976));
label_33:
      throw new InvalidOperationException(string.Format((string) UntypedISetProxy.C3Xx3emcKLuMwEKqHmZ(-1872275253 >> 6 ^ -29280115), (object) type1.FullName));
    }

    /// <summary>
    /// Добавить элемент с результатом из метода <see cref="M:System.Collections.Generic.ISet`1.Add(`0)" />
    /// </summary>
    /// <param name="o">Элемент</param>
    /// <returns></returns>
    public bool AddToSet(object o) => (bool) this.addMethod.Invoke(this.typedISet, new object[1]
    {
      o
    });

    /// <summary>Добавить элемент</summary>
    /// <param name="o">Элемент</param>
    public void Add(object o)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.addMethod.Invoke(this.typedISet, new object[1]
            {
              o
            });
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

    /// <summary>Удалить элемент</summary>
    /// <param name="o">Элемент</param>
    /// <returns></returns>
    public bool Remove(object o) => (bool) this.removeMethod.Invoke(this.typedISet, new object[1]
    {
      o
    });

    /// <summary>Очистить список</summary>
    public void Clear()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UntypedISetProxy.XYArr3yWkPKwVS7iiyV((object) this.clearMethod, this.typedISet, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Число элементов</summary>
    public int Count => Convert.ToInt32(UntypedISetProxy.cXFiqTyoAOlVa6tMjvd((object) this.countProperty, this.typedISet, (object) null));

    /// <summary>Определяет содержит ли список элемент</summary>
    /// <param name="o">Элемент</param>
    public bool Contains(object o) => UntypedISetProxy.k6F04VybcQLEkELbXrQ(UntypedISetProxy.XYArr3yWkPKwVS7iiyV((object) this.containsMethod, this.typedISet, (object) new object[1]
    {
      o
    }));

    public IEnumerator GetEnumerator() => (IEnumerator) UntypedISetProxy.XYArr3yWkPKwVS7iiyV((object) this.getEnumeratorMethod, this.typedISet, (object) null);

    internal static void IHI3kEmLWgQjJGwe1ib() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type miMk9mmUE3Ry9Hi8w84([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool UHBiw7ms77VSyXx9Akm([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object C3Xx3emcKLuMwEKqHmZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Ry8sQgmzOafDQ3hq5Xs([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object CetoHGyFUbWUC9wUy44([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool hm84dDyBjcm4gjAE5YP([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 == (PropertyInfo) obj1;

    internal static bool vmw2WCmjdqCesyQ3ZiH() => UntypedISetProxy.ixVCvOm53qUXvUJKble == null;

    internal static UntypedISetProxy cVSgO1mYOgvywP23h0N() => UntypedISetProxy.ixVCvOm53qUXvUJKble;

    internal static object XYArr3yWkPKwVS7iiyV([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static object cXFiqTyoAOlVa6tMjvd([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool k6F04VybcQLEkELbXrQ([In] object obj0) => Convert.ToBoolean(obj0);
  }
}
