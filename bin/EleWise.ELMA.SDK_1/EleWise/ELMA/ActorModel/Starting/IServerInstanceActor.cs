// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Starting.IServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Runtime.Db;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Starting
{
  /// <summary>Актор экземпляра сервера ELMA (для запуска сервера)</summary>
  internal interface IServerInstanceActor : IServerPlacementActor, IActorWithGuidKey, IActor
  {
    /// <summary>Получить статус запуска сервера</summary>
    Task<DbConnectionStatus> GetStatus();

    /// <summary>Получить версию сервера</summary>
    Task<Version> GetVersion();

    /// <summary>Сервер запущен</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <param name="serverVersion">Версия сервера</param>
    /// <remarks>
    /// <para>В качестве <paramref name="serverUid" /> может прийти уникальный идентификатор текущего сервера. Это является прямым указанием серверу ELMA продолжить запуск.</para>
    /// <para>В параметр <paramref name="serverVersion" /> может быть передан null, это означает, что в кластере еще нет ни одного запущенного сервера ELMA, и текщий сервер является первым в кластере.</para>
    /// </remarks>
    Task ServerStarted(Guid serverUid, Version serverVersion);
  }
}
