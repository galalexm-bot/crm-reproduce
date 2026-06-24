// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.ReferenceOnTypeSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Types.Settings
{
  /// <summary>Настройки типа "Ссылка на тип"</summary>
  [Serializable]
  public class ReferenceOnTypeSettings : SimpleTypeSettings
  {
    private static ReferenceOnTypeSettings Q1lRI6oUsbP4tIWDkOma;

    /// <summary>Ctor</summary>
    public ReferenceOnTypeSettings()
    {
      ReferenceOnTypeSettings.Hpk02YosFaY6WVaXB4Cf();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Serialization info</param>
    /// <param name="context">Context</param>
    protected ReferenceOnTypeSettings(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Отображать неопубликованные типы</summary>
    [DefaultValue(false)]
    public bool ShowDirtyTypes
    {
      get => this.\u003CShowDirtyTypes\u003Ek__BackingField;
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
              this.\u003CShowDirtyTypes\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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

    /// <summary>
    /// Отображать только типы отображаемые в дереве справочников
    /// </summary>
    [DefaultValue(false)]
    public bool ShowInCatalogListTypes
    {
      get => this.\u003CShowInCatalogListTypes\u003Ek__BackingField;
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
              this.\u003CShowInCatalogListTypes\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
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

    internal static void Hpk02YosFaY6WVaXB4Cf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool XAmfEKoUcLhyPtbaJg0G() => ReferenceOnTypeSettings.Q1lRI6oUsbP4tIWDkOma == null;

    internal static ReferenceOnTypeSettings sUNsjGoUzlx7lJubH3uP() => ReferenceOnTypeSettings.Q1lRI6oUsbP4tIWDkOma;
  }
}
