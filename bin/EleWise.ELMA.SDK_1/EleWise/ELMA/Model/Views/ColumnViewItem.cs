// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.ColumnViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views.Toolbox;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Колонка</summary>
  [EleWise.ELMA.Model.Attributes.DisplayName(typeof (__Resources_ColumnViewItem), "DisplayName")]
  [Serializable]
  public class ColumnViewItem : RootViewItem, ILayoutItemViewItem, IContainerViewItem
  {
    private static ColumnViewItem X2QGl7oOIUcULRq9HRp5;

    public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (parentViewItem != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return ColumnViewItem.vOFsT8oOi6W3XxAwKpAd((object) parentViewItem, (object) this);
label_5:
      return true;
    }

    public override bool IsChildValid(ViewItem childViewItem) => true;

    /// <summary>Ширина колонки</summary>
    [DefaultValue(ViewItemColumnSize.Auto)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public virtual ViewItemColumnSize Size
    {
      get => this.\u003CSize\u003Ek__BackingField;
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
              this.\u003CSize\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    public ColumnViewItem()
    {
      ColumnViewItem.qKIsxdoORbZSivcjxkIK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool vOFsT8oOi6W3XxAwKpAd([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static bool YTjIdCoOV9q3BVEK4ocL() => ColumnViewItem.X2QGl7oOIUcULRq9HRp5 == null;

    internal static ColumnViewItem Cvakj7oOSCb8gDTyvEDT() => ColumnViewItem.X2QGl7oOIUcULRq9HRp5;

    internal static void qKIsxdoORbZSivcjxkIK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    [Component(Order = 100)]
    private class ToolboxItem : CommonViewItemToolboxItem<ColumnViewItem>
    {
      private static object I5gSJrCfGk52wB5K4tLO;

      public ToolboxItem()
      {
        ColumnViewItem.ToolboxItem.cvv7ifCfQuHd5MktAnAs();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void cvv7ifCfQuHd5MktAnAs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool wctgpZCfEyRsExJSQRYd() => ColumnViewItem.ToolboxItem.I5gSJrCfGk52wB5K4tLO == null;

      internal static ColumnViewItem.ToolboxItem tRpVS2CffWhaNLheNkXO() => (ColumnViewItem.ToolboxItem) ColumnViewItem.ToolboxItem.I5gSJrCfGk52wB5K4tLO;
    }
  }
}
