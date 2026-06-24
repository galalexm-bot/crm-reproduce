// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.AssemblyModelsMetadataStatus
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Статус метаданных сборки с моделями</summary>
  public enum AssemblyModelsMetadataStatus
  {
    /// <summary>Сборки с этим статусом были запущены в приложении</summary>
    Runned,
    /// <summary>
    /// Сборки с этим статусом опубликованы и должны быть загружены при старте приложения
    /// </summary>
    Published,
    /// <summary>
    /// Сборки с этим статусом подготовлены для следующей загрузки
    /// </summary>
    Prepared,
    /// <summary>
    /// Сборки с этим статусом были запущены в приложении, но в момент последнего запуска были отключены
    /// </summary>
    RunnedDisable,
    /// <summary>Глобальный модуль</summary>
    GlobalModule,
    /// <summary>
    /// Сборки с этим статусом опубликованы, но никогда не будут загружены в приложение
    /// </summary>
    PublishedDisabled,
  }
}
