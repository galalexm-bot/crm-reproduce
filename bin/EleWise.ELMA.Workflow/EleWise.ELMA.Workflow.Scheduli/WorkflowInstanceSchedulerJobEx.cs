using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

public abstract class WorkflowInstanceSchedulerJobExecutor<TJob> : ISchedulerTaskJobExecutor, IWorkflowInstanceSchedulerJobExecutor, IThreadPoolContainer where TJob : class, ISchedulerTaskJob
{
	private WorkflowQueueService _queueService;

	internal static object FYiFMTtcloAxjXaFrHl;

	public IWorkflowRuntimeService WorkflowRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowRuntimeService_003Ek__BackingField;
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
					_003CWorkflowRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
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

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionProvider_003Ek__BackingField;
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
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal WorkflowQueueService QueueService
	{
		get
		{
			int num = 1;
			int num2 = num;
			WorkflowQueueService workflowQueueService;
			while (true)
			{
				switch (num2)
				{
				case 1:
					workflowQueueService = _queueService;
					if (workflowQueueService == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					workflowQueueService = Locator.GetServiceNotNull<WorkflowQueueService>();
					break;
				}
				break;
			}
			return workflowQueueService;
		}
	}

	IThreadPool IThreadPoolContainer.Pool => ProcessingPool;

	protected virtual bool NoSaveResult => false;

	protected virtual IThreadPool ProcessingPool => QueueService.ProcessingPool;

	public virtual bool CanExecute(ISchedulerTaskJob job)
	{
		return job is TJob;
	}

	public virtual JobResult Do(ISchedulerTaskJob job, DateTime dateToRun)
	{
		//Discarded unreachable code: IL_008a, IL_0099
		int num = 2;
		int num2 = num;
		TJob val = default(TJob);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			default:
				return Do(val, dateToRun);
			case 1:
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 2:
				val = job as TJob;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual void CloseActiveJobs(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_002e, IL_003d, IL_0048, IL_00d7, IL_010f, IL_011e
		int num = 2;
		int num2 = num;
		IEnumerator<TJob> enumerator = default(IEnumerator<TJob>);
		TJob current = default(TJob);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					while (true)
					{
						IL_0089:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							goto IL_004c;
						}
						goto IL_0066;
						IL_004c:
						while (true)
						{
							switch (num3)
							{
							case 2:
								goto IL_0089;
							case 1:
								DeleteJob(current);
								num3 = 2;
								continue;
							case 3:
								return;
							}
							break;
						}
						goto IL_0066;
						IL_0066:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num3 = 0;
						}
						goto IL_004c;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								enumerator.Dispose();
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 0:
				return;
			case 2:
				enumerator = FindActiveOnceExecuteJobs(instance).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual JobResult Do(TJob job, DateTime dateToRun)
	{
		Contract.ServiceNotNull(WorkflowRuntimeService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651FA00D));
		IWorkflowBookmark bookmark = GetBookmark(job);
		if (bookmark == null)
		{
			return new JobResult
			{
				Information = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x19279851)),
				Status = JobStatus.Fail,
				NoSaveResult = NoSaveResult
			};
		}
		IWorkflowInstance instance = bookmark.Instance;
		if (instance == null)
		{
			return new JobResult
			{
				Information = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683730776)),
				Status = JobStatus.Fail,
				NoSaveResult = NoSaveResult
			};
		}
		if (instance.Status == WorkflowInstanceStatus.Completed || instance.Status == WorkflowInstanceStatus.Aborted || instance.Status == WorkflowInstanceStatus.Terminated)
		{
			return new JobResult
			{
				Information = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2C9B6)),
				Status = JobStatus.Success,
				NoSaveResult = NoSaveResult
			};
		}
		IWorkflowExecuteData data = CreateData(job, bookmark, dateToRun);
		WorkflowRuntimeService.Execute(data);
		return new JobResult
		{
			Information = GetSuccessMessage(),
			Status = JobStatus.Success,
			NoSaveResult = NoSaveResult
		};
	}

	protected abstract IWorkflowBookmark GetBookmark(TJob job);

	protected abstract IWorkflowExecuteData CreateData(TJob job, IWorkflowBookmark bookmark, DateTime dateToRun);

	protected virtual IEnumerable<TJob> FindActiveOnceExecuteJobs(IWorkflowInstance instance)
	{
		Contract.ServiceNotNull(SessionProvider, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214166562));
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<ISchedulerJobRunInfo>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7F2C27)).SetProjection((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768785279))).Add((ICriterion)(object)Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125913712), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708143550)));
		ICriteria val2 = SessionProvider.GetSession("").CreateCriteria(InterfaceActivator.TypeOf<TJob>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214165400)).Add((ICriterion)(object)CriteriaByOnceExecuteStatus())
			.Add((ICriterion)(object)Subqueries.NotExists(val));
		SetupFindActiveJobsCriteria(instance, val2);
		return val2.List<TJob>();
	}

	protected virtual AbstractCriterion CriteriaByOnceExecuteStatus()
	{
		int num = 1;
		int num2 = num;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			switch (num2)
			{
			default:
				return Restrictions.IsNull(LinqUtils.NameOf(Expression.Lambda<Func<TJob, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression })));
			case 1:
				parameterExpression = Expression.Parameter(typeof(TJob), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539503535));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected abstract void SetupFindActiveJobsCriteria(IWorkflowInstance instance, ICriteria criteria);

	protected virtual void DeleteJob(TJob job)
	{
		job.Delete();
		job.Task.Delete();
	}

	protected virtual string GetSuccessMessage()
	{
		return SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790206054));
	}

	protected WorkflowInstanceSchedulerJobExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool U8MGcUtPR5giroOuoCQ()
	{
		return FYiFMTtcloAxjXaFrHl == null;
	}

	internal static object fQWREFtXbTKWuNSE6jl()
	{
		return FYiFMTtcloAxjXaFrHl;
	}
}
