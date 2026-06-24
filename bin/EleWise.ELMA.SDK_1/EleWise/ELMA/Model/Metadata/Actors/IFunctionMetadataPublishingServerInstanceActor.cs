// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.IFunctionMetadataPublishingServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Actors
{
  /// <summary>
  /// Интерфейс актора экземпляра сервера (для публикации фунций)
  /// </summary>
  internal interface IFunctionMetadataPublishingServerInstanceActor : 
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    /// <summary>Публикация завершена</summary>
    /// <param name="functionMetadataUid">Уникальный идентификатор заголовка функции</param>
    /// <param name="result">Результат публикации</param>
    Task PublicationSuccess(Guid functionMetadataUid, UIMetadataPublishResult result);

    /// <summary>Публикация завершена с ошибкой</summary>
    /// <param name="functionMetadataUid">Уникальный идентификатор заголовка функции</param>
    /// <param name="exception">Ошибка публикации</param>
    Task PublicationError(Guid functionMetadataUid, Exception exception);
  }
}
