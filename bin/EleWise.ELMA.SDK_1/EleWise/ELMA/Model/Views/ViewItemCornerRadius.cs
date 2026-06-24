// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ViewItemCornerRadius
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
  /// <summary>Закругления углов</summary>
  public class ViewItemCornerRadius
  {
    internal static ViewItemCornerRadius Sg61jgokNEPG2vTEG9RD;

    public ViewItemCornerRadius()
    {
      ViewItemCornerRadius.MNvrAAokawKfvS9B0l5L();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ViewItemCornerRadius(int? topLeft, int? topRight, int? bottomRight, int? bottomLeft)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.TopLeft = topLeft;
      this.TopRight = topRight;
      this.BottomRight = bottomRight;
      this.BottomLeft = bottomLeft;
    }

    public ViewItemCornerRadius(int? all)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.TopLeft = all;
      this.TopRight = all;
      this.BottomRight = all;
      this.BottomLeft = all;
    }

    /// <summary>Верхний левый</summary>
    [DefaultValue(null)]
    public int? TopLeft { get; set; }

    /// <summary>Верхний правый</summary>
    [DefaultValue(null)]
    public int? TopRight { get; set; }

    /// <summary>Нижний правый</summary>
    [DefaultValue(null)]
    public int? BottomRight { get; set; }

    /// <summary>Нижний левый</summary>
    [DefaultValue(null)]
    public int? BottomLeft { get; set; }

    /// <summary>Применить указанные отступы</summary>
    /// <param name="radius"></param>
    public void Apply(ViewItemCornerRadius radius)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        int? nullable;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (nullable.HasValue)
              {
                num2 = 5;
                continue;
              }
              goto label_13;
            case 2:
              goto label_19;
            case 3:
            case 13:
              nullable = radius.BottomLeft;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
              continue;
            case 4:
              this.TopLeft = radius.TopLeft;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 10 : 9;
              continue;
            case 5:
              this.BottomLeft = radius.BottomLeft;
              num2 = 2;
              continue;
            case 6:
            case 10:
              nullable = radius.TopRight;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 5 : 12;
              continue;
            case 7:
              nullable = radius.BottomRight;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
              continue;
            case 8:
              nullable = radius.TopLeft;
              num2 = 11;
              continue;
            case 9:
              ViewItemCornerRadius.MkJpNjoktkUHlxXnfx4a((object) radius, ViewItemCornerRadius.av4ksWokDXfrcPk4KQ49(1319452732 ^ 1319575014));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 8 : 5;
              continue;
            case 11:
              if (!nullable.HasValue)
              {
                num2 = 6;
                continue;
              }
              goto case 4;
            case 12:
              if (nullable.HasValue)
              {
                num2 = 15;
                continue;
              }
              goto case 7;
            case 14:
              goto label_18;
            case 15:
              this.TopRight = radius.TopRight;
              num2 = 7;
              continue;
            default:
              if (!nullable.HasValue)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 3;
                continue;
              }
              goto label_18;
          }
        }
label_18:
        this.BottomRight = radius.BottomRight;
        num1 = 13;
      }
label_19:
      return;
label_13:;
    }

    internal static void MNvrAAokawKfvS9B0l5L() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Upai0ook3jEIep9qgGPd() => ViewItemCornerRadius.Sg61jgokNEPG2vTEG9RD == null;

    internal static ViewItemCornerRadius GgX0sRokpWKtKmT1AckG() => ViewItemCornerRadius.Sg61jgokNEPG2vTEG9RD;

    internal static object av4ksWokDXfrcPk4KQ49(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void MkJpNjoktkUHlxXnfx4a([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);
  }
}
