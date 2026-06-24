using System;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ActorModel.Starting;

internal sealed class ServerInstanceActor : Actor, IServerInstanceActor, IServerPlacementActor, IActorWithGuidKey, IActor
{
	private readonly IRuntimeApplication runtimeApplication;

	private readonly IConnectionStatusContainer connectionStatusContainer;

	private readonly IServerStartEventHandler serverStartEventHandler;

	private readonly IServerStatusEventHandler serverStatusEventHandler;

	private readonly ILogger logger;

	private static ServerInstanceActor QhxYJkf3NwTrUQcEmAKx;

	public ServerInstanceActor(IRuntimeApplication runtimeApplication, IConnectionStatusContainer connectionStatusContainer, IServerStartEventHandler serverStartEventHandler, IServerStatusEventHandler serverStatusEventHandler)
	{
		//Discarded unreachable code: IL_0034, IL_0039
		nVxGBOf3aY8eO8PsBjXo();
		logger = (ILogger)T6P7q6f3ttvDhCkPJdQQ(aNjwtgf3DoXD7aKF3Djj(typeof(ServerInstanceActor).TypeHandle));
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 3:
				this.runtimeApplication = runtimeApplication;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num = 0;
				}
				break;
			default:
				this.connectionStatusContainer = connectionStatusContainer;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			case 1:
				this.serverStartEventHandler = serverStartEventHandler;
				num = 4;
				break;
			case 4:
				this.serverStatusEventHandler = serverStatusEventHandler;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public Task<DbConnectionStatus> GetStatus()
	{
		logger.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345235526), GetPrimaryKey<Guid>(), connectionStatusContainer.Status));
		return Task.FromResult(connectionStatusContainer.Status);
	}

	public Task<Version> GetVersion()
	{
		Version version = (runtimeApplication.IsStarted ? VersionInfo.GetVersion<SR>() : null);
		logger.Debug(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A84EB64), GetPrimaryKey<Guid>(), connectionStatusContainer.Status, version?.ToString() ?? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289710452)));
		return Task.FromResult(version);
	}

	public Task ServerStarted(Guid serverUid, Version serverVersion)
	{
		//Discarded unreachable code: IL_0101, IL_0110, IL_0167, IL_0176, IL_0186, IL_0195
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 5:
			case 9:
				if (I6W5D5f3xidrm7r8MYlr(serverUid, cejIjQf36cBqMm8kDWjV(runtimeApplication)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 4;
					}
					continue;
				}
				goto case 3;
			case 6:
				if (!eeJNUQf3ACFmpyQHVdP6(serverVersion, null))
				{
					num2 = 2;
					continue;
				}
				break;
			case 3:
				if (i9DP0Sf34ZIH7kQKqA5M(connectionStatusContainer).HasFlag(DbConnectionStatus.Started))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 10;
			case 11:
				if (!LZWJM5f3HsnIrgOOuKX4(serverUid, cejIjQf36cBqMm8kDWjV(runtimeApplication)))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 5;
					}
					continue;
				}
				break;
			case 10:
				return (Task)UePNvKf3mKD1e3BSFBQY();
			case 7:
				if (i9DP0Sf34ZIH7kQKqA5M(connectionStatusContainer) != 0)
				{
					num2 = 9;
					continue;
				}
				goto case 11;
			default:
				DeBafNf30E6P52wTeKYU(serverStatusEventHandler, serverUid, serverVersion);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 6;
				}
				continue;
			case 8:
				logger.Debug(DhHujnf3woxNWkxZ1TTU(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29045171), GetPrimaryKey<Guid>(), serverUid, serverVersion));
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 4;
				}
				continue;
			case 1:
				break;
			}
			mIjQULf374vnmFAjofmV(serverStartEventHandler, serverVersion);
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
			{
				num2 = 5;
			}
		}
	}

	internal static void nVxGBOf3aY8eO8PsBjXo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type aNjwtgf3DoXD7aKF3Djj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object T6P7q6f3ttvDhCkPJdQQ(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static bool VsIaHuf33hx29QHTT0wa()
	{
		return QhxYJkf3NwTrUQcEmAKx == null;
	}

	internal static ServerInstanceActor lX2hJZf3p3bwTk2uUEY9()
	{
		return QhxYJkf3NwTrUQcEmAKx;
	}

	internal static object DhHujnf3woxNWkxZ1TTU(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static DbConnectionStatus i9DP0Sf34ZIH7kQKqA5M(object P_0)
	{
		return ((IConnectionStatusContainer)P_0).Status;
	}

	internal static Guid cejIjQf36cBqMm8kDWjV(object P_0)
	{
		return ((IRuntimeApplication)P_0).ConnectionUid;
	}

	internal static bool LZWJM5f3HsnIrgOOuKX4(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool eeJNUQf3ACFmpyQHVdP6(object P_0, object P_1)
	{
		return (Version)P_0 != (Version)P_1;
	}

	internal static void mIjQULf374vnmFAjofmV(object P_0, object P_1)
	{
		((IServerStartEventHandler)P_0).StartServer((Version)P_1);
	}

	internal static bool I6W5D5f3xidrm7r8MYlr(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void DeBafNf30E6P52wTeKYU(object P_0, Guid serverUid, object P_2)
	{
		((IServerStatusEventHandler)P_0).ServerStarted(serverUid, (Version)P_2);
	}

	internal static object UePNvKf3mKD1e3BSFBQY()
	{
		return Task.CompletedTask;
	}
}
