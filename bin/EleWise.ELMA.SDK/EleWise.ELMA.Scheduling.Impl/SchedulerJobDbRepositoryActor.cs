using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Scheduling.Triggers;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Scheduling.Impl;

internal sealed class SchedulerJobDbRepositoryActor : Actor, ISchedulerJobDbRepositoryActor, IActorWithGuidKey, IActor
{
	private readonly IRuntimeApplication runtimeApplication;

	private readonly ISchedulerJobRunInfoManager schedulerJobRunInfoManager;

	private readonly IEnumerable<ISchedulerJobDbRepository> schedulerJobDbRepositories;

	private readonly IFeatureFlagService featureFlagService;

	private readonly HashSet<Guid> forceRunTrigger;

	private Dictionary<Guid, ITrigger> schedulerTaskToTriggerMap;

	internal static SchedulerJobDbRepositoryActor A6pXyHBkSnFovK9fH7St;

	public override TimeSpan LifeTime { get; }

	public SchedulerJobDbRepositoryActor(IRuntimeApplication runtimeApplication, ISchedulerJobRunInfoManager schedulerJobRunInfoManager, IEnumerable<ISchedulerJobRepository> schedulerJobRepositories, IFeatureFlagService featureFlagService)
	{
		SingletonReader.JJCZtPuTvSt();
		forceRunTrigger = new HashSet<Guid>();
		LifeTime = TimeSpan.FromDays(365.0);
		base._002Ector();
		this.runtimeApplication = runtimeApplication;
		this.schedulerJobRunInfoManager = schedulerJobRunInfoManager;
		schedulerJobDbRepositories = schedulerJobRepositories.OfType<ISchedulerJobDbRepository>();
		this.featureFlagService = featureFlagService;
	}

	public override Task OnActivateAsync()
	{
		return Refresh();
	}

	[AsyncStateMachine(typeof(_003CGetSchedulerTasksUid_003Ed__11))]
	public Task<IEnumerable<Guid>> GetSchedulerTasksUid(DateTime dateTimeToRun)
	{
		_003CGetSchedulerTasksUid_003Ed__11 stateMachine = default(_003CGetSchedulerTasksUid_003Ed__11);
		stateMachine._003C_003E4__this = this;
		stateMachine.dateTimeToRun = dateTimeToRun;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<Guid>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable<Guid>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task AddForceRunTrigger(Guid triggerUid)
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (Task)E2UrAHBkqaS9b0grpInW();
			}
		}
	}

	public Task Refresh()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				schedulerTaskToTriggerMap = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Task.CompletedTask;
			}
		}
	}

	private IEnumerable<Guid> GetSchedulerTasksUidInternal(DateTime dateTimeToRun)
	{
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
		_003C_003Ec__DisplayClass14_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass14_.dateTimeToRun = dateTimeToRun;
		using (CallContextSessionOwner.Create())
		{
			_003C_003Ec__DisplayClass14_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass14_;
			if (schedulerTaskToTriggerMap == null)
			{
				schedulerTaskToTriggerMap = new Dictionary<Guid, ITrigger>();
				ISchedulerJob[] array = schedulerJobDbRepositories.SelectMany((ISchedulerJobDbRepository repository) => repository.GetSchedulerJobs()).ToArray();
				foreach (ISchedulerJob schedulerJob in array)
				{
					schedulerTaskToTriggerMap.Add(((ISchedulerJobDb)schedulerJob).SchedulerTask.Uid, schedulerJob.Trigger);
				}
			}
			CS_0024_003C_003E8__locals0.schedulerJobRunInfos = schedulerJobRunInfoManager.GetLastRunInfos(schedulerTaskToTriggerMap.Select((KeyValuePair<Guid, ITrigger> p) => p.Key), onlyFinished: false);
			List<Guid> list = new List<Guid>();
			foreach (ISchedulerJobRunInfo item in CS_0024_003C_003E8__locals0.schedulerJobRunInfos.Where((ISchedulerJobRunInfo item) => item != null).ToList())
			{
				ITrigger trigger = schedulerTaskToTriggerMap[item.Job.Task.Uid];
				if ((item.Status == JobStatus.Pending || item.Status == JobStatus.Working) && (item.ConnectionUid == Guid.Empty || !runtimeApplication.IsConnectionAlive(item.ConnectionUid) || CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.dateTimeToRun > item.StatusUpdateDate.Add(trigger.GetTriggerTimeout())))
				{
					list.Add(trigger.Id);
					CS_0024_003C_003E8__locals0.schedulerJobRunInfos.Remove(item);
				}
			}
			CS_0024_003C_003E8__locals0.schedulerJobRunInfos.AddRange(schedulerJobRunInfoManager.GetLastRunInfos(list, onlyFinished: true));
			return (from item in schedulerTaskToTriggerMap.Where(delegate(KeyValuePair<Guid, ITrigger> item)
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_2();
					CS_0024_003C_003E8__locals0.item = item;
					if (CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.forceRunTrigger.Contains(CS_0024_003C_003E8__locals0.item.Value.Id))
					{
						CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.forceRunTrigger.Remove(CS_0024_003C_003E8__locals0.item.Value.Id);
						return true;
					}
					ISchedulerJobRunInfo schedulerJobRunInfo = CS_0024_003C_003E8__locals0.schedulerJobRunInfos.FirstOrDefault((ISchedulerJobRunInfo info) => _003C_003Ec__DisplayClass14_2.pShldkQIDhW2b3Dr3CDB(_003C_003Ec__DisplayClass14_2.Oed0ETQIpdYJNxvJj5I9(info), _003C_003Ec__DisplayClass14_2.d9llU7QIaBvo2doZ2PKL(CS_0024_003C_003E8__locals0.item.Value)));
					if (schedulerJobRunInfo != null && (schedulerJobRunInfo.Status == JobStatus.Pending || schedulerJobRunInfo.Status == JobStatus.Pending))
					{
						return false;
					}
					DateTime? dateTime = schedulerJobRunInfo?.DateToRun;
					return ((CS_0024_003C_003E8__locals0.item.Value is OnceExecuteTrigger) ? CS_0024_003C_003E8__locals0.item.Value.GetNextTimeAfter(dateTime, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.dateTimeToRun) : CS_0024_003C_003E8__locals0.item.Value.GetNextTimeAfterUnfolded(dateTime, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.dateTimeToRun)).HasValue;
				})
				select item.Key).ToArray();
		}
	}

	internal static object E2UrAHBkqaS9b0grpInW()
	{
		return Task.CompletedTask;
	}

	internal static bool m9m8t7BkioVlb53tsDBq()
	{
		return A6pXyHBkSnFovK9fH7St == null;
	}

	internal static SchedulerJobDbRepositoryActor pf0LKcBkRngBpCImGe2m()
	{
		return A6pXyHBkSnFovK9fH7St;
	}
}
