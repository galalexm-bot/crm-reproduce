// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ImportTestReadData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;
using System.Xml;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>
  /// Вспомогательный класс для передачи информации об импортируемых метаданных между ConfigurationImportExecutor и действиями по импорту сущностей (IEntityImportSaveActions).
  /// Создается и используется на этапе проверки импортируемого файла.
  /// </summary>
  public class ImportTestReadData
  {
    private static ImportTestReadData fWk0y3Emx4uN2j10rFEG;

    /// <summary>Ctor</summary>
    /// <param name="reader">Xml-ридер</param>
    /// <param name="mergeReplace">Список заменяемых Uid'ов</param>
    /// <param name="serviceData">Дополнительные данные</param>
    /// <param name="configImportSettings">Настройки импорта</param>
    public ImportTestReadData(
      XmlReader reader,
      MergeReplace mergeReplace,
      Dictionary<string, string> serviceData,
      IConfigImportSettings configImportSettings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Reader = reader;
      this.MergeMDReplace = mergeReplace;
      this.ServiceData = serviceData;
      this.ConfigImportSettings = configImportSettings;
    }

    /// <summary>Xml-ридер</summary>
    public XmlReader Reader
    {
      get => this.\u003CReader\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CReader\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
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

    /// <summary>Список заменяемых Uid'ов</summary>
    public MergeReplace MergeMDReplace
    {
      get => this.\u003CMergeMDReplace\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMergeMDReplace\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    /// <summary>Дополнительные данные</summary>
    public Dictionary<string, string> ServiceData { get; private set; }

    /// <summary>Настройки импорта</summary>
    public IConfigImportSettings ConfigImportSettings
    {
      get => this.\u003CConfigImportSettings\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CConfigImportSettings\u003Ek__BackingField = value;
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

    internal static bool FlgVUbEm01vlF3E0mP78() => ImportTestReadData.fWk0y3Emx4uN2j10rFEG == null;

    internal static ImportTestReadData T9N4Q1Emm3YHEEN1ANKb() => ImportTestReadData.fWk0y3Emx4uN2j10rFEG;
  }
}
