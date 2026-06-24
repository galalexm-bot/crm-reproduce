// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PreStartTestImportParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Параметры операции выполняемой перед началом тестирования
  /// </summary>
  public class PreStartTestImportParameters : TestImportExtensionParameters
  {
    private static PreStartTestImportParameters Oa7wPYElifpGKYiErjh6;

    /// <summary>Конструктор</summary>
    /// <param name="messages">Сообщения в результате проверки файла импорта</param>
    /// <param name="systemMessages">Тип ситемных сообщений для передачи между функцией импортом и визардом импорта</param>
    /// <param name="serverFolderName">Серверная папка импорта конфигурации</param>
    /// <param name="serviceData">Сервисные данные</param>
    /// <param name="manifest">Манифест</param>
    /// <param name="settings">Настройки</param>
    public PreStartTestImportParameters(
      List<TestImportMessages> messages,
      List<DeploySystemMessage> systemMessages,
      string serverFolderName,
      Dictionary<string, string> serviceData,
      ElmaStoreComponentManifest manifest,
      IImportSettings settings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages, serverFolderName, serviceData, manifest);
      this.ImportSettings = settings;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    internal static bool zx9dlGElR3imj0ZgNrAb() => PreStartTestImportParameters.Oa7wPYElifpGKYiErjh6 == null;

    internal static PreStartTestImportParameters dYFfq9ElqeGLtNHoHY58() => PreStartTestImportParameters.Oa7wPYElifpGKYiErjh6;
  }
}
