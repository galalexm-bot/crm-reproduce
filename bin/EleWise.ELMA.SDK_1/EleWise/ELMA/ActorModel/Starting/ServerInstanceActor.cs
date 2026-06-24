// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Starting.ServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Starting
{
  /// <inheritdoc />
  internal sealed class ServerInstanceActor : 
    Actor,
    IServerInstanceActor,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IRuntimeApplication runtimeApplication;
    private readonly IConnectionStatusContainer connectionStatusContainer;
    private readonly IServerStartEventHandler serverStartEventHandler;
    private readonly IServerStatusEventHandler serverStatusEventHandler;
    private readonly ILogger logger;
    private static ServerInstanceActor QhxYJkf3NwTrUQcEmAKx;

    /// <summary>ctor</summary>
    /// <param name="runtimeApplication">Cреда исполнения приложения</param>
    /// <param name="connectionStatusContainer">Интерфейс контейнера для текущего статуса сервера</param>
    /// <param name="serverStartEventHandler">Событие возможности запуска сервера</param>
    /// <param name="serverStatusEventHandler">События статуса сервера</param>
    public ServerInstanceActor(
      IRuntimeApplication runtimeApplication,
      IConnectionStatusContainer connectionStatusContainer,
      IServerStartEventHandler serverStartEventHandler,
      IServerStatusEventHandler serverStatusEventHandler)
    {
      ServerInstanceActor.nVxGBOf3aY8eO8PsBjXo();
      // ISSUE: type reference
      this.logger = (ILogger) ServerInstanceActor.T6P7q6f3ttvDhCkPJdQQ(ServerInstanceActor.aNjwtgf3DoXD7aKF3Djj(__typeref (ServerInstanceActor)));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.serverStartEventHandler = serverStartEventHandler;
            num = 4;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.runtimeApplication = runtimeApplication;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          case 4:
            this.serverStatusEventHandler = serverStatusEventHandler;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 2;
            continue;
          default:
            this.connectionStatusContainer = connectionStatusContainer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public Task<DbConnectionStatus> GetStatus()
    {
      this.logger.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345235526), (object) this.GetPrimaryKey<Guid>(), (object) this.connectionStatusContainer.Status));
      return Task.FromResult<DbConnectionStatus>(this.connectionStatusContainer.Status);
    }

    /// <inheritdoc />
    public Task<Version> GetVersion()
    {
      Version version = this.runtimeApplication.IsStarted ? VersionInfo.GetVersion<EleWise.ELMA.SR>() : (Version) null;
      this.logger.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1787095908), (object) this.GetPrimaryKey<Guid>(), (object) this.connectionStatusContainer.Status, (object) (version?.ToString() ?? z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289710452))));
      return Task.FromResult<Version>(version);
    }

    /// <inheritdoc />
    public Task ServerStarted(Guid serverUid, Version serverVersion)
    {
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 1:
            ServerInstanceActor.mIjQULf374vnmFAjofmV((object) this.serverStartEventHandler, (object) serverVersion);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 5 : 5;
            continue;
          case 2:
          case 5:
          case 9:
            if (ServerInstanceActor.I6W5D5f3xidrm7r8MYlr(serverUid, ServerInstanceActor.cejIjQf36cBqMm8kDWjV((object) this.runtimeApplication)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 4;
              continue;
            }
            goto case 3;
          case 3:
            if (ServerInstanceActor.i9DP0Sf34ZIH7kQKqA5M((object) this.connectionStatusContainer).HasFlag((Enum) DbConnectionStatus.Started))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 6:
            if (!ServerInstanceActor.eeJNUQf3ACFmpyQHVdP6((object) serverVersion, (object) null))
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 7:
            if (ServerInstanceActor.i9DP0Sf34ZIH7kQKqA5M((object) this.connectionStatusContainer) != DbConnectionStatus.Unknown)
            {
              num = 9;
              continue;
            }
            goto case 11;
          case 8:
            this.logger.Debug(ServerInstanceActor.DhHujnf3woxNWkxZ1TTU((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1872275253 >> 6 ^ -29045171), (object) this.GetPrimaryKey<Guid>(), (object) serverUid, (object) serverVersion));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 7 : 4;
            continue;
          case 10:
            goto label_10;
          case 11:
            if (!ServerInstanceActor.LZWJM5f3HsnIrgOOuKX4(serverUid, ServerInstanceActor.cejIjQf36cBqMm8kDWjV((object) this.runtimeApplication)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 6 : 5;
              continue;
            }
            goto case 1;
          default:
            ServerInstanceActor.DeBafNf30E6P52wTeKYU((object) this.serverStatusEventHandler, serverUid, (object) serverVersion);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 10 : 6;
            continue;
        }
      }
label_10:
      return (Task) ServerInstanceActor.UePNvKf3mKD1e3BSFBQY();
    }

    internal static void nVxGBOf3aY8eO8PsBjXo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type aNjwtgf3DoXD7aKF3Djj([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object T6P7q6f3ttvDhCkPJdQQ(Type componentType) => (object) Logger.GetLogger(componentType);

    internal static bool VsIaHuf33hx29QHTT0wa() => ServerInstanceActor.QhxYJkf3NwTrUQcEmAKx == null;

    internal static ServerInstanceActor lX2hJZf3p3bwTk2uUEY9() => ServerInstanceActor.QhxYJkf3NwTrUQcEmAKx;

    internal static object DhHujnf3woxNWkxZ1TTU(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static DbConnectionStatus i9DP0Sf34ZIH7kQKqA5M([In] object obj0) => ((IConnectionStatusContainer) obj0).Status;

    internal static Guid cejIjQf36cBqMm8kDWjV([In] object obj0) => ((IRuntimeApplication) obj0).ConnectionUid;

    internal static bool LZWJM5f3HsnIrgOOuKX4([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool eeJNUQf3ACFmpyQHVdP6([In] object obj0, [In] object obj1) => (Version) obj0 != (Version) obj1;

    internal static void mIjQULf374vnmFAjofmV([In] object obj0, [In] object obj1) => ((IServerStartEventHandler) obj0).StartServer((Version) obj1);

    internal static bool I6W5D5f3xidrm7r8MYlr([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void DeBafNf30E6P52wTeKYU([In] object obj0, Guid serverUid, [In] object obj2) => ((IServerStatusEventHandler) obj0).ServerStarted(serverUid, (Version) obj2);

    internal static object UePNvKf3mKD1e3BSFBQY() => (object) Task.CompletedTask;
  }
}
