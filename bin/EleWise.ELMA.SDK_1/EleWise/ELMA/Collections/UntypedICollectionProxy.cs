// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.UntypedICollectionProxy
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
  /// Нетипизированная обертка для типизированного <see cref="T:System.Collections.Generic.ICollection`1" />
  /// </summary>
  public class UntypedICollectionProxy : IUntypedCollectionProxy, IEnumerable
  {
    private readonly object typedICollection;
    private readonly MethodInfo addMethod;
    private readonly MethodInfo removeMethod;
    private readonly MethodInfo clearMethod;
    private readonly MethodInfo getEnumeratorMethod;
    private readonly MethodInfo containsMethod;
    internal static UntypedICollectionProxy NHXv5Amp9HBqHSrPZ8h;

    /// <summary>Ctor</summary>
    /// <param name="typedICollection">Значение с типом <see cref="T:System.Collections.Generic.ICollection`1" /></param>
    public UntypedICollectionProxy(object typedICollection)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 2;
      Type type1;
      while (true)
      {
        int num2;
        Type type2;
        switch (num1)
        {
          case 1:
            this.clearMethod = type1.GetMethod((string) UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(-138018305 ^ -137983099));
            num2 = 10;
            break;
          case 2:
            Contract.ArgumentNotNull(typedICollection, (string) UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(-882126494 ^ -882150672));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 3 : 0;
            continue;
          case 3:
            this.typedICollection = typedICollection;
            num1 = 14;
            continue;
          case 4:
            if (UntypedICollectionProxy.r1muOsmw6kpl4kRFxwD(type1, (Type) null))
            {
              num2 = 6;
              break;
            }
            this.addMethod = type1.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-397266137 ^ 397240548));
            num1 = 5;
            continue;
          case 5:
            if (!(this.addMethod == (MethodInfo) null))
            {
              num1 = 17;
              continue;
            }
            goto label_21;
          case 6:
            goto label_19;
          case 7:
            if (UntypedICollectionProxy.iUkRa2m6sxCXfl2Qmoc((object) this.containsMethod, (object) null))
            {
              num1 = 11;
              continue;
            }
            goto label_8;
          case 8:
            goto label_26;
          case 9:
            if (!UntypedICollectionProxy.iUkRa2m6sxCXfl2Qmoc((object) this.getEnumeratorMethod, (object) null))
            {
              this.containsMethod = type1.GetMethod((string) UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(~-122002947 ^ 121977816));
              num1 = 7;
              continue;
            }
            num1 = 13;
            continue;
          case 10:
            if (this.clearMethod == (MethodInfo) null)
            {
              num1 = 8;
              continue;
            }
            // ISSUE: type reference
            type2 = typedICollection.GetType().GetInterface(UntypedICollectionProxy.ClcKJCmHn5kn3KyRw4E(__typeref (IEnumerable)).FullName);
            num1 = 12;
            continue;
          case 11:
            goto label_18;
          case 12:
            this.getEnumeratorMethod = type2.GetMethod((string) UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(-1837662597 ^ -1837638867));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 5 : 9;
            continue;
          case 13:
            goto label_4;
          case 14:
            type1 = typedICollection.GetType().GetInterface(typeof (ICollection<>).FullName);
            num1 = 4;
            continue;
          case 15:
            if (!UntypedICollectionProxy.iUkRa2m6sxCXfl2Qmoc((object) this.removeMethod, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
              continue;
            }
            goto label_11;
          case 16:
            goto label_21;
          case 17:
            this.removeMethod = type1.GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767760541));
            num2 = 15;
            break;
          default:
            goto label_11;
        }
        num1 = num2;
      }
label_4:
      throw new InvalidOperationException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487346414), (object) type1.FullName));
label_11:
      throw new InvalidOperationException((string) UntypedICollectionProxy.srLUEHm4DRWf1hSKi9b(UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(825385222 ^ 825410990), (object) type1.FullName));
label_18:
      throw new InvalidOperationException((string) UntypedICollectionProxy.srLUEHm4DRWf1hSKi9b(UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(--1867379187 ^ 1867338781), (object) type1.FullName));
label_19:
      throw new ArgumentException((string) UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(-1217523399 ^ -1217482097), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606629234));
label_21:
      throw new InvalidOperationException((string) UntypedICollectionProxy.srLUEHm4DRWf1hSKi9b(UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(-1350312861 << 3 ^ 2082359134), (object) type1.FullName));
label_26:
      throw new InvalidOperationException((string) UntypedICollectionProxy.srLUEHm4DRWf1hSKi9b(UntypedICollectionProxy.ngE3EkmtUaY7aK5GdlB(-1710575414 ^ -1710615094), (object) type1.FullName));
label_8:;
    }

    /// <summary>Добавить элемент</summary>
    /// <param name="o">Элемент</param>
    /// <returns></returns>
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
            UntypedICollectionProxy.nOKbC1mApHrmLhCRWVn((object) this.addMethod, this.typedICollection, (object) new object[1]
            {
              o
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
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
    public bool Remove(object o) => (bool) UntypedICollectionProxy.nOKbC1mApHrmLhCRWVn((object) this.removeMethod, this.typedICollection, (object) new object[1]
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
            this.clearMethod.Invoke(this.typedICollection, (object[]) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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
    public bool Contains(object o) => Convert.ToBoolean(UntypedICollectionProxy.nOKbC1mApHrmLhCRWVn((object) this.containsMethod, this.typedICollection, (object) new object[1]
    {
      o
    }));

    public IEnumerator GetEnumerator() => (IEnumerator) UntypedICollectionProxy.nOKbC1mApHrmLhCRWVn((object) this.getEnumeratorMethod, this.typedICollection, (object) null);

    internal static object ngE3EkmtUaY7aK5GdlB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool r1muOsmw6kpl4kRFxwD([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object srLUEHm4DRWf1hSKi9b([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static bool iUkRa2m6sxCXfl2Qmoc([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static Type ClcKJCmHn5kn3KyRw4E([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool Les6dumaxYW442cQJv5() => UntypedICollectionProxy.NHXv5Amp9HBqHSrPZ8h == null;

    internal static UntypedICollectionProxy YCdnrOmD9JfsTsN9HfM() => UntypedICollectionProxy.NHXv5Amp9HBqHSrPZ8h;

    internal static object nOKbC1mApHrmLhCRWVn([In] object obj0, [In] object obj1, [In] object obj2) => ((MethodBase) obj0).Invoke(obj1, (object[]) obj2);
  }
}
