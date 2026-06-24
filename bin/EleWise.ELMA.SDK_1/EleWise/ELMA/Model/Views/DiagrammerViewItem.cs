// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.DiagrammerViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Диаграммер</summary>
  [Serializable]
  public class DiagrammerViewItem : RootViewItem
  {
    internal static DiagrammerViewItem suHR2Soi3b5bRW4EhmDW;

    /// <summary>
    /// Диаграммер рисует диаграмму в режиме только для чтения
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    [DefaultValue(false)]
    public bool ReadOnlyDiagram
    {
      get => this.\u003CReadOnlyDiagram\u003Ek__BackingField;
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
              this.\u003CReadOnlyDiagram\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
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

    /// <summary>
    /// Отображать контрол "На весь экран"
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    [DefaultValue(false)]
    public bool DisplayFullscreen
    {
      get => this.\u003CDisplayFullscreen\u003Ek__BackingField;
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
              this.\u003CDisplayFullscreen\u003Ek__BackingField = value;
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

    /// <summary>Отображение на весь экран</summary>
    [DefaultValue(false)]
    public bool Fullscreen
    {
      get => this.\u003CFullscreen\u003Ek__BackingField;
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
              this.\u003CFullscreen\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

    /// <summary>Отображать сетку</summary>
    [DefaultValue(false)]
    public bool DisplayGrid
    {
      get => this.\u003CDisplayGrid\u003Ek__BackingField;
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
              this.\u003CDisplayGrid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is DynamicListViewItem;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => DiagrammerViewItem.MU1Mq4oiDmouNdp69el4((object) parentViewItem, (object) this);

    public DiagrammerViewItem()
    {
      DiagrammerViewItem.tkqjyNoit2ROfiroRMRr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qYGa2uoipR1TReJW07C2() => DiagrammerViewItem.suHR2Soi3b5bRW4EhmDW == null;

    internal static DiagrammerViewItem IaojThoiaqAXRk5xSXPo() => DiagrammerViewItem.suHR2Soi3b5bRW4EhmDW;

    internal static bool MU1Mq4oiDmouNdp69el4([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static void tkqjyNoit2ROfiroRMRr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
