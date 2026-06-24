// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PreReadPacketsParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  public class PreReadPacketsParameters : ImportExtensionParameters
  {
    public PreReadPacketsParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      string serverFolderName,
      Dictionary<string, string> serviceData,
      ElmaStoreComponentManifest manifest,
      int importStep)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages, serverFolderName, serviceData, manifest, importStep);
    }
  }
}
