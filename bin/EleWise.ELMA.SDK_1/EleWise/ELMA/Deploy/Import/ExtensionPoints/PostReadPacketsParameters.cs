// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PostReadPacketsParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  public class PostReadPacketsParameters : ImportExtensionParameters
  {
    /// <summary>Ctor</summary>
    /// <param name="messages">Сообщения</param>
    /// <param name="systemMessages">Системные сообщения</param>
    /// <param name="serverFolderName">Имя временной папки на стороне сервера</param>
    /// <param name="serviceData">Служебные данные</param>
    /// <param name="manifest">Манифест</param>
    /// <param name="importStep">Шаг импорта</param>
    /// <param name="headerIds">Идентификаторы заголовков метаданных</param>
    /// <param name="treeUid">Идентификатор дерева</param>
    public PostReadPacketsParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      string serverFolderName,
      Dictionary<string, string> serviceData,
      ElmaStoreComponentManifest manifest,
      int importStep,
      List<long> headerIds,
      string treeUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: reference to a compiler-generated field
      this.\u003CHeaderIds\u003Ek__BackingField = new List<long>();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages, serverFolderName, serviceData, manifest, importStep, treeUid);
      this.HeaderIds = headerIds;
    }

    /// <summary>Идентификаторы заголовков метаданных</summary>
    public List<long> HeaderIds { get; set; }
  }
}
