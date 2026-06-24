using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Actors;

internal sealed class CustomActivityPublicationActor : Actor, ICustomActivityPublicationActor, IActorWithIntegerKey, IActor
{
	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly ICustomActivityPublicationService customActivityPublicationService;

	private readonly ICustomActivityManager customActivityManager;

	private readonly string reminderPrefix;

	private readonly ILogger logger;

	private bool publicationStarted;

	internal static CustomActivityPublicationActor RbH11xmXe6agAZWj2OA;

	public override TimeSpan LifeTime { get; }

	public CustomActivityPublicationActor(ILoggerFactory loggerFactory, IServerPlacementPublishService serverPlacementPublishService, ICustomActivityPublicationService customActivityPublicationService, ICustomActivityManager customActivityManager)
	{
		//Discarded unreachable code: IL_005e, IL_0063
		u7kpqcmhDsCIlEm5tI9();
		reminderPrefix = (string)PYFCHQmxhFS4XV3oOmF(0x4CBDA8D5 ^ 0x4CBD3145);
		LifeTime = TimeSpan.FromHours(1.0);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8a653485701e45079b9af8815b59e5f3 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				this.serverPlacementPublishService = serverPlacementPublishService;
				num = 4;
				break;
			case 4:
				this.customActivityPublicationService = customActivityPublicationService;
				num = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f != 0)
				{
					num = 0;
				}
				break;
			case 2:
				logger = (ILogger)vYJF7xmFB1ijk8sQHCA(loggerFactory, typeof(CustomActivityPublicationActor));
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.customActivityManager = customActivityManager;
				num = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CReceiveReminder_003Ed__10))]
	public override Task ReceiveReminder(string reminderName)
	{
		int num = 5;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CReceiveReminder_003Ed__10 stateMachine = default(_003CReceiveReminder_003Ed__10);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num2 = 4;
				break;
			case 3:
				stateMachine._003C_003Et__builder = sX1A93m8YECGsRrLEtm();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 6;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				break;
			case 4:
				stateMachine.reminderName = reminderName;
				num2 = 3;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublish_003Ed__11))]
	public Task Publish()
	{
		int num = 2;
		int num2 = num;
		_003CPublish_003Ed__11 stateMachine = default(_003CPublish_003Ed__11);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return stateMachine._003C_003Et__builder.Task;
			case 1:
				stateMachine._003C_003Et__builder = sX1A93m8YECGsRrLEtm();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 5;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				stateMachine._003C_003E1__state = -1;
				num2 = 4;
				break;
			case 5:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 3;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublicationComplete_003Ed__12))]
	public Task PublicationComplete()
	{
		int num = 5;
		int num2 = num;
		_003CPublicationComplete_003Ed__12 stateMachine = default(_003CPublicationComplete_003Ed__12);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 4:
				stateMachine._003C_003Et__builder = sX1A93m8YECGsRrLEtm();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num2 = 4;
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublishInternal_003Ed__13))]
	private Task PublishInternal(long activityId)
	{
		int num = 6;
		int num2 = num;
		_003CPublishInternal_003Ed__13 stateMachine = default(_003CPublishInternal_003Ed__13);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return stateMachine._003C_003Et__builder.Task;
			case 6:
				stateMachine._003C_003E4__this = this;
				num2 = 5;
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				stateMachine._003C_003Et__builder = sX1A93m8YECGsRrLEtm();
				num2 = 2;
				break;
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				break;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 == 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				stateMachine.activityId = activityId;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void u7kpqcmhDsCIlEm5tI9()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object PYFCHQmxhFS4XV3oOmF(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vYJF7xmFB1ijk8sQHCA(object P_0, Type P_1)
	{
		return ((ILoggerFactory)P_0).CreateLogger(P_1);
	}

	internal static bool rHT76Amo9avN1tuwpWc()
	{
		return RbH11xmXe6agAZWj2OA == null;
	}

	internal static CustomActivityPublicationActor MhEV6im3O3q766RAsh5()
	{
		return RbH11xmXe6agAZWj2OA;
	}

	internal static AsyncTaskMethodBuilder sX1A93m8YECGsRrLEtm()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
