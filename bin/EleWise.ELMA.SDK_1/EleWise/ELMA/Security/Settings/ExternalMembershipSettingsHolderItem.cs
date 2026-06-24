// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Settings.ExternalMembershipSettingsHolderItem
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.Settings
{
  /// <summary>
  /// Класс для хранения сериализованных настроек экземпляра точки работы с учетными записями пользователей
  /// </summary>
  [Serializable]
  public class ExternalMembershipSettingsHolderItem
  {
    internal static ExternalMembershipSettingsHolderItem aKZiqLBY56R7ePwTVeBL;

    /// <summary>Uid экземпляра точки</summary>
    public string Key
    {
      get => this.\u003CKey\u003Ek__BackingField;
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
              this.\u003CKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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

    /// <summary>Настройки</summary>
    public string Value
    {
      get => this.\u003CValue\u003Ek__BackingField;
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
              this.\u003CValue\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

    public ExternalMembershipSettingsHolderItem()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QnZYkABYjh0CWCSaPCns() => ExternalMembershipSettingsHolderItem.aKZiqLBY56R7ePwTVeBL == null;

    internal static ExternalMembershipSettingsHolderItem THkCJWBYYS3mO8yIiQWL() => ExternalMembershipSettingsHolderItem.aKZiqLBY56R7ePwTVeBL;
  }
}
