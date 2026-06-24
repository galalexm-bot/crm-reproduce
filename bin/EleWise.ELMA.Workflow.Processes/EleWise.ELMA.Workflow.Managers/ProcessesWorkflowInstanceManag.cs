using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.Components;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class ProcessesWorkflowInstanceManager : EntityExtensionManager<IWorkflowInstance, IProcessesWorkflowInstance, long, WorkflowInstanceManager>
{
	private static ProcessesWorkflowInstanceManager Iw5lhdMWw50XMdQT2h5;

	public static ProcessesWorkflowInstanceManager Instance => Locator.GetServiceNotNull<ProcessesWorkflowInstanceManager>();

	public IEnumerable<ISchedulerJobRepository> SchedulerJobRepositories { get; set; }

	protected override void OnSetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0096, IL_00a5, IL_00b5
		int num = 8;
		int num2 = num;
		IProcessesWorkflowInstanceFilter processesWorkflowInstanceFilter = default(IProcessesWorkflowInstanceFilter);
		long? num3 = default(long?);
		IProcessHeader entity = default(IProcessHeader);
		long? num4 = default(long?);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 7:
				if (processesWorkflowInstanceFilter == null)
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			case 8:
				processesWorkflowInstanceFilter = filter as IProcessesWorkflowInstanceFilter;
				num2 = 7;
				continue;
			case 4:
				num3 = null;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				criteria.Add((ICriterion)(object)NHQueryExtensions.Sql((string)r0hZ5tMrFJrGB9kHNXV(KIvO9KMuXcQ4eXPxUxP(--1059430085 ^ 0x3F25C119), SKaGedMLM5FhI5p9WwE(), string.Join((string)KIvO9KMuXcQ4eXPxUxP(0xE108112 ^ 0xE10E114), ((WorkflowInstanceManager)SM6F9yMJoQVjhJDWgpf()).BuildInstancesByEntityQueryList((IEntity<long>)entity)))));
				num2 = 10;
				continue;
			case 5:
				num4 = (num3 = (long?)cWxBMyMlknvPkIfcy7L(processesWorkflowInstanceFilter, KIvO9KMuXcQ4eXPxUxP(-30505303 ^ -30484221), null));
				num2 = 6;
				continue;
			case 10:
				return;
			case 1:
				if (kjinnPMiesRU2A6joOC(processesWorkflowInstanceFilter) != null)
				{
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 6:
				if (!num4.HasValue)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5581cf8fc5c14768be6f13345a9a04e1 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				obj = kjinnPMiesRU2A6joOC(processesWorkflowInstanceFilter);
				if (obj != null)
				{
					break;
				}
				num2 = 9;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 == 0)
				{
					num2 = 3;
				}
				continue;
			case 9:
				obj = ((AbstractNHEntityManager<IProcessHeader, long>)GvwQvkMfLsTWqpUKU1F()).Load(num3.Value);
				break;
			}
			entity = (IProcessHeader)obj;
			num2 = 2;
		}
	}

	[Transaction]
	public virtual void RecreateCacheByUsers()
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
				((AbstractNHEntityManager<IProcessHeader, long>)GvwQvkMfLsTWqpUKU1F()).FindAll().ForEach(delegate(IProcessHeader h)
				{
					int num3 = 3;
					int num4 = num3;
					IMonitorUpdateQueueAction monitorUpdateQueueAction3 = default(IMonitorUpdateQueueAction);
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 2:
							if (monitorUpdateQueueAction3 == null)
							{
								return;
							}
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc != 0)
							{
								num4 = 1;
							}
							break;
						case 0:
							return;
						case 1:
							monitorUpdateQueueAction3.DoAction(h, null);
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c41b9b25e0a04be1b1ded81427c555dd == 0)
							{
								num4 = 0;
							}
							break;
						case 3:
						{
							List<IMonitorUpdateQueueAction> source = ((ComponentManager)_003C_003Ec.m8pJV9yjKUebRObyZqY()).GetExtensionPoints<IMonitorUpdateQueueAction>().ToList();
							source.FirstOrDefault((IMonitorUpdateQueueAction c) => _003C_003Ec.zKCcUYybNjFPecUS8Ub(_003C_003Ec.Op3gjryk2nXi8BnBJUj(c), RecalcCurrentInstanceCountMonitorUpdateQueueAction.UID))?.DoAction(h, null);
							IMonitorUpdateQueueAction monitorUpdateQueueAction = source.FirstOrDefault((IMonitorUpdateQueueAction c) => _003C_003Ec.zKCcUYybNjFPecUS8Ub(_003C_003Ec.Op3gjryk2nXi8BnBJUj(c), RecalcCompleteInstanceCountMonitorUpdateQueueAction.UID));
							if (monitorUpdateQueueAction != null)
							{
								_003C_003Ec.n9bmhyySJc9uKjKAQxt(monitorUpdateQueueAction, h, null);
							}
							IMonitorUpdateQueueAction monitorUpdateQueueAction2 = source.FirstOrDefault((IMonitorUpdateQueueAction c) => _003C_003Ec.zKCcUYybNjFPecUS8Ub(_003C_003Ec.Op3gjryk2nXi8BnBJUj(c), RecalcTerminateInstanceCountMonitorUpdateQueueAction.UID));
							if (monitorUpdateQueueAction2 != null)
							{
								_003C_003Ec.n9bmhyySJc9uKjKAQxt(monitorUpdateQueueAction2, h, null);
							}
							monitorUpdateQueueAction3 = source.FirstOrDefault((IMonitorUpdateQueueAction c) => _003C_003Ec.zKCcUYybNjFPecUS8Ub(_003C_003Ec.Op3gjryk2nXi8BnBJUj(c), RecalcTasksOfInstanceCountMonitorUpdateQueueAction.UID));
							num4 = 2;
							break;
						}
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void RunRecreateCacheSchedulerJob()
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		IEnumerable<_003C_003Ef__AnonymousType0<ISchedulerJob, IJob>> source = default(IEnumerable<_003C_003Ef__AnonymousType0<ISchedulerJob, IJob>>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				AIy1pxM1hGl60cCwEM6(new ThreadStart(new BackgroundTask(_003C_003Ec__DisplayClass8_._003CRunRecreateCacheSchedulerJob_003Eb__3, qUWZB1MgPMSrWufu2bG(typeof(ProcessesWorkflowInstanceManager).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-474638327 ^ -474613743), (string)KIvO9KMuXcQ4eXPxUxP(-1843608060 ^ -1843616228)).Execute));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c != 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				JAymDnM5yHjIyTpOvEn(this, new NthIncludedDaySettings
				{
					ScheduleType = ScheduleType.Once,
					StartDate = VsMiF4M7NtPRXlZvBVO(),
					OvertimeToRun = TimeSpan.FromDays(1.0)
				});
				num2 = 5;
				continue;
			case 5:
				return;
			case 4:
				return;
			case 6:
				if (_003C_003Ec__DisplayClass8_.jobObject != null)
				{
					_003C_003Ec__DisplayClass8_.now = DateTime.Now;
					num2 = 7;
					continue;
				}
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				_003C_003Ec__DisplayClass8_.jobObject = source.FirstOrDefault(j => j.Job.Id == WorkflowConstants.RecreateCacheJobId);
				num2 = 6;
				continue;
			}
			source = SchedulerJobRepositories.SelectMany((ISchedulerJobRepository r) => r.GetSchedulerJobs()).SelectMany(delegate(ISchedulerJob j)
			{
				_003C_003Ec__DisplayClass8_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_1();
				CS_0024_003C_003E8__locals0.j = j;
				return CS_0024_003C_003E8__locals0.j.Jobs.Select((IJob item) => new
				{
					SchedulerJob = CS_0024_003C_003E8__locals0.j,
					Job = item
				});
			});
			num2 = 3;
		}
	}

	[Transaction]
	public virtual void RunOptimizeMonitorCacheJob()
	{
		int num = 7;
		IOptimizeMonitorCacheJob optimizeMonitorCacheJob = default(IOptimizeMonitorCacheJob);
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
					daZRU7aoUrRnDfUSH0s(optimizeMonitorCacheJob, BV9muTaXSK8p7FuWEiv(schedulerTask));
					num2 = 10;
					continue;
				case 7:
					schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
					{
						num2 = 6;
					}
					continue;
				case 9:
					optimizeMonitorCacheJob.Task = schedulerTask;
					num2 = 2;
					continue;
				case 4:
					schedulerTask.OwnerUid = RecreateMonitorCacheSchedulerTaskOwner.UID;
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb != 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					lFP8B5aCj4f97G98j1p(optimizeMonitorCacheJob, jK4qlUMzPF3HiANGEWV());
					num2 = 9;
					continue;
				case 6:
					ntTrJiMZVYO16px8edt(schedulerTask, lLMTByMIAYcv1lK5Htd(KIvO9KMuXcQ4eXPxUxP(-133069941 ^ -133045293)));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					IoaU1va3Oe5bEMHe0iL(schedulerTask);
					num2 = 3;
					continue;
				case 5:
					optimizeMonitorCacheJob = InterfaceActivator.Create<IOptimizeMonitorCacheJob>();
					num2 = 8;
					continue;
				case 10:
					schedulerTask.Jobs.Add((ISchedulerTaskJob)optimizeMonitorCacheJob);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					break;
				default:
					PsGGbtaE6xn5AOTEXZY(schedulerTask, jK4qlUMzPF3HiANGEWV());
					num2 = 11;
					continue;
				}
				break;
			}
			schedulerTask.OnceExecuteTime = VsMiF4M7NtPRXlZvBVO();
			num = 4;
		}
	}

	[Transaction]
	public virtual void InvokeCreateOrUpdatePlanRecreateCacheJob(NthIncludedDaySettings settings)
	{
		//Discarded unreachable code: IL_00e4, IL_00f3, IL_0239, IL_0248
		int num = 11;
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		IRecreateMonitorCacheJob recreateMonitorCacheJob = default(IRecreateMonitorCacheJob);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
				case 16:
					goto end_IL_0012;
				case 7:
				case 19:
					PIjCwba8R4ywQTZV4KB(schedulerTask, SchedulerTaskStatus.Closed);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 == 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					hxNVPqaFcEPKxGWFRd5(recreateMonitorCacheJob, schedulerTask);
					num2 = 20;
					continue;
				case 10:
					if (schedulerTask != null)
					{
						num2 = 19;
						continue;
					}
					break;
				case 18:
					return;
				case 2:
					XTJuVSahJiBUAoJreKA(schedulerTask, settings);
					num2 = 6;
					continue;
				case 3:
					lFP8B5aCj4f97G98j1p(recreateMonitorCacheJob, WorkflowConstants.RecreateCacheJobId);
					num2 = 12;
					continue;
				case 13:
					ntTrJiMZVYO16px8edt(schedulerTask, lLMTByMIAYcv1lK5Htd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-588615921 ^ -588640319)));
					num2 = 14;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c != 0)
					{
						num2 = 5;
					}
					continue;
				case 6:
					IoaU1va3Oe5bEMHe0iL(schedulerTask);
					num2 = 18;
					continue;
				case 4:
					schedulerTask.Jobs.Add((ISchedulerTaskJob)recreateMonitorCacheJob);
					num2 = 8;
					continue;
				case 15:
					recreateMonitorCacheJob = InterfaceActivator.Create<IRecreateMonitorCacheJob>();
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e307e1455f8c4779adb085e36b40526a == 0)
					{
						num2 = 3;
					}
					continue;
				case 14:
					schedulerTask.Uid = WorkflowConstants.RecreateCacheTaskId;
					num2 = 5;
					continue;
				case 9:
					yLWRtaaxnl2fgfH2QC9(schedulerTask, SchedulerTaskType.Periodic);
					num2 = 15;
					continue;
				case 20:
					daZRU7aoUrRnDfUSH0s(recreateMonitorCacheJob, BV9muTaXSK8p7FuWEiv(schedulerTask));
					num2 = 4;
					continue;
				case 1:
					XTJuVSahJiBUAoJreKA(schedulerTask, settings);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 != 0)
					{
						num2 = 9;
					}
					continue;
				case 11:
					schedulerTask = AbstractNHEntityManager<ISchedulerTask, long>.Instance.LoadOrNull(WorkflowConstants.RecreateCacheTaskId);
					num2 = 10;
					continue;
				default:
					IoaU1va3Oe5bEMHe0iL(schedulerTask);
					num2 = 6;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa != 0)
					{
						num2 = 16;
					}
					continue;
				case 5:
					schedulerTask.OwnerUid = RecreateMonitorCacheSchedulerTaskOwner.UID;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9f9823be58b94730af510f3472045ea6 != 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					break;
				}
				schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
				num2 = 13;
				continue;
				end_IL_0012:
				break;
			}
			schedulerTask.Status = SchedulerTaskStatus.Enabled;
			num = 2;
		}
	}

	public bool GlobalRecreateCacheSchedulerTaskActived()
	{
		int num = 1;
		int num2 = num;
		IRecreateMonitorCacheJob recreateMonitorCacheJob = default(IRecreateMonitorCacheJob);
		ISchedulerJobRunInfoFilter @new = default(ISchedulerJobRunInfoFilter);
		while (true)
		{
			switch (num2)
			{
			case 1:
				recreateMonitorCacheJob = AbstractNHEntityManager<IRecreateMonitorCacheJob, long>.Instance.LoadOrNull(WorkflowConstants.RecreateCacheJobId);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return wQSCPDa2FojRwbEuDIr(AbstractNHEntityManager<ISchedulerJobRunInfo, long>.Instance, @new);
			case 2:
				return false;
			}
			if (recreateMonitorCacheJob != null)
			{
				InstanceOf<ISchedulerJobRunInfoFilter> instanceOf = new InstanceOf<ISchedulerJobRunInfoFilter>();
				k54qYAatuPPKGYkW3JW(instanceOf.New, qv53doaw0inZn6rVgyD(KIvO9KMuXcQ4eXPxUxP(-194568252 ^ -194543994), recreateMonitorCacheJob.Id));
				OEYIKNasUA3nbeyIVdE(instanceOf.New, true);
				@new = instanceOf.New;
				num2 = 3;
			}
			else
			{
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
				{
					num2 = 1;
				}
			}
		}
	}

	[Transaction]
	public virtual void CreateOrUpdatePlanRecreateCacheJob()
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_00a0, IL_0101, IL_0110, IL_018d
		int num = 2;
		WorkflowMonitorSettingsModule service = default(WorkflowMonitorSettingsModule);
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					return;
				case 4:
				case 6:
				case 7:
					break;
				case 14:
					return;
				case 10:
					if (!gUkB6CaVPWTXW7g33wX(service.Settings))
					{
						num2 = 6;
						continue;
					}
					goto case 15;
				case 8:
					return;
				case 1:
					if (service != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 3:
					if (schedulerTask == null)
					{
						num2 = 14;
						continue;
					}
					goto case 12;
				case 13:
					if (!VxmPmxaqPVgk25x2Bwe(service.Settings))
					{
						num2 = 7;
						continue;
					}
					goto case 5;
				case 11:
					IoaU1va3Oe5bEMHe0iL(schedulerTask);
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
					{
						num2 = 8;
					}
					continue;
				case 5:
					if (XH3bYCaQW9sKpOhcuL5(service.Settings) != null)
					{
						num2 = 10;
						continue;
					}
					break;
				default:
					if (service.Settings == null)
					{
						num2 = 4;
						continue;
					}
					goto case 13;
				case 12:
					PIjCwba8R4ywQTZV4KB(schedulerTask, SchedulerTaskStatus.Closed);
					num2 = 11;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e == 0)
					{
						num2 = 11;
					}
					continue;
				case 15:
					JAymDnM5yHjIyTpOvEn(this, XH3bYCaQW9sKpOhcuL5(service.Settings));
					num2 = 9;
					continue;
				case 2:
					service = Locator.GetService<WorkflowMonitorSettingsModule>();
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			schedulerTask = AbstractNHEntityManager<ISchedulerTask, long>.Instance.LoadOrNull(WorkflowConstants.RecreateCacheTaskId);
			num = 3;
		}
	}

	public ICollection<ProcessHeaderInfo> LoadAllProcessesHeadTree(bool onlyActive = false)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.transform = Locator.GetServiceNotNull<ITransformationProvider>();
		List<string> list = (from q in WorkflowInstanceManager.Instance.BuildInstancesByEntityQueryList(null, InterfaceActivator.TypeOf<IProcessHeader>(), ImprovementProcessSettingsManager.Instance.GetProcessHeaderPropertyUidList(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-897645572 ^ -897624518))
			select (string)_003C_003Ec__DisplayClass13_0.Yx8OOSyfrKg1qECVDXB(_003C_003Ec__DisplayClass13_0.MGEgbGyiPrFFxQkkijX(0x4244DF13 ^ 0x42447C2F), new object[7]
			{
				q,
				_003C_003Ec__DisplayClass13_0.fqMVLbylSGl8nXGLk4g(_003C_003Ec__DisplayClass13_0.y2UbtZyuj3bbXKGSXv8(CS_0024_003C_003E8__locals0.transform), _003C_003Ec__DisplayClass13_0.MGEgbGyiPrFFxQkkijX(0x77CE159B ^ 0x77CE22BF)),
				CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x29336E79 ^ 0x29330C41)),
				_003C_003Ec__DisplayClass13_0.fqMVLbylSGl8nXGLk4g(CS_0024_003C_003E8__locals0.transform.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1643416224 ^ -1643426484)),
				((Dialect)_003C_003Ec__DisplayClass13_0.y2UbtZyuj3bbXKGSXv8(CS_0024_003C_003E8__locals0.transform)).QuoteIfNeeded((string)_003C_003Ec__DisplayClass13_0.MGEgbGyiPrFFxQkkijX(0x1C21F94 ^ 0x1C2286E)),
				_003C_003Ec__DisplayClass13_0.fqMVLbylSGl8nXGLk4g(_003C_003Ec__DisplayClass13_0.y2UbtZyuj3bbXKGSXv8(CS_0024_003C_003E8__locals0.transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-588615921 ^ -588622045)),
				_003C_003Ec__DisplayClass13_0.fqMVLbylSGl8nXGLk4g(_003C_003Ec__DisplayClass13_0.y2UbtZyuj3bbXKGSXv8(CS_0024_003C_003E8__locals0.transform), _003C_003Ec__DisplayClass13_0.MGEgbGyiPrFFxQkkijX(-1803374629 ^ -1803367031))
			})).ToList();
		if (!onlyActive)
		{
			list.Add(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51F798FE ^ 0x51F7F974), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3F8E27D0 ^ 0x3F8E102A)), 0, CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2144947971 ^ -2144939323)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-254800515 ^ -254775505)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x29336E79 ^ 0x2933395D))));
		}
		string text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-444713948 ^ -444705196), string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C817E00 ^ 0x2C811B1C), list), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-769877317 ^ -769864505)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2C9503E1 ^ 0x2C9561D9)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x124714F0 ^ 0x124723D4)), 1, 2, 3, 4, CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-275456087 ^ -275453869)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3D87FABF ^ 0x3D87ACC3)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1275462473 ^ -1275487867)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-474638327 ^ -474612401)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C21F94 ^ 0x1C27AF2)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-416187968 ^ -416211900)), CS_0024_003C_003E8__locals0.transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138431307 ^ -138422553)));
		return ((IQuery)base.Session.CreateSQLQuery(text).AddScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x319750D3 ^ 0x31976729), (IType)(object)NHibernateUtil.Int64).AddScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C324F5C ^ 0x6C321920), (IType)(object)NHibernateUtil.String)
			.AddScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x664EA08F ^ 0x664EC5BD), (IType)(object)NHibernateUtil.Int64)
			.AddScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-193507406 ^ -193496938), (IType)(object)NHibernateUtil.Int32)
			.AddScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179265198 ^ -179256300), (IType)(object)NHibernateUtil.Int64)
			.AddScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48B7D69C ^ 0x48B7B3FA), (IType)(object)NHibernateUtil.Int64)
			.AddScalar(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1365449958 ^ -1365473634), (IType)(object)NHibernateUtil.Int64)).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessHeaderInfo))).CleanUpCache(cleanUpCache: false).List<ProcessHeaderInfo>();
	}

	public ProcessesWorkflowInstanceManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cri7IGaDq1ErmlTZZFy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object kjinnPMiesRU2A6joOC(object P_0)
	{
		return ((IProcessesWorkflowInstanceFilter)P_0).ImprovedProcessHeader;
	}

	internal static object KIvO9KMuXcQ4eXPxUxP(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cWxBMyMlknvPkIfcy7L(object P_0, object P_1, object P_2)
	{
		return P_0.GetPropertyValue((string)P_1, P_2);
	}

	internal static object GvwQvkMfLsTWqpUKU1F()
	{
		return ProcessHeaderManager.Instance;
	}

	internal static object SKaGedMLM5FhI5p9WwE()
	{
		return WorkflowInstanceManager.DefaultCriteriaAliasStatic;
	}

	internal static object SM6F9yMJoQVjhJDWgpf()
	{
		return WorkflowInstanceManager.Instance;
	}

	internal static object r0hZ5tMrFJrGB9kHNXV(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool Jqd8nXMHPdGGI87XrrP()
	{
		return Iw5lhdMWw50XMdQT2h5 == null;
	}

	internal static ProcessesWorkflowInstanceManager ib9Xb5Me0nIvMh7oxHw()
	{
		return Iw5lhdMWw50XMdQT2h5;
	}

	internal static DateTime VsMiF4M7NtPRXlZvBVO()
	{
		return DateTime.Now;
	}

	internal static void JAymDnM5yHjIyTpOvEn(object P_0, object P_1)
	{
		((ProcessesWorkflowInstanceManager)P_0).InvokeCreateOrUpdatePlanRecreateCacheJob((NthIncludedDaySettings)P_1);
	}

	internal static Type qUWZB1MgPMSrWufu2bG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool AIy1pxM1hGl60cCwEM6(object P_0)
	{
		return ThreadStarter.QueueThread((ThreadStart)P_0);
	}

	internal static object lLMTByMIAYcv1lK5Htd(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void ntTrJiMZVYO16px8edt(object P_0, object P_1)
	{
		((ISchedulerTask)P_0).Name = (string)P_1;
	}

	internal static Guid jK4qlUMzPF3HiANGEWV()
	{
		return Guid.NewGuid();
	}

	internal static void PsGGbtaE6xn5AOTEXZY(object P_0, Guid P_1)
	{
		((ISchedulerTask)P_0).Uid = P_1;
	}

	internal static void lFP8B5aCj4f97G98j1p(object P_0, Guid P_1)
	{
		((ISchedulerTaskJob)P_0).Uid = P_1;
	}

	internal static object BV9muTaXSK8p7FuWEiv(object P_0)
	{
		return ((ISchedulerTask)P_0).Name;
	}

	internal static void daZRU7aoUrRnDfUSH0s(object P_0, object P_1)
	{
		((ISchedulerTaskJob)P_0).Name = (string)P_1;
	}

	internal static void IoaU1va3Oe5bEMHe0iL(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void XTJuVSahJiBUAoJreKA(object P_0, object P_1)
	{
		((ISchedulerTask)P_0).Settings = P_1;
	}

	internal static void yLWRtaaxnl2fgfH2QC9(object P_0, SchedulerTaskType P_1)
	{
		((ISchedulerTask)P_0).Type = P_1;
	}

	internal static void hxNVPqaFcEPKxGWFRd5(object P_0, object P_1)
	{
		((ISchedulerTaskJob)P_0).Task = (ISchedulerTask)P_1;
	}

	internal static void PIjCwba8R4ywQTZV4KB(object P_0, SchedulerTaskStatus P_1)
	{
		((ISchedulerTask)P_0).Status = P_1;
	}

	internal static object qv53doaw0inZn6rVgyD(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void k54qYAatuPPKGYkW3JW(object P_0, object P_1)
	{
		((IEntityFilter)P_0).Query = (string)P_1;
	}

	internal static void OEYIKNasUA3nbeyIVdE(object P_0, bool P_1)
	{
		((IEntityFilter)P_0).DisableSecurity = P_1;
	}

	internal static bool wQSCPDa2FojRwbEuDIr(object P_0, object P_1)
	{
		return ((IEntityManager)P_0).Exists((IEntityFilter)P_1);
	}

	internal static bool VxmPmxaqPVgk25x2Bwe(object P_0)
	{
		return ((WorkflowMonitorSettings)P_0).DisableAutoUpdateMonitorCache;
	}

	internal static object XH3bYCaQW9sKpOhcuL5(object P_0)
	{
		return ((WorkflowMonitorSettings)P_0).DateTimeUpdateSettings;
	}

	internal static bool gUkB6CaVPWTXW7g33wX(object P_0)
	{
		return ((WorkflowMonitorSettings)P_0).PlanRecreateMonitorCache;
	}

	internal static void cri7IGaDq1ErmlTZZFy()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
