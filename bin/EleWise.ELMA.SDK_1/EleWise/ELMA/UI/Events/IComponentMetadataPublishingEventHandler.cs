// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Events.IComponentMetadataPublishingEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using EleWise.ELMA.Model;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.UI.Events
{
  /// <summary>Событие публикации компонента</summary>
  internal interface IComponentMetadataPublishingEventHandler : IEventHandler
  {
    /// <summary>Публикация завершена</summary>
    /// <param name="componentMetadataUid">Уникальный идентификатор заголовка компонента</param>
    /// <param name="result">Результат публикации</param>
    Task PublicationSuccess(Guid componentMetadataUid, UIMetadataPublishResult result);

    /// <summary>Публикация завершена с ошибкой</summary>
    /// <param name="componentMetadataUid">Уникальный идентификатор заголовка компонента</param>
    /// <param name="exception">Ошибка публикации</param>
    Task PublicationError(Guid componentMetadataUid, Exception exception);
  }
}
