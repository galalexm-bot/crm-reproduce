// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.IPublicationEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using System;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>События публикации</summary>
  internal interface IPublicationEventHandler : IEventHandler
  {
    /// <summary>Завершение публикации</summary>
    /// <param name="publicationToken">Токен публикации</param>
    void Complete(Guid publicationToken);

    /// <summary>Ошибка публикации</summary>
    /// <param name="publicationToken">Токен публикации</param>
    /// <param name="exception">Ошибка</param>
    void Error(Guid publicationToken, Exception exception);
  }
}
