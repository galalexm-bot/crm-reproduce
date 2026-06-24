using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Extensions;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Impl;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Scheduling.Triggers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class SchedulerJobRunInfoManager : EntityManager<ISchedulerJobRunInfo, long>, ISchedulerJobRunInfoManager, IEntityManager<ISchedulerJobRunInfo, long>, IEntityManager<ISchedulerJobRunInfo>, IEntityManager
{
	internal const string SchedulerJobRunInfoLockKey = "scheduler_job_run_info_insert_lock";

	private static readonly string F_Id;

	private static readonly string F_DateToRun;

	private static readonly string F_TriggerId;

	private static readonly string F_JobId;

	private static readonly string F_Status;

	private static SchedulerJobRunInfoManager pOmaXpBTAZmPBHM1L1AN;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
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
				case 0:
					return;
				case 1:
					_003CSchedulerTaskManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SchedulerTaskJobManager SchedulerTaskJobManager
	{
		[CompilerGenerated]
		get
		{
			return _003CSchedulerTaskJobManager_003Ek__BackingField;
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
					_003CSchedulerTaskJobManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
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

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
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

	public DateTime? GetLastRun(ITrigger trigger)
	{
		return GetLastRunInfo(trigger, onlyFinished: false)?.DateToRun;
	}

	public DateTime? GetLastRun(ITrigger trigger, Guid jobId)
	{
		return GetLastRunInfo(trigger, jobId, onlyFinished: false)?.DateToRun;
	}

	public ISchedulerJobRunInfo GetLastRunInfo(ITrigger trigger, bool onlyFinished)
	{
		return GetLastRunInfo(trigger, Guid.Empty, onlyFinished);
	}

	public ISchedulerJobRunInfo GetLastRunInfo(ITrigger trigger, Guid jobId, bool onlyFinished)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return GetLastRunInfo(lLjR35BTmKadXiGT82HD(trigger), jobId, onlyFinished);
			case 1:
				Contract.ArgumentNotNull(trigger, (string)K5mhivBT0TwvosOGkg1R(0x53CB464B ^ 0x53CA6D3F));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ISchedulerJobRunInfo GetLastRunInfo(Guid triggerId, Guid jobId, bool onlyFinished)
	{
		//Discarded unreachable code: IL_014e
		int num = 4;
		ICriteria val = default(ICriteria);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					dhJ6x2BTJm2d4ePjQaLU(val, pyH2bABTM4b9jZK7kbWk(F_JobId, jobId));
					num = 5;
					break;
				case 5:
					if (!onlyFinished)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				default:
					return ((ICriteria)lpI8XLBTglQm9usfE0GP(F6ZhukBTr0tuG8ujvJ2P(val, qZMeSpBTldBMxwjiy4tq(F_DateToRun)), 1)).SetCacheable(true).List<ISchedulerJobRunInfo>().FirstOrDefault();
				case 6:
					dhJ6x2BTJm2d4ePjQaLU(val, P0Lu5fBTdcanvnGjeNtP(F_Status, new object[3]
					{
						JobStatus.Success,
						JobStatus.Errors,
						JobStatus.Fail
					}));
					num = 2;
					break;
				case 3:
					if (j5fQqbBT9DXyIH7HqV9E(jobId, Guid.Empty))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 5;
				case 4:
					val = (ICriteria)dhJ6x2BTJm2d4ePjQaLU(vXEVy1BTyJu0hgrpQjeQ(this, null), pyH2bABTM4b9jZK7kbWk(F_TriggerId, triggerId));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	public IList<ISchedulerJobRunInfo> GetLastRunInfos(Guid triggerId, Guid jobId, bool onlyFinished)
	{
		return GetLastRunInfos(triggerId, jobId, onlyFinished, 3);
	}

	private IList<ISchedulerJobRunInfo> GetLastRunInfos(Guid triggerId, Guid jobId, bool onlyFinished, int? count)
	{
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(F_TriggerId, (object)triggerId));
		if (jobId != Guid.Empty)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(F_JobId, (object)jobId));
		}
		if (onlyFinished)
		{
			val.Add((ICriterion)(object)Restrictions.In(F_Status, new object[3]
			{
				JobStatus.Success,
				JobStatus.Errors,
				JobStatus.Fail
			}));
		}
		if (count.HasValue)
		{
			val.SetMaxResults(count.Value);
		}
		return val.AddOrder(Order.Desc(F_DateToRun)).SetCacheable(true).List<ISchedulerJobRunInfo>();
	}

	public IList<ISchedulerJobRunInfo> GetLastRunInfos(IEnumerable<Guid> triggerIds, bool onlyFinished)
	{
		if (triggerIds == null || !triggerIds.Any())
		{
			return new List<ISchedulerJobRunInfo>();
		}
		string text = TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x744B584));
		string text2 = TransformationProvider.Dialect.QuoteIfNeeded(F_TriggerId);
		string text3 = TransformationProvider.Dialect.QuoteIfNeeded(F_DateToRun);
		string text4 = TransformationProvider.Dialect.QuoteIfNeeded(F_Status);
		ISQLQuery val = base.Session.CreateSQLQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099675929) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A75DFB) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548A82AA) + text3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108712448) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3631DF37) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837739501) + (onlyFinished ? (z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31334D8A) + text4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858958023)) : "") + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281919486) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106574058) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281919404) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105125148) + text3).AddEntity(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A4D785), InterfaceActivator.TypeOf<ISchedulerJobRunInfo>());
		((IQuery)val).SetParameterList(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957747436), (IEnumerable)triggerIds, (IType)(object)NHibernateUtil.Guid);
		if (onlyFinished)
		{
			((IQuery)val).SetParameterList(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951573362), (IEnumerable)new JobStatus[3]
			{
				JobStatus.Success,
				JobStatus.Errors,
				JobStatus.Fail
			}, NHibernateUtil.Enum(typeof(JobStatus)));
		}
		return ((IQuery)val).List<ISchedulerJobRunInfo>();
	}

	public virtual JobStatus GetStatus(ITrigger trigger, IJob job, DateTime dateToRun)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				OedqqXBT5VIHDt1p8N0D(trigger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398603736));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Contract.ArgumentNotNull(job, (string)K5mhivBT0TwvosOGkg1R(0x76DD48E ^ 0x76CF9F2));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return yAJGkOBTYoY4As32JiDM(oKEUmwBTjY4DFVRvP2dA(this, trigger, job, dateToRun) ?? throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751251354))));
			}
		}
	}

	public virtual ISchedulerJobRunInfo Get(ITrigger trigger, IJob job, DateTime dateToRun)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				OedqqXBT5VIHDt1p8N0D(job, K5mhivBT0TwvosOGkg1R(-345420348 ^ -345481032));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Contract.ArgumentNotNull(trigger, (string)K5mhivBT0TwvosOGkg1R(0x3A5D5EF ^ 0x3A4FE9B));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return ((ICriteria)I8IEQQBTscypScHTxAsB(lpI8XLBTglQm9usfE0GP(F6ZhukBTr0tuG8ujvJ2P(dhJ6x2BTJm2d4ePjQaLU(dhJ6x2BTJm2d4ePjQaLU(((ICriteria)vXEVy1BTyJu0hgrpQjeQ(this, null)).Add((ICriterion)pyH2bABTM4b9jZK7kbWk(F_TriggerId, lLjR35BTmKadXiGT82HD(trigger))), pyH2bABTM4b9jZK7kbWk(F_JobId, XNGK7SBTLWIc40S6GLeQ(job))), AYIx2TBTUWnGBb6ynEJd(F_DateToRun, dateToRun)), qZMeSpBTldBMxwjiy4tq(F_DateToRun)), 1), true)).List<ISchedulerJobRunInfo>().FirstOrDefault();
			}
		}
	}

	public virtual ISchedulerJobRunInfo SetResult(ITrigger trigger, IJob job, DateTime dateToRun, JobResult result)
	{
		return SetResult(trigger, job, dateToRun, null, result);
	}

	[Transaction]
	public virtual ISchedulerJobRunInfo SetResult(ITrigger trigger, IJob job, DateTime dateToRun, DateTime? actualStartDate, JobResult result)
	{
		_003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass33_0();
		Contract.ArgumentNotNull(trigger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C52138B));
		Contract.ArgumentNotNull(job, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541786379));
		Contract.ArgumentNotNull(result, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138882510));
		Contract.ServiceNotNull(RuntimeApplication, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92E3F0F));
		ITrigger obj = ((trigger is CustomExecuteTimeTrigger) ? ((CustomExecuteTimeTrigger)trigger).BaseTrigger : trigger);
		dateToRun = dateToRun.GetDateTimeWithoutMilliseconds();
		OnceExecuteTrigger onceExecuteTrigger = obj as OnceExecuteTrigger;
		CS_0024_003C_003E8__locals0.info = Get(trigger, job, dateToRun);
		bool flag = (result.NoSaveResult || onceExecuteTrigger != null) && result.Status == JobStatus.Success;
		if (flag)
		{
			Guid guid = ((job is SchedulerJobRepository.JobImpl) ? ((SchedulerJobRepository.JobImpl)job).job : null)?.Uid ?? job.Id;
			IList<ISchedulerJobRunInfo> list2;
			if (!(guid != Guid.Empty))
			{
				IList<ISchedulerJobRunInfo> list = new List<ISchedulerJobRunInfo>();
				list2 = list;
			}
			else
			{
				list2 = GetLastRunInfos(trigger.Id, guid, onlyFinished: false, null);
			}
			IList<ISchedulerJobRunInfo> list3 = list2;
			if (CS_0024_003C_003E8__locals0.info != null && list3.All((ISchedulerJobRunInfo i) => i.Id != CS_0024_003C_003E8__locals0.info.Id))
			{
				list3.Add(CS_0024_003C_003E8__locals0.info);
			}
			list3.ForEach(Delete);
		}
		bool flag2 = result.Status != 0 && result.Status != JobStatus.Working;
		if (onceExecuteTrigger == null || (flag2 && !flag))
		{
			if (CS_0024_003C_003E8__locals0.info == null)
			{
				InstanceOf<ISchedulerJobRunInfo> instanceOf = new InstanceOf<ISchedulerJobRunInfo>();
				instanceOf.New.ActualStartDate = DateTime.Now;
				instanceOf.New.StatusUpdateDate = DateTime.Now;
				instanceOf.New.DateToRun = dateToRun;
				instanceOf.New.Job = ((job is SchedulerJobRepository.JobImpl) ? ((SchedulerJobRepository.JobImpl)job).job : null);
				instanceOf.New.JobId = job.Id;
				instanceOf.New.JobName = job.Name;
				instanceOf.New.TriggerId = trigger.Id;
				instanceOf.New.TriggerName = trigger.Name;
				instanceOf.New.ConnectionUid = RuntimeApplication.ConnectionUid;
				CS_0024_003C_003E8__locals0.info = instanceOf.New;
			}
			CS_0024_003C_003E8__locals0.info.Description = result.Information;
			CS_0024_003C_003E8__locals0.info.Error = result.ErrorDescription;
			CS_0024_003C_003E8__locals0.info.Status = result.Status;
			if (actualStartDate.HasValue)
			{
				CS_0024_003C_003E8__locals0.info.ActualStartDate = actualStartDate.Value;
			}
			if (flag2 && !CS_0024_003C_003E8__locals0.info.FinishDate.HasValue)
			{
				CS_0024_003C_003E8__locals0.info.FinishDate = DateTime.Now;
			}
			Save(CS_0024_003C_003E8__locals0.info);
		}
		if (flag2 && onceExecuteTrigger != null)
		{
			ISchedulerTaskJob schedulerTaskJob = ((job is SchedulerJobRepository.JobImpl) ? ((SchedulerJobRepository.JobImpl)job).job : null);
			if (schedulerTaskJob != null)
			{
				if (flag)
				{
					schedulerTaskJob.Delete();
				}
				else
				{
					schedulerTaskJob.OnceExecuteStatus = result.Status;
					schedulerTaskJob.Save();
				}
			}
			ISchedulerTask task = onceExecuteTrigger.Task;
			if (task != null)
			{
				if (flag)
				{
					task.Delete();
				}
				else
				{
					task.Status = SchedulerTaskStatus.Closed;
					task.Save();
				}
			}
		}
		return CS_0024_003C_003E8__locals0.info;
	}

	public virtual bool SetPending(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun)
	{
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
		_003C_003Ec__DisplayClass34_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass34_.trigger = trigger;
		_003C_003Ec__DisplayClass34_.jobs = jobs;
		_003C_003Ec__DisplayClass34_.dateToRun = dateToRun;
		using (LockManager.Lock(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886575731)))
		{
			_003C_003Ec__DisplayClass34_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass34_1();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass34_;
			CS_0024_003C_003E8__locals0.result = false;
			base.UnitOfWorkManager.Execute((Action)delegate
			{
				//Discarded unreachable code: IL_0076, IL_0099, IL_00bc, IL_00cb, IL_0130, IL_013f
				switch (1)
				{
				case 1:
					try
					{
						CS_0024_003C_003E8__locals0.result = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.SetPendingWithNoLock(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.trigger, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.jobs, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.dateToRun);
						int num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num = 0;
						}
						switch (num)
						{
						case 0:
							break;
						}
						break;
					}
					catch (TimeoutException ex)
					{
						int num2 = 2;
						while (true)
						{
							switch (num2)
							{
							case 3:
								return;
							case 2:
								if (!_003C_003Ec__DisplayClass34_1.pFuXstQuUUHUuQXXKN1U(_003C_003Ec__DisplayClass34_1.HZ33aCQuL4Zxv2yCP6J3(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this)))
								{
									num2 = 3;
									continue;
								}
								break;
							case 1:
								return;
							}
							_003C_003Ec__DisplayClass34_1.wIuKydQusLo6irrK0twr(_003C_003Ec__DisplayClass34_1.HZ33aCQuL4Zxv2yCP6J3(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this), ex);
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
							{
								num2 = 1;
							}
						}
					}
				case 0:
					break;
				}
			});
			return CS_0024_003C_003E8__locals0.result;
		}
	}

	public virtual void CancelPending(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun)
	{
		_003C_003Ec__DisplayClass35_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass35_0();
		CS_0024_003C_003E8__locals0.jobs = jobs;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.trigger = trigger;
		CS_0024_003C_003E8__locals0.dateToRun = dateToRun;
		using (LockManager.Lock(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751251486)))
		{
			base.UnitOfWorkManager.Execute((Action)delegate
			{
				//Discarded unreachable code: IL_0085, IL_0094, IL_009f, IL_0131, IL_0144, IL_0153, IL_0164, IL_0173, IL_017e, IL_01ed, IL_01fc, IL_0299, IL_02b8, IL_02c7, IL_02f4, IL_0303, IL_0346, IL_03b4, IL_03c7, IL_03d6
				switch (1)
				{
				case 1:
					try
					{
						List<ISchedulerJobRunInfo> list = new List<ISchedulerJobRunInfo>();
						int num = 2;
						int num2 = num;
						List<ISchedulerJobRunInfo>.Enumerator enumerator2 = default(List<ISchedulerJobRunInfo>.Enumerator);
						IEnumerator<IJob> enumerator = default(IEnumerator<IJob>);
						ISchedulerJobRunInfo schedulerJobRunInfo = default(ISchedulerJobRunInfo);
						IJob current = default(IJob);
						while (true)
						{
							switch (num2)
							{
							default:
								return;
							case 1:
								enumerator2 = list.GetEnumerator();
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
								{
									num2 = 4;
								}
								break;
							case 4:
								try
								{
									while (true)
									{
										int num5;
										if (!enumerator2.MoveNext())
										{
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
											{
												num5 = 1;
											}
											goto IL_00a3;
										}
										goto IL_00b9;
										IL_00b9:
										_003C_003Ec__DisplayClass35_0.RJAGHAQIW9QUSWEUtQrd(enumerator2.Current);
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
										{
											num5 = 2;
										}
										goto IL_00a3;
										IL_00a3:
										switch (num5)
										{
										case 2:
											continue;
										case 1:
											return;
										}
										goto IL_00b9;
									}
								}
								finally
								{
									((IDisposable)enumerator2).Dispose();
									int num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									case 0:
										break;
									}
								}
							case 3:
								try
								{
									while (true)
									{
										IL_01d2:
										int num3;
										if (!enumerator.MoveNext())
										{
											num3 = 3;
											goto IL_0182;
										}
										goto IL_01bf;
										IL_0182:
										while (true)
										{
											switch (num3)
											{
											case 2:
												list.Add(schedulerJobRunInfo);
												num3 = 7;
												continue;
											case 6:
											case 7:
												goto IL_01d2;
											case 5:
												if (schedulerJobRunInfo.Status != 0)
												{
													num3 = 6;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
													{
														num3 = 6;
													}
													continue;
												}
												goto case 2;
											case 4:
												schedulerJobRunInfo = CS_0024_003C_003E8__locals0._003C_003E4__this.Get(CS_0024_003C_003E8__locals0.trigger, current, CS_0024_003C_003E8__locals0.dateToRun);
												num3 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
												{
													num3 = 1;
												}
												continue;
											case 1:
												if (schedulerJobRunInfo != null)
												{
													num3 = 5;
													continue;
												}
												goto IL_01d2;
											case 3:
												goto end_IL_01d2;
											}
											break;
										}
										goto IL_01bf;
										IL_01bf:
										current = enumerator.Current;
										num3 = 4;
										goto IL_0182;
										continue;
										end_IL_01d2:
										break;
									}
								}
								finally
								{
									int num4;
									if (enumerator == null)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
										{
											num4 = 0;
										}
										goto IL_029d;
									}
									goto IL_02d2;
									IL_02d2:
									_003C_003Ec__DisplayClass35_0.HIEJSfQIBeVKifl6HtK2(enumerator);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
									{
										num4 = 0;
									}
									goto IL_029d;
									IL_029d:
									switch (num4)
									{
									default:
										goto end_IL_0278;
									case 0:
										goto end_IL_0278;
									case 2:
										break;
									case 1:
										goto end_IL_0278;
									}
									goto IL_02d2;
									end_IL_0278:;
								}
								goto case 1;
							case 2:
								enumerator = CS_0024_003C_003E8__locals0.jobs.GetEnumerator();
								num2 = 3;
								break;
							case 0:
								return;
							}
						}
					}
					catch (TimeoutException ex)
					{
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								if (!_003C_003Ec__DisplayClass35_0.PKdAAQQIbmQeoZEkW8GL(_003C_003Ec__DisplayClass35_0.T3wdi9QIoJ1knuW7yxYJ(CS_0024_003C_003E8__locals0._003C_003E4__this)))
								{
									num7 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
									{
										num7 = 1;
									}
									continue;
								}
								break;
							case 3:
								break;
							case 1:
								return;
							case 2:
								return;
							}
							_003C_003Ec__DisplayClass35_0.LY4FVmQIhtUkDESIBM0P(_003C_003Ec__DisplayClass35_0.T3wdi9QIoJ1knuW7yxYJ(CS_0024_003C_003E8__locals0._003C_003E4__this), ex);
							num7 = 2;
						}
					}
				case 0:
					break;
				}
			});
		}
	}

	internal static TimeSpan GetJobRunInfoTtl()
	{
		//Discarded unreachable code: IL_008a
		int num = 1;
		int num2 = num;
		int setting = default(int);
		int num3;
		while (true)
		{
			switch (num2)
			{
			case 1:
				setting = SR.GetSetting((string)K5mhivBT0TwvosOGkg1R(-542721635 ^ -542664745), 720);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				if (setting <= 0)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				num3 = setting;
				break;
			case 2:
				num3 = 720;
				break;
			}
			break;
		}
		return mQRr5PBTconeMKumrEfj(num3);
	}

	internal bool SetPendingWithNoLock(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun)
	{
		Contract.ServiceNotNull(RuntimeApplication, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767664607));
		dateToRun = dateToRun.GetDateTimeWithoutMilliseconds();
		foreach (IJob job in jobs)
		{
			ISchedulerJobRunInfo schedulerJobRunInfo = Get(trigger, job, dateToRun);
			if (schedulerJobRunInfo != null && RuntimeApplication.IsConnectionAlive(schedulerJobRunInfo.ConnectionUid) && schedulerJobRunInfo.StatusUpdateDate.Add(trigger.GetTriggerTimeout()) > DateTime.Now)
			{
				return false;
			}
		}
		foreach (IJob job2 in jobs)
		{
			InstanceOf<ISchedulerJobRunInfo> instanceOf = new InstanceOf<ISchedulerJobRunInfo>();
			instanceOf.New.DateToRun = dateToRun;
			instanceOf.New.Job = ((job2 is SchedulerJobRepository.JobImpl) ? ((SchedulerJobRepository.JobImpl)job2).job : null);
			instanceOf.New.JobId = job2.Id;
			instanceOf.New.JobName = job2.Name;
			instanceOf.New.TriggerId = trigger.Id;
			instanceOf.New.TriggerName = trigger.Name;
			instanceOf.New.Status = JobStatus.Pending;
			instanceOf.New.ActualStartDate = DateTime.Now;
			instanceOf.New.StatusUpdateDate = DateTime.Now;
			instanceOf.New.ConnectionUid = RuntimeApplication.ConnectionUid;
			ISchedulerJobRunInfo @new = instanceOf.New;
			Save(@new);
		}
		if (jobs.Any())
		{
			base.Session.Flush();
		}
		return true;
	}

	public SchedulerJobRunInfoManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Yviw7ABTz0ExH4oIRotd();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SchedulerJobRunInfoManager()
	{
		int num = 7;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 8:
					parameterExpression = (ParameterExpression)bKGB5XBkBJjiXP7vv5WU(oaSnCWBkF3GMKVGwm4XB(typeof(ISchedulerJobRunInfo).TypeHandle), K5mhivBT0TwvosOGkg1R(0x1A33FE36 ^ 0x1A330BA6));
					num2 = 11;
					continue;
				case 5:
					parameterExpression = (ParameterExpression)bKGB5XBkBJjiXP7vv5WU(typeof(ISchedulerJobRunInfo), K5mhivBT0TwvosOGkg1R(0xA592A41 ^ 0xA59DFD1));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					F_DateToRun = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((Expression)qoXcy1BkbQlCHErD0RCG(psEyx9BkopadG0wbbYKj(parameterExpression, (MethodInfo)GXiZMWBkWAv5EuMnYmPa((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), oaSnCWBkF3GMKVGwm4XB(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					F_Status = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((Expression)qoXcy1BkbQlCHErD0RCG(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), oaSnCWBkF3GMKVGwm4XB(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num = 3;
					break;
				case 7:
					Yviw7ABTz0ExH4oIRotd();
					num = 6;
					break;
				case 2:
					F_JobId = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((Expression)qoXcy1BkbQlCHErD0RCG(psEyx9BkopadG0wbbYKj(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					num = 8;
					break;
				case 6:
					parameterExpression = Expression.Parameter(oaSnCWBkF3GMKVGwm4XB(typeof(ISchedulerJobRunInfo).TypeHandle), (string)K5mhivBT0TwvosOGkg1R(0x7C1EE318 ^ 0x7C1E1688));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					F_Id = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerJobRunInfo, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					num2 = 5;
					continue;
				case 4:
					F_TriggerId = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((Expression)qoXcy1BkbQlCHErD0RCG(psEyx9BkopadG0wbbYKj(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), oaSnCWBkF3GMKVGwm4XB(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					parameterExpression = Expression.Parameter(oaSnCWBkF3GMKVGwm4XB(typeof(ISchedulerJobRunInfo).TypeHandle), (string)K5mhivBT0TwvosOGkg1R(-1822890472 ^ -1822944376));
					num2 = 2;
					continue;
				case 9:
					parameterExpression = Expression.Parameter(oaSnCWBkF3GMKVGwm4XB(typeof(ISchedulerJobRunInfo).TypeHandle), (string)K5mhivBT0TwvosOGkg1R(0x42643203 ^ 0x4264C793));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool xZbJ6jBT7PpTPotSlAcR()
	{
		return pOmaXpBTAZmPBHM1L1AN == null;
	}

	internal static SchedulerJobRunInfoManager g7lLiABTxRqGwa2uwyq2()
	{
		return pOmaXpBTAZmPBHM1L1AN;
	}

	internal static object K5mhivBT0TwvosOGkg1R(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Guid lLjR35BTmKadXiGT82HD(object P_0)
	{
		return ((ITrigger)P_0).Id;
	}

	internal static object vXEVy1BTyJu0hgrpQjeQ(object P_0, object P_1)
	{
		return ((EntityManager<ISchedulerJobRunInfo, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object pyH2bABTM4b9jZK7kbWk(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object dhJ6x2BTJm2d4ePjQaLU(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool j5fQqbBT9DXyIH7HqV9E(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object P0Lu5fBTdcanvnGjeNtP(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static object qZMeSpBTldBMxwjiy4tq(object P_0)
	{
		return Order.Desc((string)P_0);
	}

	internal static object F6ZhukBTr0tuG8ujvJ2P(object P_0, object P_1)
	{
		return ((ICriteria)P_0).AddOrder((Order)P_1);
	}

	internal static object lpI8XLBTglQm9usfE0GP(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static void OedqqXBT5VIHDt1p8N0D(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object oKEUmwBTjY4DFVRvP2dA(object P_0, object P_1, object P_2, DateTime dateToRun)
	{
		return ((SchedulerJobRunInfoManager)P_0).Get((ITrigger)P_1, (IJob)P_2, dateToRun);
	}

	internal static JobStatus yAJGkOBTYoY4As32JiDM(object P_0)
	{
		return ((ISchedulerJobRunInfo)P_0).Status;
	}

	internal static Guid XNGK7SBTLWIc40S6GLeQ(object P_0)
	{
		return ((IJob)P_0).Id;
	}

	internal static object AYIx2TBTUWnGBb6ynEJd(object P_0, object P_1)
	{
		return Restrictions.Ge((string)P_0, P_1);
	}

	internal static object I8IEQQBTscypScHTxAsB(object P_0, bool P_1)
	{
		return ((ICriteria)P_0).SetCacheable(P_1);
	}

	internal static TimeSpan mQRr5PBTconeMKumrEfj(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static void Yviw7ABTz0ExH4oIRotd()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type oaSnCWBkF3GMKVGwm4XB(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object bKGB5XBkBJjiXP7vv5WU(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object GXiZMWBkWAv5EuMnYmPa(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object psEyx9BkopadG0wbbYKj(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object qoXcy1BkbQlCHErD0RCG(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}
}
