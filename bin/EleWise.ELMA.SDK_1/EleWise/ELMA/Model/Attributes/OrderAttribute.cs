// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.OrderAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Атрбут указывает порядок для какого-либо элемента метаданных
  /// </summary>
  public class OrderAttribute : Attribute
  {
    private int order;
    private static OrderAttribute rWNBtxo85KDwX9pRuNs6;

    /// <summary>Ctor</summary>
    /// <param name="order">Порядок</param>
    public OrderAttribute(int order)
    {
      OrderAttribute.KpTxoko8LjYYVvbqo9u8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.order = order;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Порядок</summary>
    public int Order => this.order;

    internal static void KpTxoko8LjYYVvbqo9u8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool MYIlmto8jxiRbDGKylNH() => OrderAttribute.rWNBtxo85KDwX9pRuNs6 == null;

    internal static OrderAttribute YuEenso8YMjDgaUAet08() => OrderAttribute.rWNBtxo85KDwX9pRuNs6;
  }
}
