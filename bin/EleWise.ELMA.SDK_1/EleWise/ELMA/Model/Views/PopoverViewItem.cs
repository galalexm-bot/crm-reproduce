// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.PopoverViewItem
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
  [Serializable]
  public class PopoverViewItem : RootViewItem
  {
    private static PopoverViewItem tIFb81oKQrh8TyZ5VniT;

    /// <summary>Ctor</summary>
    public PopoverViewItem()
    {
      PopoverViewItem.SjvXBeoK8YMSFc5aFGj6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            PopoverViewItem.Ky5hLNoKZf4cKMi9huKc((object) this, ViewItemComponentSize.Full);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override bool IsChildValid(ViewItem childViewItem) => true;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return PopoverViewItem.FeLdE4oKuxIGAiWCLqat((object) parentViewItem, (object) this);
label_5:
      return true;
    }

    /// <summary>Размер поповера</summary>
    [DefaultValue(ViewItemComponentSize.Full)]
    [EleWise.ELMA.Model.Transformations.ChangeableProperty]
    public virtual ViewItemComponentSize Size
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    internal static void SjvXBeoK8YMSFc5aFGj6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void Ky5hLNoKZf4cKMi9huKc([In] object obj0, ViewItemComponentSize value) => ((PopoverViewItem) obj0).Size = value;

    internal static bool pt6yIsoKCuy7SSg7hT0S() => PopoverViewItem.tIFb81oKQrh8TyZ5VniT == null;

    internal static PopoverViewItem m6ey4LoKvYmb9410dyS9() => PopoverViewItem.tIFb81oKQrh8TyZ5VniT;

    internal static bool FeLdE4oKuxIGAiWCLqat([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);
  }
}
