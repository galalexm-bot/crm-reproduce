// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.Models.API.WebDataItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Common.Models.API
{
  /// <summary>Элемент данных</summary>
  [Serializable]
  public class WebDataItem : EleWise.ELMA.Common.Models.WebDataItem
  {
    private static WebDataItem GdPrKwfRKRTk3lBftERa;

    public WebDataItem()
    {
      WebDataItem.aXspbNfRk1n23jjkvxee();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public static WebDataItem Create(EleWise.ELMA.Common.Models.WebDataItem baseItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (baseItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (WebDataItem) null;
label_5:
      WebDataItem webDataItem = new WebDataItem();
      webDataItem.name = (string) WebDataItem.XrAbUFfRngty0SNvmSAE((object) baseItem);
      webDataItem.value = (string) WebDataItem.pptoc9fROWfJfHPZtG92((object) baseItem);
      webDataItem.data = (EleWise.ELMA.Common.Models.WebData) WebDataItem.DpOJ0lfReNTbEYWBw5LS(WebDataItem.OK82pkfR2C1rc6PkcEBv((object) baseItem));
      webDataItem.dataArray = ((IEnumerable<EleWise.ELMA.Common.Models.WebData>) baseItem.DataArray).Select<EleWise.ELMA.Common.Models.WebData, WebData>(new Func<EleWise.ELMA.Common.Models.WebData, WebData>(WebData.Create)).Cast<EleWise.ELMA.Common.Models.WebData>().ToArray<EleWise.ELMA.Common.Models.WebData>();
      return webDataItem;
    }

    internal static void aXspbNfRk1n23jjkvxee() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool NMmrQPfRXS8wTWwoV81q() => WebDataItem.GdPrKwfRKRTk3lBftERa == null;

    internal static WebDataItem iv1kdNfRTPiuqO6dMcIq() => WebDataItem.GdPrKwfRKRTk3lBftERa;

    internal static object XrAbUFfRngty0SNvmSAE([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Name;

    internal static object pptoc9fROWfJfHPZtG92([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Value;

    internal static object OK82pkfR2C1rc6PkcEBv([In] object obj0) => (object) ((EleWise.ELMA.Common.Models.WebDataItem) obj0).Data;

    internal static object DpOJ0lfReNTbEYWBw5LS([In] object obj0) => (object) WebData.Create((EleWise.ELMA.Common.Models.WebData) obj0);
  }
}
