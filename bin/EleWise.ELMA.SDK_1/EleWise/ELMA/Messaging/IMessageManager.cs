// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Messaging.IMessageManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Messaging
{
  /// <summary>Менеджер сообщений</summary>
  public interface IMessageManager
  {
    /// <summary>Создать объект сообщения (без отправки)</summary>
    /// <returns>Объект сообщения</returns>
    IMessage Create();

    /// <summary>Отправить сообщение по всем каналам</summary>
    /// <param name="message">Сообщение</param>
    void Send(IMessageBase message);

    /// <summary>Отправить сообщение по указанным каналам</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="channels">Каналы. Если не указаны - отправляется по всем доступным</param>
    void Send(IMessageBase message, IEnumerable<IMessageChannel> channels);

    /// <summary>Отправить сообщение по указанным каналам</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="channelNames">Имена каналов. Если не указаны - отправляется по всем доступным</param>
    void Send(IMessageBase message, IEnumerable<string> channelNames);

    /// <summary>Отправить сообщение по указанным каналам</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="channelUids">Идентификаторы каналов. Если не указаны - отправляется по всем доступным</param>
    void Send(IMessageBase message, IEnumerable<Guid> channelUids);

    /// <summary>Отложить отправку сообщения</summary>
    /// <param name="objectUid">Уникальный идентификатор типа объекта</param>
    /// <param name="objectId">Идентификатор объекта</param>
    /// <param name="actionUid">Уникальный идентификатор действия</param>
    void Delay(Guid objectUid, string objectId, Guid actionUid);

    /// <summary>Отложена ли отправка сообщения</summary>
    /// <param name="objectUid">Уникальный идентификатор типа объекта</param>
    /// <param name="objectId">Идентификатор объекта</param>
    /// <param name="actionUid">Уникальный идентификатор действия</param>
    bool IsDelayed(Guid objectUid, string objectId, Guid actionUid);

    /// <summary>Отменить отправку отложенного сообщения</summary>
    /// <param name="objectUid">Уникальный идентификатор типа объекта</param>
    /// <param name="objectId">Идентификатор объекта</param>
    /// <param name="recipientId">Получатель сообщения. Если null - используется текущий пользователь.</param>
    void CancelSend(Guid objectUid, string objectId, long? recipientId = null);

    /// <summary>Отменина ли отправка отложенного сообщения</summary>
    /// <param name="objectUid">Уникальный идентификатор типа объекта</param>
    /// <param name="objectId">Идентификатор объекта</param>
    /// <param name="recipientId">Получатель сообщения.</param>
    /// <returns>True, если отправка отменена.</returns>
    bool IsCancelledSend(Guid objectUid, string objectId, long recipientId);
  }
}
