// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.FullscreenViewItem
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
  /// <summary>На весь экран</summary>
  [Serializable]
  public sealed class FullscreenViewItem : RootViewItem
  {
    private static FullscreenViewItem QUDUX3oS4A5B2WnVRaCn;

    /// <summary>
    /// Отображается на весь экран.
    /// Используется для рефлексии при генерации вычисляемого значения
    /// </summary>
    [DefaultValue(false)]
    private bool Fullscreen
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
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

    /// <summary>Удалять контент при закрытии</summary>
    [DefaultValue(false)]
    public bool DestroyOnClose
    {
      get => this.\u003CDestroyOnClose\u003Ek__BackingField;
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
              this.\u003CDestroyOnClose\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
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
    public override bool IsChildValid(ViewItem childViewItem) => true;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => FullscreenViewItem.hmPfGLoSAv4uoSimaMYl((object) parentViewItem, (object) this);

    public FullscreenViewItem()
    {
      FullscreenViewItem.UbaTRGoS7N7Ju6hZG2KO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Vq633EoS6Gv71a8YXhHe() => FullscreenViewItem.QUDUX3oS4A5B2WnVRaCn == null;

    internal static FullscreenViewItem rcIIyFoSHy9sgA1I2bdf() => FullscreenViewItem.QUDUX3oS4A5B2WnVRaCn;

    internal static bool hmPfGLoSAv4uoSimaMYl([In] object obj0, [In] object obj1) => ((ViewItem) obj0).IsChildValid((ViewItem) obj1);

    internal static void UbaTRGoS7N7Ju6hZG2KO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
