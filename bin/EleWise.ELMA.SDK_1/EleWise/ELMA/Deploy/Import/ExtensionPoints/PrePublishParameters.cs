// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PrePublishParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Параметры операции выполняемой перед публикации объектов
  /// </summary>
  public sealed class PrePublishParameters : ImportExtensionBaseParameters
  {
    private static PrePublishParameters oIB3F1E9ib1qviJx9sVX;

    /// <summary>Конструктор</summary>
    /// <param name="messages">Сообщения в результате проверки файла импорта</param>
    /// <param name="systemMessages">Тип ситемных сообщений для передачи между функцией импортом и визардом импорта</param>
    /// <param name="serviceData">Сервисные данные</param>
    /// <param name="settings">Настройки</param>
    public PrePublishParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      Dictionary<string, string> serviceData,
      IImportSettings settings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages);
      this.ImportSettings = settings;
      this.ServiceData = (IDictionary<string, string>) serviceData;
    }

    /// <summary>Настройки</summary>
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

    /// <summary>Служебные данные</summary>
    public IDictionary<string, string> ServiceData { get; private set; }

    internal static bool U3ABg7E9RAXc0V330oS6() => PrePublishParameters.oIB3F1E9ib1qviJx9sVX == null;

    internal static PrePublishParameters d4EvvuE9quQqh5PHgyjj() => PrePublishParameters.oIB3F1E9ib1qviJx9sVX;
  }
}
