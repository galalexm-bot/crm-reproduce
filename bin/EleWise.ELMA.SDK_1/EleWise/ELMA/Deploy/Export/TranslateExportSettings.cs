// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.TranslateExportSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EleWise.ELMA.Deploy.Export
{
  /// <summary>Настройки экспорта языковых переводов</summary>
  [Serializable]
  public class TranslateExportSettings
  {
    internal static TranslateExportSettings iRyVFlE5UejXutQG7YBJ;

    /// <summary>Ctor</summary>
    public TranslateExportSettings()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Translates = new List<CultureInfo>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Флаг переноса пакетов</summary>
    public bool ExportTranslate
    {
      get => this.\u003CExportTranslate\u003Ek__BackingField;
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
              this.\u003CExportTranslate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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

    /// <summary>Экспортируемые языковые пакеты</summary>
    public List<CultureInfo> Translates { get; set; }

    internal static bool YAwoXjE5sMlHQ2L36kNI() => TranslateExportSettings.iRyVFlE5UejXutQG7YBJ == null;

    internal static TranslateExportSettings qEnJ2TE5cpNA3uD07HZy() => TranslateExportSettings.iRyVFlE5UejXutQG7YBJ;
  }
}
