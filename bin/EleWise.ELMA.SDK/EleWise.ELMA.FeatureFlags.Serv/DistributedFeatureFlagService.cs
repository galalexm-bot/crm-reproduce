using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FeatureFlags.Services;

[Service]
internal sealed class DistributedFeatureFlagService : IDistributedFeatureFlagService
{
	[Component]
	private sealed class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
	{
		private readonly object logger;

		private readonly object distributedFeatureFlagService;

		internal static object JcM1Dtv9s2EswPjYcg0M;

		public ServerStatusEventHandler(DistributedFeatureFlagService distributedFeatureFlagService)
		{
			//Discarded unreachable code: IL_0044, IL_0049
			CN7nC7vdF6UyIlBVTqfG();
			logger = atHtkovdW5fp4CcqhbkE(EvvAx1vdB5bNR15AesOK(typeof(DistributedFeatureFlagService).TypeHandle));
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				this.distributedFeatureFlagService = distributedFeatureFlagService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num = 1;
				}
			}
		}

		public void ServerStarted(Guid serverUid, Version serverVersion)
		{
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
					((DistributedFeatureFlagService)distributedFeatureFlagService).serversFeatureFlags.Remove(serverUid);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				case 1:
					((ILogger)logger).DebugFormat((string)Oc1E0IvdoOycIncn4MfF(0x34185E55 ^ 0x341D88E5), serverUid);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void CN7nC7vdF6UyIlBVTqfG()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static Type EvvAx1vdB5bNR15AesOK(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static object atHtkovdW5fp4CcqhbkE(Type componentType)
		{
			return Logger.GetLogger(componentType);
		}

		internal static bool TNXfoCv9cYPVAjIA8mFy()
		{
			return JcM1Dtv9s2EswPjYcg0M == null;
		}

		internal static ServerStatusEventHandler EPpPdTv9zdskqu0vECmp()
		{
			return (ServerStatusEventHandler)JcM1Dtv9s2EswPjYcg0M;
		}

		internal static object Oc1E0IvdoOycIncn4MfF(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}
	}

	private readonly ILogger logger;

	private readonly IDictionary<Guid, IDictionary<string, bool?>> serversFeatureFlags;

	private readonly IActorModelRuntime actorModelRuntime;

	private static DistributedFeatureFlagService dM4vHyGWTct5SBNHA2Y9;

	public IEnumerable<Guid> AvailableServers => serversFeatureFlags.Keys;

	public DistributedFeatureFlagService(IActorModelRuntime actorModelRuntime)
	{
		//Discarded unreachable code: IL_0054, IL_0059
		P8r5uYGWOTBIR5D8iwsr();
		logger = (ILogger)CGQyGGGW25JqEEjVDeO0(typeof(DistributedFeatureFlagService));
		serversFeatureFlags = new Dictionary<Guid, IDictionary<string, bool?>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.actorModelRuntime = actorModelRuntime;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
			{
				num = 1;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CEnabled_003Ed__6))]
	public Task<bool> Enabled(Guid serverUid, string name, bool defaultEnabled)
	{
		_003CEnabled_003Ed__6 stateMachine = default(_003CEnabled_003Ed__6);
		stateMachine._003C_003E4__this = this;
		stateMachine.serverUid = serverUid;
		stateMachine.name = name;
		stateMachine.defaultEnabled = defaultEnabled;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal Task UpdateCache(Guid serverUid, IDictionary<string, bool?> featureFlags)
	{
		logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x832C2D8), serverUid);
		serversFeatureFlags[serverUid] = featureFlags;
		return Task.CompletedTask;
	}

	internal static void P8r5uYGWOTBIR5D8iwsr()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object CGQyGGGW25JqEEjVDeO0(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static bool r3v1AyGWkOHXAie0hQIY()
	{
		return dM4vHyGWTct5SBNHA2Y9 == null;
	}

	internal static DistributedFeatureFlagService x9aAFkGWn6x6pZMMiryh()
	{
		return dM4vHyGWTct5SBNHA2Y9;
	}
}
