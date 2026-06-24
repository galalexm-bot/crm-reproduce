using System;
using System.Activities;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Audit;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Events;

public class IntermediateEventActivity : EventActivity<IntermediateEventElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object h47OCbvfyjXg3tUcHkfQ;

		public Type ActivityType => typeof(IntermediateEventActivity);

		public Type DiagramElementType => YkCQHqvfb9ahs6oCWQ6s(typeof(IntermediateEventElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			KOeOn6vf5xa8fgT3UKZ7();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type YkCQHqvfb9ahs6oCWQ6s(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void KOeOn6vf5xa8fgT3UKZ7()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool wR2jvkvfm4UhCbXwbkyg()
		{
			return h47OCbvfyjXg3tUcHkfQ == null;
		}

		internal static Info IW14Ekvftab49GmZlZ08()
		{
			return (Info)h47OCbvfyjXg3tUcHkfQ;
		}
	}

	private static IntermediateEventActivity pZHyABZP2lj0HPh4drY0;

	protected override bool CanInduceIdle => true;

	protected override void Execute(NativeActivityContext context)
	{
		int num = 2;
		int num2 = num;
		EventTrigger trigger = default(EventTrigger);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				return;
			case 0:
				return;
			case 2:
				trigger = base.Element.Trigger;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (trigger != EventTrigger.Timer)
				{
					base.Execute(context);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 4:
				ExecuteTimer(context);
				num2 = 3;
				break;
			}
		}
	}

	protected virtual void ExecuteTimer(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_0141, IL_0150, IL_01d0, IL_01df, IL_0228, IL_0237, IL_02a5
		int num = 25;
		IResumeProcessSchedulerJob resumeProcessSchedulerJob = default(IResumeProcessSchedulerJob);
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		DateTime? dateTime2 = default(DateTime?);
		DateTime? dateTime3 = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				DateTime? dateTime;
				switch (num2)
				{
				case 18:
					resumeProcessSchedulerJob.Task = schedulerTask;
					num2 = 9;
					continue;
				case 10:
					CPnbh7ZPwTJ2FCunAEA8(schedulerTask, FfTnj0ZPE11bUqc93Rkc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F5E8ED), new object[2]
					{
						JMCMGuZPxl63yPfeLS5B(workflowInstance),
						lw8oYiZPhECtvSfk9SAm(oNuKdXZP1hCeg4qFERfP(bLd7DwZPSosoxHmGMV10(workflowInstance)))
					}));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 5;
					}
					continue;
				case 20:
					return;
				case 23:
					workflowBookmark = (IWorkflowBookmark)hkOJPwZPebgsfLwHPPS6(this, workflowInstance);
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					resumeProcessSchedulerJob.Uid = ArA8hFZPzqb4nJCVfWBL();
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 21;
					}
					continue;
				case 11:
					goto end_IL_0012;
				case 16:
					return;
				default:
					schedulerTask.Jobs.Add((ISchedulerTaskJob)resumeProcessSchedulerJob);
					num2 = 14;
					continue;
				case 19:
					if (!dateTime2.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 13;
				case 3:
					resumeProcessSchedulerJob = InterfaceActivator.Create<IResumeProcessSchedulerJob>();
					num2 = 7;
					continue;
				case 14:
					p7GhcaZXZg9XxStis7Wv(schedulerTask);
					num2 = 22;
					continue;
				case 9:
					resumeProcessSchedulerJob.Name = (string)enJy5QZXO3OVyGoCCM3X(schedulerTask);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
					num2 = 10;
					continue;
				case 12:
					dateTime3 = null;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
					{
						num2 = 6;
					}
					continue;
				case 22:
					SaveTimerStartedEventToHistory(workflowInstance, dateTime2.Value);
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 16;
					}
					continue;
				case 6:
					dateTime = dateTime3;
					break;
				case 24:
					if (base.Element.TimerSettings != null)
					{
						num2 = 17;
						continue;
					}
					goto case 12;
				case 1:
				case 4:
					ContinueOnDefaultConnector(context);
					num2 = 20;
					continue;
				case 8:
					WGa68xZPNoueQrZ1Ag0x(context, workflowBookmark.Uid.ToString(), new BookmarkCallback(OnTimerCompleted));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					schedulerTask.OnceExecuteTime = dateTime2.Value;
					num2 = 11;
					continue;
				case 13:
					if (!pDRIhYZPrSRQ4ID9IeNL(dateTime2.Value, gD3YsgZPa9a2spLghtBD()))
					{
						num2 = 23;
						continue;
					}
					goto case 1;
				case 21:
					btj4C1ZXKDegcH9wLq2g(resumeProcessSchedulerJob, workflowBookmark);
					num2 = 18;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 3;
					}
					continue;
				case 25:
					workflowInstance = (IWorkflowInstance)zfkMduZPicatr4Rt7hUl(this, context);
					num2 = 24;
					continue;
				case 5:
					o2r7bGZP4EttSO8wMLAo(schedulerTask, Guid.NewGuid());
					num2 = 15;
					continue;
				case 17:
					dateTime = ((IntermediateTimerSettings)fwHjSjZPIEHNNiETIopK(base.Element)).GetNextTimerExpiration(workflowInstance);
					break;
				}
				dateTime2 = dateTime;
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
				{
					num2 = 19;
				}
				continue;
				end_IL_0012:
				break;
			}
			schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
			num = 3;
		}
	}

	private void SaveTimerStartedEventToHistory(IWorkflowInstance instance, DateTime dateTime)
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
			{
				IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				WorkflowInstanceTimerActionEventArgs workflowInstanceTimerActionEventArgs = (WorkflowInstanceTimerActionEventArgs)GQPqSnZXY4IJmsYe6SZb(instance, instance, LoVtJfZXvHFDbf9a68wZ());
				z8E5RFZX81x393y3XH9R(workflowInstanceTimerActionEventArgs, dateTime);
				workflowInstanceTimerActionEventArgs.TimerName = (string)KdWRyFZXs49HXouM1mSy(base.Element);
				gjFoYwZXJyckJOsI2GDS(serviceNotNull, workflowInstanceTimerActionEventArgs);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	protected virtual void OnTimerCompleted(NativeActivityContext context, Bookmark bookmark, object state)
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					_ = (WorkflowTimerResumeData)state;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					Contract.CheckArgument(state is WorkflowTimerResumeData, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x73880702));
					num2 = 3;
					continue;
				case 4:
					return;
				case 5:
					ContinueOnDefaultConnector(context);
					num2 = 4;
					continue;
				case 2:
					AXYk1uZXlCapf4vvUGka(state, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420076599));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			SaveTimerExecutedEventToHistory(context);
			num = 5;
		}
	}

	private void SaveTimerExecutedEventToHistory(NativeActivityContext context)
	{
		int num = 1;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				workflowInstance = (IWorkflowInstance)zfkMduZPicatr4Rt7hUl(this, context);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 0;
				}
				continue;
			}
			IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
			WorkflowInstanceTimerActionEventArgs workflowInstanceTimerActionEventArgs = (WorkflowInstanceTimerActionEventArgs)GQPqSnZXY4IJmsYe6SZb(workflowInstance, workflowInstance, WorkflowInstanceActions.TimerExecutedGuid);
			kfoAilZX0qJAIN93BSxb(workflowInstanceTimerActionEventArgs, KdWRyFZXs49HXouM1mSy(base.Element));
			gjFoYwZXJyckJOsI2GDS(serviceNotNull, workflowInstanceTimerActionEventArgs);
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
			{
				num2 = 1;
			}
		}
	}

	public IntermediateEventActivity()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		A48KLOZXybtQASnMQY71();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool oZiBBhZPodbBg7N0ZXhm()
	{
		return pZHyABZP2lj0HPh4drY0 == null;
	}

	internal static IntermediateEventActivity BNOyImZPF7IQC15XOATk()
	{
		return pZHyABZP2lj0HPh4drY0;
	}

	internal static object zfkMduZPicatr4Rt7hUl(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static object fwHjSjZPIEHNNiETIopK(object P_0)
	{
		return ((IntermediateEventElement)P_0).TimerSettings;
	}

	internal static DateTime gD3YsgZPa9a2spLghtBD()
	{
		return DateTime.Now;
	}

	internal static bool pDRIhYZPrSRQ4ID9IeNL(DateTime P_0, DateTime P_1)
	{
		return P_0 <= P_1;
	}

	internal static object hkOJPwZPebgsfLwHPPS6(object P_0, object P_1)
	{
		return ((BPMNActivity<IntermediateEventElement>)P_0).CreateBookmark((IWorkflowInstance)P_1);
	}

	internal static object WGa68xZPNoueQrZ1Ag0x(object P_0, object P_1, object P_2)
	{
		return ((NativeActivityContext)P_0).CreateBookmark((string)P_1, (BookmarkCallback)P_2);
	}

	internal static object JMCMGuZPxl63yPfeLS5B(object P_0)
	{
		return ((IWorkflowInstance)P_0).InstanceName();
	}

	internal static object bLd7DwZPSosoxHmGMV10(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object oNuKdXZP1hCeg4qFERfP(object P_0)
	{
		return ((IWorkflowProcess)P_0).Name;
	}

	internal static object lw8oYiZPhECtvSfk9SAm(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object FfTnj0ZPE11bUqc93Rkc(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void CPnbh7ZPwTJ2FCunAEA8(object P_0, object P_1)
	{
		((ISchedulerTask)P_0).Name = (string)P_1;
	}

	internal static void o2r7bGZP4EttSO8wMLAo(object P_0, Guid P_1)
	{
		((ISchedulerTask)P_0).Uid = P_1;
	}

	internal static Guid ArA8hFZPzqb4nJCVfWBL()
	{
		return Guid.NewGuid();
	}

	internal static void btj4C1ZXKDegcH9wLq2g(object P_0, object P_1)
	{
		((IResumeProcessSchedulerJob)P_0).WorkflowBookmark = (IWorkflowBookmark)P_1;
	}

	internal static object enJy5QZXO3OVyGoCCM3X(object P_0)
	{
		return ((ISchedulerTask)P_0).Name;
	}

	internal static void p7GhcaZXZg9XxStis7Wv(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static Guid LoVtJfZXvHFDbf9a68wZ()
	{
		return WorkflowInstanceActions.TimerStartedGuid;
	}

	internal static object GQPqSnZXY4IJmsYe6SZb(object P_0, object P_1, Guid actionUid)
	{
		return WorkflowInstanceTimerActionEventArgs.TryCreate((IEntity)P_0, (IEntity)P_1, actionUid);
	}

	internal static void z8E5RFZX81x393y3XH9R(object P_0, DateTime value)
	{
		((WorkflowInstanceTimerActionEventArgs)P_0).OnceExecuteTime = value;
	}

	internal static object KdWRyFZXs49HXouM1mSy(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void gjFoYwZXJyckJOsI2GDS(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static void AXYk1uZXlCapf4vvUGka(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void kfoAilZX0qJAIN93BSxb(object P_0, object P_1)
	{
		((WorkflowInstanceTimerActionEventArgs)P_0).TimerName = (string)P_1;
	}

	internal static void A48KLOZXybtQASnMQY71()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
