// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.RowLayoutViewItem
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
  /// <summary>Шаблон строки</summary>
  [Serializable]
  public class RowLayoutViewItem : RootViewItem
  {
    internal static RowLayoutViewItem BviZemoKx8yv0V9TUNXd;

    /// <summary>ctor</summary>
    public RowLayoutViewItem()
    {
      RowLayoutViewItem.CrlxF8oKyjwqOW5nncNb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Align = HorizontalAlign.Left;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.VerticalAlign = VerticalAlign.Top;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Выравнивание дочерних элементов по горизонтали</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(HorizontalAlign.Left)]
    public HorizontalAlign Align
    {
      get => this.\u003CAlign\u003Ek__BackingField;
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
              this.\u003CAlign\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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

    /// <summary>Выравнивание дочерних элементов по вертикали</summary>
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    [DefaultValue(VerticalAlign.Top)]
    public VerticalAlign VerticalAlign
    {
      get => this.\u003CVerticalAlign\u003Ek__BackingField;
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
              this.\u003CVerticalAlign\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
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
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => RowLayoutViewItem.siHlhUoKMXEtxhx7srWs((object) parentViewItem, (object) this);

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem) => true;

    internal static void CrlxF8oKyjwqOW5nncNb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool VBAf81oK0jRmmVYMrpQM() => RowLayoutViewItem.BviZemoKx8yv0V9TUNXd == null;

    internal static RowLayoutViewItem fONvIMoKmNZdrq5MocwM() => RowLayoutViewItem.BviZemoKx8yv0V9TUNXd;

    internal static bool siHlhUoKMXEtxhx7srWs([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);
  }
}
