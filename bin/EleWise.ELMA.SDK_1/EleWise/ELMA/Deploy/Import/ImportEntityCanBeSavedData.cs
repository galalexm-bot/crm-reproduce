// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ImportEntityCanBeSavedData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import
{
  public class ImportEntityCanBeSavedData
  {
    public ImportEntityCanBeSavedData(
      Dictionary<string, string> serviceData,
      List<DeployLogMessage> deployMessages)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) serviceData, z2jc63fLkugS1X8Q9N.tE1kD1vbB(95909607 + 343705423 ^ 439834402));
      Contract.ArgumentNotNull((object) deployMessages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107742928));
      this.ServiceData = serviceData;
      this.DeployMessages = deployMessages;
    }

    public Dictionary<string, string> ServiceData { get; private set; }

    public List<DeployLogMessage> DeployMessages { get; private set; }
  }
}
