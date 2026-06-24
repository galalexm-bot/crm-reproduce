using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;
using EleWise.ELMA.Workflow.Diagrams.Activities.Helpers;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.SubProcess;

public abstract class SubProcessActivity<TElement> : BPMNActivity<TElement>, ISubProcessActivityNotificationRecipients, IActivityNotificationRecipientsByExecutors, IActivityNotificationRecipients where TElement : SubProcessElement
{
	private static object Cv76LuZg6LrdUuw439vd;

	public WorkflowInstanceManager WorkflowInstanceManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceManager_003Ek__BackingField;
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
					_003CWorkflowInstanceManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowProcessManager WorkflowProcessManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowProcessManager_003Ek__BackingField;
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
					_003CWorkflowProcessManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override bool CanInduceIdle => true;

	protected abstract IWorkflowProcess GetSubProcess(IWorkflowInstance instance);

	protected override void Execute(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_00c0, IL_01b2, IL_01c1
		int num = 8;
		TaskMarker marker = default(TaskMarker);
		IWorkflowInstance instance = default(IWorkflowInstance);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					ExecuteSubProcess(context);
					num2 = 12;
					continue;
				case 5:
					if (base.Element.LoopCondition.CheckTime != LoopCheckTime.After)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 10:
					switch (marker)
					{
					case TaskMarker.Loop:
						goto IL_010f;
					case TaskMarker.Condition:
						goto IL_0182;
					case TaskMarker.None:
					case TaskMarker.MultiInstance:
						goto IL_01cc;
					}
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 13;
					}
					continue;
				case 8:
					instance = GetInstance(context);
					num2 = 7;
					continue;
				case 2:
					if (ConditionHelper.Evaluate(base.Element.LoopCondition.Condition, instance))
					{
						num2 = 3;
						continue;
					}
					goto case 13;
				case 1:
					return;
				case 12:
					return;
				case 7:
					marker = base.Element.Marker;
					num2 = 10;
					continue;
				case 9:
					return;
				case 13:
					ContinueOnDefaultConnector(context);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
				case 11:
					ExecuteSubProcess(context);
					num2 = 9;
					continue;
				case 6:
					return;
				default:
					goto IL_01cc;
					IL_010f:
					if (base.Element.LoopCondition == null)
					{
						num = 11;
						break;
					}
					goto case 5;
					IL_01cc:
					ExecuteSubProcess(context);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 6;
					}
					continue;
					IL_0182:
					if (ConditionHelper.Evaluate(base.Element.Condition, instance))
					{
						num = 4;
						break;
					}
					goto case 13;
				}
				break;
			}
		}
	}

	protected virtual void ExecuteSubProcess(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_00e5, IL_00f4, IL_0124, IL_0133, IL_0198, IL_0207, IL_0216, IL_0476, IL_0497, IL_0579, IL_05d7
		int num = 27;
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		IWorkflowInstance instance = default(IWorkflowInstance);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		int num4 = default(int);
		int num3 = default(int);
		IWorkflowProcess subProcess = default(IWorkflowProcess);
		MultiInstanceSettings.ValueType instanceCountType = default(MultiInstanceSettings.ValueType);
		object propertyValue = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (base.Element.Marker == TaskMarker.MultiInstance)
					{
						num2 = 22;
						continue;
					}
					return;
				case 32:
					return;
				case 41:
					CreateSheduleTask(workflowBookmark, instance, workflowInstance);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					workflowInstance.IsEmulation = true;
					num2 = 43;
					continue;
				case 7:
				case 24:
				case 29:
				case 47:
					if (num4 <= 0)
					{
						num2 = 45;
						continue;
					}
					num3 = 0;
					num2 = 44;
					continue;
				case 37:
					workflowInstance.ParentBookmark = workflowBookmark;
					num2 = 40;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num2 = 14;
					}
					continue;
				case 18:
					if (subProcess != null)
					{
						num2 = 17;
						continue;
					}
					goto case 21;
				case 3:
					workflowInstance.Name = instance.Name;
					num2 = 25;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 22;
					}
					continue;
				case 30:
					workflowBookmark = CreateBookmark(instance);
					num2 = 38;
					continue;
				case 48:
					if (base.Element.Marker != TaskMarker.MultiInstance)
					{
						num2 = 30;
						continue;
					}
					goto case 14;
				case 27:
					instance = GetInstance(context);
					num2 = 26;
					continue;
				case 25:
					workflowInstance.ParentInstance = instance;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
					{
						num2 = 37;
					}
					continue;
				case 6:
					instanceCountType = base.Element.MultiInstanceSettings.InstanceCountType;
					num2 = 16;
					continue;
				case 28:
					workflowInstance.Initiator = instance.Initiator;
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
					{
						num2 = 11;
					}
					continue;
				case 22:
					ContinueOnDefaultConnector(context);
					num2 = 32;
					continue;
				default:
					num4 = base.Element.MultiInstanceSettings.InstanceCount;
					num2 = 7;
					continue;
				case 31:
				case 44:
					if (num3 < num4)
					{
						num2 = 4;
						continue;
					}
					goto case 10;
				case 20:
				case 43:
					workflowInstance.Process = subProcess;
					num2 = 3;
					continue;
				case 13:
					return;
				case 1:
					return;
				case 17:
					num4 = 1;
					num2 = 19;
					continue;
				case 5:
					base.WorkflowRuntimeService.Run(workflowInstance);
					num = 35;
					break;
				case 26:
					subProcess = GetSubProcess(instance);
					num2 = 18;
					continue;
				case 19:
					if (base.Element.Marker == TaskMarker.MultiInstance)
					{
						num2 = 42;
						continue;
					}
					goto case 7;
				case 38:
					context.CreateBookmark(workflowBookmark.Uid.ToString(), OnSubProcessCompleted);
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 13;
					}
					continue;
				case 23:
					if (instanceCountType == MultiInstanceSettings.ValueType.Property)
					{
						num2 = 8;
						continue;
					}
					goto case 7;
				case 16:
					if (instanceCountType == MultiInstanceSettings.ValueType.Value)
					{
						num2 = 12;
						continue;
					}
					goto case 23;
				case 42:
					if (base.Element.MultiInstanceSettings == null)
					{
						num2 = 47;
						continue;
					}
					goto case 6;
				case 21:
					ContinueOnDefaultConnector(context);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 1;
					}
					continue;
				case 33:
					if (propertyValue == null)
					{
						num2 = 29;
						continue;
					}
					goto case 39;
				case 39:
					num4 = Convert.ToInt32(propertyValue);
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 20;
					}
					continue;
				case 34:
					_ = instance.IsEmulation;
					num2 = 46;
					continue;
				case 9:
					OnSubInstanceRunning(context, workflowInstance, num3);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
				case 4:
					workflowBookmark = null;
					num = 48;
					break;
				case 40:
					workflowInstance.SubProcessElementUid = base.Element.Uid;
					num2 = 28;
					continue;
				case 46:
					if (!instance.IsEmulation)
					{
						num2 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 11;
				case 36:
					AddMembers(instance, workflowInstance);
					num2 = 41;
					continue;
				case 8:
					propertyValue = instance.Context.GetPropertyValue(base.Element.MultiInstanceSettings.InstanceCountPropertyUid);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 33;
					}
					continue;
				case 14:
					workflowInstance = WorkflowInstanceManager.Instance.Create();
					num2 = 34;
					continue;
				case 15:
					workflowInstance.Responsible = instance.Responsible;
					num2 = 36;
					continue;
				case 35:
					num3++;
					num2 = 31;
					continue;
				case 45:
					ContinueOnDefaultConnector(context);
					num2 = 13;
					continue;
				}
				break;
			}
		}
	}

	protected virtual void AddMembers(IWorkflowInstance instance, IWorkflowInstance subInstance)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_009d, IL_00ac, IL_010e, IL_011d, IL_0128, IL_01dd, IL_01fc, IL_020b, IL_0238
		int num = 1;
		int num2 = num;
		IUserFilter @new = default(IUserFilter);
		IEnumerator<IUser> enumerator = default(IEnumerator<IUser>);
		IUser current = default(IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 7:
				return;
			case 5:
			{
				InstanceOf<IUserFilter> instanceOf = new InstanceOf<IUserFilter>();
				instanceOf.New.Workers = Worker.PrepareForFilter(base.Element.Members, instance.Context);
				@new = instanceOf.New;
				num2 = 6;
				break;
			}
			case 1:
				if (!base.Element.CanAddMembers)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 2:
				enumerator = UserManager.Instance.Find(@new, FetchOptions.All).GetEnumerator();
				num2 = 4;
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
							{
								num3 = 2;
							}
							goto IL_012c;
						}
						goto IL_016c;
						IL_016c:
						current = enumerator.Current;
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
						{
							num3 = 0;
						}
						goto IL_012c;
						IL_012c:
						while (true)
						{
							switch (num3)
							{
							case 2:
								return;
							case 3:
								break;
							case 1:
								goto IL_016c;
							default:
								WorkflowInstanceManager.AddMember(subInstance, current);
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
								{
									num3 = 3;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
						{
							num4 = 0;
						}
						goto IL_01e1;
					}
					goto IL_0216;
					IL_0216:
					enumerator.Dispose();
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num4 = 0;
					}
					goto IL_01e1;
					IL_01e1:
					switch (num4)
					{
					default:
						goto end_IL_01bc;
					case 2:
						goto end_IL_01bc;
					case 1:
						break;
					case 0:
						goto end_IL_01bc;
					}
					goto IL_0216;
					end_IL_01bc:;
				}
			case 6:
				if (@new.Workers.Count <= 0)
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected virtual void OnSubInstanceRunning(NativeActivityContext context, IWorkflowInstance subInstance, int index)
	{
	}

	protected virtual void OnSubInstanceCompleted(NativeActivityContext context, IWorkflowInstance subInstance)
	{
	}

	protected void CreateSheduleTask(IWorkflowBookmark bookmark, IWorkflowInstance instance, IWorkflowInstance subInstance, Guid connector = default(Guid))
	{
		//Discarded unreachable code: IL_005b, IL_0209, IL_0226, IL_0235, IL_0244, IL_0347, IL_0358, IL_049d, IL_06c5, IL_06fd, IL_070c
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		IEnumerator<FlowConnectorElement> enumerator = default(IEnumerator<FlowConnectorElement>);
		ITerminateExternalSubProcessShelulerJob terminateExternalSubProcessShelulerJob = default(ITerminateExternalSubProcessShelulerJob);
		ISchedulerTask schedulerTask2 = default(ISchedulerTask);
		ITerminateExternalSubProcessShelulerJob terminateExternalSubProcessShelulerJob2 = default(ITerminateExternalSubProcessShelulerJob);
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		EventTrigger trigger = default(EventTrigger);
		DateTime? dateTime4 = default(DateTime?);
		FlowConnectorElement current = default(FlowConnectorElement);
		DateTime? dateTime2 = default(DateTime?);
		DateTime? dateTime3 = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				_003C_003Ec__DisplayClass20_.connector = connector;
				num2 = 4;
				continue;
			case 3:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 2;
				continue;
			case 4:
				enumerator = base.Element.ExceptionOutputFlows.Where(_003C_003Ec__DisplayClass20_._003CCreateSheduleTask_003Eb__0).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 9;
						goto IL_0069;
					}
					goto IL_0265;
					IL_0069:
					while (true)
					{
						DateTime? dateTime5;
						DateTime? dateTime;
						switch (num3)
						{
						case 9:
							return;
						case 36:
							terminateExternalSubProcessShelulerJob.Uid = Guid.NewGuid();
							num3 = 23;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
							{
								num3 = 16;
							}
							continue;
						default:
							schedulerTask2.Uid = Guid.NewGuid();
							num3 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
							{
								num3 = 3;
							}
							continue;
						case 3:
						{
							terminateExternalSubProcessShelulerJob2.Uid = Guid.NewGuid();
							int num4 = 14;
							num3 = num4;
							continue;
						}
						case 13:
							schedulerTask.Jobs.Add((ISchedulerTaskJob)terminateExternalSubProcessShelulerJob);
							num3 = 35;
							continue;
						case 35:
							schedulerTask.Save();
							num3 = 17;
							continue;
						case 8:
						case 10:
						case 17:
						case 25:
							break;
						case 19:
							if (trigger != EventTrigger.Timer)
							{
								num3 = 15;
								continue;
							}
							goto case 21;
						case 27:
							schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
							num3 = 6;
							continue;
						case 29:
							dateTime5 = dateTime4;
							goto IL_067a;
						case 30:
							terminateExternalSubProcessShelulerJob2.Task = schedulerTask2;
							num3 = 43;
							continue;
						case 24:
							schedulerTask.Uid = Guid.NewGuid();
							num3 = 46;
							continue;
						case 42:
							goto IL_0265;
						case 12:
							terminateExternalSubProcessShelulerJob.ConnectorUid = current.Uid;
							num3 = 37;
							continue;
						case 34:
							schedulerTask2.OwnerUid = WorkflowSchedulerTaskOwner.UID;
							num3 = 39;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
							{
								num3 = 12;
							}
							continue;
						case 22:
							schedulerTask2.Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46C14BF), base.Element.Name, instance.InstanceName(), SR.T(instance.Process.Name));
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
							{
								num3 = 0;
							}
							continue;
						case 38:
							schedulerTask2.Save();
							num3 = 10;
							continue;
						case 7:
							dateTime = dateTime4;
							goto IL_0693;
						case 5:
							schedulerTask2.OnceExecuteTime = dateTime2.Value;
							num3 = 34;
							continue;
						case 28:
							dateTime4 = null;
							num3 = 29;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
							{
								num3 = 17;
							}
							continue;
						case 39:
							terminateExternalSubProcessShelulerJob2 = InterfaceActivator.Create<ITerminateExternalSubProcessShelulerJob>();
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
							{
								num3 = 0;
							}
							continue;
						case 6:
							terminateExternalSubProcessShelulerJob = InterfaceActivator.Create<ITerminateExternalSubProcessShelulerJob>();
							num3 = 36;
							continue;
						case 32:
							terminateExternalSubProcessShelulerJob2.ConnectorUid = current.Uid;
							num3 = 30;
							continue;
						case 2:
							if (dateTime3.Value > DateTime.Now)
							{
								num3 = 45;
								continue;
							}
							break;
						case 46:
							schedulerTask.OnceExecuteTime = dateTime3.Value;
							num3 = 27;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
							{
								num3 = 7;
							}
							continue;
						case 26:
							if (current.TimerScriptEscalation != null)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
								{
									num3 = 1;
								}
								continue;
							}
							goto case 4;
						case 43:
							terminateExternalSubProcessShelulerJob2.Name = schedulerTask2.Name;
							num3 = 31;
							continue;
						case 14:
							terminateExternalSubProcessShelulerJob2.WorkflowBookmark = bookmark;
							num3 = 11;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
							{
								num3 = 0;
							}
							continue;
						case 37:
							terminateExternalSubProcessShelulerJob.Task = schedulerTask;
							num3 = 20;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
							{
								num3 = 5;
							}
							continue;
						case 41:
							schedulerTask.Name = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197879100), base.Element.Name, instance.InstanceName(), SR.T(instance.Process.Name));
							num3 = 24;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
							{
								num3 = 1;
							}
							continue;
						case 45:
							schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
							num3 = 41;
							continue;
						case 21:
							if (current.TimerSettings == null)
							{
								num3 = 28;
								continue;
							}
							dateTime5 = current.TimerSettings.GetNextTimerExpiration(instance);
							goto IL_067a;
						case 18:
							if (dateTime3.HasValue)
							{
								num3 = 2;
								continue;
							}
							break;
						case 40:
							schedulerTask2 = InterfaceActivator.Create<ISchedulerTask>();
							num3 = 22;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
							{
								num3 = 13;
							}
							continue;
						case 33:
							terminateExternalSubProcessShelulerJob.subInstance = subInstance;
							num3 = 12;
							continue;
						case 23:
							terminateExternalSubProcessShelulerJob.WorkflowBookmark = bookmark;
							num3 = 33;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
							{
								num3 = 33;
							}
							continue;
						case 11:
							terminateExternalSubProcessShelulerJob2.subInstance = subInstance;
							num3 = 32;
							continue;
						case 15:
							if (trigger != EventTrigger.Script)
							{
								num3 = 25;
								continue;
							}
							goto case 26;
						case 4:
							dateTime4 = null;
							num3 = 7;
							continue;
						case 31:
							schedulerTask2.Jobs.Add((ISchedulerTaskJob)terminateExternalSubProcessShelulerJob2);
							num3 = 38;
							continue;
						case 44:
							if (!dateTime2.HasValue)
							{
								num3 = 8;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
								{
									num3 = 6;
								}
								continue;
							}
							goto case 40;
						case 20:
							terminateExternalSubProcessShelulerJob.Name = schedulerTask.Name;
							num3 = 13;
							continue;
						case 16:
							trigger = current.Trigger;
							num3 = 19;
							continue;
						case 1:
							{
								dateTime = current.TimerScriptEscalation.GetNextTimerExpiration(instance);
								goto IL_0693;
							}
							IL_067a:
							dateTime2 = dateTime5;
							num3 = 44;
							continue;
							IL_0693:
							dateTime3 = dateTime;
							num3 = 18;
							continue;
						}
						break;
					}
					continue;
					IL_0265:
					current = enumerator.Current;
					num3 = 16;
					goto IL_0069;
				}
			}
			finally
			{
				if (enumerator != null)
				{
					int num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							enumerator.Dispose();
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
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
		}
	}

	private void OnSubProcessCompleted(NativeActivityContext context, Bookmark bookmark, object state)
	{
		//Discarded unreachable code: IL_03f3
		int num = 6;
		WorkflowExternalSubProcessTerminateData workflowExternalSubProcessTerminateData = default(WorkflowExternalSubProcessTerminateData);
		IWorkflowInstance subInstance = default(IWorkflowInstance);
		IWorkflowInstance instance = default(IWorkflowInstance);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		IEnumerable<IUser> recipientsForNotification = default(IEnumerable<IUser>);
		IUser[] swimlaneExecutors = default(IUser[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				bool assignedToResponsible;
				switch (num2)
				{
				case 19:
					ContinueOnConnector(context, workflowExternalSubProcessTerminateData.ConnectorUid);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					if (workflowExternalSubProcessTerminateData != null)
					{
						num = 4;
						break;
					}
					OnSubInstanceCompleted(context, subInstance);
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
					{
						num2 = 18;
					}
					continue;
				case 9:
					if (!(bool)base.WorkflowScriptingService.ExecuteScript(instance, flowConnectorElement.ScriprEscalation))
					{
						num2 = 21;
						continue;
					}
					goto IL_03ff;
				case 6:
					instance = GetInstance(context);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					workflowExternalSubProcessTerminateData = state as WorkflowExternalSubProcessTerminateData;
					num2 = 11;
					continue;
				case 2:
					if (ConditionHelper.Evaluate(base.Element.LoopCondition.Condition, instance))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				case 12:
				{
					IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
					EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17905245));
					entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14374478)] = instance.Name;
					entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431982760)] = instance.Id;
					entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C1FFB55 ^ 0x3C1E9F5B)] = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716437897);
					entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46EFDE9)] = instance.Process;
					entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430556287)] = recipientsForNotification;
					serviceNotNull.ActionExecuted(entityActionEventArgs);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
					{
						num2 = 16;
					}
					continue;
				}
				case 15:
					return;
				case 10:
					ContinueOnDefaultConnector(context);
					num2 = 13;
					continue;
				default:
					recipientsForNotification = Locator.GetServiceNotNull<IActivityEscalationNotifyService>().GetRecipientsForNotification(new GetRecipientsParameters(this, instance, flowConnectorElement, swimlaneExecutors));
					num2 = 12;
					continue;
				case 4:
					flowConnectorElement = base.Diagram.Elements[workflowExternalSubProcessTerminateData.ConnectorUid] as FlowConnectorElement;
					num2 = 17;
					continue;
				case 21:
					context.CreateBookmark(workflowExternalSubProcessTerminateData.Bookmark.Uid.ToString(), OnSubProcessCompleted);
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					subInstance = state as IWorkflowInstance;
					num = 8;
					break;
				case 1:
					ExecuteSubProcess(context);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 10;
					}
					continue;
				case 18:
					if (base.Element.Marker == TaskMarker.Loop)
					{
						num2 = 20;
						continue;
					}
					goto case 10;
				case 7:
					return;
				case 16:
					WorkflowInstanceManager.Instance.Terminate(workflowExternalSubProcessTerminateData.SubInstance);
					num2 = 19;
					continue;
				case 14:
					CreateSheduleTask(workflowExternalSubProcessTerminateData.Bookmark, instance, workflowExternalSubProcessTerminateData.SubInstance, workflowExternalSubProcessTerminateData.ConnectorUid);
					num2 = 3;
					continue;
				case 20:
					if (base.Element.LoopCondition == null)
					{
						num2 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 2;
				case 13:
					return;
				case 3:
					return;
				case 17:
					{
						if (flowConnectorElement.Trigger == EventTrigger.Script)
						{
							num2 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
							{
								num2 = 9;
							}
							continue;
						}
						goto IL_03ff;
					}
					IL_03ff:
					swimlaneExecutors = GetSwimlaneExecutors(context, out assignedToResponsible);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	protected SubProcessActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool rymNaJZgqeYr1bnKOQfH()
	{
		return Cv76LuZg6LrdUuw439vd == null;
	}

	internal static object XiU3UeZg30DdtFdTLnwT()
	{
		return Cv76LuZg6LrdUuw439vd;
	}
}
