using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Diagrams.Activities.Helpers;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using EleWise.ELMA.Workflow.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;

public class UserTaskActivity : TaskActivity<UserTaskElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		private static object ndxkn2v9uP8HTGWYFeg8;

		public Type ActivityType => typeof(UserTaskActivity);

		public Type DiagramElementType => typeof(UserTaskElement);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool RL7vGKv9DVk6fnjT0DKg()
		{
			return ndxkn2v9uP8HTGWYFeg8 == null;
		}

		internal static Info xJAU3lv9nYalM9fOqSxX()
		{
			return (Info)ndxkn2v9uP8HTGWYFeg8;
		}
	}

	internal static UserTaskActivity WJ1mFKZdQN5x2OhQJiGB;

	public IInstanceMetricService InstanceMetricService
	{
		[CompilerGenerated]
		get
		{
			return _003CInstanceMetricService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CInstanceMetricService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public UserManager UserManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CUserManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	protected override bool CanInduceIdle => true;

	protected override void ExecuteTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_00de, IL_00ed, IL_0172, IL_0181
		int num = 2;
		int num2 = num;
		IWorkflowInstance instance = default(IWorkflowInstance);
		TaskMarker taskMarker = default(TaskMarker);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 7:
			case 9:
				ContinueOnDefaultConnector(context);
				num2 = 8;
				break;
			case 11:
				return;
			case 10:
				if (hFHlT6ZdAShl5CKCMGAb(FM8YQyZdVj1ZcSK8mOrO(base.Element)) == LoopCheckTime.Before)
				{
					num2 = 14;
					break;
				}
				goto case 7;
			case 2:
				instance = (IWorkflowInstance)ADiG6qZdMRAwm7lCckmJ(this, context);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				return;
			default:
				goto IL_00c8;
			case 3:
				if (hFHlT6ZdAShl5CKCMGAb(FM8YQyZdVj1ZcSK8mOrO(base.Element)) != LoopCheckTime.After)
				{
					num2 = 10;
					break;
				}
				goto case 6;
			case 12:
				MnjJL0ZdUJpXJsp6R8Da(this, context);
				num2 = 11;
				break;
			case 5:
				switch (taskMarker)
				{
				case TaskMarker.Loop:
					break;
				case TaskMarker.None:
					goto IL_00c8;
				default:
					goto IL_013c;
				case TaskMarker.Condition:
					goto IL_018d;
				}
				if (FM8YQyZdVj1ZcSK8mOrO(base.Element) == null)
				{
					num2 = 7;
					break;
				}
				goto case 3;
			case 1:
				taskMarker = wvVeYdZdkAKNXC034mO2(base.Element);
				num2 = 5;
				break;
			case 13:
				return;
			case 6:
				MnjJL0ZdUJpXJsp6R8Da(this, context);
				num2 = 4;
				break;
			case 14:
				{
					if (ConditionHelper.Evaluate((Condition)RwL845ZdGkZw5gdf3lPe(FM8YQyZdVj1ZcSK8mOrO(base.Element)), instance))
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
						{
							num2 = 6;
						}
						break;
					}
					goto case 7;
				}
				IL_018d:
				if (ConditionHelper.Evaluate(base.Element.Condition, instance))
				{
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 7;
				IL_00c8:
				MnjJL0ZdUJpXJsp6R8Da(this, context);
				num2 = 13;
				break;
				IL_013c:
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	protected virtual void ExecuteUserTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_00e5, IL_015b, IL_02d5, IL_0386, IL_03e5, IL_03f4, IL_0550, IL_05f3, IL_0688, IL_06d7, IL_06e6, IL_0779, IL_078c, IL_086c, IL_087b, IL_08b4, IL_09ef, IL_0b1f, IL_0b2e, IL_0b3e, IL_0b4d, IL_0bf8, IL_0c3c
		int num = 25;
		UserTaskElement element = default(UserTaskElement);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		string text = default(string);
		List<FlowConnectorElement>.Enumerator enumerator = default(List<FlowConnectorElement>.Enumerator);
		FlowConnectorElement current = default(FlowConnectorElement);
		ITerminateTaskSchedulerJob terminateTaskSchedulerJob2 = default(ITerminateTaskSchedulerJob);
		ISchedulerTask schedulerTask2 = default(ISchedulerTask);
		ITerminateTaskSchedulerJob terminateTaskSchedulerJob = default(ITerminateTaskSchedulerJob);
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		DateTime? dateTime4 = default(DateTime?);
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		DateTime? dateTime3 = default(DateTime?);
		EventTrigger eventTrigger = default(EventTrigger);
		DateTime? dateTime5 = default(DateTime?);
		IWorkflowTask workflowTask = default(IWorkflowTask);
		int num3 = default(int);
		EleWise.ELMA.Security.Models.IUser[] array = default(EleWise.ELMA.Security.Models.IUser[]);
		string description = default(string);
		bool flag = default(bool);
		bool flag3 = default(bool);
		bool assignedToResponsible = default(bool);
		bool flag2 = default(bool);
		IMessageManager serviceNotNull = default(IMessageManager);
		bool? noReassignAffectsUserReplace = default(bool?);
		bool isLimitExceeded = default(bool);
		EleWise.ELMA.Security.Models.IUser executor = default(EleWise.ELMA.Security.Models.IUser);
		List<EleWise.ELMA.Security.Models.IUser> executorsTasks = default(List<EleWise.ELMA.Security.Models.IUser>);
		bool isAvailableReAssign = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num7;
				switch (num2)
				{
				case 2:
					if (base.Element == null)
					{
						num2 = 29;
						continue;
					}
					goto case 31;
				case 19:
				{
					TextTemplateGenerator textTemplateGenerator = new TextTemplateGenerator((string)xNMc2HZdFWMK4GLNH6ig(element));
					NotificationElement.DataSource dataSource = new NotificationElement.DataSource();
					GjmQiRZdiqDZST4hqRlV(dataSource, workflowInstance);
					Jhg3AXZdaMVMFpFrYX6M(dataSource, ywrvXyZdIAciohUIlPCq(workflowInstance));
					NotificationElement.DataSource dataSourceObject = dataSource;
					text = textTemplateGenerator.Generate(dataSourceObject);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 7;
					}
					continue;
				}
				case 3:
					try
					{
						while (true)
						{
							IL_04c2:
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 11;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
								{
									num4 = 13;
								}
								goto IL_0169;
							}
							goto IL_0279;
							IL_0279:
							current = enumerator.Current;
							num4 = 37;
							goto IL_0169;
							IL_0169:
							while (true)
							{
								int num5;
								DateTime? dateTime2;
								DateTime? dateTime;
								switch (num4)
								{
								case 40:
									terminateTaskSchedulerJob2 = InterfaceActivator.Create<ITerminateTaskSchedulerJob>();
									num4 = 6;
									continue;
								case 28:
									schedulerTask2 = InterfaceActivator.Create<ISchedulerTask>();
									num4 = 3;
									continue;
								case 45:
									gePBp5ZuJJCibTg8HRqf(terminateTaskSchedulerJob, pbVl5lZusMeYL8UyWqqx());
									num4 = 27;
									continue;
								case 23:
									schedulerTask2.Uid = pbVl5lZusMeYL8UyWqqx();
									num4 = 30;
									continue;
								case 36:
									break;
								default:
									iGbpifZuyrXqmjLKvbSH(terminateTaskSchedulerJob, dg4LmiZu0Z5DSV2NdCe9(schedulerTask));
									num4 = 12;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
									{
										num4 = 2;
									}
									continue;
								case 17:
									JGQfGjZuPx0ub5xnlwaK(terminateTaskSchedulerJob, rWw9iLZucHr4hg6MtpfT(current));
									num5 = 14;
									goto IL_0165;
								case 3:
									pdiCbhZu8DdGSF9H456h(schedulerTask2, mPwjHiZuYD6MJo4vvnLx(IFDtNNZuOBd0mJqZeR7d(-683713632 ^ -683809440), new object[3]
									{
										WIbia2ZuZyDRdq6URvga(base.Element),
										workflowInstance.InstanceName(),
										NoMIGbZuvc44C4X93NPi(workflowInstance.Process.Name)
									}));
									num4 = 23;
									continue;
								case 1:
									MGrCihZumcbkQqLThQNa(schedulerTask);
									num4 = 5;
									continue;
								case 31:
									if (dateTime4.HasValue)
									{
										num4 = 34;
										continue;
									}
									goto IL_04c2;
								case 22:
									xM9HqDZulEmYCwGn0g1P(terminateTaskSchedulerJob2, workflowBookmark);
									num4 = 10;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
									{
										num4 = 35;
									}
									continue;
								case 42:
									terminateTaskSchedulerJob = InterfaceActivator.Create<ITerminateTaskSchedulerJob>();
									num4 = 45;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
									{
										num4 = 12;
									}
									continue;
								case 30:
									schedulerTask2.OnceExecuteTime = dateTime3.Value;
									num4 = 19;
									continue;
								case 43:
									if (eventTrigger != EventTrigger.Script)
									{
										num4 = 29;
										continue;
									}
									goto case 20;
								case 15:
									schedulerTask.Name = SR.T((string)IFDtNNZuOBd0mJqZeR7d(-29981480 ^ -30131292), WIbia2ZuZyDRdq6URvga(base.Element), workflowInstance.InstanceName(), NoMIGbZuvc44C4X93NPi(bTS63yZugU45NvKRYLSu(ekwLKmZdh9rAYRlwmfVY(workflowInstance))));
									num4 = 16;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
									{
										num4 = 3;
									}
									continue;
								case 7:
									if (fs7gNuZuKqM6oqGfdH8G(current) != null)
									{
										num4 = 21;
										continue;
									}
									goto case 32;
								case 38:
									MGrCihZumcbkQqLThQNa(schedulerTask2);
									num4 = 18;
									continue;
								case 27:
									xM9HqDZulEmYCwGn0g1P(terminateTaskSchedulerJob, workflowBookmark);
									num4 = 17;
									continue;
								case 2:
									schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
									num4 = 42;
									continue;
								case 5:
								case 8:
								case 18:
								case 29:
								case 44:
									goto IL_04c2;
								case 26:
									if (eventTrigger != EventTrigger.Timer)
									{
										num5 = 43;
										goto IL_0165;
									}
									goto case 7;
								case 10:
									iGbpifZuyrXqmjLKvbSH(terminateTaskSchedulerJob2, dg4LmiZu0Z5DSV2NdCe9(schedulerTask2));
									num4 = 9;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
									{
										num4 = 6;
									}
									continue;
								case 19:
									schedulerTask2.OwnerUid = WorkflowSchedulerTaskOwner.UID;
									num4 = 40;
									continue;
								case 32:
									dateTime2 = DateTime.Now;
									goto IL_0727;
								case 6:
									gePBp5ZuJJCibTg8HRqf(terminateTaskSchedulerJob2, pbVl5lZusMeYL8UyWqqx());
									num4 = 22;
									continue;
								case 34:
									if (!GsSFYUZu5CFnN6KsfW9O(dateTime4.Value, iUeLTSZubiN6BaQbINvD()))
									{
										num4 = 44;
										continue;
									}
									goto case 39;
								case 9:
									schedulerTask2.Jobs.Add((ISchedulerTaskJob)terminateTaskSchedulerJob2);
									num4 = 38;
									continue;
								case 4:
									if (!dateTime3.HasValue)
									{
										num4 = 8;
										continue;
									}
									goto case 28;
								case 14:
									vjbgjXZuXdJopSVq5nrA(terminateTaskSchedulerJob, schedulerTask);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
									{
										num4 = 0;
									}
									continue;
								case 39:
									schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
									num4 = 15;
									continue;
								case 33:
									terminateTaskSchedulerJob2.Task = schedulerTask2;
									num4 = 10;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
									{
										num4 = 7;
									}
									continue;
								case 37:
									eventTrigger = GxDWo8Zdzp9E01D3PL2c(current);
									num4 = 26;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
									{
										num4 = 15;
									}
									continue;
								case 20:
									if (zbARjLZutrXOk61RqVJX(current) != null)
									{
										num4 = 24;
										continue;
									}
									goto case 25;
								case 35:
									terminateTaskSchedulerJob2.ConnectorUid = current.Uid;
									num4 = 33;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
									{
										num4 = 0;
									}
									continue;
								case 41:
									dateTime = dateTime5;
									goto IL_0741;
								case 25:
									dateTime5 = null;
									num4 = 41;
									continue;
								case 11:
									schedulerTask.OnceExecuteTime = dateTime4.Value;
									num4 = 2;
									continue;
								case 16:
									wRqLfEZuBSGTO56BAWP6(schedulerTask, pbVl5lZusMeYL8UyWqqx());
									num4 = 11;
									continue;
								case 12:
									schedulerTask.Jobs.Add((ISchedulerTaskJob)terminateTaskSchedulerJob);
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
									{
										num4 = 1;
									}
									continue;
								case 21:
									dateTime2 = ((IntermediateTimerSettings)fs7gNuZuKqM6oqGfdH8G(current)).GetNextTimerExpiration(workflowInstance);
									goto IL_0727;
								case 24:
									dateTime = ((IntermediateTimerSettings)zbARjLZutrXOk61RqVJX(current)).GetNextTimerExpiration(workflowInstance);
									goto IL_0741;
								case 13:
									return;
									IL_0741:
									dateTime4 = dateTime;
									num4 = 31;
									continue;
									IL_0727:
									dateTime3 = dateTime2;
									num4 = 4;
									continue;
									IL_0165:
									num4 = num5;
									continue;
								}
								break;
							}
							goto IL_0279;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				case 23:
					workflowTask.EndDate = GetEndDate(workflowInstance, (EleWise.ELMA.Security.Models.IUser)CyMHlRZd47BDQrGtTjJP(workflowTask));
					num2 = 41;
					continue;
				case 33:
				case 36:
					if (num3 < array.Length)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 12:
					if (!EXQp66ZdNjrlIQ2JGFTK(element))
					{
						num2 = 18;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
						{
							num2 = 40;
						}
						continue;
					}
					goto case 37;
				case 45:
					workflowTask.Description = description;
					num2 = 20;
					continue;
				case 13:
					return;
				case 8:
					flag = false;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 2;
					}
					continue;
				case 27:
					flag3 = false;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					((IWorkflowTaskBase)workflowTask).AssignedToResponsible = assignedToResponsible;
					num2 = 47;
					continue;
				case 11:
					enumerator = base.Element.ExceptionOutputFlows.GetEnumerator();
					num2 = 3;
					continue;
				case 15:
					flag2 = false;
					num2 = 8;
					continue;
				case 25:
					workflowInstance = (IWorkflowInstance)ADiG6qZdMRAwm7lCckmJ(this, context);
					num2 = 24;
					continue;
				case 28:
					num3 = 0;
					num2 = 36;
					continue;
				case 10:
				case 29:
				case 40:
					if (flag2)
					{
						num = 42;
						break;
					}
					goto case 9;
				case 9:
					workflowTask.Subject = base.Element.Name;
					num2 = 34;
					continue;
				case 22:
					workflowTask.Save();
					num2 = 30;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 30;
					}
					continue;
				case 6:
					p5IpCvZdocJ7hyWWkluX(context, UZWZ06Zd2uysGFEy0AnF(workflowBookmark).ToString(), new BookmarkCallback(OnTaskCompleted));
					num2 = 44;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num2 = 41;
					}
					continue;
				case 17:
				case 48:
					num3++;
					num2 = 33;
					continue;
				case 37:
				{
					TextTemplateGenerator textTemplateGenerator2 = new TextTemplateGenerator((string)yNNyeIZdxMRnP29C152H(element));
					NotificationElement.DataSource dataSource2 = new NotificationElement.DataSource();
					GjmQiRZdiqDZST4hqRlV(dataSource2, workflowInstance);
					Jhg3AXZdaMVMFpFrYX6M(dataSource2, ywrvXyZdIAciohUIlPCq(workflowInstance));
					NotificationElement.DataSource dataSource3 = dataSource2;
					description = (string)gMTcuuZdS3yPvdoKfGmh(textTemplateGenerator2, dataSource3);
					num2 = 45;
					continue;
				}
				case 20:
					flag = true;
					num2 = 10;
					continue;
				case 30:
					serviceNotNull.Delay(workflowTask, DefaultEntityActions.CreateGuid);
					num = 17;
					break;
				case 35:
					num7 = 1;
					goto IL_0c80;
				case 5:
					if (noReassignAffectsUserReplace == flag3)
					{
						num2 = 35;
						continue;
					}
					num7 = (QuxbicZdEbncmsGYuMMA(WorkflowTaskBaseManager.Instance, workflowTask) ? 1 : 0);
					goto IL_0c80;
				case 34:
				case 42:
					oV0fZsZd1vvDPbZiRjxQ((IWorkflowTaskBase)workflowTask, workflowBookmark);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					if (!isLimitExceeded)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 43;
				case 41:
					BPMNActivity<UserTaskElement>.SettingEmulation(workflowTask, workflowInstance);
					num2 = 22;
					continue;
				case 18:
					workflowTask = InterfaceActivator.Create<IWorkflowTask>();
					num2 = 15;
					continue;
				default:
					executor = array[num3];
					num2 = 18;
					continue;
				case 46:
					if (!AssignExecutor(workflowTask, executor, executorsTasks, isAvailableReAssign))
					{
						num2 = 48;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 14;
				case 43:
					CreateLimitComment(workflowTask);
					num2 = 39;
					continue;
				case 4:
				case 39:
					workflowTask.PlanWorkLog = GetPlanWorkLog(workflowInstance, (EleWise.ELMA.Security.Models.IUser)CyMHlRZd47BDQrGtTjJP(workflowTask));
					num2 = 23;
					continue;
				case 32:
					flag2 = true;
					num = 12;
					break;
				case 26:
					if (element.FormingTemplateName)
					{
						num2 = 19;
						continue;
					}
					goto case 12;
				case 47:
					noReassignAffectsUserReplace = ((IWorkflowProcess)ekwLKmZdh9rAYRlwmfVY(workflowInstance)).NoReassignAffectsUserReplace;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 27;
					}
					continue;
				case 24:
					workflowBookmark = (IWorkflowBookmark)XaAqLHZd75cBsgRYk22v(this, workflowInstance);
					num2 = 6;
					continue;
				case 21:
					eBPBQ5Zdwr17q4HrHAfo(workflowTask, base.Element.Description);
					num2 = 42;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 46;
					}
					continue;
				case 31:
					element = base.Element;
					num2 = 26;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 25;
					}
					continue;
				case 16:
					if (!flag)
					{
						num2 = 21;
						continue;
					}
					goto case 46;
				case 44:
				{
					EleWise.ELMA.Security.Models.IUser[] swimlaneExecutors = GetSwimlaneExecutors(context, out assignedToResponsible, out isLimitExceeded);
					serviceNotNull = Locator.GetServiceNotNull<IMessageManager>();
					executorsTasks = new List<EleWise.ELMA.Security.Models.IUser>();
					array = swimlaneExecutors;
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num2 = 28;
					}
					continue;
				}
				case 7:
					{
						workflowTask.Subject = (string)(Lp2NxwZdrudxwBCLh53f(text) ? OB5C3VZdeLGZVOMU7Mi7() : text);
						num2 = 32;
						continue;
					}
					IL_0c80:
					isAvailableReAssign = (byte)num7 != 0;
					num2 = 16;
					continue;
				}
				break;
			}
		}
	}

	private DateTime? GetEndDate(IWorkflowInstance instance, EleWise.ELMA.Security.Models.IUser executor)
	{
		DateTime? result = ((base.Element.LimitByTime && base.Element.TimeOfExecution != null) ? base.Element.TimeOfExecution.Evaluate(instance, executor) : null);
		if (result.HasValue && result.Value <= DateTime.Now)
		{
			result = DateTime.Now.AddMinutes(30.0);
		}
		return result;
	}

	private WorkTime? GetPlanWorkLog(IWorkflowInstance instance, EleWise.ELMA.Security.Models.IUser executor)
	{
		if (!base.Element.LimitByWorkLogTime || base.Element.WorkLogTimeOfExecution == null)
		{
			return null;
		}
		return base.Element.WorkLogTimeOfExecution.Evaluate(instance, executor);
	}

	private void CreateLimitComment(IWorkflowTask task)
	{
		int num = 6;
		IComment comment = default(IComment);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					comment.CreationDate = iUeLTSZubiN6BaQbINvD();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					HDTckOZuDnDarv72Bjjq(comment, PWMjaiZuujMCP0sYyvFR(task));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					y8wd3BZudKL6NYbw6oVg(comment, SR.T((string)IFDtNNZuOBd0mJqZeR7d(-2111219045 ^ -2111071567)));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					MGrCihZumcbkQqLThQNa(comment);
					num2 = 2;
					continue;
				case 4:
					return;
				case 2:
					task.Comments.Add(comment);
					num2 = 4;
					continue;
				case 6:
					break;
				}
				break;
			}
			comment = InterfaceActivator.Create<IComment>();
			num = 5;
		}
	}

	protected virtual void ExecuteUserTaskScript(NativeActivityContext context, WorkflowTaskTerminateData terminateData)
	{
		//Discarded unreachable code: IL_00bf, IL_00ce, IL_01f0, IL_0411, IL_0451, IL_0460, IL_046c, IL_047b
		int num = 6;
		int num2 = num;
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		IEnumerator<FlowConnectorElement> enumerator = default(IEnumerator<FlowConnectorElement>);
		FlowConnectorElement current = default(FlowConnectorElement);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		EventTrigger eventTrigger = default(EventTrigger);
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		DateTime? dateTime = default(DateTime?);
		ITerminateTaskSchedulerJob terminateTaskSchedulerJob = default(ITerminateTaskSchedulerJob);
		DateTime? dateTime2 = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 4:
				workflowBookmark = (IWorkflowBookmark)emdnwEZunGtGSUbp4Rf5(_003C_003Ec__DisplayClass14_.terminateData);
				num2 = 2;
				break;
			case 2:
				context.CreateBookmark(UZWZ06Zd2uysGFEy0AnF(workflowBookmark).ToString(), OnTaskCompleted);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
							{
								num3 = 0;
							}
							goto IL_00dd;
						}
						goto IL_017f;
						IL_017f:
						current = enumerator.Current;
						num3 = 11;
						goto IL_00dd;
						IL_00dd:
						while (true)
						{
							DateTime? dateTime3;
							int num4;
							switch (num3)
							{
							case 1:
								return;
							case 8:
								if (zbARjLZutrXOk61RqVJX(current) == null)
								{
									num3 = 13;
									continue;
								}
								dateTime3 = ((IntermediateTimerSettings)zbARjLZutrXOk61RqVJX(current)).GetNextTimerExpiration(workflowInstance);
								goto IL_03cf;
							case 2:
								break;
							case 4:
								goto IL_017f;
							case 6:
								if (eventTrigger == EventTrigger.Script)
								{
									num3 = 8;
									continue;
								}
								break;
							case 14:
								schedulerTask.OnceExecuteTime = dateTime.Value;
								num4 = 15;
								goto IL_00d9;
							case 5:
								schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
								num3 = 22;
								continue;
							case 12:
								vjbgjXZuXdJopSVq5nrA(terminateTaskSchedulerJob, schedulerTask);
								num3 = 3;
								continue;
							case 7:
								dateTime3 = dateTime2;
								goto IL_03cf;
							case 16:
								gePBp5ZuJJCibTg8HRqf(terminateTaskSchedulerJob, pbVl5lZusMeYL8UyWqqx());
								num3 = 10;
								continue;
							default:
								if (dateTime.HasValue)
								{
									num3 = 19;
									continue;
								}
								break;
							case 20:
								wRqLfEZuBSGTO56BAWP6(schedulerTask, Guid.NewGuid());
								num3 = 14;
								continue;
							case 18:
								JGQfGjZuPx0ub5xnlwaK(terminateTaskSchedulerJob, rWw9iLZucHr4hg6MtpfT(current));
								num3 = 12;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
								{
									num3 = 1;
								}
								continue;
							case 10:
								xM9HqDZulEmYCwGn0g1P(terminateTaskSchedulerJob, workflowBookmark);
								num3 = 18;
								continue;
							case 11:
								eventTrigger = GxDWo8Zdzp9E01D3PL2c(current);
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
								{
									num3 = 6;
								}
								continue;
							case 22:
								schedulerTask.Name = (string)mPwjHiZuYD6MJo4vvnLx(IFDtNNZuOBd0mJqZeR7d(-495296780 ^ -495411276), new object[3]
								{
									WIbia2ZuZyDRdq6URvga(base.Element),
									Hwp6fyZuHbiZL2FIKihn(workflowInstance),
									NoMIGbZuvc44C4X93NPi(bTS63yZugU45NvKRYLSu(ekwLKmZdh9rAYRlwmfVY(workflowInstance)))
								});
								num3 = 20;
								continue;
							case 21:
								schedulerTask.Jobs.Add((ISchedulerTaskJob)terminateTaskSchedulerJob);
								num3 = 9;
								continue;
							case 15:
								schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
								num3 = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
								{
									num3 = 17;
								}
								continue;
							case 13:
								dateTime2 = null;
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
								{
									num3 = 7;
								}
								continue;
							case 19:
								if (dateTime.Value > iUeLTSZubiN6BaQbINvD())
								{
									num3 = 5;
									continue;
								}
								break;
							case 9:
								schedulerTask.Save();
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
								{
									num3 = 2;
								}
								continue;
							case 3:
								iGbpifZuyrXqmjLKvbSH(terminateTaskSchedulerJob, dg4LmiZu0Z5DSV2NdCe9(schedulerTask));
								num3 = 21;
								continue;
							case 17:
								{
									terminateTaskSchedulerJob = InterfaceActivator.Create<ITerminateTaskSchedulerJob>();
									num4 = 16;
									goto IL_00d9;
								}
								IL_00d9:
								num3 = num4;
								continue;
								IL_03cf:
								dateTime = dateTime3;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
						{
							num5 = 0;
						}
						goto IL_0415;
					}
					goto IL_042b;
					IL_042b:
					enumerator.Dispose();
					num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num5 = 1;
					}
					goto IL_0415;
					IL_0415:
					switch (num5)
					{
					default:
						goto end_IL_03f0;
					case 2:
						break;
					case 0:
						goto end_IL_03f0;
					case 1:
						goto end_IL_03f0;
					}
					goto IL_042b;
					end_IL_03f0:;
				}
			case 5:
				_003C_003Ec__DisplayClass14_.terminateData = terminateData;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
				{
					num2 = 7;
				}
				break;
			case 7:
				workflowInstance = (IWorkflowInstance)ADiG6qZdMRAwm7lCckmJ(this, context);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				enumerator = base.Element.ExceptionOutputFlows.Where(_003C_003Ec__DisplayClass14_._003CExecuteUserTaskScript_003Eb__0).GetEnumerator();
				num2 = 3;
				break;
			}
		}
	}

	protected void OnTaskCompleted(NativeActivityContext context, Bookmark bookmark, object state)
	{
		//Discarded unreachable code: IL_00e6, IL_00f0, IL_01b1, IL_01e9, IL_01f3, IL_0291, IL_02c7, IL_031a, IL_032d, IL_033c, IL_03da, IL_041c, IL_04ed, IL_04fc, IL_0679, IL_0806, IL_0839, IL_08ab, IL_08f7, IL_0918, IL_0ac2, IL_0b1d, IL_0b55, IL_0b64
		int num = 35;
		List<PropertyMetadata>.Enumerator enumerator2 = default(List<PropertyMetadata>.Enumerator);
		bool flag = default(bool);
		ProcessInstanceMetric processInstanceMetric = default(ProcessInstanceMetric);
		Guid? selectedProcessTaskUid = default(Guid?);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		TimeSpan? time = default(TimeSpan?);
		Guid uid = default(Guid);
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		WorkflowTaskTerminateData workflowTaskTerminateData = default(WorkflowTaskTerminateData);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IWorkflowTask task = default(IWorkflowTask);
		FlowConnectorElement flowConnectorElement2 = default(FlowConnectorElement);
		TaskActionEventArgs taskActionEventArgs = default(TaskActionEventArgs);
		bool flag2 = default(bool);
		IEnumerator<ITaskBase> enumerator = default(IEnumerator<ITaskBase>);
		IEnumerable<ITaskBase> tasks = default(IEnumerable<ITaskBase>);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		ITaskBase current = default(ITaskBase);
		IEnumerable<EleWise.ELMA.Security.Models.IUser> recipientsForNotification = default(IEnumerable<EleWise.ELMA.Security.Models.IUser>);
		EleWise.ELMA.Security.Models.IUser currentExecutor = default(EleWise.ELMA.Security.Models.IUser);
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 40:
					try
					{
						while (true)
						{
							IL_01fd:
							int num8;
							if (!enumerator2.MoveNext())
							{
								num8 = 8;
								goto IL_00f4;
							}
							goto IL_01bb;
							IL_00f4:
							while (true)
							{
								switch (num8)
								{
								default:
									flag = true;
									num8 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
									{
										num8 = 1;
									}
									continue;
								case 3:
									if (wNx8SQZuoWbcb4NgvKIW(processInstanceMetric) == ProcessMetricComputationType.Time)
									{
										num8 = 7;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
										{
											num8 = 2;
										}
										continue;
									}
									goto IL_01fd;
								case 7:
									if (GR78x5ZuF4g54yaDwEnU(processInstanceMetric) == ProcessMetricTimeCalculationType.TaskExecutionTime)
									{
										num8 = 10;
										continue;
									}
									goto IL_01fd;
								case 10:
									selectedProcessTaskUid = processInstanceMetric.SelectedProcessTaskUid;
									num8 = 9;
									continue;
								case 6:
									break;
								case 1:
								case 12:
								case 14:
									goto IL_01fd;
								case 11:
									InstanceMetricService.UpdateWithExecutionTime(workflowInstance, processInstanceMetric, time);
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
									{
										num8 = 0;
									}
									continue;
								case 13:
									if (!VOxg9wZu2hdTrq3DLsVe(processInstanceMetric))
									{
										num8 = 14;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
										{
											num8 = 2;
										}
										continue;
									}
									goto case 3;
								case 9:
									uid = base.Element.Uid;
									num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
									{
										num8 = 5;
									}
									continue;
								case 15:
									if (selectedProcessTaskUid.HasValue)
									{
										num8 = 2;
										continue;
									}
									goto case 4;
								case 5:
									if (selectedProcessTaskUid.HasValue)
									{
										num8 = 15;
										continue;
									}
									goto IL_01fd;
								case 2:
									if (!(selectedProcessTaskUid.GetValueOrDefault() == uid))
									{
										goto IL_01fd;
									}
									goto case 4;
								case 4:
									num8 = 11;
									continue;
								case 8:
									goto end_IL_01fd;
								}
								break;
							}
							goto IL_01bb;
							IL_01bb:
							processInstanceMetric = (ProcessInstanceMetric)enumerator2.Current;
							num8 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
							{
								num8 = 13;
							}
							goto IL_00f4;
							continue;
							end_IL_01fd:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num9 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
						{
							num9 = 0;
						}
						switch (num9)
						{
						case 0:
							break;
						}
					}
					goto case 20;
				case 19:
					if (_003C_003Ec__DisplayClass15_.executeData == null)
					{
						num2 = 30;
						continue;
					}
					goto case 11;
				case 2:
					ContinueOnConnector(context, workflowTaskTerminateData.ConnectorUid);
					num = 10;
					break;
				case 28:
					obj = new EntityActionEventArgs(null, _003C_003Ec__DisplayClass15_.executeData.Task, TaskBaseActions.CompleteGuid);
					YU08N8Zujn6abTI9VLlA(obj, Y0UOE0ZuWajcG9LB0UYX(_003C_003Ec__DisplayClass15_.executeData));
					goto IL_0c41;
				case 11:
					((ITaskBase)FnXlOEZufbJpOKTlvTOh(_003C_003Ec__DisplayClass15_.executeData)).Status = (TaskBaseStatus)yShph6Zu9voLVWWAXOq2();
					num2 = 39;
					continue;
				case 3:
					enumerator2 = entityMetadata.Properties.GetEnumerator();
					num2 = 40;
					continue;
				default:
					if (entityMetadata != null)
					{
						num2 = 31;
						continue;
					}
					goto case 24;
				case 38:
					workflowTaskTerminateData = state as WorkflowTaskTerminateData;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
					{
						num2 = 8;
					}
					continue;
				case 41:
					MnjJL0ZdUJpXJsp6R8Da(this, context);
					num2 = 7;
					continue;
				case 34:
					e99rvfZuLn3S5S12n32t(state, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351279298));
					num2 = 38;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
					{
						num2 = 35;
					}
					continue;
				case 6:
					if (FM8YQyZdVj1ZcSK8mOrO(base.Element) == null)
					{
						num2 = 47;
						continue;
					}
					goto case 5;
				case 8:
					_003C_003Ec__DisplayClass15_.executeData = state as WorkflowTaskExecuteData;
					num2 = 23;
					continue;
				case 26:
					task = _003C_003Ec__DisplayClass15_.executeData.Task.CastAs<IWorkflowTask>();
					num2 = 48;
					continue;
				case 31:
					if (PGrx9WZu7gKbR36VwkCX(entityMetadata.Properties) == 0)
					{
						num2 = 24;
						continue;
					}
					goto case 15;
				case 13:
					J6GR0DZuIMC68HyNxSki(IrvgmAZuivUG9jbeKfSx(workflowInstance));
					num2 = 27;
					continue;
				case 20:
					if (!flag)
					{
						num = 44;
						break;
					}
					goto case 13;
				case 32:
					flowConnectorElement2 = miwKx8ZupPpZMT5vanOK(qTpUgbZuQqrMxxfyiena(base.Diagram), workflowTaskTerminateData.ConnectorUid) as FlowConnectorElement;
					num2 = 16;
					continue;
				case 17:
					time = ((IntermediateTimerSettings)fs7gNuZuKqM6oqGfdH8G(flowConnectorElement2)).RelativeTimeValue;
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
					{
						num2 = 4;
					}
					continue;
				case 48:
					Locator.GetServiceNotNull<WorkflowTaskManager>().Assign(task);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num2 = 18;
					}
					continue;
				case 46:
					taskActionEventArgs.ActionAuthor = (EleWise.ELMA.Security.IUser)Y0UOE0ZuWajcG9LB0UYX(_003C_003Ec__DisplayClass15_.executeData);
					num2 = 42;
					continue;
				case 43:
					flag2 = false;
					num2 = 36;
					continue;
				case 35:
					_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
					num2 = 34;
					continue;
				case 7:
					return;
				case 47:
					ContinueOnConnector(context, qKKlQDZuTI2tJy8gNNj1(_003C_003Ec__DisplayClass15_.executeData));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
					{
						num2 = 21;
					}
					continue;
				case 9:
					entityMetadata = (EntityMetadata)yBPMucZuGm7AjAcSdq7S(IY7GQoZuAJVkmAyej9VZ(), ekwLKmZdh9rAYRlwmfVY(workflowInstance));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 0;
					}
					continue;
				case 23:
					workflowInstance = (IWorkflowInstance)ADiG6qZdMRAwm7lCckmJ(this, context);
					num = 19;
					break;
				case 39:
					((IEntity)FnXlOEZufbJpOKTlvTOh(_003C_003Ec__DisplayClass15_.executeData)).Save();
					num2 = 45;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 16;
					}
					continue;
				case 21:
					return;
				case 30:
					if (workflowTaskTerminateData != null)
					{
						num2 = 32;
						continue;
					}
					throw new InvalidOperationException((string)aDvyu2ZuhTqSk5sEb2vq(IFDtNNZuOBd0mJqZeR7d(-14356676 ^ -14275278), state.GetType().FullName));
				case 4:
					enumerator = tasks.GetEnumerator();
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 17;
					}
					continue;
				case 5:
					if (ConditionHelper.Evaluate(((LoopCondition)FM8YQyZdVj1ZcSK8mOrO(base.Element)).Condition, workflowInstance))
					{
						num2 = 41;
						continue;
					}
					goto case 47;
				case 16:
					if (GxDWo8Zdzp9E01D3PL2c(flowConnectorElement2) == EventTrigger.Script)
					{
						num2 = 43;
						continue;
					}
					goto case 33;
				case 18:
					if (wvVeYdZdkAKNXC034mO2(base.Element) == TaskMarker.Loop)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 47;
				case 12:
					if (flag2)
					{
						num2 = 33;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 25;
				case 1:
					if (flowConnectorElement != null)
					{
						taskActionEventArgs = new TaskActionEventArgs(null, (IEntity)FnXlOEZufbJpOKTlvTOh(_003C_003Ec__DisplayClass15_.executeData), IRafXtZuRPgjixMfn4Z3());
						num2 = 46;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
						{
							num2 = 12;
						}
					}
					else
					{
						num2 = 28;
					}
					continue;
				case 25:
					wBiEv7ZuVRrtaAa8IQ8T(this, context, workflowTaskTerminateData);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
					{
						num2 = 14;
					}
					continue;
				case 10:
					return;
				case 36:
					try
					{
						flag2 = (bool)((IWorkflowScriptingService)rpll8hZuCmpjSSDBGd4I(this)).ExecuteScript(workflowInstance, (string)kdPhGQZuMoOW4JuLZm00(flowConnectorElement2), (Dictionary<string, object>)null, (Func<string, Type, object>)null);
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num7 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							case 1:
								bxQxbCZuUbV9bjp7PKVc(Up4UTxZuk5sAsVdCjLgO(IFDtNNZuOBd0mJqZeR7d(-1895853023 ^ -1896000125)), SR.T((string)IFDtNNZuOBd0mJqZeR7d(0x614274E3 ^ 0x6140B55B)), ex);
								num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
								{
									num7 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 12;
				case 45:
					flowConnectorElement = base.Element.StandardOutputFlows.FirstOrDefault(_003C_003Ec__DisplayClass15_._003COnTaskCompleted_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					flag = false;
					num = 3;
					break;
				case 22:
					try
					{
						while (true)
						{
							IL_0acc:
							int num4;
							if (!bUGvMcZuSX0WYR9WfuRT(enumerator))
							{
								int num3 = 3;
								num4 = num3;
								goto IL_0926;
							}
							goto IL_0a5e;
							IL_0926:
							while (true)
							{
								switch (num4)
								{
								case 5:
								{
									IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
									EntityActionEventArgs entityActionEventArgs2 = new EntityActionEventArgs(null, current, JkUPHSZuaITV7iHA73eS());
									entityActionEventArgs2.ExtendedProperties[(string)IFDtNNZuOBd0mJqZeR7d(0x63D6C913 ^ 0x63D68F95)] = current.Id;
									entityActionEventArgs2.ExtendedProperties[(string)IFDtNNZuOBd0mJqZeR7d(-708128192 ^ -708143922)] = I8evj6ZurPN1WhbFkTop(workflowInstance);
									entityActionEventArgs2.ExtendedProperties[(string)IFDtNNZuOBd0mJqZeR7d(-2077784392 ^ -2077826378)] = vaKcWgZue6yhNdfwtnmE(current);
									entityActionEventArgs2.ExtendedProperties[(string)IFDtNNZuOBd0mJqZeR7d(-2122743969 ^ -2122768025)] = ekwLKmZdh9rAYRlwmfVY(workflowInstance);
									entityActionEventArgs2.ExtendedProperties[(string)IFDtNNZuOBd0mJqZeR7d(-2122743969 ^ -2122835139)] = recipientsForNotification.ConcatIfNotNull(currentExecutor);
									ONVkXQZu37aa3RqskABO(serviceNotNull, entityActionEventArgs2);
									num4 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
									{
										num4 = 1;
									}
									continue;
								}
								case 1:
									if (!Si6sIUZuNG7BP4SFU9QT(current))
									{
										num4 = 6;
										continue;
									}
									goto case 7;
								case 8:
									break;
								case 2:
									currentExecutor = GetCurrentExecutor(current, flowConnectorElement2);
									num4 = 5;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
									{
										num4 = 5;
									}
									continue;
								case 7:
									m6Di96ZuxDA2r2bqPoyp(current, TaskBaseStatus.WasClosed);
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
									{
										num4 = 0;
									}
									continue;
								case 4:
								case 6:
									goto IL_0acc;
								default:
									current.Save();
									num4 = 4;
									continue;
								case 3:
									goto end_IL_0acc;
								}
								break;
							}
							goto IL_0a5e;
							IL_0a5e:
							current = enumerator.Current;
							num4 = 2;
							goto IL_0926;
							continue;
							end_IL_0acc:
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									TGFKhXZu1E6kVch3E15t(enumerator);
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
									{
										num5 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
					goto case 2;
				case 24:
				case 27:
				case 44:
				{
					IActivityEscalationNotifyService serviceNotNull2 = Locator.GetServiceNotNull<IActivityEscalationNotifyService>();
					tasks = GetTasks(workflowTaskTerminateData.Bookmark);
					recipientsForNotification = serviceNotNull2.GetRecipientsForNotification(new GetRecipientsParameters(this, workflowInstance, flowConnectorElement2));
					num = 4;
					break;
				}
				case 29:
					ONVkXQZu37aa3RqskABO(base.ActionHandler, entityActionEventArgs);
					num2 = 26;
					continue;
				case 14:
					return;
				case 33:
					if (GxDWo8Zdzp9E01D3PL2c(flowConnectorElement2) == EventTrigger.Timer)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 24;
				case 42:
					taskActionEventArgs.Caption = SR.T((string)IFDtNNZuOBd0mJqZeR7d(-106528299 ^ -106547359), (!hIBYywZu6QivaS6MLpUj(WIbia2ZuZyDRdq6URvga(flowConnectorElement))) ? WIbia2ZuZyDRdq6URvga(flowConnectorElement) : WIbia2ZuZyDRdq6URvga(lYjahyZuqofyetDIhXty(flowConnectorElement)));
					num2 = 37;
					continue;
				case 37:
					{
						obj = taskActionEventArgs;
						goto IL_0c41;
					}
					IL_0c41:
					entityActionEventArgs = (EntityActionEventArgs)obj;
					num2 = 29;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	protected virtual IEnumerable<ITaskBase> GetTasks(IWorkflowBookmark bookmark)
	{
		return Locator.GetServiceNotNull<WorkflowTaskBaseManager>().GetTasks(bookmark);
	}

	public UserTaskActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		N5xKDZZuEO2RCdkHbbpN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool FWqnxtZdp7AmjZlfe3Jp()
	{
		return WJ1mFKZdQN5x2OhQJiGB == null;
	}

	internal static UserTaskActivity eFE55FZdChU1KbEKd1bH()
	{
		return WJ1mFKZdQN5x2OhQJiGB;
	}

	internal static object ADiG6qZdMRAwm7lCckmJ(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static TaskMarker wvVeYdZdkAKNXC034mO2(object P_0)
	{
		return ((TaskElement)P_0).Marker;
	}

	internal static void MnjJL0ZdUJpXJsp6R8Da(object P_0, object P_1)
	{
		((UserTaskActivity)P_0).ExecuteUserTask((NativeActivityContext)P_1);
	}

	internal static object FM8YQyZdVj1ZcSK8mOrO(object P_0)
	{
		return ((TaskElement)P_0).LoopCondition;
	}

	internal static LoopCheckTime hFHlT6ZdAShl5CKCMGAb(object P_0)
	{
		return ((LoopCondition)P_0).CheckTime;
	}

	internal static object RwL845ZdGkZw5gdf3lPe(object P_0)
	{
		return ((LoopCondition)P_0).Condition;
	}

	internal static object XaAqLHZd75cBsgRYk22v(object P_0, object P_1)
	{
		return ((BPMNActivity<UserTaskElement>)P_0).CreateBookmark((IWorkflowInstance)P_1);
	}

	internal static Guid UZWZ06Zd2uysGFEy0AnF(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Uid;
	}

	internal static object p5IpCvZdocJ7hyWWkluX(object P_0, object P_1, object P_2)
	{
		return ((NativeActivityContext)P_0).CreateBookmark((string)P_1, (BookmarkCallback)P_2);
	}

	internal static object xNMc2HZdFWMK4GLNH6ig(object P_0)
	{
		return ((UserTaskElement)P_0).TemplateName;
	}

	internal static void GjmQiRZdiqDZST4hqRlV(object P_0, object P_1)
	{
		((NotificationElement.DataSource)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static object ywrvXyZdIAciohUIlPCq(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static void Jhg3AXZdaMVMFpFrYX6M(object P_0, object P_1)
	{
		((NotificationElement.DataSource)P_0).Context = P_1;
	}

	internal static bool Lp2NxwZdrudxwBCLh53f(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object OB5C3VZdeLGZVOMU7Mi7()
	{
		return SR.Untitled;
	}

	internal static bool EXQp66ZdNjrlIQ2JGFTK(object P_0)
	{
		return ((UserTaskElement)P_0).FormingTemplateDescription;
	}

	internal static object yNNyeIZdxMRnP29C152H(object P_0)
	{
		return ((Element)P_0).Description;
	}

	internal static object gMTcuuZdS3yPvdoKfGmh(object P_0, object P_1)
	{
		return ((TextGenerator)P_0).Generate(P_1);
	}

	internal static void oV0fZsZd1vvDPbZiRjxQ(object P_0, object P_1)
	{
		((IWorkflowTaskBase)P_0).WorkflowBookmark = (IWorkflowBookmark)P_1;
	}

	internal static object ekwLKmZdh9rAYRlwmfVY(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static bool QuxbicZdEbncmsGYuMMA(object P_0, object P_1)
	{
		return ((WorkflowTaskBaseManager)P_0).IsAvailableReAssign((ITaskBase)P_1);
	}

	internal static void eBPBQ5Zdwr17q4HrHAfo(object P_0, object P_1)
	{
		((ITaskBase)P_0).Description = (string)P_1;
	}

	internal static object CyMHlRZd47BDQrGtTjJP(object P_0)
	{
		return ((ITaskBase)P_0).Executor;
	}

	internal static EventTrigger GxDWo8Zdzp9E01D3PL2c(object P_0)
	{
		return ((FlowConnectorElement)P_0).Trigger;
	}

	internal static object fs7gNuZuKqM6oqGfdH8G(object P_0)
	{
		return ((FlowConnectorElement)P_0).TimerSettings;
	}

	internal static object IFDtNNZuOBd0mJqZeR7d(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WIbia2ZuZyDRdq6URvga(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object NoMIGbZuvc44C4X93NPi(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object mPwjHiZuYD6MJo4vvnLx(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void pdiCbhZu8DdGSF9H456h(object P_0, object P_1)
	{
		((ISchedulerTask)P_0).Name = (string)P_1;
	}

	internal static Guid pbVl5lZusMeYL8UyWqqx()
	{
		return Guid.NewGuid();
	}

	internal static void gePBp5ZuJJCibTg8HRqf(object P_0, Guid P_1)
	{
		((ISchedulerTaskJob)P_0).Uid = P_1;
	}

	internal static void xM9HqDZulEmYCwGn0g1P(object P_0, object P_1)
	{
		((ITerminateTaskSchedulerJob)P_0).WorkflowBookmark = (IWorkflowBookmark)P_1;
	}

	internal static object dg4LmiZu0Z5DSV2NdCe9(object P_0)
	{
		return ((ISchedulerTask)P_0).Name;
	}

	internal static void iGbpifZuyrXqmjLKvbSH(object P_0, object P_1)
	{
		((ISchedulerTaskJob)P_0).Name = (string)P_1;
	}

	internal static void MGrCihZumcbkQqLThQNa(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object zbARjLZutrXOk61RqVJX(object P_0)
	{
		return ((FlowConnectorElement)P_0).TimerScriptEscalation;
	}

	internal static DateTime iUeLTSZubiN6BaQbINvD()
	{
		return DateTime.Now;
	}

	internal static bool GsSFYUZu5CFnN6KsfW9O(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static object bTS63yZugU45NvKRYLSu(object P_0)
	{
		return ((IWorkflowProcess)P_0).Name;
	}

	internal static void wRqLfEZuBSGTO56BAWP6(object P_0, Guid P_1)
	{
		((ISchedulerTask)P_0).Uid = P_1;
	}

	internal static Guid rWw9iLZucHr4hg6MtpfT(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void JGQfGjZuPx0ub5xnlwaK(object P_0, Guid value)
	{
		((ITerminateTaskSchedulerJob)P_0).ConnectorUid = value;
	}

	internal static void vjbgjXZuXdJopSVq5nrA(object P_0, object P_1)
	{
		((ISchedulerTaskJob)P_0).Task = (ISchedulerTask)P_1;
	}

	internal static void y8wd3BZudKL6NYbw6oVg(object P_0, object P_1)
	{
		((IComment)P_0).Text = (string)P_1;
	}

	internal static object PWMjaiZuujMCP0sYyvFR(object P_0)
	{
		return ((ITaskBase)P_0).CreationAuthor;
	}

	internal static void HDTckOZuDnDarv72Bjjq(object P_0, object P_1)
	{
		((IComment)P_0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static object emdnwEZunGtGSUbp4Rf5(object P_0)
	{
		return ((WorkflowTaskTerminateData)P_0).Bookmark;
	}

	internal static object Hwp6fyZuHbiZL2FIKihn(object P_0)
	{
		return ((IWorkflowInstance)P_0).InstanceName();
	}

	internal static void e99rvfZuLn3S5S12n32t(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object FnXlOEZufbJpOKTlvTOh(object P_0)
	{
		return ((WorkflowTaskExecuteData)P_0).Task;
	}

	internal static object yShph6Zu9voLVWWAXOq2()
	{
		return TaskBaseStatus.Complete;
	}

	internal static object Y0UOE0ZuWajcG9LB0UYX(object P_0)
	{
		return ((WorkflowTaskExecuteData)P_0).Executor;
	}

	internal static void YU08N8Zujn6abTI9VLlA(object P_0, object P_1)
	{
		((EntityActionEventArgs)P_0).ActionAuthor = (EleWise.ELMA.Security.IUser)P_1;
	}

	internal static Guid IRafXtZuRPgjixMfn4Z3()
	{
		return TaskBaseActions.CompleteGuid;
	}

	internal static bool hIBYywZu6QivaS6MLpUj(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object lYjahyZuqofyetDIhXty(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static void ONVkXQZu37aa3RqskABO(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static Guid qKKlQDZuTI2tJy8gNNj1(object P_0)
	{
		return ((WorkflowTaskExecuteData)P_0).ConnectorUid;
	}

	internal static object qTpUgbZuQqrMxxfyiena(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object miwKx8ZupPpZMT5vanOK(object P_0, Guid P_1)
	{
		return ((ElementList)P_0)[P_1];
	}

	internal static object rpll8hZuCmpjSSDBGd4I(object P_0)
	{
		return ((BPMNActivity<UserTaskElement>)P_0).WorkflowScriptingService;
	}

	internal static object kdPhGQZuMoOW4JuLZm00(object P_0)
	{
		return ((FlowConnectorElement)P_0).ScriprEscalation;
	}

	internal static object Up4UTxZuk5sAsVdCjLgO(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}

	internal static void bxQxbCZuUbV9bjp7PKVc(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void wBiEv7ZuVRrtaAa8IQ8T(object P_0, object P_1, object P_2)
	{
		((UserTaskActivity)P_0).ExecuteUserTaskScript((NativeActivityContext)P_1, (WorkflowTaskTerminateData)P_2);
	}

	internal static object IY7GQoZuAJVkmAyej9VZ()
	{
		return WorkflowInstanceContextService.Instance;
	}

	internal static object yBPMucZuGm7AjAcSdq7S(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceMetricValuesMetadata((IWorkflowProcess)P_1);
	}

	internal static int PGrx9WZu7gKbR36VwkCX(object P_0)
	{
		return ((List<PropertyMetadata>)P_0).Count;
	}

	internal static bool VOxg9wZu2hdTrq3DLsVe(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).Active;
	}

	internal static ProcessMetricComputationType wNx8SQZuoWbcb4NgvKIW(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).Type;
	}

	internal static ProcessMetricTimeCalculationType GR78x5ZuF4g54yaDwEnU(object P_0)
	{
		return ((ProcessInstanceMetric)P_0).TimeMetricCalculationType;
	}

	internal static object IrvgmAZuivUG9jbeKfSx(object P_0)
	{
		return ((IWorkflowInstance)P_0).MetricValues;
	}

	internal static void J6GR0DZuIMC68HyNxSki(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static Guid JkUPHSZuaITV7iHA73eS()
	{
		return WorkflowTaskBaseActions.EscalationGuid;
	}

	internal static object I8evj6ZurPN1WhbFkTop(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static object vaKcWgZue6yhNdfwtnmE(object P_0)
	{
		return ((ITaskBase)P_0).Subject;
	}

	internal static bool Si6sIUZuNG7BP4SFU9QT(object P_0)
	{
		return ((ITaskBase)P_0).IsActive();
	}

	internal static void m6Di96ZuxDA2r2bqPoyp(object P_0, object P_1)
	{
		((ITaskBase)P_0).Status = (TaskBaseStatus)P_1;
	}

	internal static bool bUGvMcZuSX0WYR9WfuRT(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void TGFKhXZu1E6kVch3E15t(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object aDvyu2ZuhTqSk5sEb2vq(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void N5xKDZZuEO2RCdkHbbpN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
