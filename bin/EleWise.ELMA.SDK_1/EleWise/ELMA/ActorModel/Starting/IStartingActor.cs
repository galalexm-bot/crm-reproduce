// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Starting.IStartingActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Starting
{
  /// <summary>Актор, управляющий запуском серверов кластера</summary>
  internal interface IStartingActor : IActorWithGuidKey, IActor
  {
    /// <summary>Начало запуска сервера</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    Task Start(Guid serverUid);

    /// <summary>Завершение запуска сервера</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <param name="serverVersion">Версия сервера</param>
    /// <returns></returns>
    Task Finish(Guid serverUid, Version serverVersion);

    /// <summary>
    /// Завершение запуска сервера с необходимостью перекомпиляции сценариев модели дизайнера
    /// </summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <returns></returns>
    Task ConfigurationScriptsRecompileRequired(Guid serverUid);
  }
}
