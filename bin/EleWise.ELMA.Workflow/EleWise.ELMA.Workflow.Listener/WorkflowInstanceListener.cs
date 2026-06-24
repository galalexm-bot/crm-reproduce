using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
public class WorkflowInstanceListener : EntityEventsListener
{
	internal static WorkflowInstanceListener lcg2Zw3bJNtqXoPbJEE;

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		//Discarded unreachable code: IL_0158, IL_0162, IL_01a1, IL_01b0, IL_0234, IL_0243, IL_027b, IL_028a, IL_0357, IL_036a, IL_0379, IL_0389, IL_043e
		int num = 3;
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		ProcessInstanceMetric processInstanceMetric = default(ProcessInstanceMetric);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 10:
					enumerator = entityMetadata.Properties.GetEnumerator();
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					workflowInstance.ShowGoodMetric = ((IWorkflowProcess)XPnEvP3cN90floU9JDE(workflowInstance)).ShowGoodMetric;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 9;
					}
					continue;
				case 9:
					goto end_IL_0012;
				case 11:
					if (entityMetadata != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 14;
				case 8:
					entityMetadata = (EntityMetadata)uloHI33n0cPpGIiVqdT(WorkflowInstanceContextService.Instance, workflowProcess);
					num2 = 11;
					continue;
				case 1:
					if (workflowProcess != null)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 14;
				case 4:
					if (IX2OFY3LXuj513xa7Ox(workflowInstance) != null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 14;
				case 13:
					try
					{
						while (true)
						{
							IL_0295:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
								{
									num3 = 0;
								}
								goto IL_0166;
							}
							goto IL_01e1;
							IL_01e1:
							processInstanceMetric = enumerator.Current as ProcessInstanceMetric;
							num3 = 8;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
							{
								num3 = 1;
							}
							goto IL_0166;
							IL_0166:
							while (true)
							{
								switch (num3)
								{
								case 10:
									if (processInstanceMetric.TimeMetricCalculationType != 0)
									{
										num3 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
										{
											num3 = 6;
										}
										continue;
									}
									goto case 7;
								case 5:
									goto IL_01e1;
								case 9:
									if (!O3YARi3fgq5wxsnqMev(processInstanceMetric))
									{
										num3 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
										{
											num3 = 3;
										}
										continue;
									}
									goto case 1;
								case 8:
									if (processInstanceMetric == null)
									{
										num3 = 2;
										continue;
									}
									goto case 9;
								case 1:
									if (GugLls39FpYyWiyT0Ct(processInstanceMetric) == ProcessMetricComputationType.Time)
									{
										num3 = 10;
										continue;
									}
									goto IL_0295;
								case 2:
								case 3:
								case 4:
								case 6:
									goto IL_0295;
								case 7:
									MetricValueDataManager.Instance.SetMetricTemporaryTimeValue(workflowInstance, QhCd7y3WRnZuZbHiS2G(processInstanceMetric), workflowInstance.StartDate ?? zNBANL3jKn8PQwVpZ0J(), null, processInstanceMetric.PlanValue, zXBrrf3RQSxN7gooqKQ(processInstanceMetric));
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
									{
										num3 = 3;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 14;
				default:
					if (xlDCOk3HT5Uu50vSg6f(entityMetadata.Properties) > 0)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 14;
				case 7:
					NiWhTR3XnD1FJQGrV8X(workflowInstance, workflowInstance.Process.ShowWarningMetric);
					num2 = 6;
					continue;
				case 14:
					return false;
				case 3:
					workflowInstance = lRPQog3BYqnfGw60ofJ(@event) as IWorkflowInstance;
					num2 = 2;
					continue;
				case 2:
					if (workflowInstance == null)
					{
						return AD3YEV36S8OQaIwCEJ3(this, @event);
					}
					num2 = 12;
					continue;
				case 6:
					if (t068la3dtXptC1F0fDk(workflowInstance))
					{
						num2 = 15;
						continue;
					}
					goto case 5;
				case 5:
					obj = ((IProcessHeader)goaMXY3u4upOGTYSRHJ(workflowInstance.Process)).Published;
					break;
				case 15:
					obj = KLIIs83D6d7Q1vsCHm7(goaMXY3u4upOGTYSRHJ(XPnEvP3cN90floU9JDE(workflowInstance)));
					break;
				}
				workflowProcess = (IWorkflowProcess)obj;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			GAm9jA3P9lAprOHGcmp(workflowInstance, workflowInstance.Process.ShowProblemMetric);
			num = 7;
		}
	}

	public WorkflowInstanceListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object lRPQog3BYqnfGw60ofJ(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object XPnEvP3cN90floU9JDE(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static void GAm9jA3P9lAprOHGcmp(object P_0, bool value)
	{
		((IWorkflowInstance)P_0).ShowProblemMetric = value;
	}

	internal static void NiWhTR3XnD1FJQGrV8X(object P_0, bool value)
	{
		((IWorkflowInstance)P_0).ShowWarningMetric = value;
	}

	internal static bool t068la3dtXptC1F0fDk(object P_0)
	{
		return ((IWorkflowInstance)P_0).IsEmulation;
	}

	internal static object goaMXY3u4upOGTYSRHJ(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static object KLIIs83D6d7Q1vsCHm7(object P_0)
	{
		return ((IProcessHeader)P_0).PublishedEmulation;
	}

	internal static object uloHI33n0cPpGIiVqdT(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceMetricValuesMetadata((IWorkflowProcess)P_1);
	}

	internal static int xlDCOk3HT5Uu50vSg6f(object P_0)
	{
		return ((List<PropertyMetadata>)P_0).Count;
	}

	internal static object IX2OFY3LXuj513xa7Ox(object P_0)
	{
		return ((IWorkflowInstance)P_0).MetricValues;
	}

	internal static bool O3YARi3fgq5wxsnqMev(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).Active;
	}

	internal static ProcessMetricComputationType GugLls39FpYyWiyT0Ct(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).Type;
	}

	internal static Guid QhCd7y3WRnZuZbHiS2G(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static DateTime zNBANL3jKn8PQwVpZ0J()
	{
		return DateTime.Now;
	}

	internal static bool zXBrrf3RQSxN7gooqKQ(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).UseWorkCalendar;
	}

	internal static bool AD3YEV36S8OQaIwCEJ3(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreInsert((PreInsertEvent)P_1);
	}

	internal static bool MDEVip353jvlWSBIA3W()
	{
		return lcg2Zw3bJNtqXoPbJEE == null;
	}

	internal static WorkflowInstanceListener Gm1guW3guHTaDQEMgjv()
	{
		return lcg2Zw3bJNtqXoPbJEE;
	}
}
