// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Views.TypeSettingsViewItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;

namespace EleWise.ELMA.Model.Views
{
  /// <summary>Представление настроек типа</summary>
  [Serializable]
  public class TypeSettingsViewItem : ViewItem
  {
    internal static TypeSettingsViewItem LsweOPoTSPWK6tRJUHte;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
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

    public TypeSettingsViewItem()
    {
      TypeSettingsViewItem.MU6SxCoTqhea4s0lL4cc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool WdVcxqoTiPFlN3Ijlbdd() => TypeSettingsViewItem.LsweOPoTSPWK6tRJUHte == null;

    internal static TypeSettingsViewItem PRp0JOoTRbVI5xyCJuRx() => TypeSettingsViewItem.LsweOPoTSPWK6tRJUHte;

    internal static void MU6SxCoTqhea4s0lL4cc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
