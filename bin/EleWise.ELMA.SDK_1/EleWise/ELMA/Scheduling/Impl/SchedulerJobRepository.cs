// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Impl.SchedulerJobRepository
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
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
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Scheduling.Impl
{
  /// <summary>
  /// Реализация репозитория работ планировщика, основанная на работах, хранящихся в БД
  /// </summary>
  [Component(Type = ComponentType.WebServer, EnableInterceptors = true)]
  public class SchedulerJobRepository : ISchedulerJobRepository, ISchedulerJobDbRepository
  {
    private static SchedulerJobRepository mWIqreBk2eNNLIHVXqG3;

    /// <summary>Менеджер задачи планировщика</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
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

    /// <summary>Менеджер информации о запуске работы планировщика</summary>
    public SchedulerJobRunInfoManager SchedulerJobRunInfoManager
    {
      get => this.\u003CSchedulerJobRunInfoManager\u003Ek__BackingField;
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
              this.\u003CSchedulerJobRunInfoManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
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

    /// <summary>Менеджер единиц работы</summary>
    public IUnitOfWorkManager UnitOfWorkManager
    {
      get => this.\u003CUnitOfWorkManager\u003Ek__BackingField;
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
              this.\u003CUnitOfWorkManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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

    /// <summary>Cервис производственного календаря</summary>
    public IProductionCalendarService ProductionCalendarService
    {
      get => this.\u003CProductionCalendarService\u003Ek__BackingField;
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
              this.\u003CProductionCalendarService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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

    /// <summary>Исполнители работ планировщика</summary>
    public IEnumerable<ISchedulerTaskJobExecutor> SchedulerTaskJobExecutors { get; set; }

    /// <summary>Менеджер работ задачи планировщика</summary>
    public IEntityManager<ISchedulerTaskJob> SchedulerTaskJobManager { get; set; }

    /// <summary>Среда исполнения акторов</summary>
    public IActorModelRuntime ActorModelRuntime
    {
      get => this.\u003CActorModelRuntime\u003Ek__BackingField;
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
              this.\u003CActorModelRuntime\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    /// <summary>Сервис флагов функций</summary>
    public IFeatureFlagService FeatureFlagService
    {
      get => this.\u003CFeatureFlagService\u003Ek__BackingField;
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
              this.\u003CFeatureFlagService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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
    public ICollection<ISchedulerJob> GetSchedulerJobs() => !this.FeatureFlagService.Enabled(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317720846), true) ? (ICollection<ISchedulerJob>) new ISchedulerJob[0] : (ICollection<ISchedulerJob>) this.SchedulerTaskManager.FindPeriodicTasksToExecute().Select<ISchedulerTask, SchedulerJobRepository.SchedulerJobImpl>((Func<ISchedulerTask, SchedulerJobRepository.SchedulerJobImpl>) (t => SchedulerJobRepository.SchedulerJobImpl.Create((object) this.ProductionCalendarService, this.SchedulerTaskJobExecutors, (IEntityManager<ISchedulerTask>) this.SchedulerTaskManager, this.SchedulerTaskJobManager, (object) t))).Where<SchedulerJobRepository.SchedulerJobImpl>((Func<SchedulerJobRepository.SchedulerJobImpl, bool>) (j => j != null)).Cast<ISchedulerJob>().ToList<ISchedulerJob>();

    /// <inheritdoc />
    public ISchedulerJob CreateSchedulerJob(ISchedulerTask task, DateTime? customExecuteTime = null) => (ISchedulerJob) SchedulerJobRepository.SchedulerJobImpl.Create((object) this.ProductionCalendarService, this.SchedulerTaskJobExecutors, (IEntityManager<ISchedulerTask>) this.SchedulerTaskManager, this.SchedulerTaskJobManager, (object) task, customExecuteTime);

    /// <inheritdoc />
    public virtual ICollection<ISchedulerJob> GetOnceSchedulerJobs()
    {
      using (this.LockManager.Lock(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576091738)))
      {
        List<ISchedulerJob> result = new List<ISchedulerJob>();
        this.UnitOfWorkManager.Execute((System.Action) (() =>
        {
          int num1 = 1;
          IEnumerator<SchedulerJobRepository.SchedulerJobImpl> enumerator;
          while (true)
          {
            switch (num1)
            {
              case 1:
                IEnumerable<SchedulerJobRepository.SchedulerJobImpl> source = this.SchedulerTaskManager.FindOnceExecuteTasksToExecute().Select<ISchedulerTask, SchedulerJobRepository.SchedulerJobImpl>((Func<ISchedulerTask, SchedulerJobRepository.SchedulerJobImpl>) (t => SchedulerJobRepository.SchedulerJobImpl.Create((object) this.ProductionCalendarService, this.SchedulerTaskJobExecutors, (IEntityManager<ISchedulerTask>) this.SchedulerTaskManager, this.SchedulerTaskJobManager, (object) t)));
                // ISSUE: reference to a compiler-generated field
                Func<SchedulerJobRepository.SchedulerJobImpl, bool> func = SchedulerJobRepository.\u003C\u003Ec.\u003C\u003E9__38_2;
                Func<SchedulerJobRepository.SchedulerJobImpl, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  SchedulerJobRepository.\u003C\u003Ec.\u003C\u003E9__38_2 = predicate = (Func<SchedulerJobRepository.SchedulerJobImpl, bool>) (j =>
                  {
                    int num2 = 5;
                    DateTime? nullable3;
                    while (true)
                    {
                      DateTime? nullable4;
                      switch (num2)
                      {
                        case 1:
                          goto label_5;
                        case 2:
                          nullable3 = new DateTime?();
                          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                          continue;
                        case 3:
                          goto label_2;
                        case 4:
                          ISchedulerTask schedulerTask = j.SchedulerTask;
                          if (schedulerTask == null)
                          {
                            num2 = 2;
                            continue;
                          }
                          nullable4 = schedulerTask.OnceExecuteTime;
                          break;
                        case 5:
                          if (j != null)
                          {
                            num2 = 4;
                            continue;
                          }
                          goto label_2;
                        default:
                          nullable4 = nullable3;
                          break;
                      }
                      nullable3 = nullable4;
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
                    }
label_2:
                    return false;
label_5:
                    return nullable3.HasValue;
                  });
                }
                else
                  goto label_27;
label_26:
                enumerator = source.Where<SchedulerJobRepository.SchedulerJobImpl>(predicate).GetEnumerator();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                continue;
label_27:
                predicate = func;
                goto label_26;
              case 2:
                goto label_24;
              default:
                goto label_2;
            }
          }
label_24:
          return;
label_2:
          try
          {
label_7:
            // ISSUE: reference to a compiler-generated method
            if (SchedulerJobRepository.\u003C\u003Ec__DisplayClass38_0.Jb89ONQVFkFMWpWhEPup((object) enumerator))
              goto label_13;
            else
              goto label_8;
label_4:
            SchedulerJobRepository.SchedulerJobImpl current;
            int num3;
            while (true)
            {
              switch (num3)
              {
                case 1:
                case 3:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (!this.SchedulerJobRunInfoManager.SetPendingWithNoLock((ITrigger) SchedulerJobRepository.\u003C\u003Ec__DisplayClass38_0.YMGsgOQIz8VmFBRwIhD2((object) current), current.Jobs, ((ISchedulerTask) SchedulerJobRepository.\u003C\u003Ec__DisplayClass38_0.B758JpQIcj7uuSwyNdFH((object) current)).OnceExecuteTime.Value))
                  {
                    num3 = 6;
                    continue;
                  }
                  goto case 5;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  if (SchedulerJobRepository.\u003C\u003Ec__DisplayClass38_0.B758JpQIcj7uuSwyNdFH((object) current) != null)
                  {
                    num3 = 9;
                    continue;
                  }
                  goto case 1;
                case 4:
                  goto label_13;
                case 5:
                  result.Add((ISchedulerJob) current);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
                  continue;
                case 7:
                  goto label_21;
                case 9:
                  // ISSUE: reference to a compiler-generated method
                  ((IEntity) SchedulerJobRepository.\u003C\u003Ec__DisplayClass38_0.B758JpQIcj7uuSwyNdFH((object) current)).Delete();
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 8 : 3;
                  continue;
                case 10:
                  // ISSUE: reference to a compiler-generated method
                  if (SchedulerJobRepository.\u003C\u003Ec__DisplayClass38_0.vRo5p8QIsa4rV02VUpr6((object) current.Jobs) != 0)
                  {
                    num3 = 3;
                    continue;
                  }
                  goto case 2;
                default:
                  goto label_7;
              }
            }
label_21:
            return;
label_8:
            num3 = 7;
            goto label_4;
label_13:
            current = enumerator.Current;
            num3 = 10;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
            {
              num3 = 1;
              goto label_4;
            }
            else
              goto label_4;
          }
          finally
          {
            int num4;
            if (enumerator == null)
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
            else
              goto label_20;
label_19:
            switch (num4)
            {
              case 1:
              case 2:
            }
label_20:
            // ISSUE: reference to a compiler-generated method
            SchedulerJobRepository.\u003C\u003Ec__DisplayClass38_0.UKfQtpQVBjlYTtydrx5Z((object) enumerator);
            num4 = 2;
            goto label_19;
          }
        }));
        return (ICollection<ISchedulerJob>) result;
      }
    }

    /// <inheritdoc />
    async Task<ICollection<ISchedulerJob>> ISchedulerJobDbRepository.GetSchedulerJobs(
      DateTime dateTimeToRun)
    {
      int num1 = 3;
      int num2;
      ICollection<ISchedulerJob> result1;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_46:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            num1 = 4;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 2;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 15;
              else
                goto label_11;
label_6:
              TaskAwaiter<IEnumerable<Guid>> awaiter;
              while (true)
              {
                TaskAwaiter<IEnumerable<Guid>> taskAwaiter;
                int num4;
                IEnumerable<Guid> result2;
                List<ISchedulerJob> schedulerJobList;
                IEnumerator<ISchedulerTask> enumerator;
                switch (num3)
                {
                  case 1:
                    try
                    {
label_19:
                      // ISSUE: reference to a compiler-generated method
                      if (SchedulerJobRepository.\u003CEleWise\u002DELMA\u002DScheduling\u002DISchedulerJobDbRepository\u002DGetSchedulerJobs\u003Ed__39.A4U6YlQVhLIMRFBmdBt2((object) enumerator))
                        goto label_17;
                      else
                        goto label_20;
label_16:
                      ISchedulerTask current;
                      ISchedulerJob schedulerJob;
                      int num5;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            schedulerJob = this.CreateSchedulerJob(current);
                            num5 = 2;
                            continue;
                          case 2:
                            schedulerJobList.Add(schedulerJob);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                            continue;
                          case 3:
                            goto label_10;
                          case 4:
                            goto label_17;
                          default:
                            goto label_19;
                        }
                      }
label_17:
                      current = enumerator.Current;
                      num5 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
                      {
                        num5 = 1;
                        goto label_16;
                      }
                      else
                        goto label_16;
label_20:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 3 : 3;
                      goto label_16;
                    }
                    finally
                    {
                      int num6;
                      if (num2 >= 0)
                        num6 = 3;
                      else
                        goto label_26;
label_25:
                      while (true)
                      {
                        switch (num6)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            SchedulerJobRepository.\u003CEleWise\u002DELMA\u002DScheduling\u002DISchedulerJobDbRepository\u002DGetSchedulerJobs\u003Ed__39.DOfyFfQVGvqqjMvLCxXn((object) enumerator);
                            num6 = 2;
                            continue;
                          case 2:
                          case 3:
                            goto label_30;
                          default:
                            goto label_26;
                        }
                      }
label_26:
                      if (enumerator != null)
                      {
                        num6 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                        {
                          num6 = 0;
                          goto label_25;
                        }
                        else
                          goto label_25;
                      }
label_30:;
                    }
                  case 2:
                  case 8:
                    result2 = awaiter.GetResult();
                    num3 = 9;
                    continue;
                  case 3:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num4 = 12;
                    break;
                  case 4:
                    goto label_46;
                  case 5:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<Guid>>, SchedulerJobRepository.\u003CEleWise\u002DELMA\u002DScheduling\u002DISchedulerJobDbRepository\u002DGetSchedulerJobs\u003Ed__39>(ref awaiter, this);
                    num3 = 14;
                    continue;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 2;
                    continue;
                  case 7:
                    goto label_11;
                  case 9:
                    ICollection<ISchedulerTask> byIdArray = this.SchedulerTaskManager.FindByIdArray(result2.ToArray<Guid>());
                    schedulerJobList = new List<ISchedulerJob>();
                    enumerator = byIdArray.GetEnumerator();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 1;
                    continue;
                  case 10:
                    taskAwaiter = new TaskAwaiter<IEnumerable<Guid>>();
                    num4 = 6;
                    break;
                  case 11:
label_10:
                    result1 = (ICollection<ISchedulerJob>) schedulerJobList;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 2;
                    continue;
                  case 12:
                    taskAwaiter = awaiter;
                    num3 = 5;
                    continue;
                  case 13:
                    if (awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 8;
                      continue;
                    }
                    goto case 3;
                  case 14:
                    goto label_40;
                  default:
                    awaiter = taskAwaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 10 : 10;
                    continue;
                }
                num3 = num4;
              }
label_40:
              return;
label_11:
              awaiter = this.ActorModelRuntime.GetActor<ISchedulerJobDbRepositoryActor>(Guid.Empty).GetSchedulerTasksUid(dateTimeToRun).GetAwaiter();
              num3 = 13;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0)
              {
                num3 = 12;
                goto label_6;
              }
              else
                goto label_6;
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
                num7 = 0;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    goto label_36;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 2 : 0;
                    continue;
                }
              }
label_36:
              return;
            }
          case 5:
            goto label_43;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result1);
            num1 = 5;
            continue;
        }
      }
label_43:;
    }

    public SchedulerJobRepository()
    {
      SchedulerJobRepository.ggMVUUBk1mmPiYVSbpq0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool BYvhWbBkek4YawHaRJh4() => SchedulerJobRepository.mWIqreBk2eNNLIHVXqG3 == null;

    internal static SchedulerJobRepository cVXAEpBkPGRDIBtd8eo9() => SchedulerJobRepository.mWIqreBk2eNNLIHVXqG3;

    internal static void ggMVUUBk1mmPiYVSbpq0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Запланированная работа планировщика, хрянящаяся в БД</summary>
    private sealed class SchedulerJobImpl : SchedulerJobBase, ISchedulerJobDb, ISchedulerJob
    {
      private readonly long schedulerTaskId;
      private object trigger;
      private readonly IEntityManager<ISchedulerTask> schedulerTaskManager;
      private readonly IEntityManager<ISchedulerTaskJob> schedulerTaskJobManager;
      private readonly List<IJob> jobs;
      internal static object PclSnkQIHXhBZpH8oykK;

      public static SchedulerJobRepository.SchedulerJobImpl Create(
        object productionCalendarService,
        IEnumerable<ISchedulerTaskJobExecutor> schedulerTaskJobExecutors,
        IEntityManager<ISchedulerTask> schedulerTaskManager,
        IEntityManager<ISchedulerTaskJob> schedulerTaskJobManager,
        object schedulerTask,
        DateTime? customExecuteTime = null)
      {
        ITrigger baseTrigger = (ITrigger) null;
        SchedulerJobRepository.SchedulerJobImpl job = new SchedulerJobRepository.SchedulerJobImpl((ISchedulerTask) schedulerTask, (ITrigger) null, schedulerTaskJobExecutors, schedulerTaskManager, schedulerTaskJobManager);
        switch (((ISchedulerTask) schedulerTask).Type)
        {
          case SchedulerTaskType.Once:
            OnceExecuteTrigger onceExecuteTrigger;
            if (!((ISchedulerTask) schedulerTask).OnceExecuteTime.HasValue)
            {
              onceExecuteTrigger = (OnceExecuteTrigger) null;
            }
            else
            {
              onceExecuteTrigger = new OnceExecuteTrigger((Func<ISchedulerTask>) (() => job.SchedulerTask));
              onceExecuteTrigger.Name = ((ISchedulerTask) schedulerTask).Name;
              onceExecuteTrigger.Id = ((ISchedulerTask) schedulerTask).Uid;
            }
            baseTrigger = (ITrigger) onceExecuteTrigger;
            break;
          case SchedulerTaskType.Periodic:
            baseTrigger = (ITrigger) new NthIncludedDayTrigger((NthIncludedDaySettings) ((ISchedulerTask) schedulerTask).Settings, ((IProductionCalendarService) productionCalendarService).GetGlobalProductionSchedule())
            {
              Name = ((ISchedulerTask) schedulerTask).Name,
              Id = ((ISchedulerTask) schedulerTask).Uid
            };
            break;
        }
        if (baseTrigger == null)
          return (SchedulerJobRepository.SchedulerJobImpl) null;
        job.trigger = customExecuteTime.HasValue ? (object) new CustomExecuteTimeTrigger(baseTrigger, customExecuteTime.Value) : (object) baseTrigger;
        return job;
      }

      /// <summary>Ctor</summary>
      /// <param name="schedulerTask"></param>
      /// <param name="trigger"></param>
      private SchedulerJobImpl(
        ISchedulerTask schedulerTask,
        ITrigger trigger,
        IEnumerable<ISchedulerTaskJobExecutor> schedulerTaskJobExecutors,
        IEntityManager<ISchedulerTask> schedulerTaskManager,
        IEntityManager<ISchedulerTaskJob> schedulerTaskJobManager)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        Contract.ArgumentNotNull((object) schedulerTask, z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516628730));
        Contract.ArgumentNotNull((object) schedulerTaskJobExecutors, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420576472));
        Contract.ArgumentNotNull((object) schedulerTaskManager, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106301568));
        Contract.ArgumentNotNull((object) schedulerTaskJobManager, z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825693558));
        this.schedulerTaskId = schedulerTask.Id;
        this.SchedulerTask = schedulerTask;
        this.trigger = (object) trigger;
        this.schedulerTaskManager = schedulerTaskManager;
        this.schedulerTaskJobManager = schedulerTaskJobManager;
        this.jobs = schedulerTask.Jobs.Select<ISchedulerTaskJob, SchedulerJobRepository.JobImpl>((Func<ISchedulerTaskJob, SchedulerJobRepository.JobImpl>) (j => new SchedulerJobRepository.JobImpl(j, schedulerTaskJobExecutors))).Cast<IJob>().ToList<IJob>();
      }

      /// <inheritdoc />
      public override Guid? OwnerUid => this.SchedulerTask.OwnerUid;

      /// <inheritdoc />
      public override ITrigger Trigger => (ITrigger) this.trigger;

      /// <inheritdoc />
      public override ICollection<IJob> Jobs => (ICollection<IJob>) this.jobs;

      /// <inheritdoc />
      public ISchedulerTask SchedulerTask
      {
        get => this.\u003CSchedulerTask\u003Ek__BackingField;
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
                this.\u003CSchedulerTask\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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
      public void Refresh()
      {
        int num1 = 2;
        List<IJob>.Enumerator enumerator;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_19;
            case 1:
              enumerator = this.jobs.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 3 : 1;
              continue;
            case 2:
              this.SchedulerTask = this.schedulerTaskManager.Load((object) this.schedulerTaskId);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_4;
            default:
              goto label_15;
          }
        }
label_19:
        return;
label_15:
        return;
label_4:
        try
        {
label_7:
          if (enumerator.MoveNext())
            goto label_9;
          else
            goto label_8;
label_5:
          SchedulerJobRepository.JobImpl current;
          int num2;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_6;
              case 1:
                current.job = this.schedulerTaskJobManager.Load((object) current.job.Id);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 3;
                continue;
              case 2:
                goto label_9;
              case 3:
                if (current.job != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 4;
                  continue;
                }
                goto label_7;
              case 4:
                current.job = current.job.CastAsRealType<ISchedulerTaskJob>();
                num2 = 5;
                continue;
              case 5:
                goto label_7;
              default:
                goto label_2;
            }
          }
label_6:
          return;
label_2:
          return;
label_8:
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
          goto label_5;
label_9:
          current = (SchedulerJobRepository.JobImpl) enumerator.Current;
          num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
          {
            num2 = 1;
            goto label_5;
          }
          else
            goto label_5;
        }
        finally
        {
          enumerator.Dispose();
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
            num3 = 0;
          switch (num3)
          {
            default:
          }
        }
      }

      internal static bool cMJbUMQIAe5L5Rg1Cfnd() => SchedulerJobRepository.SchedulerJobImpl.PclSnkQIHXhBZpH8oykK == null;

      internal static SchedulerJobRepository.SchedulerJobImpl SmqamfQI7hlMtU7M2dva() => (SchedulerJobRepository.SchedulerJobImpl) SchedulerJobRepository.SchedulerJobImpl.PclSnkQIHXhBZpH8oykK;
    }

    /// <summary>Работа планировщика, хранящаяся в БД</summary>
    internal class JobImpl : IJob, IThreadPoolContainer
    {
      /// <summary>Работа задачи планировщика</summary>
      internal ISchedulerTaskJob job;
      /// <summary>Исполнитель работы планировщика</summary>
      internal readonly ISchedulerTaskJobExecutor executor;
      private readonly IThreadPool threadPool;
      internal static SchedulerJobRepository.JobImpl nbv4RlQIxFtVF4SD24cd;

      /// <summary>Ctor</summary>
      /// <param name="job">Работа задачи планировщика</param>
      /// <param name="schedulerTaskJobExecutors">Исполнители работы планировщика</param>
      public JobImpl(
        ISchedulerTaskJob job,
        IEnumerable<ISchedulerTaskJobExecutor> schedulerTaskJobExecutors)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        Contract.ArgumentNotNull((object) job, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411124015));
        this.job = job.CastAsRealType<ISchedulerTaskJob>();
        this.executor = schedulerTaskJobExecutors.FirstOrDefault<ISchedulerTaskJobExecutor>((Func<ISchedulerTaskJobExecutor, bool>) (e => e.CanExecute(job)));
        this.threadPool = this.executor is IThreadPoolContainer executor ? executor.Pool : (IThreadPool) null;
      }

      /// <inheritdoc />
      public Guid Id => SchedulerJobRepository.JobImpl.Jco4RPQIyY07yIOZTufF((object) this.job);

      /// <inheritdoc />
      public string Name => (string) SchedulerJobRepository.JobImpl.fSFoHhQIM0MwYcuhhC6M((object) this.job);

      /// <inheritdoc />
      public Image Icon => (Image) null;

      /// <inheritdoc />
      public JobResult Do(DateTime dateToRun)
      {
        int num1 = 3;
        JobResult jobResult;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_6;
              case 2:
                ((ILogger) SchedulerJobRepository.JobImpl.homo5AQIJPupZ30ZFaxk()).Error((object) ((string) SchedulerJobRepository.JobImpl.cGB4QUQI9LVZYtFxTqXD(-218496594 ^ -218139380) + this.job.GetType().FullName + (string) SchedulerJobRepository.JobImpl.cGB4QUQI9LVZYtFxTqXD(381945751 ^ 1158627804 ^ 1406022313)));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
                continue;
              case 3:
                if (this.executor == null)
                {
                  num2 = 2;
                  continue;
                }
                goto label_10;
              case 4:
                SchedulerJobRepository.JobImpl.B0UjNdQIdWegRkfRXeHl((object) jobResult, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757331906), (object) this.job.GetType().FullName));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              case 5:
                jobResult.Status = JobStatus.Fail;
                num2 = 4;
                continue;
              default:
                goto label_9;
            }
          }
label_6:
          jobResult = new JobResult();
          num1 = 5;
        }
label_9:
        return jobResult;
label_10:
        return this.executor.Do(this.job, dateToRun);
      }

      /// <inheritdoc />
      IThreadPool IThreadPoolContainer.Pool => this.threadPool;

      internal static Guid Jco4RPQIyY07yIOZTufF([In] object obj0) => ((ISchedulerTaskJob) obj0).Uid;

      internal static bool oq8thQQI0C0PYPxrgH8V() => SchedulerJobRepository.JobImpl.nbv4RlQIxFtVF4SD24cd == null;

      internal static SchedulerJobRepository.JobImpl PFIDE8QImD3lroBNNSLN() => SchedulerJobRepository.JobImpl.nbv4RlQIxFtVF4SD24cd;

      internal static object fSFoHhQIM0MwYcuhhC6M([In] object obj0) => (object) ((ISchedulerTaskJob) obj0).Name;

      internal static object homo5AQIJPupZ30ZFaxk() => (object) Logger.Log;

      internal static object cGB4QUQI9LVZYtFxTqXD(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void B0UjNdQIdWegRkfRXeHl([In] object obj0, [In] object obj1) => ((JobResult) obj0).ErrorDescription = (string) obj1;
    }
  }
}
