// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ImportSuccessfullParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>Параметры операции выполняемой при удачном импорте</summary>
  public class ImportSuccessfullParameters : ImportExtensionBaseParameters
  {
    internal static ImportSuccessfullParameters zrYoR0E9IfPWAu09SZU0;

    /// <summary>Конструктор</summary>
    /// <param name="messages">Сообщения в результате проверки файла импорта</param>
    /// <param name="systemMessages">Тип системных сообщений для передачи между функцией импортом и визардом импорта</param>
    /// <param name="settings">Настройки кастомного импорта</param>
    public ImportSuccessfullParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      IImportSettings settings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages);
      this.ImportSettings = settings;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    internal static bool wrateFE9VGLghrRRqKdC() => ImportSuccessfullParameters.zrYoR0E9IfPWAu09SZU0 == null;

    internal static ImportSuccessfullParameters EkoQv7E9SEwHbBunioZG() => ImportSuccessfullParameters.zrYoR0E9IfPWAu09SZU0;
  }
}
