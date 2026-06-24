// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Starting.IServerStatusEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events;
using System;

namespace EleWise.ELMA.ActorModel.Starting
{
  /// <summary>События статуса сервера</summary>
  public interface IServerStatusEventHandler : IEventHandler
  {
    /// <summary>Сервер запускается</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <remarks>Реализация метода не должна задерживать поток вызова!</remarks>
    void ServerStarting(Guid serverUid);

    /// <summary>Сервер запущен</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <param name="serverVersion">Версия сервера</param>
    /// <remarks>Реализация метода не должна задерживать поток вызова!</remarks>
    void ServerStarted(Guid serverUid, Version serverVersion);

    /// <summary>Сервер остановлен</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <remarks>Реализация метода не должна задерживать поток вызова!</remarks>
    void ServerStoped(Guid serverUid);
  }
}
