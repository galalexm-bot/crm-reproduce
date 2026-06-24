// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.ExcelStyleHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  public static class ExcelStyleHelper
  {
    private static ExcelStyleHelper XBMF7BEGgln5Lqi8BUm2;

    public static void SetBackColor(Style style, StyleFlag styleFlag, Color color)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            style.ForegroundColor = color;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
            continue;
          case 2:
            ExcelStyleHelper.AyhR6CEGY4Q97Q0FgawQ((object) styleFlag, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            ExcelStyleHelper.fAaKikEGLXMOyApUBTfM((object) style, BackgroundType.Solid);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    public static void SetFontColor(Style style, StyleFlag styleFlag, Color color)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExcelStyleHelper.TxAeMTEGs6DjhgKestwO((object) style.Font, color);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          case 2:
            ExcelStyleHelper.dSuuhnEGUqEsgBmDk5bX((object) styleFlag, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public static void SetFontSize(Style style, StyleFlag styleFlag, int size)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExcelStyleHelper.J6yM6rEGcG13Syg1G5Xa((object) styleFlag, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ExcelStyleHelper.uNBnjmEGz88uUYTqGe0o((object) style.Font, size);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    public static void SetFontBold(Style style, StyleFlag styleFlag, bool isBold)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExcelStyleHelper.SdQlmfEEB19wX17yf46K((object) style.Font, isBold);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          case 2:
            ExcelStyleHelper.E98C56EEFqMEIyiWh43n((object) styleFlag, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public static void SetIndentLevel(Style style, StyleFlag styleFlag, int level)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExcelStyleHelper.GCrCg3EEoFrQHGlUfjCF((object) style, level);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            ExcelStyleHelper.QKwRawEEWiKH2oTHqJ4R((object) styleFlag, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public static void SetHorizontalAlignment(
      Style style,
      StyleFlag styleFlag,
      TextAlignmentType alignment)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExcelStyleHelper.oS26yeEEhMwj7VlkYUnn((object) style, alignment);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            ExcelStyleHelper.woeUP5EEbEMXBfgjrtvC((object) styleFlag, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void AyhR6CEGY4Q97Q0FgawQ([In] object obj0, [In] bool obj1) => ((StyleFlag) obj0).CellShading = obj1;

    internal static void fAaKikEGLXMOyApUBTfM([In] object obj0, [In] BackgroundType obj1) => ((Style) obj0).Pattern = obj1;

    internal static bool zlc154EG5cAtjcsexiDh() => ExcelStyleHelper.XBMF7BEGgln5Lqi8BUm2 == null;

    internal static ExcelStyleHelper z0ZdI9EGj0upM0e5TWGN() => ExcelStyleHelper.XBMF7BEGgln5Lqi8BUm2;

    internal static void dSuuhnEGUqEsgBmDk5bX([In] object obj0, [In] bool obj1) => ((StyleFlag) obj0).FontColor = obj1;

    internal static void TxAeMTEGs6DjhgKestwO([In] object obj0, [In] Color obj1) => ((Aspose.Cells.Font) obj0).Color = obj1;

    internal static void J6yM6rEGcG13Syg1G5Xa([In] object obj0, [In] bool obj1) => ((StyleFlag) obj0).FontSize = obj1;

    internal static void uNBnjmEGz88uUYTqGe0o([In] object obj0, [In] int obj1) => ((Aspose.Cells.Font) obj0).Size = obj1;

    internal static void E98C56EEFqMEIyiWh43n([In] object obj0, [In] bool obj1) => ((StyleFlag) obj0).FontBold = obj1;

    internal static void SdQlmfEEB19wX17yf46K([In] object obj0, [In] bool obj1) => ((Aspose.Cells.Font) obj0).IsBold = obj1;

    internal static void QKwRawEEWiKH2oTHqJ4R([In] object obj0, [In] bool obj1) => ((StyleFlag) obj0).Indent = obj1;

    internal static void GCrCg3EEoFrQHGlUfjCF([In] object obj0, [In] int obj1) => ((Style) obj0).IndentLevel = obj1;

    internal static void woeUP5EEbEMXBfgjrtvC([In] object obj0, [In] bool obj1) => ((StyleFlag) obj0).HorizontalAlignment = obj1;

    internal static void oS26yeEEhMwj7VlkYUnn([In] object obj0, [In] TextAlignmentType obj1) => ((Style) obj0).HorizontalAlignment = obj1;
  }
}
