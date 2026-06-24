using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling.Impl;

[Component(Type = ComponentType.WebServer, EnableInterceptors = true)]
public class SchedulerJobRepository : ISchedulerJobRepository, ISchedulerJobDbRepository
{
	private sealed class SchedulerJobImpl : SchedulerJobBase, ISchedulerJobDb, ISchedulerJob
	{
		private readonly long schedulerTaskId;

		private object trigger;

		private readonly IEntityManager<ISchedulerTask> schedulerTaskManager;

		private readonly IEntityManager<ISchedulerTaskJob> schedulerTaskJobManager;

		private readonly List<IJob> jobs;

		internal static object PclSnkQIHXhBZpH8oykK;

		public override Guid? OwnerUid => SchedulerTask.OwnerUid;

		public override ITrigger Trigger => (ITrigger)trigger;

		public override ICollection<IJob> Jobs => jobs;

		public ISchedulerTask SchedulerTask
		{
			[CompilerGenerated]
			get
			{
				return _003CSchedulerTask_003Ek__BackingField;
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
						_003CSchedulerTask_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
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

		public static SchedulerJobImpl Create(object productionCalendarService, IEnumerable<ISchedulerTaskJobExecutor> schedulerTaskJobExecutors, IEntityManager<ISchedulerTask> schedulerTaskManager, IEntityManager<ISchedulerTaskJob> schedulerTaskJobManager, object schedulerTask, DateTime? customExecuteTime = null)
		{
			_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
			ITrigger trigger = null;
			CS_0024_003C_003E8__locals0.job = new SchedulerJobImpl((ISchedulerTask)schedulerTask, null, schedulerTaskJobExecutors, schedulerTaskManager, schedulerTaskJobManager);
			switch (((ISchedulerTask)schedulerTask).Type)
			{
			case SchedulerTaskType.Periodic:
				trigger = new NthIncludedDayTrigger((NthIncludedDaySettings)((ISchedulerTask)schedulerTask).Settings, ((IProductionCalendarService)productionCalendarService).GetGlobalProductionSchedule())
				{
					Name = ((ISchedulerTask)schedulerTask).Name,
					Id = ((ISchedulerTask)schedulerTask).Uid
				};
				break;
			case SchedulerTaskType.Once:
				trigger = (((ISchedulerTask)schedulerTask).OnceExecuteTime.HasValue ? new OnceExecuteTrigger(() => CS_0024_003C_003E8__locals0.job.SchedulerTask)
				{
					Name = ((ISchedulerTask)schedulerTask).Name,
					Id = ((ISchedulerTask)schedulerTask).Uid
				} : null);
				break;
			}
			if (trigger == null)
			{
				return null;
			}
			SchedulerJobImpl job = CS_0024_003C_003E8__locals0.job;
			ITrigger obj;
			if (!customExecuteTime.HasValue)
			{
				obj = trigger;
			}
			else
			{
				ITrigger trigger2 = new CustomExecuteTimeTrigger(trigger, customExecuteTime.Value);
				obj = trigger2;
			}
			job.trigger = obj;
			return CS_0024_003C_003E8__locals0.job;
		}

		private SchedulerJobImpl(ISchedulerTask schedulerTask, ITrigger trigger, IEnumerable<ISchedulerTaskJobExecutor> schedulerTaskJobExecutors, IEntityManager<ISchedulerTask> schedulerTaskManager, IEntityManager<ISchedulerTaskJob> schedulerTaskJobManager)
		{
			SingletonReader.JJCZtPuTvSt();
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals0.schedulerTaskJobExecutors = schedulerTaskJobExecutors;
			base._002Ector();
			Contract.ArgumentNotNull(schedulerTask, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1ECE530A ^ 0x1ECB20FA));
			Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.schedulerTaskJobExecutors, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420576472));
			Contract.ArgumentNotNull(schedulerTaskManager, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106301568));
			Contract.ArgumentNotNull(schedulerTaskJobManager, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31371576));
			schedulerTaskId = schedulerTask.Id;
			SchedulerTask = schedulerTask;
			this.trigger = trigger;
			this.schedulerTaskManager = schedulerTaskManager;
			this.schedulerTaskJobManager = schedulerTaskJobManager;
			jobs = ((IEnumerable<ISchedulerTaskJob>)schedulerTask.Jobs).Select((ISchedulerTaskJob j) => new JobImpl(j, CS_0024_003C_003E8__locals0.schedulerTaskJobExecutors)).Cast<IJob>().ToList();
		}

		public void Refresh()
		{
			//Discarded unreachable code: IL_0069, IL_0073, IL_0193, IL_01a6, IL_01b5
			int num = 2;
			int num2 = num;
			List<IJob>.Enumerator enumerator = default(List<IJob>.Enumerator);
			JobImpl jobImpl = default(JobImpl);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 2:
					SchedulerTask = schedulerTaskManager.Load(schedulerTaskId);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
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
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
								{
									num3 = 0;
								}
								goto IL_0077;
							}
							goto IL_00bf;
							IL_00bf:
							jobImpl = (JobImpl)enumerator.Current;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num3 = 1;
							}
							goto IL_0077;
							IL_0077:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 0:
									return;
								case 5:
									break;
								case 2:
									goto IL_00bf;
								case 3:
									if (jobImpl.job != null)
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
										{
											num3 = 4;
										}
										continue;
									}
									break;
								case 4:
									jobImpl.job = jobImpl.job.CastAsRealType();
									num3 = 5;
									continue;
								case 1:
									jobImpl.job = schedulerTaskJobManager.Load(jobImpl.job.Id);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
				case 1:
					enumerator = jobs.GetEnumerator();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static bool cMJbUMQIAe5L5Rg1Cfnd()
		{
			return PclSnkQIHXhBZpH8oykK == null;
		}

		internal static SchedulerJobImpl SmqamfQI7hlMtU7M2dva()
		{
			return (SchedulerJobImpl)PclSnkQIHXhBZpH8oykK;
		}
	}

	internal class JobImpl : IJob, IThreadPoolContainer
	{
		internal ISchedulerTaskJob job;

		internal readonly ISchedulerTaskJobExecutor executor;

		private readonly IThreadPool threadPool;

		internal static JobImpl nbv4RlQIxFtVF4SD24cd;

		public Guid Id => Jco4RPQIyY07yIOZTufF(job);

		public string Name => (string)fSFoHhQIM0MwYcuhhC6M(job);

		public Image Icon => null;

		IThreadPool IThreadPoolContainer.Pool => threadPool;

		public JobImpl(ISchedulerTaskJob job, IEnumerable<ISchedulerTaskJobExecutor> schedulerTaskJobExecutors)
		{
			SingletonReader.JJCZtPuTvSt();
			_003C_003Ec__DisplayClass2_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2_0();
			CS_0024_003C_003E8__locals0.job = job;
			base._002Ector();
			Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.job, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411124015));
			this.job = CS_0024_003C_003E8__locals0.job.CastAsRealType();
			executor = schedulerTaskJobExecutors.FirstOrDefault((ISchedulerTaskJobExecutor e) => e.CanExecute(CS_0024_003C_003E8__locals0.job));
			threadPool = ((executor is IThreadPoolContainer threadPoolContainer) ? threadPoolContainer.Pool : null);
		}

		public JobResult Do(DateTime dateToRun)
		{
			int num = 3;
			JobResult jobResult = default(JobResult);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						B0UjNdQIdWegRkfRXeHl(jobResult, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BEC1C2), job.GetType().FullName));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 0;
						}
						continue;
					case 2:
						((ILogger)homo5AQIJPupZ30ZFaxk()).Error((string)cGB4QUQI9LVZYtFxTqXD(-218496594 ^ -218139380) + job.GetType().FullName + (string)cGB4QUQI9LVZYtFxTqXD(0x53CB464B ^ 0x53CE32A9));
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
						{
							num2 = 0;
						}
						continue;
					case 5:
						jobResult.Status = JobStatus.Fail;
						num2 = 4;
						continue;
					case 1:
						break;
					case 3:
						if (executor == null)
						{
							num2 = 2;
							continue;
						}
						return executor.Do(job, dateToRun);
					default:
						return jobResult;
					}
					break;
				}
				jobResult = new JobResult();
				num = 5;
			}
		}

		internal static Guid Jco4RPQIyY07yIOZTufF(object P_0)
		{
			return ((ISchedulerTaskJob)P_0).Uid;
		}

		internal static bool oq8thQQI0C0PYPxrgH8V()
		{
			return nbv4RlQIxFtVF4SD24cd == null;
		}

		internal static JobImpl PFIDE8QImD3lroBNNSLN()
		{
			return nbv4RlQIxFtVF4SD24cd;
		}

		internal static object fSFoHhQIM0MwYcuhhC6M(object P_0)
		{
			return ((ISchedulerTaskJob)P_0).Name;
		}

		internal static object homo5AQIJPupZ30ZFaxk()
		{
			return Logger.Log;
		}

		internal static object cGB4QUQI9LVZYtFxTqXD(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void B0UjNdQIdWegRkfRXeHl(object P_0, object P_1)
		{
			((JobResult)P_0).ErrorDescription = (string)P_1;
		}
	}

	private static SchedulerJobRepository mWIqreBk2eNNLIHVXqG3;

	public SchedulerTaskManager SchedulerTaskManager
	{
		[CompilerGenerated]
		get
		{
			return _003CSchedulerTaskManager_003Ek__BackingField;
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
					_003CSchedulerTaskManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
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

	public ILockManager LockManager
	{
		[CompilerGenerated]
		get
		{
			return _003CLockManager_003Ek__BackingField;
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
					_003CLockManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SchedulerJobRunInfoManager SchedulerJobRunInfoManager
	{
		[CompilerGenerated]
		get
		{
			return _003CSchedulerJobRunInfoManager_003Ek__BackingField;
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
					_003CSchedulerJobRunInfoManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IUnitOfWorkManager UnitOfWorkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUnitOfWorkManager_003Ek__BackingField;
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
					_003CUnitOfWorkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
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

	public IProductionCalendarService ProductionCalendarService
	{
		[CompilerGenerated]
		get
		{
			return _003CProductionCalendarService_003Ek__BackingField;
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
					_003CProductionCalendarService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<ISchedulerTaskJobExecutor> SchedulerTaskJobExecutors { get; set; }

	public IEntityManager<ISchedulerTaskJob> SchedulerTaskJobManager { get; set; }

	public IActorModelRuntime ActorModelRuntime
	{
		[CompilerGenerated]
		get
		{
			return _003CActorModelRuntime_003Ek__BackingField;
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
					_003CActorModelRuntime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
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

	public IFeatureFlagService FeatureFlagService
	{
		[CompilerGenerated]
		get
		{
			return _003CFeatureFlagService_003Ek__BackingField;
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
					_003CFeatureFlagService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
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

	public ICollection<ISchedulerJob> GetSchedulerJobs()
	{
		if (!FeatureFlagService.Enabled(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317720846), defaultEnabled: true))
		{
			return new ISchedulerJob[0];
		}
		return (from t in SchedulerTaskManager.FindPeriodicTasksToExecute()
			select SchedulerJobImpl.Create(ProductionCalendarService, SchedulerTaskJobExecutors, SchedulerTaskManager, SchedulerTaskJobManager, t) into j
			where j != null
			select j).Cast<ISchedulerJob>().ToList();
	}

	public ISchedulerJob CreateSchedulerJob(ISchedulerTask task, DateTime? customExecuteTime = null)
	{
		return SchedulerJobImpl.Create(ProductionCalendarService, SchedulerTaskJobExecutors, SchedulerTaskManager, SchedulerTaskJobManager, task, customExecuteTime);
	}

	public virtual ICollection<ISchedulerJob> GetOnceSchedulerJobs()
	{
		using (LockManager.Lock(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576091738)))
		{
			_003C_003Ec__DisplayClass38_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass38_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.result = new List<ISchedulerJob>();
			UnitOfWorkManager.Execute((Action)delegate
			{
				//Discarded unreachable code: IL_002e, IL_003c, IL_0104, IL_015c, IL_016b, IL_017b, IL_01d2, IL_0202, IL_0211, IL_021d, IL_022c
				int num = 1;
				int num2 = num;
				IEnumerator<SchedulerJobImpl> enumerator = default(IEnumerator<SchedulerJobImpl>);
				SchedulerJobImpl current = default(SchedulerJobImpl);
				while (true)
				{
					switch (num2)
					{
					default:
						try
						{
							while (true)
							{
								int num3;
								if (!_003C_003Ec__DisplayClass38_0.Jb89ONQVFkFMWpWhEPup(enumerator))
								{
									num3 = 7;
									goto IL_0040;
								}
								goto IL_010e;
								IL_0040:
								while (true)
								{
									switch (num3)
									{
									case 10:
										if (_003C_003Ec__DisplayClass38_0.vRo5p8QIsa4rV02VUpr6(current.Jobs) != 0)
										{
											num3 = 3;
											continue;
										}
										goto case 2;
									case 2:
										if (_003C_003Ec__DisplayClass38_0.B758JpQIcj7uuSwyNdFH(current) != null)
										{
											num3 = 9;
											continue;
										}
										goto case 1;
									case 1:
									case 3:
										if (!CS_0024_003C_003E8__locals0._003C_003E4__this.SchedulerJobRunInfoManager.SetPendingWithNoLock((ITrigger)_003C_003Ec__DisplayClass38_0.YMGsgOQIz8VmFBRwIhD2(current), current.Jobs, ((ISchedulerTask)_003C_003Ec__DisplayClass38_0.B758JpQIcj7uuSwyNdFH(current)).OnceExecuteTime.Value))
										{
											num3 = 6;
											continue;
										}
										goto case 5;
									case 4:
										goto IL_010e;
									case 9:
										((IEntity)_003C_003Ec__DisplayClass38_0.B758JpQIcj7uuSwyNdFH(current)).Delete();
										num3 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
										{
											num3 = 3;
										}
										continue;
									case 5:
										CS_0024_003C_003E8__locals0.result.Add(current);
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
										{
											num3 = 0;
										}
										continue;
									case 7:
										return;
									}
									break;
								}
								continue;
								IL_010e:
								current = enumerator.Current;
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
								{
									num3 = 1;
								}
								goto IL_0040;
							}
						}
						finally
						{
							int num4;
							if (enumerator == null)
							{
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
								{
									num4 = 1;
								}
								goto IL_01d6;
							}
							goto IL_01ec;
							IL_01ec:
							_003C_003Ec__DisplayClass38_0.UKfQtpQVBjlYTtydrx5Z(enumerator);
							num4 = 2;
							goto IL_01d6;
							IL_01d6:
							switch (num4)
							{
							case 1:
								goto end_IL_01b1;
							case 2:
								goto end_IL_01b1;
							}
							goto IL_01ec;
							end_IL_01b1:;
						}
					case 2:
						return;
					case 1:
						enumerator = (from t in CS_0024_003C_003E8__locals0._003C_003E4__this.SchedulerTaskManager.FindOnceExecuteTasksToExecute()
							select SchedulerJobImpl.Create(CS_0024_003C_003E8__locals0._003C_003E4__this.ProductionCalendarService, CS_0024_003C_003E8__locals0._003C_003E4__this.SchedulerTaskJobExecutors, CS_0024_003C_003E8__locals0._003C_003E4__this.SchedulerTaskManager, CS_0024_003C_003E8__locals0._003C_003E4__this.SchedulerTaskJobManager, t)).Where(delegate(SchedulerJobImpl j)
						{
							//Discarded unreachable code: IL_005a
							int num5 = 5;
							int num6 = num5;
							DateTime? dateTime = default(DateTime?);
							while (true)
							{
								DateTime? dateTime2;
								switch (num6)
								{
								case 3:
									return false;
								case 4:
								{
									ISchedulerTask schedulerTask = j.SchedulerTask;
									if (schedulerTask == null)
									{
										num6 = 2;
										continue;
									}
									dateTime2 = schedulerTask.OnceExecuteTime;
									break;
								}
								case 1:
									return dateTime.HasValue;
								case 2:
									dateTime = null;
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
									{
										num6 = 0;
									}
									continue;
								case 5:
									if (j != null)
									{
										num6 = 4;
										continue;
									}
									goto case 3;
								default:
									dateTime2 = dateTime;
									break;
								}
								dateTime = dateTime2;
								num6 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
								{
									num6 = 1;
								}
							}
						}).GetEnumerator();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
			return CS_0024_003C_003E8__locals0.result;
		}
	}

	[AsyncStateMachine(typeof(_003CEleWise_002DELMA_002DScheduling_002DISchedulerJobDbRepository_002DGetSchedulerJobs_003Ed__39))]
	Task<ICollection<ISchedulerJob>> ISchedulerJobDbRepository.GetSchedulerJobs(DateTime dateTimeToRun)
	{
		_003CEleWise_002DELMA_002DScheduling_002DISchedulerJobDbRepository_002DGetSchedulerJobs_003Ed__39 stateMachine = default(_003CEleWise_002DELMA_002DScheduling_002DISchedulerJobDbRepository_002DGetSchedulerJobs_003Ed__39);
		stateMachine._003C_003E4__this = this;
		stateMachine.dateTimeToRun = dateTimeToRun;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ICollection<ISchedulerJob>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ICollection<ISchedulerJob>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public SchedulerJobRepository()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ggMVUUBk1mmPiYVSbpq0();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool BYvhWbBkek4YawHaRJh4()
	{
		return mWIqreBk2eNNLIHVXqG3 == null;
	}

	internal static SchedulerJobRepository cVXAEpBkPGRDIBtd8eo9()
	{
		return mWIqreBk2eNNLIHVXqG3;
	}

	internal static void ggMVUUBk1mmPiYVSbpq0()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
