using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

internal sealed class WorkflowActionExecutionHandler : AbstractActionExecutionHandler
{
	private readonly WorkflowTaskBaseManager workflowTaskBaseManager;

	private static WorkflowActionExecutionHandler TqG6s3Oyf9oCVcARKKwi;

	public WorkflowActionExecutionHandler(IExecutionScopeFactory executionScopeFactory, WorkflowTaskBaseManager workflowTaskBaseManager)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		GGPgZgOyj6Ri6KHtBFaJ();
		base._002Ector(executionScopeFactory);
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.workflowTaskBaseManager = workflowTaskBaseManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override bool Check(ActionExecutionParams parameters)
	{
		return goMveQOyqn59DTvQi5jr(IFo2gQOyRHMCnuxmmG47(parameters), new Guid((string)LRDs6OOy61ntgcdBTP3O(-642713667 ^ -642716855)));
	}

	public override ActionExecutionResult Execute(ActionExecutionParams parameters)
	{
		//Discarded unreachable code: IL_00d8, IL_024c, IL_025b, IL_02ac, IL_0324, IL_0357, IL_0397, IL_03a6, IL_0419, IL_0552, IL_0561
		int num = 5;
		ProcessContext processContext = default(ProcessContext);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		ScriptModule scriptModule = default(ScriptModule);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		Guid guid = default(Guid);
		ScriptMethodInfo scriptMethodInfo = default(ScriptMethodInfo);
		string text = default(string);
		DataClassMetadata viewModelMetadata = default(DataClassMetadata);
		Assembly assembly = default(Assembly);
		string text2 = default(string);
		Type type = default(Type);
		ActionExecutionResult result = default(ActionExecutionResult);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 27:
					processContext = (ProcessContext)tDqi3uOyGs1Ht30blAi6(workflowProcess);
					num2 = 16;
					continue;
				case 25:
					scriptModule = (ScriptModule)rOfji5OyMOaT8dwEZmIj(vTLOcfOyoLoTNoibTNgJ(workflowInstance));
					num2 = 20;
					continue;
				case 23:
					scriptModule = null;
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (goMveQOyqn59DTvQi5jr(guid, Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num2 = 0;
						}
						continue;
					}
					workflowInstance = (IWorkflowInstance)WyQBOrOypwFsv9CoUfdY(KIXMNkOyQWw704fVqFcV(workflowTaskBaseManager.Load(guid)));
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 32;
					}
					continue;
				case 33:
					if (!Vao7SwOyUfarn3jVK8k4(Pnv7h4Oykp6xg2c4MNtg(scriptMethodInfo), Guid.Empty))
					{
						num2 = 30;
						continue;
					}
					goto case 28;
				case 8:
					throw new Exception((string)opJ9l7OyNG5W8RU74Et6(text, VYtHbJOyed09kW52e59q(LRDs6OOy61ntgcdBTP3O(-22348816 ^ -22331092), new object[1] { RqaVNPOyrVKFx1i7QDHu(scriptModule) })));
				case 26:
					workflowProcess = workflowInstance.Process;
					num2 = 17;
					continue;
				case 32:
					scriptMethodInfo = ScriptMethodInfoHelper.Deserialize((string)f35nIKOyC4iAmylrJ1sU(parameters));
					num = 23;
					break;
				case 10:
					if (goMveQOyqn59DTvQi5jr(MNuRNbOy7EHKToVRKsNS(viewModelMetadata), Pnv7h4Oykp6xg2c4MNtg(scriptMethodInfo)))
					{
						num2 = 27;
						continue;
					}
					goto case 16;
				case 9:
					if (!GvOdjlOyFPQFPjfdElQX(assembly, null))
					{
						text2 = (string)ra5knSOySG3cyYbQj4Yw(LRDs6OOy61ntgcdBTP3O(-790221436 ^ -790128122), y6ZMPwOyxuT4ptoBB2xC(processContext), LRDs6OOy61ntgcdBTP3O(-1050383744 ^ -1050280192));
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
						{
							num2 = 6;
						}
					}
					continue;
				case 12:
					text = SR.T((string)LRDs6OOy61ntgcdBTP3O(-1574607501 ^ -1574641891), scriptMethodInfo.Name, gv14K2OyawIsPQK7Wvql(processContext));
					num2 = 9;
					continue;
				case 34:
					throw new Exception((string)opJ9l7OyNG5W8RU74Et6(text, SR.T((string)LRDs6OOy61ntgcdBTP3O(0x37F755F5 ^ 0x37F6EEC7), text2)));
				case 19:
					try
					{
						result = (ActionExecutionResult)GB3D62OyEqt2JueHXfjK(this, type, parameters);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
						{
							num3 = 0;
						}
						return num3 switch
						{
							0 => result, 
							_ => result, 
						};
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								throw;
							}
							gNnpmUOy4PjxdLo1HtuJ(jYQMb4OywxCCQMdbFnwu(), text, ex);
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
							{
								num4 = 1;
							}
						}
					}
				case 21:
					assembly = (Assembly)MjY8XOOyINvAJWANI7Y6(scriptModule.AssemblyRaw, c3lYRkOyiO1P95X6Pwsw(scriptModule));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num2 = 12;
					}
					continue;
				case 17:
				case 22:
					if (workflowProcess != null)
					{
						num2 = 24;
						continue;
					}
					goto case 2;
				case 2:
					if (scriptModule != null)
					{
						num2 = 13;
						continue;
					}
					goto case 25;
				case 5:
					guid = BPNSN0Oy3vTCabcf2E6m(parameters);
					num2 = 4;
					continue;
				case 11:
					return result;
				case 15:
					processContext = null;
					num2 = 26;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 12;
					}
					continue;
				case 3:
					type = KI1FWFOy1D2MWVZBwOhL(assembly, text2);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
					{
						num2 = 18;
					}
					continue;
				default:
					processContext = (ProcessContext)tDqi3uOyGs1Ht30blAi6(vTLOcfOyoLoTNoibTNgJ(workflowInstance));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 7;
					}
					continue;
				case 1:
					throw new Exception((string)r0QOyvOyTVGI7ymGKjkg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x69C834)));
				case 31:
					if (GvOdjlOyFPQFPjfdElQX(assembly, null))
					{
						num = 21;
						break;
					}
					goto case 12;
				case 28:
					viewModelMetadata = ((EntityMetadata)tDqi3uOyGs1Ht30blAi6(OZD8NSOyAsVdC6Dsq9pO(wUql4lOyVmFmOVUEKp77(workflowProcess)))).ViewModelMetadata;
					num2 = 14;
					continue;
				case 14:
					if (viewModelMetadata == null)
					{
						num2 = 29;
						continue;
					}
					goto case 10;
				case 13:
				case 20:
					if (processContext == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 7;
				case 16:
				case 29:
				case 30:
					workflowProcess = (IWorkflowProcess)jLFOmIOy2vipjv1aGtOv(workflowProcess);
					num2 = 22;
					continue;
				case 7:
					assembly = ComponentManager.FindLoadedAssembly(scriptModule.AssemblyName, isFullName: false);
					num2 = 31;
					continue;
				case 6:
				case 24:
					scriptModule = (ScriptModule)rOfji5OyMOaT8dwEZmIj(workflowProcess);
					num = 33;
					break;
				case 18:
					if (!G39nhCOyheoHbZ5jpc1f(type, null))
					{
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 34;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static void GGPgZgOyj6Ri6KHtBFaJ()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool D1pRY8Oy9RvXH2HIippQ()
	{
		return TqG6s3Oyf9oCVcARKKwi == null;
	}

	internal static WorkflowActionExecutionHandler XYq1Y3OyWyvcIWxql5gH()
	{
		return TqG6s3Oyf9oCVcARKKwi;
	}

	internal static Guid IFo2gQOyRHMCnuxmmG47(object P_0)
	{
		return ((ActionExecutionParams)P_0).TypeUid;
	}

	internal static object LRDs6OOy61ntgcdBTP3O(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool goMveQOyqn59DTvQi5jr(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid BPNSN0Oy3vTCabcf2E6m(object P_0)
	{
		return ((ActionExecutionParams)P_0).InstanceUid;
	}

	internal static object r0QOyvOyTVGI7ymGKjkg(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object KIXMNkOyQWw704fVqFcV(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object WyQBOrOypwFsv9CoUfdY(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object f35nIKOyC4iAmylrJ1sU(object P_0)
	{
		return ((ActionExecutionParams)P_0).ScriptName;
	}

	internal static object rOfji5OyMOaT8dwEZmIj(object P_0)
	{
		return ((IWorkflowProcess)P_0).ScriptModule;
	}

	internal static Guid Pnv7h4Oykp6xg2c4MNtg(object P_0)
	{
		return ((ScriptMethodInfo)P_0).MetadataUid;
	}

	internal static bool Vao7SwOyUfarn3jVK8k4(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object wUql4lOyVmFmOVUEKp77(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object OZD8NSOyAsVdC6Dsq9pO(object P_0)
	{
		return ((IProcessHeader)P_0).Current;
	}

	internal static object tDqi3uOyGs1Ht30blAi6(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static Guid MNuRNbOy7EHKToVRKsNS(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object jLFOmIOy2vipjv1aGtOv(object P_0)
	{
		return ((IWorkflowProcess)P_0).Parent;
	}

	internal static object vTLOcfOyoLoTNoibTNgJ(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static bool GvOdjlOyFPQFPjfdElQX(object P_0, object P_1)
	{
		return (Assembly)P_0 == (Assembly)P_1;
	}

	internal static object c3lYRkOyiO1P95X6Pwsw(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static object MjY8XOOyINvAJWANI7Y6(object P_0, object P_1)
	{
		return ComponentManager.LoadAssembly((byte[])P_0, (byte[])P_1);
	}

	internal static object gv14K2OyawIsPQK7Wvql(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static object RqaVNPOyrVKFx1i7QDHu(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyName;
	}

	internal static object VYtHbJOyed09kW52e59q(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object opJ9l7OyNG5W8RU74Et6(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object y6ZMPwOyxuT4ptoBB2xC(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object ra5knSOySG3cyYbQj4Yw(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Type KI1FWFOy1D2MWVZBwOhL(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool G39nhCOyheoHbZ5jpc1f(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object GB3D62OyEqt2JueHXfjK(object P_0, Type P_1, object P_2)
	{
		return ((AbstractActionExecutionHandler)P_0).Execute(P_1, (ActionExecutionParams)P_2);
	}

	internal static object jYQMb4OywxCCQMdbFnwu()
	{
		return Logger.Log;
	}

	internal static void gNnpmUOy4PjxdLo1HtuJ(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}
}
