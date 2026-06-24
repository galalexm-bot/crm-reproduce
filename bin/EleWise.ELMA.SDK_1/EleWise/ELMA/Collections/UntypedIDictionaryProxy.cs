// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.UntypedIDictionaryProxy
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
  /// Нетипизированная обертка для типизированного <see cref="T:System.Collections.Generic.IDictionary`2" />
  /// </summary>
  public class UntypedIDictionaryProxy : IUntypedCollectionProxy, IEnumerable
  {
    private readonly object typedIDictionary;
    private readonly MethodInfo addKeyValueMethod;
    private readonly MethodInfo keyGetMethod;
    private readonly MethodInfo valueGetMethod;
    private readonly MethodInfo addMethod;
    private readonly MethodInfo removeMethod;
    private readonly MethodInfo clearMethod;
    private readonly MethodInfo getEnumeratorMethod;
    private readonly MethodInfo containsMethod;
    private static UntypedIDictionaryProxy n8FyHkm7hh2NUyUe8tO;

    /// <summary>Ctor</summary>
    /// <param name="typedIDictionary">Значение с типом <see cref="T:System.Collections.Generic.IDictionary`2" /></param>
    public UntypedIDictionaryProxy(object typedIDictionary)
    {
      UntypedIDictionaryProxy.JnV42OmmPyOMiQXDf3e();
      // ISSUE: type reference
      // ISSUE: explicit non-virtual call
      this.keyGetMethod = (MethodInfo) UntypedIDictionaryProxy.a8BupbmJBOYUHob1cgq((object) __nonvirtual (UntypedIDictionaryProxy.HlIbaMmyjuyZaOKfK5C(__typeref (KeyValuePair<,>)).GetProperty((string) UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(1178210108 ^ 1178249590))));
      // ISSUE: type reference
      // ISSUE: explicit non-virtual call
      this.valueGetMethod = (MethodInfo) UntypedIDictionaryProxy.a8BupbmJBOYUHob1cgq((object) __nonvirtual (UntypedIDictionaryProxy.HlIbaMmyjuyZaOKfK5C(__typeref (KeyValuePair<,>)).GetProperty((string) UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(-1839087379 - 334718690 ^ 2121202783))));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 16;
      Type type1;
      while (true)
      {
        int num2 = num1;
        Type type2;
        Type type3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.getEnumeratorMethod = type3.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767760723));
              num2 = 4;
              continue;
            case 2:
              this.addKeyValueMethod = type1.GetMethod((string) UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(-105199646 ^ -105225250));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 17 : 4;
              continue;
            case 3:
              type2 = typedIDictionary.GetType().GetInterface(typeof (ICollection<>).FullName);
              num2 = 2;
              continue;
            case 4:
              if (!UntypedIDictionaryProxy.bT3rmhmdTTmkYpdlylb((object) this.getEnumeratorMethod, (object) null))
              {
                this.containsMethod = type2.GetMethod((string) UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(87862435 ^ 87820665));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 6 : 7;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 11 : 5;
              continue;
            case 5:
              goto label_28;
            case 6:
              if (!UntypedIDictionaryProxy.bT3rmhmdTTmkYpdlylb((object) this.addMethod, (object) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 4 : 5;
                continue;
              }
              goto label_27;
            case 7:
              if (UntypedIDictionaryProxy.bT3rmhmdTTmkYpdlylb((object) this.containsMethod, (object) null))
              {
                num2 = 21;
                continue;
              }
              goto label_24;
            case 8:
              if (!(type1 == (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 1;
                continue;
              }
              goto label_10;
            case 9:
              // ISSUE: type reference
              type3 = typedIDictionary.GetType().GetInterface(UntypedIDictionaryProxy.HlIbaMmyjuyZaOKfK5C(__typeref (IEnumerable)).FullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
              continue;
            case 10:
              goto label_14;
            case 11:
              goto label_7;
            case 12:
              this.addMethod = type2.GetMethod((string) UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(-281842504 ^ -281819004));
              num2 = 6;
              continue;
            case 13:
              type1 = typedIDictionary.GetType().GetInterface(typeof (IDictionary<,>).FullName);
              num2 = 8;
              continue;
            case 14:
              this.typedIDictionary = typedIDictionary;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 11 : 13;
              continue;
            case 15:
              goto label_10;
            case 16:
              UntypedIDictionaryProxy.WW89lUm9iYhZmZeGRdJ(typedIDictionary, UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(979449278 ^ 979473372));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 6 : 14;
              continue;
            case 17:
              if (!UntypedIDictionaryProxy.bT3rmhmdTTmkYpdlylb((object) this.addKeyValueMethod, (object) null))
              {
                num2 = 12;
                continue;
              }
              goto label_14;
            case 18:
              goto label_16;
            case 19:
              if (this.removeMethod == (MethodInfo) null)
              {
                num2 = 22;
                continue;
              }
              this.clearMethod = type2.GetMethod((string) UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(-1867198571 ^ -1867233809));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            case 20:
              goto label_27;
            case 21:
              goto label_3;
            case 22:
              goto label_20;
            default:
              if (!(this.clearMethod == (MethodInfo) null))
              {
                num2 = 9;
                continue;
              }
              goto label_16;
          }
        }
label_28:
        this.removeMethod = type2.GetMethod((string) UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(~541731958 ^ -541755631));
        num1 = 19;
      }
label_3:
      throw new InvalidOperationException((string) UntypedIDictionaryProxy.aYuBxtmlkFG8fFbBmP5(UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(-1217523399 ^ -1217481513), (object) type1.FullName));
label_7:
      throw new InvalidOperationException((string) UntypedIDictionaryProxy.aYuBxtmlkFG8fFbBmP5(UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(~541731958 ^ -541755651), (object) type1.FullName));
label_10:
      throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909137383), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69998526));
label_14:
      throw new InvalidOperationException((string) UntypedIDictionaryProxy.aYuBxtmlkFG8fFbBmP5(UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(-441065788 ^ -2092910478 ^ 1727381600), (object) type1.FullName));
label_16:
      throw new InvalidOperationException((string) UntypedIDictionaryProxy.aYuBxtmlkFG8fFbBmP5(UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(~-122002947 ^ 121977602), (object) type1.FullName));
label_20:
      throw new InvalidOperationException((string) UntypedIDictionaryProxy.aYuBxtmlkFG8fFbBmP5(UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(-1824388195 ^ -1824346315), (object) type1.FullName));
label_27:
      throw new InvalidOperationException(string.Format((string) UntypedIDictionaryProxy.bTlqMxmMP53v10sBlOT(-477139494 ^ -477116004), (object) type1.FullName));
label_24:;
    }

    /// <summary>Добавить элемент</summary>
    /// <param name="o">Элемент</param>
    /// <returns></returns>
    public void Add(KeyValuePair<object, object> o) => this.addKeyValueMethod.Invoke(this.typedIDictionary, new object[2]
    {
      o.Key,
      o.Value
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
          case 1:
            if (o == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            // ISSUE: type reference
            if (UntypedIDictionaryProxy.HlIbaMmyjuyZaOKfK5C(__typeref (KeyValuePair<,>)).IsInstanceOfType(o))
            {
              num = 4;
              continue;
            }
            break;
          case 3:
            goto label_8;
          case 4:
            this.Add(new KeyValuePair<object, object>(UntypedIDictionaryProxy.dHxajLmr5H1qpdbBAh0((object) this.keyGetMethod, o, (object) null), UntypedIDictionaryProxy.dHxajLmr5H1qpdbBAh0((object) this.valueGetMethod, o, (object) null)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 3;
            continue;
          case 5:
            goto label_4;
        }
        UntypedIDictionaryProxy.dHxajLmr5H1qpdbBAh0((object) this.addMethod, this.typedIDictionary, (object) new object[1]
        {
          o
        });
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 5 : 0;
      }
label_8:
      return;
label_4:;
    }

    /// <summary>Удалить элемент</summary>
    /// <param name="o">Элемент</param>
    /// <returns></returns>
    public bool Remove(object o) => (bool) UntypedIDictionaryProxy.dHxajLmr5H1qpdbBAh0((object) this.removeMethod, this.typedIDictionary, (object) new object[1]
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
            UntypedIDictionaryProxy.dHxajLmr5H1qpdbBAh0((object) this.clearMethod, this.typedIDictionary, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Определяет содержит ли список элемент</summary>
    /// <param name="o">Элемент</param>
    public bool Contains(object o) => UntypedIDictionaryProxy.sQhHmsmg0vbfroR5ylj(UntypedIDictionaryProxy.dHxajLmr5H1qpdbBAh0((object) this.containsMethod, this.typedIDictionary, (object) new object[1]
    {
      o
    }));

    public IEnumerator GetEnumerator() => (IEnumerator) this.getEnumeratorMethod.Invoke(this.typedIDictionary, (object[]) null);

    internal static void JnV42OmmPyOMiQXDf3e() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type HlIbaMmyjuyZaOKfK5C([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object bTlqMxmMP53v10sBlOT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object a8BupbmJBOYUHob1cgq([In] object obj0) => (object) ((PropertyInfo) obj0).GetGetMethod();

    internal static void WW89lUm9iYhZmZeGRdJ([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool bT3rmhmdTTmkYpdlylb([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object aYuBxtmlkFG8fFbBmP5([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool wIBmZymx84aVEH9gWLO() => UntypedIDictionaryProxy.n8FyHkm7hh2NUyUe8tO == null;

    internal static UntypedIDictionaryProxy cxd4Bgm0FsjI7Poo8U5() => UntypedIDictionaryProxy.n8FyHkm7hh2NUyUe8tO;

    internal static object dHxajLmr5H1qpdbBAh0([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);

    internal static bool sQhHmsmg0vbfroR5ylj([In] object obj0) => Convert.ToBoolean(obj0);
  }
}
