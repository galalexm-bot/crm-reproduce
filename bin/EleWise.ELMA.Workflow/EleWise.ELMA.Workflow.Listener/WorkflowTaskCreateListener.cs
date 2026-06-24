using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scripts;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Workflow.Listeners;

[Component(Order = 10000)]
internal class WorkflowTaskCreateListener : EntityEventsListener
{
	private static WorkflowTaskCreateListener Qmh3jdpC4vtTsbtj7FP;

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		//Discarded unreachable code: IL_0095, IL_00a4, IL_0197, IL_01ef, IL_0241, IL_026f, IL_045d, IL_0470, IL_047f, IL_04b0, IL_04c0
		int num = 14;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IWorkflowTaskBase workflowTaskBase = default(IWorkflowTaskBase);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		IWorkflowInstance instance = default(IWorkflowInstance);
		IProcessScriptBase processScriptBase = default(IProcessScriptBase);
		IWorkflowScriptingService service = default(IWorkflowScriptingService);
		ProcessInstanceMetric processInstanceMetric = default(ProcessInstanceMetric);
		Guid? selectedProcessTaskUid = default(Guid?);
		Guid? elementUid = default(Guid?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 3:
					enumerator = entityMetadata.Properties.GetEnumerator();
					num = 8;
					break;
				case 14:
					workflowTaskBase = Ro2w8epU9kbRJ8t60gn(@event) as IWorkflowTaskBase;
					num2 = 13;
					continue;
				case 4:
					if (workflowProcess == null)
					{
						num2 = 7;
						continue;
					}
					goto case 11;
				case 6:
					if (instance.MetricValues == null)
					{
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 3;
				case 16:
					instance = ((IWorkflowBookmark)sWQCvEpVo4L4HKUYHL6(workflowTaskBase)).Instance;
					num2 = 19;
					continue;
				case 13:
					if (workflowTaskBase != null)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				case 9:
					yexLhMpouDIbbqhYJZp(processScriptBase, workflowTaskBase, Jb4HU3p2RrxeZrbl7kn(CwGu7jpGRA9HXwBxHu4(sWQCvEpVo4L4HKUYHL6(workflowTaskBase))));
					num2 = 16;
					continue;
				case 19:
					if (!kpAorgpF834WxOt2rq1(instance))
					{
						num2 = 21;
						continue;
					}
					obj = OjH0fcprMI8AhZ33DHX(luXMSZpImtxa2DG5BvI(zNVhhspiYBtEXLQM1JC(instance)));
					goto IL_057b;
				default:
					service = Locator.GetService<IWorkflowScriptingService>();
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
					{
						num2 = 17;
					}
					continue;
				case 21:
					obj = cm2cUSpaFjS54ytZply(luXMSZpImtxa2DG5BvI(zNVhhspiYBtEXLQM1JC(instance)));
					goto IL_057b;
				case 20:
					if (entityMetadata != null)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				case 12:
					if (eb9m1ypNoAVyuS2GJPO(entityMetadata.Properties) > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 1;
				case 8:
					try
					{
						while (true)
						{
							IL_036a:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_01f9;
							}
							goto IL_0342;
							IL_02a8:
							num3 = 3;
							goto IL_01f9;
							IL_0342:
							processInstanceMetric = enumerator.Current as ProcessInstanceMetric;
							int num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
							{
								num4 = 0;
							}
							goto IL_01fd;
							IL_01f9:
							num4 = num3;
							goto IL_01fd;
							IL_01fd:
							while (true)
							{
								switch (num4)
								{
								case 10:
									selectedProcessTaskUid = processInstanceMetric.SelectedProcessTaskUid;
									num4 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
									{
										num4 = 5;
									}
									continue;
								case 1:
									if (processInstanceMetric != null)
									{
										num4 = 7;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
										{
											num4 = 7;
										}
										continue;
									}
									goto IL_036a;
								case 11:
									break;
								case 4:
									if (gFVE8SpxXw2a8XXCAIQ(processInstanceMetric) == ProcessMetricComputationType.Time)
									{
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
										{
											num4 = 0;
										}
										continue;
									}
									goto IL_036a;
								default:
									if (c5axE2pSq1B3IahZ25W(processInstanceMetric) == ProcessMetricTimeCalculationType.TaskExecutionTime)
									{
										num4 = 10;
										continue;
									}
									goto IL_036a;
								case 7:
									if (processInstanceMetric.Active)
									{
										num4 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
										{
											num4 = 4;
										}
										continue;
									}
									goto IL_036a;
								case 5:
									elementUid = workflowTaskBase.WorkflowBookmark.ElementUid;
									num4 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
									{
										num4 = 11;
									}
									continue;
								case 8:
									goto end_IL_01fd;
								case 3:
								case 6:
									goto IL_036a;
								case 9:
									goto IL_03c2;
								case 12:
									MetricValueDataManager.Instance.SetMetricTemporaryTimeValue(instance, Hx7UA1pho6qVnaWRnS9(processInstanceMetric), workflowTaskBase.CreationDate ?? ke54WhpEKLLOJUGDwYu(), null, processInstanceMetric.PlanValue, processInstanceMetric.UseWorkCalendar);
									num4 = 6;
									continue;
								case 2:
									goto end_IL_036a;
								}
								if (selectedProcessTaskUid.HasValue != elementUid.HasValue)
								{
									goto IL_02a8;
								}
								if (!selectedProcessTaskUid.HasValue)
								{
									num4 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
									{
										num4 = 3;
									}
									continue;
								}
								if (!Ahuhfbp1CfIGCBvpbPX(selectedProcessTaskUid.GetValueOrDefault(), elementUid.GetValueOrDefault()))
								{
									goto IL_036a;
								}
								goto IL_03c2;
								IL_03c2:
								num4 = 12;
								continue;
								end_IL_01fd:
								break;
							}
							goto IL_0342;
							continue;
							end_IL_036a:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 1;
				case 10:
					if (processScriptBase != null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 16;
				case 15:
					obj2 = null;
					goto IL_055e;
				case 17:
					if (service == null)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
						{
							num2 = 5;
						}
						continue;
					}
					obj2 = pZyWfqp7hapUfJUUHDs(service, CwGu7jpGRA9HXwBxHu4(workflowTaskBase.WorkflowBookmark)) as IProcessScriptBase;
					goto IL_055e;
				case 11:
					entityMetadata = (EntityMetadata)HpcmrwpeZ98qH9XmvS7(WorkflowInstanceContextService.Instance, workflowProcess);
					num = 20;
					break;
				case 2:
					if (sWQCvEpVo4L4HKUYHL6(workflowTaskBase) != null)
					{
						num2 = 5;
						continue;
					}
					goto case 1;
				case 5:
					Hd87kSpAUj6BiKWKqTi(TaskBaseManager.Instance, workflowTaskBase);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				case 7:
				case 18:
					{
						return lXFq9tpwmAXN4a43jMW(this, @event);
					}
					IL_057b:
					workflowProcess = (IWorkflowProcess)obj;
					num2 = 4;
					continue;
					IL_055e:
					processScriptBase = (IProcessScriptBase)obj2;
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	public WorkflowTaskCreateListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		USeMaep4oJlkUSRsnOy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Ro2w8epU9kbRJ8t60gn(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object sWQCvEpVo4L4HKUYHL6(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static void Hd87kSpAUj6BiKWKqTi(object P_0, object P_1)
	{
		((TaskBaseManager<ITaskBase>)P_0).RaiseReplacementActionIfHasExecutorReplaced((ITaskBase)P_1);
	}

	internal static object CwGu7jpGRA9HXwBxHu4(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object pZyWfqp7hapUfJUUHDs(object P_0, object P_1)
	{
		return ((IWorkflowScriptingService)P_0).GetScriptInstance((IWorkflowInstance)P_1);
	}

	internal static object Jb4HU3p2RrxeZrbl7kn(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static void yexLhMpouDIbbqhYJZp(object P_0, object P_1, object P_2)
	{
		((IProcessScriptBase)P_0).OnTaskCreate((ITaskBase)P_1, P_2);
	}

	internal static bool kpAorgpF834WxOt2rq1(object P_0)
	{
		return ((IWorkflowInstance)P_0).IsEmulation;
	}

	internal static object zNVhhspiYBtEXLQM1JC(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object luXMSZpImtxa2DG5BvI(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object cm2cUSpaFjS54ytZply(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object OjH0fcprMI8AhZ33DHX(object P_0)
	{
		return ((IProcessHeader)P_0).PublishedEmulation;
	}

	internal static object HpcmrwpeZ98qH9XmvS7(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceMetricValuesMetadata((IWorkflowProcess)P_1);
	}

	internal static int eb9m1ypNoAVyuS2GJPO(object P_0)
	{
		return ((List<PropertyMetadata>)P_0).Count;
	}

	internal static ProcessMetricComputationType gFVE8SpxXw2a8XXCAIQ(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).Type;
	}

	internal static ProcessMetricTimeCalculationType c5axE2pSq1B3IahZ25W(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).TimeMetricCalculationType;
	}

	internal static bool Ahuhfbp1CfIGCBvpbPX(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid Hx7UA1pho6qVnaWRnS9(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static DateTime ke54WhpEKLLOJUGDwYu()
	{
		return DateTime.Now;
	}

	internal static bool lXFq9tpwmAXN4a43jMW(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreInsert((PreInsertEvent)P_1);
	}

	internal static bool VliBeupMsFSsM67n5nW()
	{
		return Qmh3jdpC4vtTsbtj7FP == null;
	}

	internal static WorkflowTaskCreateListener ESZfvhpkuDF38MB8j8d()
	{
		return Qmh3jdpC4vtTsbtj7FP;
	}

	internal static void USeMaep4oJlkUSRsnOy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
