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

internal sealed class WorkflowProcessPublicationActor : Actor, IWorkflowProcessPublicationActor, IActorWithIntegerKey, IActor
{
	private readonly string reminderPrefix;

	private readonly IProcessHeaderManager processHeaderManager;

	private readonly IServerPlacementPublishService serverPlacementPublishService;

	private readonly IWorkflowProcessPublicationService workflowProcessPublicationService;

	private readonly ILogger logger;

	private bool publicationStarted;

	private static WorkflowProcessPublicationActor ArZeosZHdrACbCJL5YyB;

	public override TimeSpan LifeTime { get; }

	public WorkflowProcessPublicationActor(ILoggerFactory loggerFactory, IProcessHeaderManager processHeaderManager, IServerPlacementPublishService serverPlacementPublishService, IWorkflowProcessPublicationService workflowProcessPublicationService)
	{
		//Discarded unreachable code: IL_004e, IL_0053
		WTYiyxZHnViNDr5eOUpp();
		reminderPrefix = (string)YGTLiwZHHsWEqOnkY846(-432000546 ^ -431818390);
		LifeTime = IZxkP6ZHLlNEiseAINjb(1.0);
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				logger = (ILogger)q9ugAJZH9Gs53SttOufe(loggerFactory, GNjl0xZHfXg10yOFPpat(typeof(WorkflowProcessPublicationActor).TypeHandle));
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.processHeaderManager = processHeaderManager;
				num = 4;
				break;
			case 4:
				this.serverPlacementPublishService = serverPlacementPublishService;
				num = 3;
				break;
			case 3:
				this.workflowProcessPublicationService = workflowProcessPublicationService;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CReceiveReminder_003Ed__10))]
	public override Task ReceiveReminder(string reminderName)
	{
		int num = 3;
		int num2 = num;
		_003CReceiveReminder_003Ed__10 stateMachine = default(_003CReceiveReminder_003Ed__10);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				break;
			case 2:
				stateMachine.reminderName = reminderName;
				num2 = 6;
				break;
			case 6:
				stateMachine._003C_003Et__builder = NOkT4NZHW04QF2utWyTL();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 5;
				break;
			case 5:
				return stateMachine._003C_003Et__builder.Task;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublish_003Ed__11))]
	public Task Publish(string comment, bool generateDocumentation, bool isEmulation)
	{
		int num = 6;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CPublish_003Ed__11 stateMachine = default(_003CPublish_003Ed__11);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				stateMachine.comment = comment;
				num2 = 2;
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine.generateDocumentation = generateDocumentation;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 7;
				break;
			case 4:
				stateMachine.isEmulation = isEmulation;
				num2 = 8;
				break;
			case 7:
				return stateMachine._003C_003Et__builder.Task;
			case 8:
				stateMachine._003C_003Et__builder = NOkT4NZHW04QF2utWyTL();
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
				stateMachine._003C_003Et__builder = NOkT4NZHW04QF2utWyTL();
				num2 = 2;
				break;
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 3;
				break;
			case 5:
				stateMachine._003C_003E4__this = this;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublishInternal_003Ed__13))]
	private Task PublishInternal(long headerId, string comment, bool generateDocumentation, bool isEmulation)
	{
		int num = 8;
		_003CPublishInternal_003Ed__13 stateMachine = default(_003CPublishInternal_003Ed__13);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					stateMachine.generateDocumentation = generateDocumentation;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					stateMachine._003C_003E4__this = this;
					num2 = 7;
					continue;
				case 7:
					stateMachine.headerId = headerId;
					num = 2;
					break;
				case 6:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					stateMachine.comment = comment;
					num = 4;
					break;
				case 9:
					return stateMachine._003C_003Et__builder.Task;
				case 3:
					stateMachine._003C_003E1__state = -1;
					num2 = 6;
					continue;
				case 1:
					stateMachine._003C_003Et__builder = NOkT4NZHW04QF2utWyTL();
					num = 3;
					break;
				default:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 9;
					continue;
				case 5:
					stateMachine.isEmulation = isEmulation;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static void WTYiyxZHnViNDr5eOUpp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object YGTLiwZHHsWEqOnkY846(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static TimeSpan IZxkP6ZHLlNEiseAINjb(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static Type GNjl0xZHfXg10yOFPpat(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object q9ugAJZH9Gs53SttOufe(object P_0, Type P_1)
	{
		return ((ILoggerFactory)P_0).CreateLogger(P_1);
	}

	internal static bool M5Mh9tZHufxIenQYlCFK()
	{
		return ArZeosZHdrACbCJL5YyB == null;
	}

	internal static WorkflowProcessPublicationActor a96ndvZHDa41YVKFn3VH()
	{
		return ArZeosZHdrACbCJL5YyB;
	}

	internal static AsyncTaskMethodBuilder NOkT4NZHW04QF2utWyTL()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
