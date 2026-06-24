// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.TestImportExtensionBaseParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Базовый класс для параметров в методах точки расширения <see cref="T:EleWise.ELMA.Deploy.Import.ExtensionPoints.IConfigImportExtension" /> (для этапа проверки)
  /// </summary>
  public abstract class TestImportExtensionBaseParameters
  {
    public TestImportExtensionBaseParameters(
      List<TestImportMessages> messages,
      List<DeploySystemMessage> systemMessages)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) messages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420520870));
      Contract.ArgumentNotNull((object) systemMessages, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-441065788 ^ -2092910478 ^ 1727122828));
      this.Messages = messages;
      this.SystemMessages = systemMessages;
    }

    /// <summary>Сообщения</summary>
    public List<TestImportMessages> Messages { get; private set; }

    /// <summary>Системные сообщения</summary>
    public List<DeploySystemMessage> SystemMessages { get; private set; }
  }
}
