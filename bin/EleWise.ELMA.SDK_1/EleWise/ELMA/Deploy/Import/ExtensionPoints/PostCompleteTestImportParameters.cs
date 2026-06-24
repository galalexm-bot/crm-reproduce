// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PostCompleteTestImportParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  public class PostCompleteTestImportParameters : TestImportExtensionParameters
  {
    private static PostCompleteTestImportParameters NP53nkElLOUTwaQokpW5;

    public PostCompleteTestImportParameters(
      List<TestImportMessages> messages,
      List<DeploySystemMessage> systemMessages,
      string serverFolderName,
      Dictionary<string, string> serviceData,
      ElmaStoreComponentManifest manifest,
      IConfigImportSettings settings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages, serverFolderName, serviceData, manifest);
      this.ImportSettings = (IImportSettings) settings;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
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

    internal static bool fiwmlsElUXlhXUs1TRnK() => PostCompleteTestImportParameters.NP53nkElLOUTwaQokpW5 == null;

    internal static PostCompleteTestImportParameters skOu6ZElsWVYWrv9Nw6f() => PostCompleteTestImportParameters.NP53nkElLOUTwaQokpW5;
  }
}
