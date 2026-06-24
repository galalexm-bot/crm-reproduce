// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.ExcelStyle
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  /// <summary>Основная реализация стиля</summary>
  public class ExcelStyle : IExcelStyle
  {
    private static ExcelStyle qhf2QxEEqehfHZHAeW9v;

    /// <summary>Цвет фона</summary>
    public Color? BackColor { get; set; }

    /// <summary>Цвет шрифта</summary>
    public Color? FontColor { get; set; }

    /// <summary>Размер шрифта</summary>
    public int? FontSize { get; set; }

    /// <summary>Жирный ли шрифт</summary>
    public bool? FontBold { get; set; }

    /// <summary>Дополнительное действие</summary>
    public System.Action<Style, StyleFlag> Action { get; set; }

    /// <summary>Применить стиль</summary>
    /// <param name="style">Стиль</param>
    /// <param name="styleFlag">Флаги применения стиля</param>
    public void Apply(Style style, StyleFlag styleFlag)
    {
      int num1 = 18;
      while (true)
      {
        int num2 = num1;
        int? fontSize;
        Color? nullable;
        bool? fontBold;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              fontBold = this.FontBold;
              num2 = 6;
              continue;
            case 3:
              if (!nullable.HasValue)
              {
                num2 = 15;
                continue;
              }
              goto case 20;
            case 5:
              Style style1 = style;
              StyleFlag styleFlag1 = styleFlag;
              fontSize = this.FontSize;
              int size = fontSize.Value;
              ExcelStyleHelper.SetFontSize(style1, styleFlag1, size);
              num2 = 2;
              continue;
            case 6:
              if (!fontBold.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            case 7:
              if (!nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 13 : 3;
                continue;
              }
              goto case 12;
            case 8:
            case 13:
              fontSize = this.FontSize;
              num2 = 19;
              continue;
            case 9:
              goto label_25;
            case 10:
              goto label_9;
            case 11:
              this.Action(style, styleFlag);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 10 : 10;
              continue;
            case 12:
              Style style2 = style;
              StyleFlag styleFlag2 = styleFlag;
              nullable = this.FontColor;
              Color color1 = nullable.Value;
              ExcelStyle.pBvMY1EEkWDoOQFs3A24((object) style2, (object) styleFlag2, color1);
              num2 = 8;
              continue;
            case 14:
              Style style3 = style;
              StyleFlag styleFlag3 = styleFlag;
              fontBold = this.FontBold;
              int num3 = fontBold.Value ? 1 : 0;
              ExcelStyle.uADeToEEnhDxYxCDTGOP((object) style3, (object) styleFlag3, num3 != 0);
              num2 = 4;
              continue;
            case 15:
            case 16:
              goto label_8;
            case 17:
              goto label_12;
            case 18:
              if (style == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 17 : 13;
                continue;
              }
              if (styleFlag == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
                continue;
              }
              nullable = this.BackColor;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 3 : 0;
              continue;
            case 19:
              if (fontSize.HasValue)
              {
                num2 = 5;
                continue;
              }
              goto case 2;
            case 20:
              Style style4 = style;
              StyleFlag styleFlag4 = styleFlag;
              nullable = this.BackColor;
              Color color2 = nullable.Value;
              ExcelStyleHelper.SetBackColor(style4, styleFlag4, color2);
              num2 = 16;
              continue;
            default:
              if (this.Action == null)
              {
                num2 = 9;
                continue;
              }
              goto case 11;
          }
        }
label_8:
        nullable = this.FontColor;
        num1 = 7;
      }
label_25:
      return;
label_9:
      return;
label_12:
      throw new ArgumentNullException((string) ExcelStyle.maeDAnEETPMsjiJNuHSO(-1872275253 >> 6 ^ -29113473));
label_15:
      throw new ArgumentNullException((string) ExcelStyle.maeDAnEETPMsjiJNuHSO(1021410165 ^ 1021661013));
    }

    public ExcelStyle()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object maeDAnEETPMsjiJNuHSO(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void pBvMY1EEkWDoOQFs3A24([In] object obj0, [In] object obj1, Color color) => ExcelStyleHelper.SetFontColor((Style) obj0, (StyleFlag) obj1, color);

    internal static void uADeToEEnhDxYxCDTGOP([In] object obj0, [In] object obj1, bool isBold) => ExcelStyleHelper.SetFontBold((Style) obj0, (StyleFlag) obj1, isBold);

    internal static bool tnRLIGEEKvdna0vBNhDy() => ExcelStyle.qhf2QxEEqehfHZHAeW9v == null;

    internal static ExcelStyle NaSDSIEEXlTRD6LVa6iV() => ExcelStyle.qhf2QxEEqehfHZHAeW9v;
  }
}
