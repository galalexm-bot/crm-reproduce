using System;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Cache.ActorModel.Actors;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.ActorModel.Partitioning;

internal sealed class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
{
	private readonly ILogger logger;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly Guid localNodeId;

	internal static ServerStatusEventHandler YvB0NwfTo6UAcy5liguA;

	public ServerStatusEventHandler(IActorModelRuntime actorModelRuntime, IRuntimeApplication runtimeApplication, ILoggerFactory loggerFactory)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		nmwO3nfTG0bhFKoLY3md();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				localNodeId = runtimeApplication.ConnectionUid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				this.actorModelRuntime = actorModelRuntime;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				logger = (ILogger)pSatF5fTEeiXOr6nleu5(loggerFactory, typeof(ServerInstanceActor));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num = 2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void ServerStarted(Guid serverUid, Version serverVersion)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				actorModelRuntime.GetActor<IConsistentHashingCacheActor>(localNodeId).UpdateMembershipTable(serverUid.ToString(), added: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ServerStarting(Guid serverUid)
	{
	}

	public void ServerStoped(Guid serverUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				z74jh9fTfVrbxvtT0Tmu(actorModelRuntime.GetActor<IConsistentHashingCacheActor>(localNodeId), serverUid.ToString(), false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void nmwO3nfTG0bhFKoLY3md()
	{
		SingletonReader.PushGlobal();
	}

	internal static object pSatF5fTEeiXOr6nleu5(object P_0, Type type)
	{
		return ((ILoggerFactory)P_0).CreateLogger(type);
	}

	internal static bool ROPvKyfTbjNK7Q7ZcnaC()
	{
		return YvB0NwfTo6UAcy5liguA == null;
	}

	internal static ServerStatusEventHandler Mnr9yYfThFknbbXRmy7m()
	{
		return YvB0NwfTo6UAcy5liguA;
	}

	internal static object z74jh9fTfVrbxvtT0Tmu(object P_0, object P_1, bool added)
	{
		return ((IConsistentHashingCacheActor)P_0).UpdateMembershipTable((string)P_1, added);
	}
}
