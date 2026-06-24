// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.CustomSettingsValueContainer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Контейнер для кастомных настроек типа</summary>
  /// <remarks>Используется для сериализации списка настроек</remarks>
  [Component]
  public class CustomSettingsValueContainer : IXsiRoot
  {
    private static CustomSettingsValueContainer kcbBxmosafBhM4ptDuwt;

    /// <summary>Ctor</summary>
    public CustomSettingsValueContainer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Settings = new List<CustomSettingValue>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="settings">Список настроек</param>
    public CustomSettingsValueContainer(List<CustomSettingValue> settings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Settings = settings;
    }

    /// <summary>Список настроек</summary>
    public List<CustomSettingValue> Settings { get; set; }

    internal static bool YdXjjMosD2lI5ku6DP90() => CustomSettingsValueContainer.kcbBxmosafBhM4ptDuwt == null;

    internal static CustomSettingsValueContainer nfAHlMostHNCXI3WeZbv() => CustomSettingsValueContainer.kcbBxmosafBhM4ptDuwt;
  }
}
