// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.Publication.IDataClassMetadataPublishingEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Events.Publication
{
  /// <summary>Событие публикации DataClass-а</summary>
  internal interface IDataClassMetadataPublishingEventHandler : IEventHandler
  {
    /// <summary>Публикация завершена</summary>
    /// <param name="publicationToken">Токен публикации</param>
    /// <param name="result">Результат публикации</param>
    Task Complete(Guid publicationToken, UIMetadataPublishResult result);

    /// <summary>Публикация завершена с ошибкой</summary>
    /// <param name="publicationToken">Токен публикации</param>
    /// <param name="exception">Ошибка публикации</param>
    Task Error(Guid publicationToken, Exception exception);
  }
}
