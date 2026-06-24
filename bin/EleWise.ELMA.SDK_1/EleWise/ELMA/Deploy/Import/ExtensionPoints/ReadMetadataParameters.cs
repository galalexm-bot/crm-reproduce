// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ReadMetadataParameters
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>Параметры операции выполняемой при чтении метаданных</summary>
  public sealed class ReadMetadataParameters : ImportExtensionBaseParameters
  {
    private readonly Action<TestImportMessages> testMessagesAdd;
    internal static ReadMetadataParameters w5NIa4ElKs0NNc71OP2H;

    /// <summary>Конструктор</summary>
    /// <param name="messages">Сообщения в результате проверки файла импорта</param>
    /// <param name="systemMessages">Тип ситемных сообщений для передачи между функцией импортом и визардом импорта</param>
    /// <param name="importSettings">Настройки импорта</param>
    /// <param name="metadata">Метаданные</param>
    /// <param name="isSystemMetadata">Системные метаданные</param>
    /// <param name="attributes">Атрибуты</param>
    /// <param name="treeUid">Идентификатор дерева импорта</param>
    /// <param name="mergeReplace">Описание списков заменяемых uid'ов</param>
    /// <param name="serviceData">Сервисные данные импортируемой конфигурации</param>
    /// <param name="headers">Идентификаторы заголовков</param>
    /// <param name="metadataNotIsUnique">Список Uid'ов метаданных, которые помечены как неучаствующие в экспорте-импорте (!IsUnique)</param>
    /// <param name="manifestExecuteMetadata">Манифест для BPM App</param>
    /// <param name="serverFolderName">Временная папка с распакованным пакетом на сервере</param>
    /// <param name="testMessagesAdd">Метод добавления сообщения проверки</param>
    internal ReadMetadataParameters(
      List<DeployLogMessage> messages,
      List<DeploySystemMessage> systemMessages,
      IImportSettings importSettings,
      IMetadata metadata,
      bool isSystemMetadata,
      IDictionary<string, ICollection<string>> attributes,
      string treeUid,
      MergeReplace mergeReplace,
      IDictionary<string, string> serviceData,
      ICollection<long> headers,
      ISet<Guid> metadataNotIsUnique,
      BPMAppManifest manifestExecuteMetadata,
      string serverFolderName,
      Action<TestImportMessages> testMessagesAdd)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(messages, systemMessages);
      this.testMessagesAdd = testMessagesAdd;
      this.ImportSettings = importSettings;
      this.Metadata = metadata;
      this.IsSystemMetadata = isSystemMetadata;
      this.Attributes = attributes ?? (IDictionary<string, ICollection<string>>) new Dictionary<string, ICollection<string>>();
      this.TreeUid = treeUid;
      this.MergeReplace = mergeReplace;
      this.ServiceData = serviceData;
      this.Headers = headers;
      this.MetadataNotIsUnique = metadataNotIsUnique;
      this.ManifestExecuteMetadata = manifestExecuteMetadata;
      this.ServerFolderName = serverFolderName;
    }

    /// <summary>Настройки импорта</summary>
    public IImportSettings ImportSettings { get; }

    /// <summary>Метаданные</summary>
    public IMetadata Metadata { get; }

    /// <summary>Системные метаданные</summary>
    public bool IsSystemMetadata { get; }

    /// <summary>Атрибуты</summary>
    public IDictionary<string, ICollection<string>> Attributes { get; }

    /// <summary>Идентификатор дерева импорта</summary>
    public string TreeUid { get; }

    /// <summary>Описание списков заменяемых uid'ов</summary>
    public MergeReplace MergeReplace { get; }

    /// <summary>Сервисные данные импортируемой конфигурации</summary>
    public IDictionary<string, string> ServiceData { get; }

    /// <summary>Идентификаторы заголовков</summary>
    public ICollection<long> Headers { get; }

    /// <summary>
    /// Список Uid'ов метаданных, которые помечены как неучаствующие в экспорте-импорте (!IsUnique)
    /// </summary>
    public ISet<Guid> MetadataNotIsUnique { get; }

    /// <summary>Манифест для BPM App</summary>
    public BPMAppManifest ManifestExecuteMetadata { get; }

    /// <summary>
    /// Имя временной папки на стороне сервера, куда распаковывается содержимое файла компонента или импорта-экспорта
    /// </summary>
    public string ServerFolderName { get; }

    /// <summary>Добавить сообщение проверки</summary>
    /// <param name="message">Сообщение</param>
    public void TestMessagesAdd(TestImportMessages message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.testMessagesAdd(message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool c3KjPgElXdxpEFbFRvC6() => ReadMetadataParameters.w5NIa4ElKs0NNc71OP2H == null;

    internal static ReadMetadataParameters S2d7a2ElTbOKyos3ie8b() => ReadMetadataParameters.w5NIa4ElKs0NNc71OP2H;
  }
}
