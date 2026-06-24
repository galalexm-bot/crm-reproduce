// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.Publication.IFunctionMetadataPublishingEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Events.Publication
{
  /// <summary>Событие публикации функции</summary>
  internal interface IFunctionMetadataPublishingEventHandler : IEventHandler
  {
    /// <summary>Публикация завершена</summary>
    /// <param name="functionMetadataUid">Уникальный идентификатор заголовка функции</param>
    /// <param name="result">Результат публикации</param>
    Task Complete(Guid functionMetadataUid, UIMetadataPublishResult result);

    /// <summary>Публикация завершена с ошибкой</summary>
    /// <param name="functionMetadataUid">Уникальный идентификатор заголовка функции</param>
    /// <param name="exception">Ошибка публикации</param>
    Task Error(Guid functionMetadataUid, Exception exception);
  }
}
