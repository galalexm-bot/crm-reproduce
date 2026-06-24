using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Scheduling.Managers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scheduling;

internal sealed class SchedulerJobActor : Actor, ISchedulerJobActor, IActorWithGuidCompoundKey, IActor
{
	private readonly ISchedulerTaskManager schedulerTaskManager;

	private readonly ISchedulerJobRunInfoManager schedulerJobRunInfoManager;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly IEnumerable<ISchedulerJobRepository> schedulerJobRepositories;

	internal const string NonDbRepositoryJob = "NonDbRepositoryJob";

	internal const string DbRepositoryJob = "DbRepositoryJob";

	internal static SchedulerJobActor GmuhUhBqk6F1QlXoPQ9C;

	public SchedulerJobActor(ISchedulerTaskManager schedulerTaskManager, ISchedulerJobRunInfoManager schedulerJobRunInfoManager, IRuntimeApplication runtimeApplication, IEnumerable<ISchedulerJobRepository> schedulerJobRepositories)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.schedulerTaskManager = schedulerTaskManager;
		this.schedulerJobRunInfoManager = schedulerJobRunInfoManager;
		this.runtimeApplication = runtimeApplication;
		this.schedulerJobRepositories = schedulerJobRepositories;
	}

	public Task Run()
	{
		return RunInternal(forceRunJob: false, ItLQZuBq2Ff06ViveePd());
	}

	public Task ForceRunJob(Guid? jobUid = null, DateTime? now = null)
	{
		return RunInternal(forceRunJob: true, now ?? DateTime.Now, jobUid);
	}

	[AsyncStateMachine(typeof(_003CRunInternal_003Ed__9))]
	private Task RunInternal(bool forceRunJob, DateTime currentDateTime, Guid? jobUid = null)
	{
		_003CRunInternal_003Ed__9 stateMachine = default(_003CRunInternal_003Ed__9);
		stateMachine._003C_003E4__this = this;
		stateMachine.forceRunJob = forceRunJob;
		stateMachine.currentDateTime = currentDateTime;
		stateMachine.jobUid = jobUid;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private ISchedulerJob Reload(Guid taskId)
	{
		return schedulerJobRepositories.OfType<ISchedulerJobDbRepository>().Single().CreateSchedulerJob(schedulerTaskManager.Load(taskId));
	}

	private void RunJob(DateTime currentDateTime, ISchedulerJob schedulerJob, IJob job)
	{
		//Discarded unreachable code: IL_0059, IL_008c, IL_00dc, IL_00eb
		int num = 2;
		int num2 = num;
		JobResult result = default(JobResult);
		DateTime now = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					result = job.Do(now);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
						{
							JobResult jobResult2 = new JobResult();
							Iok6WvBqPRkf1UhlBNJP(jobResult2, JobStatus.Fail);
							DPFuDSBq1RF6covn40Wg(jobResult2, ex.ToString());
							result = jobResult2;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
							{
								num4 = 0;
							}
							continue;
						}
						case 0:
							break;
						}
						break;
					}
				}
				break;
			case 1:
				now = DateTime.Now;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				schedulerJobRunInfoManager.SetResult((ITrigger)Y8WVmLBqeJrDckNy8pkn(schedulerJob), job, now, now, result);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
			{
				ISchedulerJobRunInfoManager obj = schedulerJobRunInfoManager;
				object trigger = Y8WVmLBqeJrDckNy8pkn(schedulerJob);
				JobResult jobResult = new JobResult();
				Iok6WvBqPRkf1UhlBNJP(jobResult, JobStatus.Working);
				obj.SetResult((ITrigger)trigger, job, currentDateTime, jobResult);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			case 5:
				break;
			case 4:
				return;
			}
			RefreshSchedulerJobImpl(schedulerJob);
			num2 = 3;
		}
	}

	private void RefreshSchedulerJobImpl(ISchedulerJob schedulerJob)
	{
		//Discarded unreachable code: IL_0032
		int num = 2;
		int num2 = num;
		ISchedulerJobDb schedulerJobDb = default(ISchedulerJobDb);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				return;
			case 3:
				schedulerJobDb.Refresh();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if ((schedulerJobDb = schedulerJob as ISchedulerJobDb) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static DateTime ItLQZuBq2Ff06ViveePd()
	{
		return DateTime.Now;
	}

	internal static bool w2iRhhBqn7rXFVxMr6kR()
	{
		return GmuhUhBqk6F1QlXoPQ9C == null;
	}

	internal static SchedulerJobActor v3MY6lBqO9i8t6eEq6vx()
	{
		return GmuhUhBqk6F1QlXoPQ9C;
	}

	internal static object Y8WVmLBqeJrDckNy8pkn(object P_0)
	{
		return ((ISchedulerJob)P_0).Trigger;
	}

	internal static void Iok6WvBqPRkf1UhlBNJP(object P_0, JobStatus value)
	{
		((JobResult)P_0).Status = value;
	}

	internal static void DPFuDSBq1RF6covn40Wg(object P_0, object P_1)
	{
		((JobResult)P_0).ErrorDescription = (string)P_1;
	}
}
