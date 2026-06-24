// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TableCellViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Ячейка таблицы</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_TableCellViewItem), "DisplayName")]
  [Serializable]
  public class TableCellViewItem : RootViewItem, ILayoutItemViewItem, IContainerViewItem
  {
    private static TableCellViewItem Wt3K9roeeGf4u61O25kG;

    public TableCellViewItem()
    {
      TableCellViewItem.hpqiUgoeNdHL0hGrpV9u();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.RowSpan = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          default:
            this.ColSpan = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
            continue;
        }
      }
label_2:;
    }

    [DefaultValue(1)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public int RowSpan
    {
      get => this.\u003CRowSpan\u003Ek__BackingField;
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
              this.\u003CRowSpan\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
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

    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(1)]
    public int ColSpan
    {
      get => this.\u003CColSpan\u003Ek__BackingField;
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
              this.\u003CColSpan\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return parentViewItem is TableRowViewItem;
label_5:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => true;

    internal static void hpqiUgoeNdHL0hGrpV9u() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool J8kR54oePqXoBT4OBbEv() => TableCellViewItem.Wt3K9roeeGf4u61O25kG == null;

    internal static TableCellViewItem dBaTuboe1w97F455XETQ() => TableCellViewItem.Wt3K9roeeGf4u61O25kG;
  }
}
