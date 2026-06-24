// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemBorder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Граница элемента</summary>
  public class ViewItemBorder
  {
    internal static ViewItemBorder JuoPGbokT2joUFAoKjZW;

    /// <summary>Ширина границы</summary>
    [DefaultValue(null)]
    public int? Width { get; set; }

    /// <summary>Обозначение цвета границы</summary>
    [DefaultValue(null)]
    public ViewItemColor Color
    {
      get => this.\u003CColor\u003Ek__BackingField;
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
              this.\u003CColor\u003Ek__BackingField = value;
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

    /// <summary>Применить указанный стиль</summary>
    /// <param name="border"></param>
    public void Apply(ViewItemBorder border)
    {
      int num = 2;
      int? width;
      while (true)
      {
        switch (num)
        {
          case 1:
            width = border.Width;
            num = 6;
            continue;
          case 2:
            ViewItemBorder.uuv3S5ok2xecg1lfAeCh((object) border, ViewItemBorder.SQ1sWnokOXj7PucDCI4v(1461625753 ^ 1461517907));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 1 : 1;
            continue;
          case 4:
            goto label_8;
          case 5:
            this.Width = border.Width;
            num = 3;
            continue;
          case 6:
            if (!width.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 7:
            this.Color = (ViewItemColor) ViewItemBorder.m3ifxEokPEYaxpeZAOHp((object) border.Color);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 3;
            continue;
          default:
            if (ViewItemBorder.EEa3bYokeQRJPD7gDPJO((object) border) != null)
            {
              num = 7;
              continue;
            }
            goto label_2;
        }
      }
label_8:
      return;
label_2:;
    }

    public ViewItemBorder()
    {
      ViewItemBorder.BfOAQqok1Dyqsx8YH9Xq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VitKIwokkioSFpjevE7O() => ViewItemBorder.JuoPGbokT2joUFAoKjZW == null;

    internal static ViewItemBorder fFJF2Yokn0irdHip8VtC() => ViewItemBorder.JuoPGbokT2joUFAoKjZW;

    internal static object SQ1sWnokOXj7PucDCI4v(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void uuv3S5ok2xecg1lfAeCh([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object EEa3bYokeQRJPD7gDPJO([In] object obj0) => (object) ((ViewItemBorder) obj0).Color;

    internal static object m3ifxEokPEYaxpeZAOHp([In] object obj0) => (object) ((ViewItemColor) obj0).Clone();

    internal static void BfOAQqok1Dyqsx8YH9Xq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
