// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ImportTestReadResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import
{
  public class ImportTestReadResult
  {
    public ImportTestReadResult(
      List<TestImportMessages> messages,
      List<DeploySystemMessage> systemMessages)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) messages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712195275));
      Contract.ArgumentNotNull((object) systemMessages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902098241));
      this.Messages = messages;
      this.SystemMessages = systemMessages;
    }

    public List<TestImportMessages> Messages { get; private set; }

    public List<DeploySystemMessage> SystemMessages { get; private set; }
  }
}
