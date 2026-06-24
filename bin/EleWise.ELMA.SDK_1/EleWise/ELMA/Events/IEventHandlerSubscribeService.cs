// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.IEventHandlerSubscribeService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Events
{
  /// <summary>Сервис для ручной подписки на события</summary>
  public interface IEventHandlerSubscribeService
  {
    /// <summary>Подписаться на событие</summary>
    /// <param name="observer">Обработчик события</param>
    /// <returns>Объект для отписки от событие</returns>
    IDisposable Subscribe(IEventHandler observer);
  }
}
