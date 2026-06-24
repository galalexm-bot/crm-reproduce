using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ActorModel.Publication;

internal sealed class GlobalScriptModulePublicationActor : Actor, IGlobalScriptModulePublicationActor, IActorWithIntegerKey, IActor
{
	private readonly string reminderPrefix;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly IGlobalScriptModuleManager globalScriptModuleManager;

	private readonly ILogger logger;

	private bool publicationStarted;

	private static GlobalScriptModulePublicationActor nELecMfpQMj2Hyo3Qd4t;

	public override TimeSpan LifeTime { get; }

	public GlobalScriptModulePublicationActor(ILoggerFactory loggerFactory, IServerPlacementPublishService serverPlacementPublishService, IGlobalScriptModuleManager globalScriptModuleManager)
	{
		//Discarded unreachable code: IL_004e, IL_0053
		SingletonReader.JJCZtPuTvSt();
		reminderPrefix = (string)c6wdlAfp8sxUm8Mhd2Rf(-1824388195 ^ -1824038963);
		LifeTime = bZ74XDfpZ4y60jIrhs6G(1.0);
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				logger = (ILogger)qcCn6ofpIsKp1hKjgRNw(loggerFactory, BQwhv9fpuAMi77upr7so(typeof(GlobalScriptModulePublicationActor).TypeHandle));
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			case 3:
				this.serverPlacementPublishService = serverPlacementPublishService;
				num = 2;
				break;
			case 2:
				this.globalScriptModuleManager = globalScriptModuleManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CReceiveReminder_003Ed__9))]
	public override Task ReceiveReminder(string reminderName)
	{
		int num = 3;
		_003CReceiveReminder_003Ed__9 stateMachine = default(_003CReceiveReminder_003Ed__9);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stateMachine._003C_003E1__state = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					stateMachine._003C_003Et__builder = L4WwclfpVI0LxrH8OEwB();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 6;
					continue;
				case 2:
					break;
				case 3:
					stateMachine._003C_003E4__this = this;
					num2 = 2;
					continue;
				case 4:
					return stateMachine._003C_003Et__builder.Task;
				case 6:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 4;
					continue;
				}
				break;
			}
			stateMachine.reminderName = reminderName;
			num = 5;
		}
	}

	[AsyncStateMachine(typeof(_003CPublish_003Ed__10))]
	public Task Publish()
	{
		int num = 3;
		int num2 = num;
		_003CPublish_003Ed__10 stateMachine = default(_003CPublish_003Ed__10);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 2:
				stateMachine._003C_003Et__builder = L4WwclfpVI0LxrH8OEwB();
				num2 = 4;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublicationComplete_003Ed__11))]
	public Task PublicationComplete()
	{
		int num = 1;
		int num2 = num;
		_003CPublicationComplete_003Ed__11 stateMachine = default(_003CPublicationComplete_003Ed__11);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				stateMachine._003C_003Et__builder = L4WwclfpVI0LxrH8OEwB();
				num2 = 5;
				break;
			case 3:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 3;
				break;
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublishInternal_003Ed__12))]
	private Task PublishInternal(long scriptModuleId)
	{
		int num = 4;
		_003CPublishInternal_003Ed__12 stateMachine = default(_003CPublishInternal_003Ed__12);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					stateMachine._003C_003Et__builder = L4WwclfpVI0LxrH8OEwB();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					stateMachine.scriptModuleId = scriptModuleId;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 5;
					continue;
				case 4:
					stateMachine._003C_003E4__this = this;
					num2 = 3;
					continue;
				case 5:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return stateMachine._003C_003Et__builder.Task;
				case 2:
					break;
				}
				break;
			}
			stateMachine._003C_003E1__state = -1;
			num = 6;
		}
	}

	internal static object c6wdlAfp8sxUm8Mhd2Rf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static TimeSpan bZ74XDfpZ4y60jIrhs6G(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static Type BQwhv9fpuAMi77upr7so(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object qcCn6ofpIsKp1hKjgRNw(object P_0, Type type)
	{
		return ((ILoggerFactory)P_0).CreateLogger(type);
	}

	internal static bool BNgDyHfpCkhpc045SWmI()
	{
		return nELecMfpQMj2Hyo3Qd4t == null;
	}

	internal static GlobalScriptModulePublicationActor HYyoTwfpvkNeM2CeafK3()
	{
		return nELecMfpQMj2Hyo3Qd4t;
	}

	internal static AsyncTaskMethodBuilder L4WwclfpVI0LxrH8OEwB()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
