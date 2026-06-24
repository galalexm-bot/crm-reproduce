// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ImportExtensionParameters
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
  public abstract class ImportExtensionParameters : ImportExtensionBaseParameters
  {
    internal static ImportExtensionParameters l0vfcoErZ9MKOcQH69vh;

    /// <summary>Ctor</summary>
    /// <param name="messages">Сообщения</param>
    /// <param name="systemMessages">Системные сообщения</param>
    /// <param name="serverFolderName">Имя временной папки на стороне сервера</param>
    /// <param name="serviceData">Служебные данные</param>
    /// <param name="manifest">Манифест</param>
    /// <param name="importStep">Шаг импорта</param>
    public ImportExtensionParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      string serverFolderName,
      Dictionary<string, string> serviceData,
      ElmaStoreComponentManifest manifest,
      int importStep)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(messages, systemMessages, serverFolderName, serviceData, manifest, importStep, (string) null);
    }

    /// <summary>Ctor</summary>
    /// <param name="messages">Сообщения</param>
    /// <param name="systemMessages">Системные сообщения</param>
    /// <param name="serverFolderName">Имя временной папки на стороне сервера</param>
    /// <param name="serviceData">Служебные данные</param>
    /// <param name="manifest">Манифест</param>
    /// <param name="importStep">Шаг импорта</param>
    /// <param name="treeUid">Идентификатор дерева</param>
    public ImportExtensionParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      string serverFolderName,
      Dictionary<string, string> serviceData,
      ElmaStoreComponentManifest manifest,
      int importStep,
      string treeUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages);
      Contract.ArgumentNotNull((object) serviceData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712195747));
      this.ServerFolderName = serverFolderName;
      this.ServiceData = serviceData;
      this.Manifest = manifest;
      this.ImportStep = importStep;
      this.TreeUid = treeUid;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
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

    /// <summary>Этап импорта</summary>
    public int ImportStep
    {
      get => this.\u003CImportStep\u003Ek__BackingField;
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
              this.\u003CImportStep\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор дерева импорта</summary>
    public string TreeUid
    {
      get => this.\u003CTreeUid\u003Ek__BackingField;
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
              this.\u003CTreeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    internal static bool dQ3wgQErum2jeabuY1Dg() => ImportExtensionParameters.l0vfcoErZ9MKOcQH69vh == null;

    internal static ImportExtensionParameters xDPN53ErIMvndELvtx44() => ImportExtensionParameters.l0vfcoErZ9MKOcQH69vh;
  }
}
