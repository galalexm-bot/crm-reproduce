using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ActorModel.Starting;

[StartingAvailablePlacement]
internal sealed class StartingActor : Actor, IStartingActor, IActorWithGuidKey, IActor
{
	internal const string reminderName = "live";

	private readonly IRuntimeApplication runtimeApplication;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private Version clusterVersion;

	private readonly ILogger logger;

	internal static StartingActor oMIhS9f3r6DjpVoFxNKq;

	public StartingActor(IRuntimeApplication runtimeApplication, IActorModelRuntime actorModelRuntime, IServerPlacementPublishService serverPlacementPublishService)
	{
		//Discarded unreachable code: IL_0044, IL_0049
		dW3e0wf3jLvy4NMwysF1();
		logger = (ILogger)R2V2aff3LIaSZA2DVQH1(WWfINIf3YAtgH9DH5Flk(typeof(StartingActor).TypeHandle));
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			case 3:
				this.serverPlacementPublishService = serverPlacementPublishService;
				num = 2;
				break;
			case 1:
				this.runtimeApplication = runtimeApplication;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num = 0;
				}
				break;
			default:
				this.actorModelRuntime = actorModelRuntime;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num = 3;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnActivateAsync_003Ed__7))]
	public override Task OnActivateAsync()
	{
		int num = 4;
		int num2 = num;
		_003COnActivateAsync_003Ed__7 stateMachine = default(_003COnActivateAsync_003Ed__7);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder = nYAnXIf3Uu3PDZiLKy3s();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CReceiveReminder_003Ed__8))]
	public override Task ReceiveReminder(string reminderName)
	{
		int num = 1;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CReceiveReminder_003Ed__8 stateMachine = default(_003CReceiveReminder_003Ed__8);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					stateMachine._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					stateMachine._003C_003E1__state = -1;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					stateMachine._003C_003Et__builder = nYAnXIf3Uu3PDZiLKy3s();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 6;
					continue;
				case 4:
					return stateMachine._003C_003Et__builder.Task;
				}
				break;
			}
			stateMachine.reminderName = reminderName;
			num = 3;
		}
	}

	[AsyncStateMachine(typeof(_003CStart_003Ed__9))]
	public Task Start(Guid serverUid)
	{
		int num = 3;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CStart_003Ed__9 stateMachine = default(_003CStart_003Ed__9);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num2 = 6;
				break;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 4;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				break;
			case 2:
				stateMachine.serverUid = serverUid;
				num2 = 5;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CFinish_003Ed__10))]
	public Task Finish(Guid serverUid, Version serverVersion)
	{
		int num = 5;
		_003CFinish_003Ed__10 stateMachine = default(_003CFinish_003Ed__10);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return stateMachine._003C_003Et__builder.Task;
				case 5:
					stateMachine._003C_003E4__this = this;
					num2 = 4;
					continue;
				case 4:
					break;
				case 1:
					stateMachine._003C_003Et__builder = nYAnXIf3Uu3PDZiLKy3s();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 6;
					}
					continue;
				case 7:
					stateMachine.serverVersion = serverVersion;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					stateMachine._003C_003E1__state = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			stateMachine.serverUid = serverUid;
			num = 7;
		}
	}

	[AsyncStateMachine(typeof(_003CConfigurationScriptsRecompileRequired_003Ed__11))]
	public Task ConfigurationScriptsRecompileRequired(Guid serverUid)
	{
		int num = 5;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CConfigurationScriptsRecompileRequired_003Ed__11 stateMachine = default(_003CConfigurationScriptsRecompileRequired_003Ed__11);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 3;
					continue;
				case 6:
					stateMachine._003C_003Et__builder = nYAnXIf3Uu3PDZiLKy3s();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return stateMachine._003C_003Et__builder.Task;
				case 5:
					break;
				case 4:
					stateMachine.serverUid = serverUid;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					stateMachine._003C_003E1__state = -1;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			stateMachine._003C_003E4__this = this;
			num = 4;
		}
	}

	internal static void dW3e0wf3jLvy4NMwysF1()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type WWfINIf3YAtgH9DH5Flk(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object R2V2aff3LIaSZA2DVQH1(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static bool F0iZCAf3g2QX1C5004Wq()
	{
		return oMIhS9f3r6DjpVoFxNKq == null;
	}

	internal static StartingActor RqmoKnf35yGumowKLsJy()
	{
		return oMIhS9f3r6DjpVoFxNKq;
	}

	internal static AsyncTaskMethodBuilder nYAnXIf3Uu3PDZiLKy3s()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static object oqcPiLf3sjTdVV5NrEpB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sJU4xSf3cP0gGw6iW3lX(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void HmlOKOf3zIgRIGOijVE1(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Debug(P_1, (Exception)P_2);
	}
}
