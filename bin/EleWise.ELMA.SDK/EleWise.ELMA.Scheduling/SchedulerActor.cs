using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling;

internal sealed class SchedulerActor : Actor, ISchedulerActor, IActorWithGuidKey, IActor
{
	private sealed class SchedulerJobActorAction
	{
		private readonly object schedulerJobActor;

		private readonly object cancellationTokenSource;

		private readonly object schedulerJobTrigger;

		private readonly ICollection<IJob> jobs;

		private readonly DateTime dateToRun;

		private readonly object schedulerJobRunInfoManager;

		private static object DEKty8Q8VOG6uc4trPbp;

		public bool ForceRun { get; }

		public SchedulerJobActorAction(ISchedulerJobActor schedulerJobActor, bool forceRun, CancellationTokenSource cancellationTokenSource, ITrigger schedulerJobTrigger, ICollection<IJob> jobs, DateTime dateToRun, ISchedulerJobRunInfoManager schedulerJobRunInfoManager)
		{
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			this.schedulerJobActor = schedulerJobActor;
			ForceRun = forceRun;
			this.cancellationTokenSource = cancellationTokenSource;
			this.schedulerJobTrigger = schedulerJobTrigger;
			this.jobs = jobs;
			this.dateToRun = dateToRun;
			this.schedulerJobRunInfoManager = schedulerJobRunInfoManager;
		}

		[AsyncStateMachine(typeof(_003CRun_003Ed__10))]
		public Task Run()
		{
			int num = 1;
			AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
			_003CRun_003Ed__10 stateMachine = default(_003CRun_003Ed__10);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						_003C_003Et__builder = stateMachine._003C_003Et__builder;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 2;
						}
						continue;
					default:
						stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						num2 = 5;
						continue;
					case 1:
						stateMachine._003C_003E4__this = this;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 0;
						}
						continue;
					case 4:
						return stateMachine._003C_003Et__builder.Task;
					case 5:
						break;
					case 2:
						_003C_003Et__builder.Start(ref stateMachine);
						num2 = 4;
						continue;
					}
					break;
				}
				stateMachine._003C_003E1__state = -1;
				num = 3;
			}
		}

		internal static bool cqQ1p3Q8SnIJ8UuuLiBy()
		{
			return DEKty8Q8VOG6uc4trPbp == null;
		}

		internal static SchedulerJobActorAction swSIAvQ8iipbP5mkyw6y()
		{
			return (SchedulerJobActorAction)DEKty8Q8VOG6uc4trPbp;
		}
	}

	private readonly ISchedulerJobRunInfoManager schedulerJobRunInfoManager;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly ISchedulerTaskManager schedulerTaskManager;

	private readonly IEnumerable<ISchedulerJobRepository> schedulerJobRepositories;

	private readonly IFeatureFlagService featureFlagService;

	private readonly IDistributedFeatureFlagService distributedFeatureFlagService;

	private readonly List<Guid> forceRunTrigger;

	private readonly ElmaTasksPool tasksPool;

	internal static SchedulerActor HxelOaBqCls2K5Lv6CI0;

	public SchedulerActor(ISchedulerJobRunInfoManager schedulerJobRunInfoManager, IRuntimeApplication runtimeApplication, IActorModelRuntime actorModelRuntime, IEnumerable<ISchedulerJobRepository> schedulerJobRepositories, ISchedulerTaskManager schedulerTaskManager, IFeatureFlagService featureFlagService, IDistributedFeatureFlagService distributedFeatureFlagService)
	{
		SingletonReader.JJCZtPuTvSt();
		forceRunTrigger = new List<Guid>();
		tasksPool = new ElmaTasksPool(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A4C821), 5);
		base._002Ector();
		this.schedulerJobRunInfoManager = schedulerJobRunInfoManager;
		this.runtimeApplication = runtimeApplication;
		this.actorModelRuntime = actorModelRuntime;
		this.schedulerJobRepositories = schedulerJobRepositories;
		this.schedulerTaskManager = schedulerTaskManager;
		this.featureFlagService = featureFlagService;
		this.distributedFeatureFlagService = distributedFeatureFlagService;
	}

	public override Task OnActivateAsync()
	{
		int num = 2;
		int num3 = default(int);
		TimeSpan timeSpan = default(TimeSpan);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3 = SR.GetSetting((string)zuU4D2BqZKKZ0pGlaX2C(-1751176224 ^ -1751239138), 10);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					RegisterTimer(ProcessSchedulerJobQueue, null, timeSpan, timeSpan);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return (Task)lCbj04Bqu5UL9GMqxxbd();
				case 3:
					num3 = 10;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					if (num3 < 0)
					{
						num2 = 3;
						continue;
					}
					break;
				case 4:
					break;
				}
				break;
			}
			timeSpan = TimeSpan.FromSeconds(num3);
			num = 5;
		}
	}

	public override Task OnDeactivateAsync()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return base.OnDeactivateAsync();
			case 1:
				dWJ3OGBqIypR6bhsmbgJ(tasksPool);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Task Start()
	{
		return RegisterOrUpdateReminder((string)zuU4D2BqZKKZ0pGlaX2C(-672123589 ^ -672060643), xOLqXcBqVOdsZFcQI0to(1.0), xOLqXcBqVOdsZFcQI0to(1.0));
	}

	public Task RunTrigger(Guid triggerUid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				forceRunTrigger.Add(triggerUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return actorModelRuntime.GetActor<ISchedulerJobDbRepositoryActor>(Guid.Empty).AddForceRunTrigger(triggerUid);
			}
		}
	}

	public Task RunSchedulerJob(Guid triggerUid, DateTime currentDateTime, bool forceRun)
	{
		//Discarded unreachable code: IL_0093, IL_00a2
		int num = 4;
		int num2 = num;
		SchedulerJobActorAction schedulerJobActor = default(SchedulerJobActorAction);
		ISchedulerJob item = default(ISchedulerJob);
		bool item2 = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return schedulerJobActor.Run();
			case 5:
				PushSchedulerJobs(schedulerJobActor.ToEnumerable());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (schedulerJobActor == null)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 1:
				if (schedulerJobActor.ForceRun)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 4:
			{
				(ISchedulerJob schedulerJob, bool taskFromDbRepository) schedulerJobFromTriggerUid = GetSchedulerJobFromTriggerUid(triggerUid);
				item = schedulerJobFromTriggerUid.schedulerJob;
				item2 = schedulerJobFromTriggerUid.taskFromDbRepository;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 3;
				}
				break;
			}
			default:
				return (Task)lCbj04Bqu5UL9GMqxxbd();
			case 3:
				schedulerJobActor = GetSchedulerJobActor((ITrigger)B1g8p0BqSQF9jPLPt6np(item), currentDateTime, item2, forceRun, forceRun ? new DateTime?(currentDateTime) : null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CForceRunJob_003Ed__18))]
	public Task ForceRunJob(Guid triggerUid, Guid jobUid, DateTime? now = null)
	{
		_003CForceRunJob_003Ed__18 stateMachine = default(_003CForceRunJob_003Ed__18);
		stateMachine._003C_003E4__this = this;
		stateMachine.triggerUid = triggerUid;
		stateMachine.jobUid = jobUid;
		stateMachine.now = now;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CRunStepOnce_003Ed__19))]
	private Task RunStepOnce(DateTime currentDateTime)
	{
		int num = 3;
		_003CRunStepOnce_003Ed__19 stateMachine = default(_003CRunStepOnce_003Ed__19);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return stateMachine._003C_003Et__builder.Task;
				case 1:
					stateMachine._003C_003E1__state = -1;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					stateMachine.currentDateTime = currentDateTime;
					num2 = 6;
					continue;
				case 6:
					stateMachine._003C_003Et__builder = iUOWV1BqiJAeKBnYsnqZ();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					stateMachine._003C_003E4__this = this;
					num2 = 2;
					continue;
				case 5:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
			_003C_003Et__builder = stateMachine._003C_003Et__builder;
			num = 5;
		}
	}

	private (ISchedulerJob schedulerJob, bool taskFromDbRepository) GetSchedulerJobFromTriggerUid(Guid triggerUid)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0.triggerUid = triggerUid;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		bool item = false;
		ISchedulerJob schedulerJob = schedulerJobRepositories.Where((ISchedulerJobRepository repository) => !(repository is ISchedulerJobDbRepository)).SelectMany((ISchedulerJobRepository repository) => repository.GetSchedulerJobs()).FirstOrDefault((ISchedulerJob job) => _003C_003Ec__DisplayClass20_0.yFAej3Q8Ub1pAXTfc1rR(_003C_003Ec__DisplayClass20_0.N1tMsCQ8LeCN07YIj1pb(_003C_003Ec__DisplayClass20_0.BRCEUdQ8YcR7S6f3robG(job)), CS_0024_003C_003E8__locals0.triggerUid));
		if (schedulerJob == null)
		{
			schedulerJob = (from repository in schedulerJobRepositories.OfType<ISchedulerJobDbRepository>()
				select CS_0024_003C_003E8__locals0._003C_003E4__this.GetSchedulerJob(repository, CS_0024_003C_003E8__locals0.triggerUid)).FirstOrDefault((ISchedulerJob job) => job != null);
			if (schedulerJob == null)
			{
				throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957752314), CS_0024_003C_003E8__locals0.triggerUid));
			}
			item = true;
		}
		return (schedulerJob, item);
	}

	private ISchedulerJob GetSchedulerJob(ISchedulerJobDbRepository repository, Guid taskUid)
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 1;
		int num2 = num;
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return repository.CreateSchedulerJob(schedulerTask);
			case 3:
				return null;
			default:
				if (schedulerTask == null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			case 1:
				schedulerTask = schedulerTaskManager.LoadOrNull(taskUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CRunStep_003Ed__22))]
	private Task RunStep(DateTime currentDateTime)
	{
		int num = 4;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CRunStep_003Ed__22 stateMachine = default(_003CRunStep_003Ed__22);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 2;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				stateMachine.currentDateTime = currentDateTime;
				num2 = 5;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CProcessSchedulerJobQueue_003Ed__23))]
	private Task ProcessSchedulerJobQueue(object arg)
	{
		int num = 3;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CProcessSchedulerJobQueue_003Ed__23 stateMachine = default(_003CProcessSchedulerJobQueue_003Ed__23);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					break;
				default:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					stateMachine._003C_003E1__state = -1;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return stateMachine._003C_003Et__builder.Task;
				case 3:
					stateMachine._003C_003E4__this = this;
					num2 = 2;
					continue;
				}
				break;
			}
			stateMachine._003C_003Et__builder = iUOWV1BqiJAeKBnYsnqZ();
			num = 5;
		}
	}

	private void PushSchedulerJobs(IEnumerable<SchedulerJobActorAction> schedulerJobActorActions)
	{
		using IEnumerator<SchedulerJobActorAction> enumerator = schedulerJobActorActions.Where((SchedulerJobActorAction a) => a != null).GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass24_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass24_0();
			CS_0024_003C_003E8__locals0.stepSchedulerJobActorAction = enumerator.Current;
			tasksPool.Push(() => (Task)_003C_003Ec__DisplayClass24_0.TkuRoQQZIA7MRZwOYhhI(CS_0024_003C_003E8__locals0.stepSchedulerJobActorAction));
		}
	}

	private SchedulerJobActorAction GetSchedulerJobActor(ITrigger schedulerJobTrigger, DateTime currentDateTime, bool jobFromDbRepository, bool forceRun, DateTime? dateTimeToRun)
	{
		return GetSchedulerJobActor(schedulerJobTrigger, currentDateTime, jobFromDbRepository, forceRun, dateTimeToRun, null, null);
	}

	private SchedulerJobActorAction GetSchedulerJobActor(ITrigger schedulerJobTrigger, DateTime currentDateTime, bool jobFromDbRepository, bool forceRun, DateTime? dateTimeToRun, CancellationTokenSource cancellationTokenSource, ICollection<IJob> jobs)
	{
		if (forceRunTrigger.Contains(schedulerJobTrigger.Id))
		{
			forceRun = true;
			forceRunTrigger.Remove(schedulerJobTrigger.Id);
		}
		dateTimeToRun = dateTimeToRun ?? (forceRun ? new DateTime?(currentDateTime) : SchedulerHelper.GetDateTimeToRun(schedulerJobTrigger, currentDateTime, schedulerJobRunInfoManager, runtimeApplication));
		if (!dateTimeToRun.HasValue)
		{
			return null;
		}
		return new SchedulerJobActorAction(actorModelRuntime.GetActor<ISchedulerJobActor>(schedulerJobTrigger.Id, jobFromDbRepository ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870828307) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6DC147B0 ^ 0x6DC05902)), forceRun, cancellationTokenSource, schedulerJobTrigger, jobs, dateTimeToRun.Value, schedulerJobRunInfoManager);
	}

	internal static object zuU4D2BqZKKZ0pGlaX2C(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object lCbj04Bqu5UL9GMqxxbd()
	{
		return Task.CompletedTask;
	}

	internal static bool qgLNCsBqvJ2vwY7Sr7TL()
	{
		return HxelOaBqCls2K5Lv6CI0 == null;
	}

	internal static SchedulerActor eedNYtBq852VSwQx6Fkw()
	{
		return HxelOaBqCls2K5Lv6CI0;
	}

	internal static void dWJ3OGBqIypR6bhsmbgJ(object P_0)
	{
		((ElmaTasksPool)P_0).Dispose();
	}

	internal static TimeSpan xOLqXcBqVOdsZFcQI0to(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static object B1g8p0BqSQF9jPLPt6np(object P_0)
	{
		return ((ISchedulerJob)P_0).Trigger;
	}

	internal static AsyncTaskMethodBuilder iUOWV1BqiJAeKBnYsnqZ()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
