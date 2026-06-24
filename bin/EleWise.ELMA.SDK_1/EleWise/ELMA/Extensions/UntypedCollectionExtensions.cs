// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.UntypedCollectionExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширения для работы с нетипизированными коллекциями</summary>
  public static class UntypedCollectionExtensions
  {
    private static UntypedCollectionExtensions MuuxHkG6ewuf6tUd8scC;

    /// <summary>
    /// Преобразовать значение типизированного <see cref="T:System.Collections.Generic.ISet`1" /> в нетипизированный прокси
    /// </summary>
    /// <param name="iSetValue">Значение с типом, реализующим <see cref="T:System.Collections.Generic.ISet`1" /></param>
    /// <returns>Прокси-обертка</returns>
    public static UntypedISetProxy AsUntypedISet(this object iSetValue)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (!(iSetValue.GetType().GetInterface(UntypedCollectionExtensions.U9mmovG6NMXJn0mbkjGS(__typeref (Iesi.Collections.Generic.ISet<>)).FullName) != (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            if (iSetValue != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return (UntypedISetProxy) null;
label_5:
      return new UntypedISetProxy(iSetValue);
    }

    /// <summary>
    /// Преобразовать значение типизированного <see cref="T:System.Collections.Generic.ICollection`1" /> в нетипизированный прокси
    /// </summary>
    /// <param name="iCollectionValue">Значение с типом, реализующим <see cref="T:System.Collections.Generic.ICollection`1" /></param>
    /// <returns>Прокси-обертка</returns>
    public static UntypedICollectionProxy AsUntypedICollection(this object iCollectionValue)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            if (!UntypedCollectionExtensions.CGOeJcG63Zp5ylamhNfa(iCollectionValue.GetType().GetInterface(UntypedCollectionExtensions.U9mmovG6NMXJn0mbkjGS(__typeref (ICollection<>)).FullName), (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 3:
            if (iCollectionValue == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_2;
        }
      }
label_2:
      return (UntypedICollectionProxy) null;
label_3:
      return new UntypedICollectionProxy(iCollectionValue);
    }

    /// <summary>
    /// Преобразовать значение типизированного <see cref="T:System.Collections.Generic.IDictionary`2" /> в нетипизированный прокси
    /// </summary>
    /// <param name="iDictionaryValue">Значение с типом, реализующим <see cref="T:System.Collections.Generic.IDictionary`2" /></param>
    /// <returns>Прокси-обертка</returns>
    public static UntypedIDictionaryProxy AsUntypedIDictionary(this object iDictionaryValue)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
            goto label_6;
          case 3:
            if (iDictionaryValue == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 2 : 1;
              continue;
            }
            break;
        }
        if (!(iDictionaryValue.GetType().GetInterface(typeof (IDictionary<,>).FullName) != (Type) null))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
        else
          goto label_7;
      }
label_6:
      return (UntypedIDictionaryProxy) null;
label_7:
      return new UntypedIDictionaryProxy(iDictionaryValue);
    }

    internal static Type U9mmovG6NMXJn0mbkjGS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool RFs7OmG6P52Uv6uSvohR() => UntypedCollectionExtensions.MuuxHkG6ewuf6tUd8scC == null;

    internal static UntypedCollectionExtensions zBqvwuG618LewubBRebR() => UntypedCollectionExtensions.MuuxHkG6ewuf6tUd8scC;

    internal static bool CGOeJcG63Zp5ylamhNfa([In] Type obj0, [In] Type obj1) => obj0 != obj1;
  }
}
