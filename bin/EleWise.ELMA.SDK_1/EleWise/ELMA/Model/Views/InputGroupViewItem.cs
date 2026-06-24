// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.InputGroupViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Группа ввода</summary>
  [Serializable]
  public sealed class InputGroupViewItem : RootViewItem, IContainerViewItem
  {
    private static InputGroupViewItem G4KTXjoSz9gsWIKEYnUt;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => parentViewItem.IsChildValid((ViewItem) this);

    /// <inheritdoc />
    public override bool IsChildValid(ViewItem childViewItem)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 3:
            goto label_7;
          case 2:
            if (childViewItem is TreeSelectViewItem)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
              continue;
            }
            goto case 6;
          case 4:
            if (!(childViewItem is PropertyValueViewItem))
            {
              num = 2;
              continue;
            }
            goto label_7;
          case 5:
            if (!(childViewItem is ButtonViewItem))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 4 : 4;
              continue;
            }
            goto label_7;
          case 6:
            if (childViewItem is PopoverViewItem)
            {
              num = 3;
              continue;
            }
            goto label_6;
          default:
            goto label_6;
        }
      }
label_6:
      return childViewItem is BadgeViewItem;
label_7:
      return true;
    }

    public InputGroupViewItem()
    {
      InputGroupViewItem.WvvLHuoiWCcKFmPQ63gF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool SEek4eoiFOwsjX9lloRI() => InputGroupViewItem.G4KTXjoSz9gsWIKEYnUt == null;

    internal static InputGroupViewItem zKcRwfoiByfyGOFlTZCs() => InputGroupViewItem.G4KTXjoSz9gsWIKEYnUt;

    internal static void WvvLHuoiWCcKFmPQ63gF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
