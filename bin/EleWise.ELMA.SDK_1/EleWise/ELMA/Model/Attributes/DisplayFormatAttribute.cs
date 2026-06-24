// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DisplayFormatAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Формат отображения класса на формах. Используется при вызове метода ToString()
  /// </summary>
  public class DisplayFormatAttribute : Attribute
  {
    private string format;
    internal static DisplayFormatAttribute WD12qYoICkH4IYxyFbSi;

    /// <summary>Новый формат</summary>
    /// <param name="format"></param>
    public DisplayFormatAttribute(string format)
    {
      DisplayFormatAttribute.bEZBrNoIZ3AeFOs0dwd0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.format = format;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Формат отображения</summary>
    public string Format
    {
      get => this.format;
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
              this.format = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

    internal static void bEZBrNoIZ3AeFOs0dwd0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool jRKhrmoIv5WtSd0bKWVN() => DisplayFormatAttribute.WD12qYoICkH4IYxyFbSi == null;

    internal static DisplayFormatAttribute z32bW2oI8JRFfnMITbWi() => DisplayFormatAttribute.WD12qYoICkH4IYxyFbSi;
  }
}
