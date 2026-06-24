// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.PostPublishParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Параметры операции выполняемой после публикации объектов
  /// </summary>
  public class PostPublishParameters : ImportExtensionBaseParameters
  {
    internal static PostPublishParameters jLSAv2ElIZdIVNUHVRHn;

    /// <summary>Конструктор</summary>
    /// <param name="messages">Сообщения в результате проверки файла импорта</param>
    /// <param name="systemMessages">Тип ситемных сообщений для передачи между функцией импортом и визардом импорта</param>
    /// <param name="serverFolderName">Серверная папка импорта конфигурации</param>
    /// <param name="serviceData">Сервисные данные</param>
    /// <param name="settings">Настройки</param>
    public PostPublishParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      string serverFolderName,
      Dictionary<string, string> serviceData,
      IImportSettings settings)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages);
      this.ImportSettings = settings;
      this.ServerFolderName = serverFolderName;
      this.ServiceData = serviceData;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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

    /// <summary>Заменяемые уникальные идентификаторы</summary>
    internal MergeReplace MergeReplace
    {
      get => this.\u003CMergeReplace\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CMergeReplace\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    /// <summary>Импортируемые метаданные</summary>
    internal List<IEntityMetadata> EntityMetadataList { get; set; }

    internal static bool y3bp5kElVdeSwiyoXCd9() => PostPublishParameters.jLSAv2ElIZdIVNUHVRHn == null;

    internal static PostPublishParameters rDsx88ElSya3HwpKp943() => PostPublishParameters.jLSAv2ElIZdIVNUHVRHn;
  }
}
