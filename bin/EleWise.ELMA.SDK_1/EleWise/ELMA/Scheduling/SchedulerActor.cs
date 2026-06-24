// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.SchedulerActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Актор планировщика заданий</summary>
  internal sealed class SchedulerActor : Actor, ISchedulerActor, IActorWithGuidKey, IActor
  {
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

    /// <summary>Ctor</summary>
    /// <param name="schedulerJobRunInfoManager">Менеджер информации о запуске работы планировщика</param>
    /// <param name="runtimeApplication">Среда исполнения приложения</param>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    /// <param name="schedulerJobRepositories">Репозитории работ планировщика</param>
    /// <param name="schedulerTaskManager">Менеджер задач планировщика</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    /// <param name="distributedFeatureFlagService">Распределенный сервис флагов функций</param>
    public SchedulerActor(
      ISchedulerJobRunInfoManager schedulerJobRunInfoManager,
      IRuntimeApplication runtimeApplication,
      IActorModelRuntime actorModelRuntime,
      IEnumerable<ISchedulerJobRepository> schedulerJobRepositories,
      ISchedulerTaskManager schedulerTaskManager,
      IFeatureFlagService featureFlagService,
      IDistributedFeatureFlagService distributedFeatureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.forceRunTrigger = new List<Guid>();
      this.tasksPool = new ElmaTasksPool(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61130785), 5);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.schedulerJobRunInfoManager = schedulerJobRunInfoManager;
      this.runtimeApplication = runtimeApplication;
      this.actorModelRuntime = actorModelRuntime;
      this.schedulerJobRepositories = schedulerJobRepositories;
      this.schedulerTaskManager = schedulerTaskManager;
      this.featureFlagService = featureFlagService;
      this.distributedFeatureFlagService = distributedFeatureFlagService;
    }

    /// <inheritdoc />
    public override Task OnActivateAsync()
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        int num3;
        TimeSpan timeSpan;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (num3 < 0)
              {
                num2 = 3;
                continue;
              }
              goto label_9;
            case 2:
              num3 = EleWise.ELMA.SR.GetSetting<int>((string) SchedulerActor.zuU4D2BqZKKZ0pGlaX2C(-630932142 - 1120244082 ^ -1751239138), 10);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 1;
              continue;
            case 3:
              num3 = 10;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 3;
              continue;
            case 4:
              goto label_9;
            case 5:
              this.RegisterTimer(new Func<object, Task>(this.ProcessSchedulerJobQueue), (object) null, timeSpan, timeSpan);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_9:
        timeSpan = TimeSpan.FromSeconds((double) num3);
        num1 = 5;
      }
label_5:
      return (Task) SchedulerActor.lCbj04Bqu5UL9GMqxxbd();
    }

    public override Task OnDeactivateAsync()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            SchedulerActor.dWJ3OGBqIypR6bhsmbgJ((object) this.tasksPool);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return base.OnDeactivateAsync();
    }

    /// <inheritdoc />
    public Task Start() => this.RegisterOrUpdateReminder((string) SchedulerActor.zuU4D2BqZKKZ0pGlaX2C(694673736 ^ -23604109 ^ -672060643), SchedulerActor.xOLqXcBqVOdsZFcQI0to(1.0), SchedulerActor.xOLqXcBqVOdsZFcQI0to(1.0));

    /// <inheritdoc />
    public Task RunTrigger(Guid triggerUid)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.forceRunTrigger.Add(triggerUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.actorModelRuntime.GetActor<ISchedulerJobDbRepositoryActor>(Guid.Empty).AddForceRunTrigger(triggerUid);
    }

    /// <inheritdoc />
    public Task RunSchedulerJob(Guid triggerUid, DateTime currentDateTime, bool forceRun)
    {
      int num = 4;
      SchedulerActor.SchedulerJobActorAction schedulerJobActor;
      ISchedulerJob schedulerJob;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (schedulerJobActor.ForceRun)
            {
              num = 6;
              continue;
            }
            goto case 5;
          case 2:
            if (schedulerJobActor == null)
            {
              num = 5;
              continue;
            }
            goto case 1;
          case 3:
            schedulerJobActor = this.GetSchedulerJobActor((ITrigger) SchedulerActor.B1g8p0BqSQF9jPLPt6np((object) schedulerJob), currentDateTime, flag, forceRun, !forceRun ? new DateTime?() : new DateTime?(currentDateTime));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
            continue;
          case 4:
            (schedulerJob, flag) = this.GetSchedulerJobFromTriggerUid(triggerUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 3;
            continue;
          case 5:
            this.PushSchedulerJobs(schedulerJobActor.ToEnumerable<SchedulerActor.SchedulerJobActorAction>());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 6:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_2:
      return schedulerJobActor.Run();
label_9:
      return (Task) SchedulerActor.lCbj04Bqu5UL9GMqxxbd();
    }

    /// <inheritdoc />
    public async Task ForceRunJob(Guid triggerUid, Guid jobUid, DateTime? now = null)
    {
      int num1 = 5;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 2;
              else
                goto label_34;
label_8:
              ISchedulerJob schedulerJob;
              ISchedulerJobActor actor;
              (ISchedulerJob schedulerJob, bool taskFromDbRepository) jobFromTriggerUid;
              bool fromDbRepository;
              Guid jobUid1;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    fromDbRepository = jobFromTriggerUid.taskFromDbRepository;
                    num3 = 6;
                    continue;
                  case 2:
                  case 7:
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 3 : 4;
                    continue;
                  case 3:
                    goto label_4;
                  case 4:
                    goto label_9;
                  case 5:
                    schedulerJob = jobFromTriggerUid.schedulerJob;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 0;
                    continue;
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    actor = this.actorModelRuntime.GetActor<ISchedulerJobActor>(((ITrigger) SchedulerActor.\u003CForceRunJob\u003Ed__18.KtgmuZQ8OHqcYQ7hNi2f((object) schedulerJob)).Id, fromDbRepository ? (string) SchedulerActor.\u003CForceRunJob\u003Ed__18.OZ7cshQ82IZHrTcehsRn(132912447 ^ 132975589) : (string) SchedulerActor.\u003CForceRunJob\u003Ed__18.OZ7cshQ82IZHrTcehsRn(~-306453669 ^ 306512406));
                    num3 = 7;
                    continue;
                  case 8:
                    goto label_34;
                  case 9:
                    jobUid1 = jobUid;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                    continue;
                  default:
                    jobFromTriggerUid = this.GetSchedulerJobFromTriggerUid(triggerUid);
                    num3 = 5;
                    continue;
                }
              }
label_9:
              try
              {
                int num4;
                if (num2 == 0)
                  num4 = 8;
                else
                  goto label_14;
label_11:
                TaskAwaiter taskAwaiter;
                TaskAwaiter awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      taskAwaiter = awaiter;
                      num4 = 12;
                      continue;
                    case 2:
                    case 8:
                      awaiter = taskAwaiter;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 2 : 11;
                      continue;
                    case 3:
                      goto label_14;
                    case 4:
                    case 6:
                      awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 4 : 10;
                      continue;
                    case 5:
                      goto label_41;
                    case 7:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 6 : 2;
                      continue;
                    case 9:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
                      continue;
                    case 10:
                      goto label_4;
                    case 11:
                      taskAwaiter = new TaskAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 7 : 7;
                      continue;
                    case 12:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, SchedulerActor.\u003CForceRunJob\u003Ed__18>(ref awaiter, this);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 4 : 5;
                      continue;
                    default:
                      if (awaiter.IsCompleted)
                      {
                        num4 = 4;
                        continue;
                      }
                      goto case 9;
                  }
                }
label_41:
                return;
label_14:
                // ISSUE: reference to a compiler-generated method
                awaiter = SchedulerActor.\u003CForceRunJob\u003Ed__18.hsYW7aQ8eGNbu2kBxrhj((object) actor.ForceRunJob(new Guid?(jobUid1)));
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                {
                  num4 = 0;
                  goto label_11;
                }
                else
                  goto label_11;
              }
              catch (Exception ex)
              {
                int num5 = 3;
                IJob job1;
                while (true)
                {
                  switch (num5)
                  {
                    case 1:
                      goto label_29;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      job1 = schedulerJob.Jobs.FirstOrDefault<IJob>((Func<IJob, bool>) (j => SchedulerActor.\u003C\u003Ec__DisplayClass18_0.bECs10Q8XUeJFywhABDE(j.Id, jobUid1)));
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                      continue;
                    case 3:
                      if (now.HasValue)
                      {
                        num5 = 2;
                        continue;
                      }
                      goto label_29;
                    default:
                      ISchedulerJobRunInfoManager jobRunInfoManager = this.schedulerJobRunInfoManager;
                      // ISSUE: reference to a compiler-generated method
                      object obj = SchedulerActor.\u003CForceRunJob\u003Ed__18.KtgmuZQ8OHqcYQ7hNi2f((object) schedulerJob);
                      IJob job2 = job1;
                      DateTime dateToRun = now.Value;
                      JobResult jobResult = new JobResult();
                      // ISSUE: reference to a compiler-generated method
                      SchedulerActor.\u003CForceRunJob\u003Ed__18.KqdsxbQ8P5vjxfPkbC4D((object) jobResult, JobStatus.Fail);
                      jobResult.ErrorDescription = ex.ToString();
                      // ISSUE: reference to a compiler-generated method
                      SchedulerActor.\u003CForceRunJob\u003Ed__18.qcv75qQ81tCYTd2PIf3i((object) jobRunInfoManager, obj, (object) job2, dateToRun, (object) jobResult);
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_29:
                throw;
              }
label_34:
              num3 = 9;
              goto label_8;
            }
            catch (Exception ex)
            {
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    goto label_37;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = 2;
                    continue;
                }
              }
label_37:
              return;
            }
          case 2:
label_4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          case 3:
            goto label_44;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 4;
            continue;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = 3;
            continue;
        }
      }
label_44:;
    }

    /// <summary>
    /// Запустить шаг планировщика по времени для задач с одиночным выполнением
    /// </summary>
    /// <param name="currentDateTime">Дата/время для запуска</param>
    private Task RunStepOnce(DateTime currentDateTime)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      SchedulerActor.\u003CRunStepOnce\u003Ed__19 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.currentDateTime = currentDateTime;
              num2 = 6;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 2;
              continue;
            case 4:
              goto label_4;
            case 5:
              tBuilder.Start<SchedulerActor.\u003CRunStepOnce\u003Ed__19>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 4;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = SchedulerActor.iUOWV1BqiJAeKBnYsnqZ();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated field
        tBuilder = stateMachine.\u003C\u003Et__builder;
        num1 = 5;
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>
    /// Получить запланированную работу планировщика по уникальному идентификатору триггера
    /// </summary>
    /// <param name="triggerUid">Уникальный идентификатор триггера</param>
    /// <returns>
    /// <c>schedulerJobTrigger</c> - запланированная работа планировщика
    /// <c>taskFromDbRepository</c> - <c>true</c> если работа получения из репозитория в БД
    /// </returns>
    private (ISchedulerJob schedulerJob, bool taskFromDbRepository) GetSchedulerJobFromTriggerUid(
      Guid triggerUid)
    {
      bool flag = false;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ISchedulerJob schedulerJob = this.schedulerJobRepositories.Where<ISchedulerJobRepository>((Func<ISchedulerJobRepository, bool>) (repository => !(repository is ISchedulerJobDbRepository))).SelectMany<ISchedulerJobRepository, ISchedulerJob>((Func<ISchedulerJobRepository, IEnumerable<ISchedulerJob>>) (repository => (IEnumerable<ISchedulerJob>) repository.GetSchedulerJobs())).FirstOrDefault<ISchedulerJob>((Func<ISchedulerJob, bool>) (job => SchedulerActor.\u003C\u003Ec__DisplayClass20_0.yFAej3Q8Ub1pAXTfc1rR(SchedulerActor.\u003C\u003Ec__DisplayClass20_0.N1tMsCQ8LeCN07YIj1pb(SchedulerActor.\u003C\u003Ec__DisplayClass20_0.BRCEUdQ8YcR7S6f3robG((object) job)), triggerUid)));
      if (schedulerJob == null)
      {
        schedulerJob = this.schedulerJobRepositories.OfType<ISchedulerJobDbRepository>().Select<ISchedulerJobDbRepository, ISchedulerJob>((Func<ISchedulerJobDbRepository, ISchedulerJob>) (repository => this.GetSchedulerJob(repository, triggerUid))).FirstOrDefault<ISchedulerJob>((Func<ISchedulerJob, bool>) (job => job != null));
        if (schedulerJob == null)
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957752314), (object) triggerUid));
        flag = true;
      }
      return (schedulerJob, flag);
    }

    /// <summary>Получить задачу из репозитория</summary>
    /// <param name="repository">Репозиторий</param>
    /// <param name="taskUid">Идентификатор задачи</param>
    private ISchedulerJob GetSchedulerJob(ISchedulerJobDbRepository repository, Guid taskUid)
    {
      int num = 1;
      ISchedulerTask task;
      while (true)
      {
        switch (num)
        {
          case 1:
            task = this.schedulerTaskManager.LoadOrNull(taskUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            if (task == null)
            {
              num = 3;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return repository.CreateSchedulerJob(task);
label_3:
      return (ISchedulerJob) null;
    }

    /// <summary>Запустить шаг планировщика по времени</summary>
    /// <param name="currentDateTime">Дата/время для запуска</param>
    private Task RunStep(DateTime currentDateTime)
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      SchedulerActor.\u003CRunStep\u003Ed__22 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            tBuilder.Start<SchedulerActor.\u003CRunStep\u003Ed__22>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.currentDateTime = currentDateTime;
            num = 5;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 3 : 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 6 : 6;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 2;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Обработать очередь исполнения задач планировщика</summary>
    /// <param name="arg">Параметры</param>
    private Task ProcessSchedulerJobQueue(object arg)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      SchedulerActor.\u003CProcessSchedulerJobQueue\u003Ed__23 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 2;
              continue;
            case 4:
              goto label_7;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 1;
              continue;
            default:
              tBuilder.Start<SchedulerActor.\u003CProcessSchedulerJobQueue\u003Ed__23>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 3 : 4;
              continue;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003Et__builder = SchedulerActor.iUOWV1BqiJAeKBnYsnqZ();
        num1 = 5;
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Добавить в пул выполнения задачи</summary>
    private void PushSchedulerJobs(
      IEnumerable<SchedulerActor.SchedulerJobActorAction> schedulerJobActorActions)
    {
      foreach (SchedulerActor.SchedulerJobActorAction schedulerJobActorAction in schedulerJobActorActions.Where<SchedulerActor.SchedulerJobActorAction>((Func<SchedulerActor.SchedulerJobActorAction, bool>) (a => a != null)))
      {
        SchedulerActor.SchedulerJobActorAction stepSchedulerJobActorAction = schedulerJobActorAction;
        // ISSUE: reference to a compiler-generated method
        this.tasksPool.Push((Func<Task>) (() => (Task) SchedulerActor.\u003C\u003Ec__DisplayClass24_0.TkuRoQQZIA7MRZwOYhhI((object) stepSchedulerJobActorAction)));
      }
    }

    /// <summary>Запустить указанную работу планировщика</summary>
    /// <param name="schedulerJobTrigger">Триггер запланированной работы планировщика</param>
    /// <param name="currentDateTime">Текущая дата/время</param>
    /// <param name="jobFromDbRepository"><c>true</c> если запланированная задача получена из репозитория, расположенного в БД</param>
    /// <param name="forceRun"><c>true</c></param>
    /// <param name="dateTimeToRun">Дата/время для запуска</param>
    private SchedulerActor.SchedulerJobActorAction GetSchedulerJobActor(
      ITrigger schedulerJobTrigger,
      DateTime currentDateTime,
      bool jobFromDbRepository,
      bool forceRun,
      DateTime? dateTimeToRun)
    {
      return this.GetSchedulerJobActor(schedulerJobTrigger, currentDateTime, jobFromDbRepository, forceRun, dateTimeToRun, (CancellationTokenSource) null, (ICollection<IJob>) null);
    }

    /// <summary>Запустить указанную работу планировщика</summary>
    /// <param name="schedulerJobTrigger">Триггер запланированной работы планировщика</param>
    /// <param name="currentDateTime">Текущая дата/время</param>
    /// <param name="jobFromDbRepository"><c>true</c> если запланированная задача получена из репозитория, расположенного в БД</param>
    /// <param name="forceRun"><c>true</c></param>
    /// <param name="dateTimeToRun">Дата/время для запуска</param>
    /// <param name="cancellationTokenSource">Токен прерывания выполнения работ</param>
    /// <param name="jobs">Список работ</param>
    private SchedulerActor.SchedulerJobActorAction GetSchedulerJobActor(
      ITrigger schedulerJobTrigger,
      DateTime currentDateTime,
      bool jobFromDbRepository,
      bool forceRun,
      DateTime? dateTimeToRun,
      CancellationTokenSource cancellationTokenSource,
      ICollection<IJob> jobs)
    {
      if (this.forceRunTrigger.Contains(schedulerJobTrigger.Id))
      {
        forceRun = true;
        this.forceRunTrigger.Remove(schedulerJobTrigger.Id);
      }
      dateTimeToRun = dateTimeToRun ?? (forceRun ? new DateTime?(currentDateTime) : SchedulerHelper.GetDateTimeToRun(schedulerJobTrigger, currentDateTime, this.schedulerJobRunInfoManager, this.runtimeApplication));
      return !dateTimeToRun.HasValue ? (SchedulerActor.SchedulerJobActorAction) null : new SchedulerActor.SchedulerJobActorAction(this.actorModelRuntime.GetActor<ISchedulerJobActor>(schedulerJobTrigger.Id, jobFromDbRepository ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870828307) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841322242)), forceRun, cancellationTokenSource, schedulerJobTrigger, jobs, dateTimeToRun.Value, this.schedulerJobRunInfoManager);
    }

    internal static object zuU4D2BqZKKZ0pGlaX2C(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object lCbj04Bqu5UL9GMqxxbd() => (object) Task.CompletedTask;

    internal static bool qgLNCsBqvJ2vwY7Sr7TL() => SchedulerActor.HxelOaBqCls2K5Lv6CI0 == null;

    internal static SchedulerActor eedNYtBq852VSwQx6Fkw() => SchedulerActor.HxelOaBqCls2K5Lv6CI0;

    internal static void dWJ3OGBqIypR6bhsmbgJ([In] object obj0) => ((ElmaTasksPool) obj0).Dispose();

    internal static TimeSpan xOLqXcBqVOdsZFcQI0to([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static object B1g8p0BqSQF9jPLPt6np([In] object obj0) => (object) ((ISchedulerJob) obj0).Trigger;

    internal static AsyncTaskMethodBuilder iUOWV1BqiJAeKBnYsnqZ() => AsyncTaskMethodBuilder.Create();

    /// <summary>Обертка над актором с указанием действия</summary>
    private sealed class SchedulerJobActorAction
    {
      private readonly object schedulerJobActor;
      private readonly object cancellationTokenSource;
      private readonly object schedulerJobTrigger;
      private readonly ICollection<IJob> jobs;
      private readonly DateTime dateToRun;
      private readonly object schedulerJobRunInfoManager;
      private static object DEKty8Q8VOG6uc4trPbp;

      public SchedulerJobActorAction(
        ISchedulerJobActor schedulerJobActor,
        bool forceRun,
        CancellationTokenSource cancellationTokenSource,
        ITrigger schedulerJobTrigger,
        ICollection<IJob> jobs,
        DateTime dateToRun,
        ISchedulerJobRunInfoManager schedulerJobRunInfoManager)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.schedulerJobActor = (object) schedulerJobActor;
        this.ForceRun = forceRun;
        this.cancellationTokenSource = (object) cancellationTokenSource;
        this.schedulerJobTrigger = (object) schedulerJobTrigger;
        this.jobs = jobs;
        this.dateToRun = dateToRun;
        this.schedulerJobRunInfoManager = (object) schedulerJobRunInfoManager;
      }

      /// <summary>Принудительный запуск</summary>
      public bool ForceRun { get; }

      /// <summary>Зпустить работу на исполнение</summary>
      public Task Run()
      {
        int num1 = 1;
        // ISSUE: variable of a compiler-generated type
        SchedulerActor.SchedulerJobActorAction.\u003CRun\u003Ed__10 stateMachine;
        while (true)
        {
          int num2 = num1;
          AsyncTaskMethodBuilder tBuilder;
          while (true)
          {
            switch (num2)
            {
              case 1:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003E4__this = this;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                continue;
              case 2:
                tBuilder.Start<SchedulerActor.SchedulerJobActorAction.\u003CRun\u003Ed__10>(ref stateMachine);
                num2 = 4;
                continue;
              case 3:
                // ISSUE: reference to a compiler-generated field
                tBuilder = stateMachine.\u003C\u003Et__builder;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 2;
                continue;
              case 4:
                goto label_6;
              case 5:
                goto label_7;
              default:
                // ISSUE: reference to a compiler-generated field
                stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
                num2 = 5;
                continue;
            }
          }
label_7:
          // ISSUE: reference to a compiler-generated field
          stateMachine.\u003C\u003E1__state = -1;
          num1 = 3;
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      }

      internal static bool cqQ1p3Q8SnIJ8UuuLiBy() => SchedulerActor.SchedulerJobActorAction.DEKty8Q8VOG6uc4trPbp == null;

      internal static SchedulerActor.SchedulerJobActorAction swSIAvQ8iipbP5mkyw6y() => (SchedulerActor.SchedulerJobActorAction) SchedulerActor.SchedulerJobActorAction.DEKty8Q8VOG6uc4trPbp;
    }
  }
}
