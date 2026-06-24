// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ColumnsLayoutViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Шаблон для формы с колонками</summary>
  [DisplayName(typeof (__Resources_ColumnsLayoutViewItem), "DisplayName")]
  [Serializable]
  public class ColumnsLayoutViewItem : RootViewItem, ILayoutViewItem
  {
    internal static ColumnsLayoutViewItem BTn4GYoOh2OPdZiRN81Y;

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return ColumnsLayoutViewItem.usD9cboOf8lMcXdVX4Pm((object) parentViewItem, (object) this);
label_5:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => childViewItem is ColumnViewItem;

    public ColumnsLayoutViewItem()
    {
      ColumnsLayoutViewItem.ydJdOEoOQuHe0b3L6LCb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool usD9cboOf8lMcXdVX4Pm([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static bool WVl0BDoOGtDJNguGaZfo() => ColumnsLayoutViewItem.BTn4GYoOh2OPdZiRN81Y == null;

    internal static ColumnsLayoutViewItem PATh5EoOE0MuOPcDVXEt() => ColumnsLayoutViewItem.BTn4GYoOh2OPdZiRN81Y;

    internal static void ydJdOEoOQuHe0b3L6LCb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
