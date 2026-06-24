// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.Partitioning.ServerStatusEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Cache.ActorModel.Actors;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache.ActorModel.Partitioning
{
  /// <summary>
  /// Уведомляет подписчиков об изменениях в конфигурации распределенного кэша.
  /// </summary>
  internal sealed class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
  {
    private readonly ILogger logger;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly Guid localNodeId;
    internal static ServerStatusEventHandler YvB0NwfTo6UAcy5liguA;

    /// <summary>Инициализирует экземпляр класса.</summary>
    /// <param name="actorModelRuntime">Интерфейс Модели Акторов.</param>
    /// <param name="runtimeApplication">Интерфейс для работы со средой исполнения приложения.</param>
    /// <param name="loggerFactory">Фабрика для создания логгеров.</param>
    public ServerStatusEventHandler(
      IActorModelRuntime actorModelRuntime,
      IRuntimeApplication runtimeApplication,
      ILoggerFactory loggerFactory)
    {
      ServerStatusEventHandler.nmwO3nfTG0bhFKoLY3md();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.logger = (ILogger) ServerStatusEventHandler.pSatF5fTEeiXOr6nleu5((object) loggerFactory, typeof (ServerInstanceActor));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 1 : 2;
            continue;
          case 2:
            this.localNodeId = runtimeApplication.ConnectionUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
            continue;
          case 3:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <inheritdoc />
    public void ServerStarted(Guid serverUid, Version serverVersion)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.actorModelRuntime.GetActor<IConsistentHashingCacheActor>(this.localNodeId).UpdateMembershipTable(serverUid.ToString(), true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public void ServerStarting(Guid serverUid)
    {
    }

    /// <inheritdoc />
    public void ServerStoped(Guid serverUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ServerStatusEventHandler.z74jh9fTfVrbxvtT0Tmu((object) this.actorModelRuntime.GetActor<IConsistentHashingCacheActor>(this.localNodeId), (object) serverUid.ToString(), false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void nmwO3nfTG0bhFKoLY3md() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object pSatF5fTEeiXOr6nleu5([In] object obj0, Type type) => (object) ((ILoggerFactory) obj0).CreateLogger(type);

    internal static bool ROPvKyfTbjNK7Q7ZcnaC() => ServerStatusEventHandler.YvB0NwfTo6UAcy5liguA == null;

    internal static ServerStatusEventHandler Mnr9yYfThFknbbXRmy7m() => ServerStatusEventHandler.YvB0NwfTo6UAcy5liguA;

    internal static object z74jh9fTfVrbxvtT0Tmu([In] object obj0, [In] object obj1, bool added) => (object) ((IConsistentHashingCacheActor) obj0).UpdateMembershipTable((string) obj1, added);
  }
}
