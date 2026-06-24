// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.IEntityMetadataDependencyService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Services
{
  /// <summary>Сервис сбора зависимостей для сущностей</summary>
  internal interface IEntityMetadataDependencyService
  {
    /// <summary>Собрать зависимости</summary>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="metadataItem">Элемент метаданных сущности</param>
    void CollectDependencies(EntityMetadata metadata, IMetadataItem metadataItem);
  }
}
