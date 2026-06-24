// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Impl.StepScheduler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Scheduling.Impl
{
  /// <summary>Планировщик, работающий в цикле.</summary>
  [Service(Type = ComponentType.WebServer, EnableInterceptors = false)]
  public class StepScheduler : IStepScheduler
  {
    internal static StepScheduler JuGM38BkNEHtaPxdnZnE;

    /// <summary>Сервис аутентификации, работа с текущим пользователем</summary>
    [NotNull]
    public IAuthenticationService AuthenticationService
    {
      get => this.\u003CAuthenticationService\u003Ek__BackingField;
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
              this.\u003CAuthenticationService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
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

    /// <summary>Репозитории работ планировщика</summary>
    public IEnumerable<ISchedulerJobRepository> SchedulerJobRepository { get; set; }

    /// <summary>
    /// <see cref="T:EleWise.ELMA.Scheduling.Impl.SchedulerJobRepository" />
    /// </summary>
    public EleWise.ELMA.Scheduling.Impl.SchedulerJobRepository OnceSchedulerJobRepository
    {
      get => this.\u003COnceSchedulerJobRepository\u003Ek__BackingField;
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
              this.\u003COnceSchedulerJobRepository\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
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
    /// <see cref="T:EleWise.ELMA.Scheduling.Managers.SchedulerJobRunInfoManager" />
    /// </summary>
    public SchedulerJobRunInfoManager SchedulerJobRunInfoReposotory
    {
      get => this.\u003CSchedulerJobRunInfoReposotory\u003Ek__BackingField;
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
              this.\u003CSchedulerJobRunInfoReposotory\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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
    /// <see cref="T:EleWise.ELMA.Logging.ILogger" />
    /// </summary>
    public ILogger Logger
    {
      get => this.\u003CLogger\u003Ek__BackingField;
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
              this.\u003CLogger\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 0 : 0;
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
    /// <see cref="T:EleWise.ELMA.Runtime.NH.ISessionProvider" />
    /// </summary>
    public ISessionProvider SessionProvider
    {
      get => this.\u003CSessionProvider\u003Ek__BackingField;
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
              this.\u003CSessionProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
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
    /// <see cref="T:EleWise.ELMA.Security.IMembershipService" />
    /// </summary>
    public IMembershipService MembershipService
    {
      get => this.\u003CMembershipService\u003Ek__BackingField;
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
              this.\u003CMembershipService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
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
    /// <see cref="T:EleWise.ELMA.Runtime.Db.Migrator.Framework.ITransformationProvider" />
    /// </summary>
    public SessionFactoryHolder SessionFactoryHolder
    {
      get => this.\u003CSessionFactoryHolder\u003Ek__BackingField;
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
              this.\u003CSessionFactoryHolder\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
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

    /// <summary>Интерфейс провайдера преобразования БД</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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
    /// <see cref="T:EleWise.ELMA.Runtime.NH.IUnitOfWorkManager" />
    /// </summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
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

    /// <summary>Запустить триггер по идентификатору</summary>
    /// <param name="triggerId">Уникальный идентификатор триггера</param>
    public void RunTrigger(Guid triggerId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.ActorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty).RunTrigger(triggerId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Выполнить задачу планировщика (если наступило время, удовлетворяющее триггеру)
    /// </summary>
    /// <param name="schedulerJob">Задача</param>
    /// <param name="now">Текущее время</param>
    public void RunSchedulerJob(ISchedulerJob schedulerJob, DateTime now)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            StepScheduler.VaEY5ABkDSP6VtUXg2Uf((object) schedulerJob, StepScheduler.PB6Bt3BkadgpCXAbdSNF(-649342099 - -1150814748 ^ 501411281));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.ActorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty).RunSchedulerJob(StepScheduler.NT3NDdBkwbSR9e5VhZ3e(StepScheduler.wIkjqoBktesZbTwb6oD2((object) schedulerJob)), now, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 2;
            continue;
          default:
            StepScheduler.VaEY5ABkDSP6VtUXg2Uf(StepScheduler.wIkjqoBktesZbTwb6oD2((object) schedulerJob), StepScheduler.PB6Bt3BkadgpCXAbdSNF(-867826612 ^ -867748808));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>
    /// Выполнить задачу планировщика принудительно (не проверяя время по триггеру)
    /// </summary>
    /// <param name="schedulerJob">Задача</param>
    /// <param name="now">Текущее время</param>
    public void ForceRunSchedulerJob(ISchedulerJob schedulerJob, DateTime now)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            StepScheduler.cx12xWBk4UOkC7mLx8qx((object) this.ActorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty), StepScheduler.NT3NDdBkwbSR9e5VhZ3e((object) schedulerJob.Trigger), now, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 2:
            StepScheduler.VaEY5ABkDSP6VtUXg2Uf(StepScheduler.wIkjqoBktesZbTwb6oD2((object) schedulerJob), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542668311));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
          case 3:
            StepScheduler.VaEY5ABkDSP6VtUXg2Uf((object) schedulerJob, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70060203));
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Выполнить работу задачи планировщика принудтельно</summary>
    /// <param name="schedulerJob">Задача планировщика</param>
    /// <param name="job">Работа</param>
    /// <param name="now">Текущее время</param>
    /// <returns></returns>
    public ISchedulerJobRunInfo ForceRunJob(ISchedulerJob schedulerJob, IJob job, DateTime now)
    {
      int num = 2;
      ISchedulerActor actor;
      while (true)
      {
        switch (num)
        {
          case 1:
            StepScheduler.VaEY5ABkDSP6VtUXg2Uf((object) schedulerJob.Trigger, StepScheduler.PB6Bt3BkadgpCXAbdSNF(-281842504 ^ -281912116));
            num = 4;
            continue;
          case 2:
            Contract.ArgumentNotNull((object) schedulerJob, (string) StepScheduler.PB6Bt3BkadgpCXAbdSNF(1925118608 << 2 ^ -889529832));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
            continue;
          case 3:
            actor = Locator.GetServiceNotNull<IActorModelRuntime>().GetActor<ISchedulerActor>(Guid.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
            continue;
          case 4:
            Contract.ArgumentNotNull((object) job, (string) StepScheduler.PB6Bt3BkadgpCXAbdSNF(589593376 ^ -1977315327 ^ -1459501475));
            num = 3;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      SchedulerJobRunInfoManager runInfoReposotory = this.SchedulerJobRunInfoReposotory;
      object obj = StepScheduler.wIkjqoBktesZbTwb6oD2((object) schedulerJob);
      IJob job1 = job;
      DateTime dateToRun = now;
      JobResult result = new JobResult();
      StepScheduler.pkEht7Bk6fuNeVcJUr9O((object) result, JobStatus.Pending);
      ISchedulerJobRunInfo schedulerJobRunInfo = runInfoReposotory.SetResult((ITrigger) obj, job1, dateToRun, result);
      actor.ForceRunJob(((ITrigger) StepScheduler.wIkjqoBktesZbTwb6oD2((object) schedulerJob)).Id, StepScheduler.UvlmUuBkHEUIThd4KDJx((object) job), new DateTime?(now));
      return schedulerJobRunInfo;
    }

    public StepScheduler()
    {
      StepScheduler.P3nrJIBkAShpTSN3ETr2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool JTT744Bk3eyNFuQT8K7B() => StepScheduler.JuGM38BkNEHtaPxdnZnE == null;

    internal static StepScheduler O1K4vUBkpp1JtwjhXtfR() => StepScheduler.JuGM38BkNEHtaPxdnZnE;

    internal static object PB6Bt3BkadgpCXAbdSNF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void VaEY5ABkDSP6VtUXg2Uf([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object wIkjqoBktesZbTwb6oD2([In] object obj0) => (object) ((ISchedulerJob) obj0).Trigger;

    internal static Guid NT3NDdBkwbSR9e5VhZ3e([In] object obj0) => ((ITrigger) obj0).Id;

    internal static object cx12xWBk4UOkC7mLx8qx(
      [In] object obj0,
      Guid triggerUid,
      DateTime currentDateTime,
      bool forceRun)
    {
      return (object) ((ISchedulerActor) obj0).RunSchedulerJob(triggerUid, currentDateTime, forceRun);
    }

    internal static void pkEht7Bk6fuNeVcJUr9O([In] object obj0, JobStatus value) => ((JobResult) obj0).Status = value;

    internal static Guid UvlmUuBkHEUIThd4KDJx([In] object obj0) => ((IJob) obj0).Id;

    internal static void P3nrJIBkAShpTSN3ETr2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
