// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.IServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model.Metadata;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>Актор экземпляра сервера ELMA (для публикации)</summary>
  internal interface IServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
  {
    /// <summary>Запустить дельта-публикацию на узлах</summary>
    /// <param name="result">Результат публикации метаданных для сборок</param>
    /// <param name="softPublished">Уникальные идентификаторы метаданных мягкой публикации</param>
    /// <param name="deltaPublished">Уникальные идентификаторы метаданных дельта-публикации</param>
    /// <param name="restartNeeded">Метаданные требующие перезапуск</param>
    Task DeltaPublicationStart(
      MetadataAssemblyPublishResult result,
      Guid[] softPublished,
      Guid[] deltaPublished,
      AssemblyModelsMetadata restartNeeded);

    /// <summary>Окончание дельта-публикации на узлах</summary>
    Task DeltaPublicationComplete();

    /// <summary>Завершение публикации</summary>
    /// <param name="publicationToken">Токен публикации</param>
    Task PublicationComplete(Guid publicationToken);

    /// <summary>Ошибка публикации</summary>
    /// <param name="publicationToken">Токен публикации</param>
    /// <param name="exception">Ошибка</param>
    Task PublicationError(Guid publicationToken, Exception exception);

    /// <summary>Деактивировать Актор</summary>
    Task Deactivate();
  }
}
