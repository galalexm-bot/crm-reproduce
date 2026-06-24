// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.DynamicSlotViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Динамический контейнер</summary>
  [DisplayName(typeof (__Resources_DynamicSlotViewItem), "DisplayName")]
  [Serializable]
  public class DynamicSlotViewItem : SlotViewItem
  {
    private static DynamicSlotViewItem zneZQAoqjUENeaPgjMkN;

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem)
    {
      int num = 2;
      while (true)
      {
        RootViewItem rootViewItem;
        switch (num)
        {
          case 1:
            RootViewItem parent = this.Parent;
            if (parent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 4;
              continue;
            }
            rootViewItem = parent.Parent;
            break;
          case 2:
            if (this.Parent is DynamicListViewItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 3:
            goto label_4;
          case 4:
            rootViewItem = (RootViewItem) null;
            break;
          default:
            if (!(childViewItem is ButtonViewItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 0;
              continue;
            }
            goto label_5;
        }
        if (rootViewItem is ButtonViewItem)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
        else
          goto label_6;
      }
label_4:
      return childViewItem is ComponentViewItem;
label_5:
      return true;
label_6:
      return true;
    }

    public DynamicSlotViewItem()
    {
      DynamicSlotViewItem.XwFCLjoqUNb43iOK0jaj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool WuKkwNoqYRRZ0uPvW4VT() => DynamicSlotViewItem.zneZQAoqjUENeaPgjMkN == null;

    internal static DynamicSlotViewItem lsQbnCoqLTFmyFi64XCB() => DynamicSlotViewItem.zneZQAoqjUENeaPgjMkN;

    internal static void XwFCLjoqUNb43iOK0jaj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
