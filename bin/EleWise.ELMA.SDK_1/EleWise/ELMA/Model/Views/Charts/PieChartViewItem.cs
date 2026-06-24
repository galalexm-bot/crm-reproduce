// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.Charts.PieChartViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views.Charts
{
  /// <summary>Круговая диаграмма</summary>
  [Serializable]
  public class PieChartViewItem : ChartViewItem
  {
    internal static PieChartViewItem extaSboDzedrc4gHiLuL;

    /// <summary>ctor</summary>
    public PieChartViewItem()
    {
      PieChartViewItem.p2bZSIotWaWKZ5120VUA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ViewType = ViewItemPieChartViewType.Ring;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Вид отображения</summary>
    [DefaultValue(ViewItemPieChartViewType.Ring)]
    public ViewItemPieChartViewType ViewType
    {
      get => this.\u003CViewType\u003Ek__BackingField;
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
              this.\u003CViewType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    internal static void p2bZSIotWaWKZ5120VUA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool PHFur2otFOPcWy6UNfIV() => PieChartViewItem.extaSboDzedrc4gHiLuL == null;

    internal static PieChartViewItem f57VniotBgjBRvL4IC3i() => PieChartViewItem.extaSboDzedrc4gHiLuL;
  }
}
