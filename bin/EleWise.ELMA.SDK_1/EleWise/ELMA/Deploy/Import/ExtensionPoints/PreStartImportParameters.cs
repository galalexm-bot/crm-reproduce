// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PreStartImportParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>Тип параметра для действия перед началом импорта</summary>
  public class PreStartImportParameters : ImportExtensionBaseParameters
  {
    internal static PreStartImportParameters PGyZLMErCyUf2xhgilb3;

    public PreStartImportParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      IImportSettings importSettings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages);
      Contract.ArgumentNotNull((object) importSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1322779916));
      this.ImportSettings = importSettings;
    }

    /// <summary>Настройки импорта</summary>
    public IImportSettings ImportSettings
    {
      get => this.\u003CImportSettings\u003Ek__BackingField;
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
              this.\u003CImportSettings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

    internal static bool ukDyW1ErvwvJeIeJbsjf() => PreStartImportParameters.PGyZLMErCyUf2xhgilb3 == null;

    internal static PreStartImportParameters vLbNb1Er8LkhjHCgWBYZ() => PreStartImportParameters.PGyZLMErCyUf2xhgilb3;
  }
}
