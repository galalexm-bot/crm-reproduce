using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.CommonWorkflowActivity;

public abstract class CommonWorkflowActivity<TElement> : TaskActivity<TElement> where TElement : BPMNFlowElement
{
	private static object F84nvhZXgDWREkyyrWjN;

	protected ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	protected void CreateSheduleTask(IWorkflowBookmark bookmark, IWorkflowInstance instance, Guid connector = default(Guid))
	{
		//Discarded unreachable code: IL_0079, IL_0100, IL_010f, IL_0205, IL_0214, IL_0224, IL_0233, IL_0243, IL_0254, IL_0271, IL_0308, IL_0385, IL_03a4, IL_03d4
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		IEnumerator<FlowConnectorElement> enumerator = default(IEnumerator<FlowConnectorElement>);
		FlowConnectorElement current = default(FlowConnectorElement);
		DateTime? dateTime2 = default(DateTime?);
		DateTime? nextExpiration2 = default(DateTime?);
		EventTrigger trigger = default(EventTrigger);
		DateTime? nextExpiration = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass2_.connector = connector;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 9;
							goto IL_0083;
						}
						goto IL_0259;
						IL_0083:
						int num4 = num3;
						goto IL_0087;
						IL_0259:
						current = enumerator.Current;
						num4 = 6;
						goto IL_0087;
						IL_0087:
						while (true)
						{
							DateTime? dateTime;
							DateTime? dateTime3;
							switch (num4)
							{
							case 13:
								dateTime2 = null;
								num4 = 12;
								continue;
							default:
								if (nextExpiration2.HasValue)
								{
									num4 = 8;
									continue;
								}
								break;
							case 3:
								if (trigger != EventTrigger.Script)
								{
									num4 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
									{
										num4 = 4;
									}
									continue;
								}
								goto case 1;
							case 6:
								trigger = current.Trigger;
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
								{
									num4 = 16;
								}
								continue;
							case 14:
								if (!(nextExpiration.Value > DateTime.Now))
								{
									goto IL_018b;
								}
								goto case 19;
							case 15:
								if (current.TimerSettings != null)
								{
									num4 = 17;
									continue;
								}
								goto case 13;
							case 4:
							case 10:
								throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30131864)));
							case 2:
							case 7:
							case 21:
								break;
							case 8:
								CreateTaskForScheduler(bookmark, instance, nextExpiration2, current);
								num4 = 21;
								continue;
							case 12:
								dateTime = dateTime2;
								goto IL_031a;
							case 11:
								goto IL_0259;
							case 18:
								if (nextExpiration.HasValue)
								{
									num4 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
									{
										num4 = 14;
									}
									continue;
								}
								break;
							case 19:
								CreateTaskForScheduler(bookmark, instance, nextExpiration, current);
								num4 = 7;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								if (current.TimerScriptEscalation == null)
								{
									num4 = 20;
									continue;
								}
								dateTime3 = current.TimerScriptEscalation.GetNextTimerExpiration(instance);
								goto IL_0343;
							case 20:
								dateTime2 = null;
								num4 = 5;
								continue;
							case 16:
								if (trigger != EventTrigger.Timer)
								{
									num4 = 3;
									continue;
								}
								goto case 15;
							case 5:
								dateTime3 = dateTime2;
								goto IL_0343;
							case 17:
								dateTime = current.TimerSettings.GetNextTimerExpiration(instance);
								goto IL_031a;
							case 9:
								return;
								IL_031a:
								nextExpiration2 = dateTime;
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
								{
									num4 = 0;
								}
								continue;
								IL_0343:
								nextExpiration = dateTime3;
								num4 = 18;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
								{
									num4 = 14;
								}
								continue;
							}
							break;
						}
						continue;
						IL_018b:
						num3 = 2;
						goto IL_0083;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
						{
							num5 = 0;
						}
						goto IL_0389;
					}
					goto IL_03b2;
					IL_03b2:
					enumerator.Dispose();
					num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num5 = 1;
					}
					goto IL_0389;
					IL_0389:
					switch (num5)
					{
					default:
						goto end_IL_0364;
					case 0:
						goto end_IL_0364;
					case 2:
						break;
					case 1:
						goto end_IL_0364;
					}
					goto IL_03b2;
					end_IL_0364:;
				}
			case 3:
				return;
			case 2:
				enumerator = base.Element.ExceptionOutputFlows.Where(_003C_003Ec__DisplayClass2_._003CCreateSheduleTask_003Eb__0).GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private void CreateTaskForScheduler(IWorkflowBookmark bookmark, IWorkflowInstance instance, DateTime? nextExpiration, FlowConnectorElement exceptionFlow)
	{
		ISchedulerTask schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
		schedulerTask.Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25883112), base.Element.Name, instance.InstanceName(), SR.T(instance.Process.Name));
		schedulerTask.Uid = Guid.NewGuid();
		schedulerTask.OnceExecuteTime = nextExpiration.Value;
		schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
		ITerminateTaskSchedulerJob terminateTaskSchedulerJob = InterfaceActivator.Create<ITerminateTaskSchedulerJob>();
		terminateTaskSchedulerJob.Uid = Guid.NewGuid();
		terminateTaskSchedulerJob.WorkflowBookmark = bookmark;
		terminateTaskSchedulerJob.ConnectorUid = exceptionFlow.Uid;
		terminateTaskSchedulerJob.Task = schedulerTask;
		terminateTaskSchedulerJob.Name = schedulerTask.Name;
		schedulerTask.Jobs.Add((ISchedulerTaskJob)terminateTaskSchedulerJob);
		schedulerTask.Save();
	}

	protected CommonWorkflowActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rR3MDaZXBQ7yCp23uY2E()
	{
		return F84nvhZXgDWREkyyrWjN == null;
	}

	internal static object sw8363ZXcTgOw1cXYneD()
	{
		return F84nvhZXgDWREkyyrWjN;
	}
}
