// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Managers.SchedulerJobRunInfoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
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
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Scheduling.Managers
{
  /// <summary>Менеджер информации о запуске работы планировщика</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class SchedulerJobRunInfoManager : 
    EntityManager<ISchedulerJobRunInfo, long>,
    ISchedulerJobRunInfoManager,
    IEntityManager<ISchedulerJobRunInfo, long>,
    IEntityManager<ISchedulerJobRunInfo>,
    IEntityManager
  {
    internal const string SchedulerJobRunInfoLockKey = "scheduler_job_run_info_insert_lock";
    private static readonly string F_Id;
    private static readonly string F_DateToRun;
    private static readonly string F_TriggerId;
    private static readonly string F_JobId;
    private static readonly string F_Status;
    private static SchedulerJobRunInfoManager pOmaXpBTAZmPBHM1L1AN;

    /// <summary>Менеджер блокировки</summary>
    public ILockManager LockManager
    {
      get => this.\u003CLockManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CLockManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// <see cref="T:EleWise.ELMA.Runtime.IRuntimeApplication" />
    /// </summary>
    public IRuntimeApplication RuntimeApplication
    {
      get => this.\u003CRuntimeApplication\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CRuntimeApplication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// <see cref="T:EleWise.ELMA.Scheduling.Managers.SchedulerTaskManager" />
    /// </summary>
    public SchedulerTaskManager SchedulerTaskManager
    {
      get => this.\u003CSchedulerTaskManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSchedulerTaskManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// <see cref="T:EleWise.ELMA.Scheduling.Managers.SchedulerTaskJobManager" />
    /// </summary>
    public SchedulerTaskJobManager SchedulerTaskJobManager
    {
      get => this.\u003CSchedulerTaskJobManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSchedulerTaskJobManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Провайдер преобразований</summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <inheritdoc />
    public DateTime? GetLastRun(ITrigger trigger) => this.GetLastRunInfo(trigger, false)?.DateToRun;

    /// <inheritdoc />
    public DateTime? GetLastRun(ITrigger trigger, Guid jobId) => this.GetLastRunInfo(trigger, jobId, false)?.DateToRun;

    /// <inheritdoc />
    public ISchedulerJobRunInfo GetLastRunInfo(ITrigger trigger, bool onlyFinished) => this.GetLastRunInfo(trigger, Guid.Empty, onlyFinished);

    /// <inheritdoc />
    public ISchedulerJobRunInfo GetLastRunInfo(ITrigger trigger, Guid jobId, bool onlyFinished)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) trigger, (string) SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(381945751 ^ 1158627804 ^ 1405775167));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.GetLastRunInfo(SchedulerJobRunInfoManager.lLjR35BTmKadXiGT82HD((object) trigger), jobId, onlyFinished);
    }

    /// <inheritdoc />
    public ISchedulerJobRunInfo GetLastRunInfo(Guid triggerId, Guid jobId, bool onlyFinished)
    {
      int num1 = 4;
      ICriteria criteria;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 3:
              if (SchedulerJobRunInfoManager.j5fQqbBT9DXyIH7HqV9E(jobId, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
                continue;
              }
              goto case 5;
            case 4:
              criteria = (ICriteria) SchedulerJobRunInfoManager.dhJ6x2BTJm2d4ePjQaLU(SchedulerJobRunInfoManager.vXEVy1BTyJu0hgrpQjeQ((object) this, (object) null), SchedulerJobRunInfoManager.pyH2bABTM4b9jZK7kbWk((object) SchedulerJobRunInfoManager.F_TriggerId, (object) triggerId));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 2;
              continue;
            case 5:
              if (!onlyFinished)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 6:
              goto label_7;
            default:
              goto label_6;
          }
        }
label_3:
        SchedulerJobRunInfoManager.dhJ6x2BTJm2d4ePjQaLU((object) criteria, SchedulerJobRunInfoManager.pyH2bABTM4b9jZK7kbWk((object) SchedulerJobRunInfoManager.F_JobId, (object) jobId));
        num1 = 5;
        continue;
label_7:
        SchedulerJobRunInfoManager.dhJ6x2BTJm2d4ePjQaLU((object) criteria, SchedulerJobRunInfoManager.P0Lu5fBTdcanvnGjeNtP((object) SchedulerJobRunInfoManager.F_Status, (object) new object[3]
        {
          (object) JobStatus.Success,
          (object) JobStatus.Errors,
          (object) JobStatus.Fail
        }));
        num1 = 2;
      }
label_6:
      return ((ICriteria) SchedulerJobRunInfoManager.lpI8XLBTglQm9usfE0GP(SchedulerJobRunInfoManager.F6ZhukBTr0tuG8ujvJ2P((object) criteria, SchedulerJobRunInfoManager.qZMeSpBTldBMxwjiy4tq((object) SchedulerJobRunInfoManager.F_DateToRun)), 1)).SetCacheable(true).List<ISchedulerJobRunInfo>().FirstOrDefault<ISchedulerJobRunInfo>();
    }

    /// <inheritdoc />
    public IList<ISchedulerJobRunInfo> GetLastRunInfos(
      Guid triggerId,
      Guid jobId,
      bool onlyFinished)
    {
      return this.GetLastRunInfos(triggerId, jobId, onlyFinished, new int?(3));
    }

    /// <summary>Получить список истории о последних запусках триггера</summary>
    /// <param name="triggerId">Идентификатор триггера</param>
    /// <param name="jobId">Идентификатор работы</param>
    /// <param name="onlyFinished">Выбирать информацию только о завершившемся запуске</param>
    /// <param name="count">Максимальное количество записей</param>
    /// <returns>Информация о последнем запуске триггера (или null, если триггер еще не запускался)</returns>
    private IList<ISchedulerJobRunInfo> GetLastRunInfos(
      Guid triggerId,
      Guid jobId,
      bool onlyFinished,
      int? count)
    {
      ICriteria criteria = this.CreateCriteria().Add((ICriterion) Restrictions.Eq(SchedulerJobRunInfoManager.F_TriggerId, (object) triggerId));
      if (jobId != Guid.Empty)
        criteria.Add((ICriterion) Restrictions.Eq(SchedulerJobRunInfoManager.F_JobId, (object) jobId));
      if (onlyFinished)
        criteria.Add((ICriterion) Restrictions.In(SchedulerJobRunInfoManager.F_Status, new object[3]
        {
          (object) JobStatus.Success,
          (object) JobStatus.Errors,
          (object) JobStatus.Fail
        }));
      if (count.HasValue)
        criteria.SetMaxResults(count.Value);
      return criteria.AddOrder(Order.Desc(SchedulerJobRunInfoManager.F_DateToRun)).SetCacheable(true).List<ISchedulerJobRunInfo>();
    }

    /// <inheritdoc />
    public IList<ISchedulerJobRunInfo> GetLastRunInfos(
      IEnumerable<Guid> triggerIds,
      bool onlyFinished)
    {
      if (triggerIds == null || !triggerIds.Any<Guid>())
        return (IList<ISchedulerJobRunInfo>) new List<ISchedulerJobRunInfo>();
      string str1 = this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121943428));
      string str2 = this.TransformationProvider.Dialect.QuoteIfNeeded(SchedulerJobRunInfoManager.F_TriggerId);
      string str3 = this.TransformationProvider.Dialect.QuoteIfNeeded(SchedulerJobRunInfoManager.F_DateToRun);
      string str4 = this.TransformationProvider.Dialect.QuoteIfNeeded(SchedulerJobRunInfoManager.F_Status);
      ISQLQuery sqlQuery = this.Session.CreateSQLQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099675929) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413621755) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418363562) + str3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108712448) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909238071) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837739501) + (onlyFinished ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825445770) + str4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858958023) : "") + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281919486) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106574058) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281919404) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105125148) + str3).AddEntity(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312792965), InterfaceActivator.TypeOf<ISchedulerJobRunInfo>());
      sqlQuery.SetParameterList(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957747436), (IEnumerable) triggerIds, (IType) NHibernateUtil.Guid);
      if (onlyFinished)
        sqlQuery.SetParameterList(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951573362), (IEnumerable) new JobStatus[3]
        {
          JobStatus.Success,
          JobStatus.Errors,
          JobStatus.Fail
        }, NHibernateUtil.Enum(typeof (JobStatus)));
      return sqlQuery.List<ISchedulerJobRunInfo>();
    }

    /// <inheritdoc />
    public virtual JobStatus GetStatus(ITrigger trigger, IJob job, DateTime dateToRun)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) job, (string) SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(1994213607 >> 4 ^ 124582386));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 0 : 0;
            continue;
          case 2:
            SchedulerJobRunInfoManager.OedqqXBT5VIHDt1p8N0D((object) trigger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398603736));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return SchedulerJobRunInfoManager.yAJGkOBTYoY4As32JiDM(SchedulerJobRunInfoManager.oKEUmwBTjY4DFVRvP2dA((object) this, (object) trigger, (object) job, dateToRun) ?? throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751251354))));
    }

    /// <inheritdoc />
    public virtual ISchedulerJobRunInfo Get(ITrigger trigger, IJob job, DateTime dateToRun)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            SchedulerJobRunInfoManager.OedqqXBT5VIHDt1p8N0D((object) job, SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(-345420348 ^ -345481032));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) trigger, (string) SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(1051276242 - 990076387 ^ 61144731));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return ((ICriteria) SchedulerJobRunInfoManager.I8IEQQBTscypScHTxAsB(SchedulerJobRunInfoManager.lpI8XLBTglQm9usfE0GP(SchedulerJobRunInfoManager.F6ZhukBTr0tuG8ujvJ2P(SchedulerJobRunInfoManager.dhJ6x2BTJm2d4ePjQaLU(SchedulerJobRunInfoManager.dhJ6x2BTJm2d4ePjQaLU((object) ((ICriteria) SchedulerJobRunInfoManager.vXEVy1BTyJu0hgrpQjeQ((object) this, (object) null)).Add((ICriterion) SchedulerJobRunInfoManager.pyH2bABTM4b9jZK7kbWk((object) SchedulerJobRunInfoManager.F_TriggerId, (object) SchedulerJobRunInfoManager.lLjR35BTmKadXiGT82HD((object) trigger))), SchedulerJobRunInfoManager.pyH2bABTM4b9jZK7kbWk((object) SchedulerJobRunInfoManager.F_JobId, (object) SchedulerJobRunInfoManager.XNGK7SBTLWIc40S6GLeQ((object) job))), SchedulerJobRunInfoManager.AYIx2TBTUWnGBb6ynEJd((object) SchedulerJobRunInfoManager.F_DateToRun, (object) dateToRun)), SchedulerJobRunInfoManager.qZMeSpBTldBMxwjiy4tq((object) SchedulerJobRunInfoManager.F_DateToRun)), 1), true)).List<ISchedulerJobRunInfo>().FirstOrDefault<ISchedulerJobRunInfo>();
    }

    /// <inheritdoc />
    public virtual ISchedulerJobRunInfo SetResult(
      ITrigger trigger,
      IJob job,
      DateTime dateToRun,
      JobResult result)
    {
      return this.SetResult(trigger, job, dateToRun, new DateTime?(), result);
    }

    /// <inheritdoc />
    [Transaction]
    public virtual ISchedulerJobRunInfo SetResult(
      ITrigger trigger,
      IJob job,
      DateTime dateToRun,
      DateTime? actualStartDate,
      JobResult result)
    {
      Contract.ArgumentNotNull((object) trigger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012011915));
      Contract.ArgumentNotNull((object) job, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541786379));
      Contract.ArgumentNotNull((object) result, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138882510));
      Contract.ServiceNotNull((object) this.RuntimeApplication, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154025743));
      ITrigger trigger1 = trigger is CustomExecuteTimeTrigger ? ((CustomExecuteTimeTrigger) trigger).BaseTrigger : trigger;
      dateToRun = dateToRun.GetDateTimeWithoutMilliseconds();
      OnceExecuteTrigger onceExecuteTrigger = trigger1 as OnceExecuteTrigger;
      ISchedulerJobRunInfo info = this.Get(trigger, job, dateToRun);
      bool flag1 = (result.NoSaveResult || onceExecuteTrigger != null) && result.Status == JobStatus.Success;
      if (flag1)
      {
        ISchedulerTaskJob job1 = job is SchedulerJobRepository.JobImpl ? ((SchedulerJobRepository.JobImpl) job).job : (ISchedulerTaskJob) null;
        Guid jobId = job1 == null ? job.Id : job1.Uid;
        IList<ISchedulerJobRunInfo> schedulerJobRunInfoList = jobId != Guid.Empty ? this.GetLastRunInfos(trigger.Id, jobId, false, new int?()) : (IList<ISchedulerJobRunInfo>) new List<ISchedulerJobRunInfo>();
        if (info != null && schedulerJobRunInfoList.All<ISchedulerJobRunInfo>((Func<ISchedulerJobRunInfo, bool>) (i => i.Id != info.Id)))
          schedulerJobRunInfoList.Add(info);
        schedulerJobRunInfoList.ForEach<ISchedulerJobRunInfo>(new Action<ISchedulerJobRunInfo>(((AbstractNHEntityManager<ISchedulerJobRunInfo, long>) this).Delete));
      }
      bool flag2 = result.Status != JobStatus.Pending && result.Status != JobStatus.Working;
      if (onceExecuteTrigger == null || flag2 && !flag1)
      {
        if (info == null)
          info = new InstanceOf<ISchedulerJobRunInfo>()
          {
            New = {
              ActualStartDate = DateTime.Now,
              StatusUpdateDate = DateTime.Now,
              DateToRun = dateToRun,
              Job = (job is SchedulerJobRepository.JobImpl ? ((SchedulerJobRepository.JobImpl) job).job : (ISchedulerTaskJob) null),
              JobId = job.Id,
              JobName = job.Name,
              TriggerId = trigger.Id,
              TriggerName = trigger.Name,
              ConnectionUid = this.RuntimeApplication.ConnectionUid
            }
          }.New;
        info.Description = result.Information;
        info.Error = result.ErrorDescription;
        info.Status = result.Status;
        if (actualStartDate.HasValue)
          info.ActualStartDate = actualStartDate.Value;
        if (flag2 && !info.FinishDate.HasValue)
          info.FinishDate = new DateTime?(DateTime.Now);
        this.Save(info);
      }
      if (flag2 && onceExecuteTrigger != null)
      {
        ISchedulerTaskJob job2 = job is SchedulerJobRepository.JobImpl ? ((SchedulerJobRepository.JobImpl) job).job : (ISchedulerTaskJob) null;
        if (job2 != null)
        {
          if (flag1)
          {
            job2.Delete();
          }
          else
          {
            job2.OnceExecuteStatus = new JobStatus?(result.Status);
            job2.Save();
          }
        }
        ISchedulerTask task = onceExecuteTrigger.Task;
        if (task != null)
        {
          if (flag1)
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
      return info;
    }

    /// <inheritdoc />
    public virtual bool SetPending(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun)
    {
      using (this.LockManager.Lock(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886575731)))
      {
        bool result = false;
        this.UnitOfWorkManager.Execute((System.Action) (() =>
        {
          switch (1)
          {
            case 1:
              try
              {
                result = this.SetPendingWithNoLock(trigger, jobs, dateToRun);
                int num = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                  num = 0;
                switch (num)
                {
                  case 0:
                    return;
                  default:
                    return;
                }
              }
              catch (TimeoutException ex)
              {
                int num = 2;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass34_1.pFuXstQuUUHUuQXXKN1U(SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass34_1.HZ33aCQuL4Zxv2yCP6J3((object) this)))
                      {
                        num = 3;
                        continue;
                      }
                      break;
                    case 3:
                      goto label_1;
                  }
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass34_1.wIuKydQusLo6irrK0twr(SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass34_1.HZ33aCQuL4Zxv2yCP6J3((object) this), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
                }
label_5:
                break;
label_1:
                break;
              }
          }
        }));
        return result;
      }
    }

    /// <inheritdoc />
    public virtual void CancelPending(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun)
    {
      using (this.LockManager.Lock(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751251486)))
        this.UnitOfWorkManager.Execute((System.Action) (() =>
        {
          switch (1)
          {
            case 1:
              try
              {
                List<ISchedulerJobRunInfo> schedulerJobRunInfoList = new List<ISchedulerJobRunInfo>();
                int num1 = 2;
                List<ISchedulerJobRunInfo>.Enumerator enumerator1;
                IEnumerator<IJob> enumerator2;
                while (true)
                {
                  switch (num1)
                  {
                    case 0:
                      goto label_39;
                    case 1:
label_3:
                      enumerator1 = schedulerJobRunInfoList.GetEnumerator();
                      num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 4;
                      continue;
                    case 2:
                      enumerator2 = jobs.GetEnumerator();
                      num1 = 3;
                      continue;
                    case 3:
                      try
                      {
label_18:
                        if (enumerator2.MoveNext())
                          goto label_17;
                        else
                          goto label_19;
label_15:
                        ISchedulerJobRunInfo schedulerJobRunInfo;
                        IJob current;
                        int num2;
                        while (true)
                        {
                          switch (num2)
                          {
                            case 1:
                              if (schedulerJobRunInfo != null)
                              {
                                num2 = 5;
                                continue;
                              }
                              goto label_18;
                            case 2:
                              schedulerJobRunInfoList.Add(schedulerJobRunInfo);
                              num2 = 7;
                              continue;
                            case 3:
                              goto label_3;
                            case 4:
                              schedulerJobRunInfo = this.Get(trigger, current, dateToRun);
                              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 1;
                              continue;
                            case 5:
                              if (schedulerJobRunInfo.Status != JobStatus.Pending)
                              {
                                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 6 : 6;
                                continue;
                              }
                              goto case 2;
                            case 6:
                            case 7:
                              goto label_18;
                            default:
                              goto label_17;
                          }
                        }
label_17:
                        current = enumerator2.Current;
                        num2 = 4;
                        goto label_15;
label_19:
                        num2 = 3;
                        goto label_15;
                      }
                      finally
                      {
                        int num3;
                        if (enumerator2 == null)
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                        else
                          goto label_31;
label_28:
                        switch (num3)
                        {
                          case 2:
                            break;
                          default:
                        }
label_31:
                        // ISSUE: reference to a compiler-generated method
                        SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass35_0.HIEJSfQIBeVKifl6HtK2((object) enumerator2);
                        num3 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                        {
                          num3 = 0;
                          goto label_28;
                        }
                        else
                          goto label_28;
                      }
                    case 4:
                      goto label_4;
                    default:
                      goto label_35;
                  }
                }
label_39:
                break;
label_35:
                break;
label_4:
                try
                {
label_8:
                  if (enumerator1.MoveNext())
                    goto label_6;
                  else
                    goto label_9;
label_5:
                  int num4;
                  switch (num4)
                  {
                    case 1:
                      return;
                    case 2:
                      goto label_8;
                  }
label_6:
                  // ISSUE: reference to a compiler-generated method
                  SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass35_0.RJAGHAQIW9QUSWEUtQrd((object) enumerator1.Current);
                  num4 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                  {
                    num4 = 2;
                    goto label_5;
                  }
                  else
                    goto label_5;
label_9:
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 1;
                  goto label_5;
                }
                finally
                {
                  enumerator1.Dispose();
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
                    num5 = 0;
                  switch (num5)
                  {
                    default:
                  }
                }
              }
              catch (TimeoutException ex)
              {
                int num = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
                  num = 0;
                while (true)
                {
                  switch (num)
                  {
                    case 1:
                      goto label_29;
                    case 2:
                      goto label_25;
                    case 3:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass35_0.LY4FVmQIhtUkDESIBM0P(SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass35_0.T3wdi9QIoJ1knuW7yxYJ((object) this), (object) ex);
                      num = 2;
                      continue;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass35_0.PKdAAQQIbmQeoZEkW8GL(SchedulerJobRunInfoManager.\u003C\u003Ec__DisplayClass35_0.T3wdi9QIoJ1knuW7yxYJ((object) this)))
                      {
                        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 1;
                        continue;
                      }
                      goto case 3;
                  }
                }
label_29:
                break;
label_25:
                break;
              }
          }
        }));
    }

    /// <summary>Получить время жизни информации о работе</summary>
    /// <returns>Время в минутах</returns>
    internal static TimeSpan GetJobRunInfoTtl()
    {
      int num1 = 1;
      int setting;
      while (true)
      {
        switch (num1)
        {
          case 1:
            setting = EleWise.ELMA.SR.GetSetting<int>((string) SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(-542721635 ^ -542664745), 720);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          default:
            if (setting <= 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 0;
              continue;
            }
            goto label_6;
        }
      }
label_5:
      int num2 = 720;
      goto label_7;
label_6:
      num2 = setting;
label_7:
      return SchedulerJobRunInfoManager.mQRr5PBTconeMKumrEfj((double) num2);
    }

    internal bool SetPendingWithNoLock(
      ITrigger trigger,
      ICollection<IJob> jobs,
      DateTime dateToRun)
    {
      Contract.ServiceNotNull((object) this.RuntimeApplication, z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767664607));
      dateToRun = dateToRun.GetDateTimeWithoutMilliseconds();
      foreach (IJob job in (IEnumerable<IJob>) jobs)
      {
        ISchedulerJobRunInfo schedulerJobRunInfo = this.Get(trigger, job, dateToRun);
        if (schedulerJobRunInfo != null && this.RuntimeApplication.IsConnectionAlive(schedulerJobRunInfo.ConnectionUid) && schedulerJobRunInfo.StatusUpdateDate.Add(trigger.GetTriggerTimeout()) > DateTime.Now)
          return false;
      }
      foreach (IJob job in (IEnumerable<IJob>) jobs)
        this.Save(new InstanceOf<ISchedulerJobRunInfo>()
        {
          New = {
            DateToRun = dateToRun,
            Job = (job is SchedulerJobRepository.JobImpl ? ((SchedulerJobRepository.JobImpl) job).job : (ISchedulerTaskJob) null),
            JobId = job.Id,
            JobName = job.Name,
            TriggerId = trigger.Id,
            TriggerName = trigger.Name,
            Status = JobStatus.Pending,
            ActualStartDate = DateTime.Now,
            StatusUpdateDate = DateTime.Now,
            ConnectionUid = this.RuntimeApplication.ConnectionUid
          }
        }.New);
      if (jobs.Any<IJob>())
        this.Session.Flush();
      return true;
    }

    public SchedulerJobRunInfoManager()
    {
      SchedulerJobRunInfoManager.Yviw7ABTz0ExH4oIRotd();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SchedulerJobRunInfoManager()
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              SchedulerJobRunInfoManager.F_Id = LinqUtils.NameOf<ISchedulerJobRunInfo>((Expression<Func<ISchedulerJobRunInfo, object>>) (parameterExpression => (object) parameterExpression.Id));
              num2 = 5;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_3;
            case 4:
              // ISSUE: method reference
              // ISSUE: type reference
              SchedulerJobRunInfoManager.F_TriggerId = LinqUtils.NameOf<ISchedulerJobRunInfo>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((System.Linq.Expressions.Expression) SchedulerJobRunInfoManager.qoXcy1BkbQlCHErD0RCG(SchedulerJobRunInfoManager.psEyx9BkopadG0wbbYKj((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ISchedulerJobRunInfo.get_TriggerId))), SchedulerJobRunInfoManager.oaSnCWBkF3GMKVGwm4XB(__typeref (object))), parameterExpression1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            case 5:
              parameterExpression1 = (ParameterExpression) SchedulerJobRunInfoManager.bKGB5XBkBJjiXP7vv5WU(typeof (ISchedulerJobRunInfo), SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(-710283084 ^ -537863435 ^ 173662161));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 10 : 0;
              continue;
            case 6:
              // ISSUE: type reference
              parameterExpression1 = System.Linq.Expressions.Expression.Parameter(SchedulerJobRunInfoManager.oaSnCWBkF3GMKVGwm4XB(__typeref (ISchedulerJobRunInfo)), (string) SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(-1350312861 << 3 ^ 2082346632));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
              continue;
            case 7:
              goto label_8;
            case 8:
              // ISSUE: type reference
              parameterExpression1 = (ParameterExpression) SchedulerJobRunInfoManager.bKGB5XBkBJjiXP7vv5WU(SchedulerJobRunInfoManager.oaSnCWBkF3GMKVGwm4XB(__typeref (ISchedulerJobRunInfo)), SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(95909607 + 343705423 ^ 439552934));
              num2 = 11;
              continue;
            case 9:
              // ISSUE: type reference
              parameterExpression1 = System.Linq.Expressions.Expression.Parameter(SchedulerJobRunInfoManager.oaSnCWBkF3GMKVGwm4XB(__typeref (ISchedulerJobRunInfo)), (string) SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(1113862659 ^ 1113900947));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 2 : 4;
              continue;
            case 10:
              // ISSUE: method reference
              // ISSUE: type reference
              SchedulerJobRunInfoManager.F_DateToRun = LinqUtils.NameOf<ISchedulerJobRunInfo>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((System.Linq.Expressions.Expression) SchedulerJobRunInfoManager.qoXcy1BkbQlCHErD0RCG(SchedulerJobRunInfoManager.psEyx9BkopadG0wbbYKj((object) parameterExpression1, (object) (MethodInfo) SchedulerJobRunInfoManager.GXiZMWBkWAv5EuMnYmPa(__methodref (ISchedulerJobRunInfo.get_DateToRun))), SchedulerJobRunInfoManager.oaSnCWBkF3GMKVGwm4XB(__typeref (object))), parameterExpression1));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 9 : 2;
              continue;
            case 11:
              goto label_7;
            default:
              // ISSUE: type reference
              parameterExpression1 = System.Linq.Expressions.Expression.Parameter(SchedulerJobRunInfoManager.oaSnCWBkF3GMKVGwm4XB(__typeref (ISchedulerJobRunInfo)), (string) SchedulerJobRunInfoManager.K5mhivBT0TwvosOGkg1R(-1822890472 ^ -1822944376));
              num2 = 2;
              continue;
          }
        }
label_7:
        // ISSUE: method reference
        // ISSUE: type reference
        SchedulerJobRunInfoManager.F_Status = LinqUtils.NameOf<ISchedulerJobRunInfo>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((System.Linq.Expressions.Expression) SchedulerJobRunInfoManager.qoXcy1BkbQlCHErD0RCG((object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression1, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ISchedulerJobRunInfo.get_Status))), SchedulerJobRunInfoManager.oaSnCWBkF3GMKVGwm4XB(__typeref (object))), parameterExpression1));
        num1 = 3;
        continue;
label_8:
        SchedulerJobRunInfoManager.Yviw7ABTz0ExH4oIRotd();
        num1 = 6;
        continue;
label_9:
        // ISSUE: method reference
        SchedulerJobRunInfoManager.F_JobId = LinqUtils.NameOf<ISchedulerJobRunInfo>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((System.Linq.Expressions.Expression) SchedulerJobRunInfoManager.qoXcy1BkbQlCHErD0RCG(SchedulerJobRunInfoManager.psEyx9BkopadG0wbbYKj((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ISchedulerJobRunInfo.get_JobId))), typeof (object)), parameterExpression1));
        num1 = 8;
      }
label_3:;
    }

    internal static bool xZbJ6jBT7PpTPotSlAcR() => SchedulerJobRunInfoManager.pOmaXpBTAZmPBHM1L1AN == null;

    internal static SchedulerJobRunInfoManager g7lLiABTxRqGwa2uwyq2() => SchedulerJobRunInfoManager.pOmaXpBTAZmPBHM1L1AN;

    internal static object K5mhivBT0TwvosOGkg1R(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid lLjR35BTmKadXiGT82HD([In] object obj0) => ((ITrigger) obj0).Id;

    internal static object vXEVy1BTyJu0hgrpQjeQ([In] object obj0, [In] object obj1) => (object) ((EntityManager<ISchedulerJobRunInfo, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object pyH2bABTM4b9jZK7kbWk([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object dhJ6x2BTJm2d4ePjQaLU([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static bool j5fQqbBT9DXyIH7HqV9E([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object P0Lu5fBTdcanvnGjeNtP([In] object obj0, [In] object obj1) => (object) Restrictions.In((string) obj0, (object[]) obj1);

    internal static object qZMeSpBTldBMxwjiy4tq([In] object obj0) => (object) Order.Desc((string) obj0);

    internal static object F6ZhukBTr0tuG8ujvJ2P([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).AddOrder((Order) obj1);

    internal static object lpI8XLBTglQm9usfE0GP([In] object obj0, [In] int obj1) => (object) ((ICriteria) obj0).SetMaxResults(obj1);

    internal static void OedqqXBT5VIHDt1p8N0D([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object oKEUmwBTjY4DFVRvP2dA(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      DateTime dateToRun)
    {
      return (object) ((SchedulerJobRunInfoManager) obj0).Get((ITrigger) obj1, (IJob) obj2, dateToRun);
    }

    internal static JobStatus yAJGkOBTYoY4As32JiDM([In] object obj0) => ((ISchedulerJobRunInfo) obj0).Status;

    internal static Guid XNGK7SBTLWIc40S6GLeQ([In] object obj0) => ((IJob) obj0).Id;

    internal static object AYIx2TBTUWnGBb6ynEJd([In] object obj0, [In] object obj1) => (object) Restrictions.Ge((string) obj0, obj1);

    internal static object I8IEQQBTscypScHTxAsB([In] object obj0, [In] bool obj1) => (object) ((ICriteria) obj0).SetCacheable(obj1);

    internal static TimeSpan mQRr5PBTconeMKumrEfj([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static void Yviw7ABTz0ExH4oIRotd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static System.Type oaSnCWBkF3GMKVGwm4XB([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object bKGB5XBkBJjiXP7vv5WU([In] System.Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object GXiZMWBkWAv5EuMnYmPa([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object psEyx9BkopadG0wbbYKj([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static object qoXcy1BkbQlCHErD0RCG([In] object obj0, [In] System.Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);
  }
}
