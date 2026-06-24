// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.TestImportExtensionParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  public abstract class TestImportExtensionParameters : TestImportExtensionBaseParameters
  {
    private static TestImportExtensionParameters muyhGDElcyjRtOwGgTWy;

    public TestImportExtensionParameters(
      List<TestImportMessages> messages,
      List<DeploySystemMessage> systemMessages,
      string serverFolderName,
      Dictionary<string, string> serviceData,
      ElmaStoreComponentManifest manifest)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages);
      Contract.ArgumentNotNull((object) serverFolderName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647669026));
      Contract.ArgumentNotNull((object) serviceData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1033719030 - 2012070891 ^ -978640865));
      this.ServerFolderName = serverFolderName;
      this.ServiceData = serviceData;
      this.Manifest = manifest;
    }

    /// <summary>
    /// Имя временной папки на стороне сервера, куда распаковывается содержимое файла компонента или импорта-экспорта
    /// </summary>
    public string ServerFolderName
    {
      get => this.\u003CServerFolderName\u003Ek__BackingField;
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
              this.\u003CServerFolderName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
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

    /// <summary>Служебные данные</summary>
    public Dictionary<string, string> ServiceData { get; private set; }

    /// <summary>Манифест компонента (если это компонент ELMA Store)</summary>
    public ElmaStoreComponentManifest Manifest
    {
      get => this.\u003CManifest\u003Ek__BackingField;
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
              this.\u003CManifest\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
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

    internal static bool pNNR3AElzx2N01nlPxij() => TestImportExtensionParameters.muyhGDElcyjRtOwGgTWy == null;

    internal static TestImportExtensionParameters BcrdjCErFQf6SiECItpF() => TestImportExtensionParameters.muyhGDElcyjRtOwGgTWy;
  }
}
