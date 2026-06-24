// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.GridColumnViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Колонка</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_GridColumnViewItem), "DisplayName")]
  [Serializable]
  public class GridColumnViewItem : RootViewItem, IContainerViewItem, IGridColumnViewItem
  {
    private static GridColumnViewItem Fa7IgSoKgCn5dyT2CYC5;

    /// <summary>Ctor</summary>
    public GridColumnViewItem()
    {
      GridColumnViewItem.Dy48ZWoKYbQnofZNnFaA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.WidthType = WidthType.Pixel;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    [DefaultValue(WidthType.Pixel)]
    public WidthType WidthType
    {
      get => this.\u003CWidthType\u003Ek__BackingField;
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
              this.\u003CWidthType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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
    [DefaultValue(null)]
    public int? Width { get; set; }

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_3;
          case 2:
            if (parentViewItem is GridViewItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 4:
            if (parentViewItem == null)
            {
              num = 3;
              continue;
            }
            goto case 2;
          default:
            goto label_2;
        }
      }
label_2:
      return parentViewItem is TableViewItem;
label_3:
      return true;
    }

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => true;

    internal static void Dy48ZWoKYbQnofZNnFaA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool TARcNeoK56Xy81aLUgxp() => GridColumnViewItem.Fa7IgSoKgCn5dyT2CYC5 == null;

    internal static GridColumnViewItem RjeACZoKjqWYSkOWrOrx() => GridColumnViewItem.Fa7IgSoKgCn5dyT2CYC5;
  }
}
