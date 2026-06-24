// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PostCompleteImportParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  public class PostCompleteImportParameters : ImportExtensionParameters
  {
    /// <summary>Ctor</summary>
    /// <param name="messages">Сообщения лога</param>
    /// <param name="systemMessages">Системные сообщения</param>
    /// <param name="serverFolderName">Имя папки импорта на сервере</param>
    /// <param name="serviceData">Дополнительные данные</param>
    /// <param name="manifest">Манифест компонента</param>
    /// <param name="importStep">Шаг импорта</param>
    /// <param name="treeUid">Идентификатор дерева</param>
    public PostCompleteImportParameters(
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
      base.\u002Ector(messages, systemMessages, serverFolderName, serviceData, manifest, importStep);
      this.TreeUid = treeUid;
    }

    /// <summary>
    /// Идентификатор дерева, для которого выполняется обработка
    /// </summary>
    public new string TreeUid { get; }
  }
}
