// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TypeSettingsAdditionalViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Представление дополнительных настроек типа</summary>
  [Serializable]
  public sealed class TypeSettingsAdditionalViewItem : ViewItem
  {
    private static TypeSettingsAdditionalViewItem lt90DkoTQeyx4NyRQub8;

    /// <summary>Заблокированы настройки</summary>
    [DefaultValue(false)]
    public bool Disabled
    {
      get => this.\u003CDisabled\u003Ek__BackingField;
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
              this.\u003CDisabled\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
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

    /// <summary>Настройки опубликованы</summary>
    [DefaultValue(false)]
    public bool Published
    {
      get => this.\u003CPublished\u003Ek__BackingField;
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
              this.\u003CPublished\u003Ek__BackingField = value;
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
    public override bool IsChildValid(ViewItem childViewItem) => false;

    /// <inheritdoc />
    public override bool IsValid(ViewType viewType, ViewItem parentViewItem) => true;

    public TypeSettingsAdditionalViewItem()
    {
      TypeSettingsAdditionalViewItem.okdvIMoT8YlZWJ9xqWeQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool chLN95oTCZsXAN5DoVKe() => TypeSettingsAdditionalViewItem.lt90DkoTQeyx4NyRQub8 == null;

    internal static TypeSettingsAdditionalViewItem CXBu3noTvQRVpVk4aYkl() => TypeSettingsAdditionalViewItem.lt90DkoTQeyx4NyRQub8;

    internal static void okdvIMoT8YlZWJ9xqWeQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
