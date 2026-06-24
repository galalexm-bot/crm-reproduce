// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Impl.SchedulerJobDbRepositoryActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Scheduling.Triggers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Scheduling.Impl
{
  /// <summary>Актор репозитория работ планировщика, хранящихся в БД</summary>
  internal sealed class SchedulerJobDbRepositoryActor : 
    Actor,
    ISchedulerJobDbRepositoryActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IRuntimeApplication runtimeApplication;
    private readonly ISchedulerJobRunInfoManager schedulerJobRunInfoManager;
    private readonly IEnumerable<ISchedulerJobDbRepository> schedulerJobDbRepositories;
    private readonly IFeatureFlagService featureFlagService;
    private readonly HashSet<Guid> forceRunTrigger;
    /// <summary>
    /// Карта Идентификатор периодической задачи - Триггер задачи
    /// </summary>
    private Dictionary<Guid, ITrigger> schedulerTaskToTriggerMap;
    internal static SchedulerJobDbRepositoryActor A6pXyHBkSnFovK9fH7St;

    /// <summary>Ctor</summary>
    /// <param name="runtimeApplication">Среда исполнения приложения</param>
    /// <param name="schedulerJobRunInfoManager">Менеджер информации о запуске работы планировщика</param>
    /// <param name="schedulerJobRepositories">Репозитории работ планировщика</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public SchedulerJobDbRepositoryActor(
      IRuntimeApplication runtimeApplication,
      ISchedulerJobRunInfoManager schedulerJobRunInfoManager,
      IEnumerable<ISchedulerJobRepository> schedulerJobRepositories,
      IFeatureFlagService featureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.forceRunTrigger = new HashSet<Guid>();
      this.LifeTime = TimeSpan.FromDays(365.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.runtimeApplication = runtimeApplication;
      this.schedulerJobRunInfoManager = schedulerJobRunInfoManager;
      this.schedulerJobDbRepositories = schedulerJobRepositories.OfType<ISchedulerJobDbRepository>();
      this.featureFlagService = featureFlagService;
    }

    /// <inheritdoc />
    public override TimeSpan LifeTime { get; }

    /// <inheritdoc />
    public override Task OnActivateAsync() => this.Refresh();

    /// <inheritdoc />
    public async Task<IEnumerable<Guid>> GetSchedulerTasksUid(DateTime dateTimeToRun)
    {
      int num1 = 2;
      IEnumerable<Guid> result;
      int num2;
      SchedulerJobDbRepositoryActor dbRepositoryActor1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_36;
          case 1:
            dbRepositoryActor1 = this;
            num1 = 4;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
            continue;
          case 3:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 5;
            continue;
          case 4:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 18;
              else
                goto label_12;
label_8:
              int num4 = num3;
label_9:
              TaskAwaiter<IEnumerable<Guid>> taskAwaiter;
              TaskAwaiter<IEnumerable<Guid>> awaiter;
              SchedulerJobDbRepositoryActor dbRepositoryActor;
              DateTime dateTimeToRun1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_29;
                  case 2:
                  case 8:
                    awaiter = dbRepositoryActor1.RunExternalTask<IEnumerable<Guid>>((Func<Task<IEnumerable<Guid>>>) (() => Task.FromResult<IEnumerable<Guid>>(dbRepositoryActor.GetSchedulerTasksUidInternal(dateTimeToRun1)))).GetAwaiter();
                    num4 = 13;
                    continue;
                  case 3:
                    dbRepositoryActor = this;
                    num4 = 6;
                    continue;
                  case 4:
                  case 5:
                    goto label_3;
                  case 6:
                    dateTimeToRun1 = dateTimeToRun;
                    num4 = 10;
                    continue;
                  case 7:
                    result = Enumerable.Empty<Guid>();
                    num4 = 5;
                    continue;
                  case 9:
                    taskAwaiter = awaiter;
                    num4 = 17;
                    continue;
                  case 10:
                    // ISSUE: reference to a compiler-generated method
                    if (EleWise.ELMA.SR.GetSetting<bool>((string) SchedulerJobDbRepositoryActor.\u003CGetSchedulerTasksUid\u003Ed__11.uxDdZlQIqP2dlcOh6aWS(-1872275253 >> 6 ^ -29315775), true))
                    {
                      num4 = 2;
                      continue;
                    }
                    goto case 7;
                  case 11:
                    goto label_12;
                  case 12:
                    taskAwaiter = new TaskAwaiter<IEnumerable<Guid>>();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                    continue;
                  case 13:
                    if (awaiter.IsCompleted)
                    {
                      num4 = 15;
                      continue;
                    }
                    goto label_11;
                  case 14:
                    goto label_11;
                  case 15:
                  case 16:
                    result = awaiter.GetResult();
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 4 : 1;
                    continue;
                  case 17:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<IEnumerable<Guid>>, SchedulerJobDbRepositoryActor.\u003CGetSchedulerTasksUid\u003Ed__11>(ref awaiter, this);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                    continue;
                  case 18:
                    num4 = 3;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 16 : 12;
                    continue;
                }
              }
label_29:
              return;
label_11:
              // ISSUE: explicit reference operation
              // ISSUE: reference to a compiler-generated field
              (^this).\u003C\u003E1__state = num2 = 0;
              num3 = 9;
              goto label_8;
label_12:
              awaiter = taskAwaiter;
              num4 = 6;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
              {
                num4 = 12;
                goto label_9;
              }
              else
                goto label_9;
            }
            catch (Exception ex)
            {
              int num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_22;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = 2;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_20;
                }
              }
label_22:
              return;
label_20:
              return;
            }
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_33;
        }
      }
label_36:
      return;
label_33:;
    }

    /// <inheritdoc />
    public Task AddForceRunTrigger(Guid triggerUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.forceRunTrigger.Add(triggerUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (Task) SchedulerJobDbRepositoryActor.E2UrAHBkqaS9b0grpInW();
    }

    /// <inheritdoc />
    public Task Refresh()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.schedulerTaskToTriggerMap = (Dictionary<Guid, ITrigger>) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return Task.CompletedTask;
    }

    /// <summary>
    /// Получить уникальные идентификаторы периодических задач для исполнения в указанный момент времени
    /// </summary>
    /// <param name="dateTimeToRun">Дата/время для запуска</param>
    /// <returns>Уникальные идентификаторы периодических задач</returns>
    private IEnumerable<Guid> GetSchedulerTasksUidInternal(DateTime dateTimeToRun)
    {
      using (CallContextSessionOwner.Create())
      {
        if (this.schedulerTaskToTriggerMap == null)
        {
          this.schedulerTaskToTriggerMap = new Dictionary<Guid, ITrigger>();
          foreach (ISchedulerJob schedulerJob in this.schedulerJobDbRepositories.SelectMany<ISchedulerJobDbRepository, ISchedulerJob>((Func<ISchedulerJobDbRepository, IEnumerable<ISchedulerJob>>) (repository => (IEnumerable<ISchedulerJob>) repository.GetSchedulerJobs())).ToArray<ISchedulerJob>())
            this.schedulerTaskToTriggerMap.Add(((ISchedulerJobDb) schedulerJob).SchedulerTask.Uid, schedulerJob.Trigger);
        }
        IList<ISchedulerJobRunInfo> schedulerJobRunInfos = this.schedulerJobRunInfoManager.GetLastRunInfos(this.schedulerTaskToTriggerMap.Select<KeyValuePair<Guid, ITrigger>, Guid>((Func<KeyValuePair<Guid, ITrigger>, Guid>) (p => p.Key)), false);
        List<Guid> triggerIds = new List<Guid>();
        foreach (ISchedulerJobRunInfo schedulerJobRunInfo in schedulerJobRunInfos.Where<ISchedulerJobRunInfo>((Func<ISchedulerJobRunInfo, bool>) (item => item != null)).ToList<ISchedulerJobRunInfo>())
        {
          ITrigger schedulerTaskToTrigger = this.schedulerTaskToTriggerMap[schedulerJobRunInfo.Job.Task.Uid];
          if ((schedulerJobRunInfo.Status == JobStatus.Pending || schedulerJobRunInfo.Status == JobStatus.Working) && (schedulerJobRunInfo.ConnectionUid == Guid.Empty || !this.runtimeApplication.IsConnectionAlive(schedulerJobRunInfo.ConnectionUid) || dateTimeToRun > schedulerJobRunInfo.StatusUpdateDate.Add(schedulerTaskToTrigger.GetTriggerTimeout())))
          {
            triggerIds.Add(schedulerTaskToTrigger.Id);
            schedulerJobRunInfos.Remove(schedulerJobRunInfo);
          }
        }
        schedulerJobRunInfos.AddRange<ISchedulerJobRunInfo>((IEnumerable<ISchedulerJobRunInfo>) this.schedulerJobRunInfoManager.GetLastRunInfos((IEnumerable<Guid>) triggerIds, true));
        return (IEnumerable<Guid>) this.schedulerTaskToTriggerMap.Where<KeyValuePair<Guid, ITrigger>>((Func<KeyValuePair<Guid, ITrigger>, bool>) (item =>
        {
          if (this.forceRunTrigger.Contains(item.Value.Id))
          {
            this.forceRunTrigger.Remove(item.Value.Id);
            return true;
          }
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          ISchedulerJobRunInfo schedulerJobRunInfo = schedulerJobRunInfos.FirstOrDefault<ISchedulerJobRunInfo>((Func<ISchedulerJobRunInfo, bool>) (info => SchedulerJobDbRepositoryActor.\u003C\u003Ec__DisplayClass14_2.pShldkQIDhW2b3Dr3CDB(SchedulerJobDbRepositoryActor.\u003C\u003Ec__DisplayClass14_2.Oed0ETQIpdYJNxvJj5I9((object) info), SchedulerJobDbRepositoryActor.\u003C\u003Ec__DisplayClass14_2.d9llU7QIaBvo2doZ2PKL((object) item.Value))));
          if (schedulerJobRunInfo != null && (schedulerJobRunInfo.Status == JobStatus.Pending || schedulerJobRunInfo.Status == JobStatus.Pending))
            return false;
          DateTime? dateToRun = schedulerJobRunInfo?.DateToRun;
          return (item.Value is OnceExecuteTrigger ? item.Value.GetNextTimeAfter(dateToRun, dateTimeToRun) : item.Value.GetNextTimeAfterUnfolded(dateToRun, dateTimeToRun)).HasValue;
        })).Select<KeyValuePair<Guid, ITrigger>, Guid>((Func<KeyValuePair<Guid, ITrigger>, Guid>) (item => item.Key)).ToArray<Guid>();
      }
    }

    internal static object E2UrAHBkqaS9b0grpInW() => (object) Task.CompletedTask;

    internal static bool m9m8t7BkioVlb53tsDBq() => SchedulerJobDbRepositoryActor.A6pXyHBkSnFovK9fH7St == null;

    internal static SchedulerJobDbRepositoryActor pf0LKcBkRngBpCImGe2m() => SchedulerJobDbRepositoryActor.A6pXyHBkSnFovK9fH7St;
  }
}
