// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Managers.SchedulerTaskManager
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
using EleWise.ELMA.Scheduling.Impl;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
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
  /// <summary>Менеджер задач планировщика</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class SchedulerTaskManager : 
    EntityManager<ISchedulerTask, long>,
    ISchedulerTaskManager,
    IEntityManager<ISchedulerTask, long>,
    IEntityManager<ISchedulerTask>,
    IEntityManager
  {
    private static readonly string F_Status;
    private static readonly string F_Jobs;
    private static readonly string F_Type;
    private static readonly string F_OnceExecuteTime;
    private static readonly string F_StatusUpdateDate;
    private static SchedulerTaskManager cAg3cEBkhZbqHrFft44x;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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
    public IEnumerable<ISchedulerTask> FindTasksToExecute() => (IEnumerable<ISchedulerTask>) this.CreateCriteria().Add((ICriterion) Restrictions.Eq(SchedulerTaskManager.F_Status, (object) SchedulerTaskStatus.Enabled)).Add((ICriterion) Restrictions.Or((ICriterion) Restrictions.Eq(SchedulerTaskManager.F_Type, (object) SchedulerTaskType.Periodic), (ICriterion) Restrictions.And((ICriterion) Restrictions.Eq(SchedulerTaskManager.F_Type, (object) SchedulerTaskType.Once), (ICriterion) Restrictions.Le(SchedulerTaskManager.F_OnceExecuteTime, (object) DateTime.Now)))).Fetch(SelectMode.Fetch, SchedulerTaskManager.F_Jobs).List<ISchedulerTask>();

    /// <inheritdoc />
    public IEnumerable<ISchedulerTask> FindPeriodicTasksToExecute() => (IEnumerable<ISchedulerTask>) this.CreateCriteria().Add((ICriterion) Restrictions.Eq(SchedulerTaskManager.F_Status, (object) SchedulerTaskStatus.Enabled)).Add((ICriterion) Restrictions.Eq(SchedulerTaskManager.F_Type, (object) SchedulerTaskType.Periodic)).Fetch(SelectMode.Fetch, SchedulerTaskManager.F_Jobs).List<ISchedulerTask>();

    /// <inheritdoc />
    public IEnumerable<ISchedulerTask> FindOnceExecuteTasksToExecute()
    {
      int processingOnceTasksCount = this.GetProcessingOnceTasksCount();
      if (processingOnceTasksCount <= 0)
        return (IEnumerable<ISchedulerTask>) new ISchedulerTask[0];
      DetachedCriteria dc = DetachedCriteria.For(InterfaceActivator.TypeOf<ISchedulerJobRunInfo>(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420816478)).SetProjection((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672064597))).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 154025079), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822832466), JoinType.InnerJoin).Add((ICriterion) Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98025750), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638475555))).Add((ICriterion) Restrictions.Gt(SchedulerTaskManager.F_StatusUpdateDate, (object) DateTime.Now.Subtract(SchedulerJobRunInfoManager.GetJobRunInfoTtl())));
      IEnumerable<Guid> activeConnectionUids = this.RuntimeApplication.GetActiveConnectionUids();
      if (activeConnectionUids.Any<Guid>())
        dc.Add((ICriterion) Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479574894), (ICollection) activeConnectionUids.ToArray<Guid>()));
      ICriteria criteria = this.Session.CreateCriteria(this.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112644204)).Add((ICriterion) Restrictions.Eq(SchedulerTaskManager.F_Status, (object) SchedulerTaskStatus.Enabled)).Add((ICriterion) Restrictions.Eq(SchedulerTaskManager.F_Type, (object) SchedulerTaskType.Once)).Add((ICriterion) Restrictions.Le(SchedulerTaskManager.F_OnceExecuteTime, (object) DateTime.Now)).Add((ICriterion) Subqueries.NotExists(dc)).Fetch(SelectMode.Fetch, SchedulerTaskManager.F_Jobs);
      this.SetupFetchOptions(criteria, new FetchOptions(0, processingOnceTasksCount), this.ImplementationType);
      return (IEnumerable<ISchedulerTask>) criteria.List<ISchedulerTask>();
    }

    /// <inheritdoc />
    public void ExecuteTask(ISchedulerTask task)
    {
      int num = 3;
      ISchedulerJob schedulerJob;
      DateTime now;
      while (true)
      {
        switch (num)
        {
          case 1:
            Locator.GetServiceNotNull<StepScheduler>().RunSchedulerJob(schedulerJob, now);
            num = 5;
            continue;
          case 2:
            SchedulerJobRepository serviceNotNull = Locator.GetServiceNotNull<SchedulerJobRepository>();
            now = SchedulerTaskManager.BakRlfBkCOR0ew5TWLPL();
            ISchedulerTask task1 = task;
            DateTime? customExecuteTime = new DateTime?(now);
            schedulerJob = serviceNotNull.CreateSchedulerJob(task1, customExecuteTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 2 : 4;
            continue;
          case 3:
            SchedulerTaskManager.lL5stWBkQDs5rGmXAvu0((object) task, SchedulerTaskManager.qCnQkABkfaGcMg5Apaub(1199946765 ^ 1199876091));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 2;
            continue;
          case 4:
            if (schedulerJob != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          case 5:
            goto label_4;
          default:
            goto label_2;
        }
      }
label_4:
      return;
label_2:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) SchedulerTaskManager.qCnQkABkfaGcMg5Apaub(-281842504 ^ -281918542)));
    }

    /// <inheritdoc />
    [Transaction]
    public virtual void DeleteTaskAndJobs(ISchedulerTask task, IEnumerable<long> excludeJobs)
    {
      Contract.ArgumentNotNull((object) task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099688287));
      ISession session = this.SessionProvider.GetSession("");
      session.Flush();
      this.SchedulerTaskJobManager.DeleteJobs(task.Jobs.Select<ISchedulerTaskJob, long>((Func<ISchedulerTaskJob, long>) (j => j.Id)).Except<long>((IEnumerable<long>) ((object) excludeJobs ?? (object) new long[0])).ToArray<long>());
      session.CreateSQLQuery(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786812118), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345480600)), (object) this.TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909144639)))).SetParameter<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87393347), task.Id).ExecuteUpdate(false);
      session.CleanUpCache(typeof (ISchedulerTask));
    }

    private int GetProcessingOnceTasksCount()
    {
      int num = 2;
      int setting;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (setting <= 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            setting = EleWise.ELMA.SR.GetSetting<int>((string) SchedulerTaskManager.qCnQkABkfaGcMg5Apaub(-1445902765 ^ -1980277732 ^ 539440533), 10);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return 10;
label_6:
      return setting;
    }

    public SchedulerTaskManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static SchedulerTaskManager()
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        ParameterExpression parameterExpression;
        while (true)
        {
          switch (num2)
          {
            case 1:
              parameterExpression = (ParameterExpression) SchedulerTaskManager.Sg5bkdBk85N8NOLsqgvX(typeof (ISchedulerTask), SchedulerTaskManager.qCnQkABkfaGcMg5Apaub(-1858887263 ^ -1858907087));
              num2 = 11;
              continue;
            case 2:
              goto label_3;
            case 3:
              // ISSUE: method reference
              // ISSUE: type reference
              SchedulerTaskManager.F_Type = LinqUtils.NameOf<ISchedulerTask>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerTask, object>>((System.Linq.Expressions.Expression) SchedulerTaskManager.wD9TUkBkILpqsA3a83DX((object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression, (MethodInfo) SchedulerTaskManager.CR7KevBkVy3XA3q2Px6e(__methodref (ISchedulerTask.get_Type))), SchedulerTaskManager.PlKJkkBkuvvgkXFvwEo2(__typeref (object))), parameterExpression));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_5;
            case 5:
              // ISSUE: type reference
              parameterExpression = (ParameterExpression) SchedulerTaskManager.Sg5bkdBk85N8NOLsqgvX(SchedulerTaskManager.PlKJkkBkuvvgkXFvwEo2(__typeref (ISchedulerTask)), SchedulerTaskManager.qCnQkABkfaGcMg5Apaub(-87337865 ^ -87318041));
              num2 = 3;
              continue;
            case 6:
              // ISSUE: method reference
              // ISSUE: type reference
              SchedulerTaskManager.F_StatusUpdateDate = LinqUtils.NameOf<ISchedulerJobRunInfo>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerJobRunInfo, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression, (MethodInfo) SchedulerTaskManager.CR7KevBkVy3XA3q2Px6e(__methodref (ISchedulerJobRunInfo.get_StatusUpdateDate))), SchedulerTaskManager.PlKJkkBkuvvgkXFvwEo2(__typeref (object))), parameterExpression));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 2 : 2;
              continue;
            case 7:
              // ISSUE: method reference
              SchedulerTaskManager.F_OnceExecuteTime = LinqUtils.NameOf<ISchedulerTask>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerTask, object>>((System.Linq.Expressions.Expression) SchedulerTaskManager.wD9TUkBkILpqsA3a83DX(SchedulerTaskManager.ERmyIKBkZObuC3XGcP5U((object) parameterExpression, (object) (MethodInfo) SchedulerTaskManager.CR7KevBkVy3XA3q2Px6e(__methodref (ISchedulerTask.get_OnceExecuteTime))), typeof (object)), parameterExpression));
              num2 = 4;
              continue;
            case 8:
              // ISSUE: method reference
              // ISSUE: type reference
              SchedulerTaskManager.F_Status = LinqUtils.NameOf<ISchedulerTask>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerTask, object>>((System.Linq.Expressions.Expression) SchedulerTaskManager.wD9TUkBkILpqsA3a83DX(SchedulerTaskManager.ERmyIKBkZObuC3XGcP5U((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (ISchedulerTask.get_Status))), SchedulerTaskManager.PlKJkkBkuvvgkXFvwEo2(__typeref (object))), parameterExpression));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
              continue;
            case 9:
              parameterExpression = (ParameterExpression) SchedulerTaskManager.Sg5bkdBk85N8NOLsqgvX(typeof (ISchedulerTask), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137956241));
              num2 = 8;
              continue;
            case 10:
              SchedulerTaskManager.ypp23MBkvTwPVWZE50Ya();
              num2 = 9;
              continue;
            case 11:
              // ISSUE: method reference
              SchedulerTaskManager.F_Jobs = LinqUtils.NameOf<ISchedulerTask>(System.Linq.Expressions.Expression.Lambda<Func<ISchedulerTask, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression, (MethodInfo) SchedulerTaskManager.CR7KevBkVy3XA3q2Px6e(__methodref (ISchedulerTask.get_Jobs))), parameterExpression));
              num2 = 5;
              continue;
            default:
              parameterExpression = (ParameterExpression) SchedulerTaskManager.Sg5bkdBk85N8NOLsqgvX(typeof (ISchedulerTask), SchedulerTaskManager.qCnQkABkfaGcMg5Apaub(-1350312861 << 3 ^ 2082346632));
              num2 = 7;
              continue;
          }
        }
label_5:
        // ISSUE: type reference
        parameterExpression = (ParameterExpression) SchedulerTaskManager.Sg5bkdBk85N8NOLsqgvX(SchedulerTaskManager.PlKJkkBkuvvgkXFvwEo2(__typeref (ISchedulerJobRunInfo)), SchedulerTaskManager.qCnQkABkfaGcMg5Apaub(--1418440330 ^ 1418418970));
        num1 = 6;
      }
label_3:;
    }

    internal static bool UAmujhBkG7CPNhNRPQ7i() => SchedulerTaskManager.cAg3cEBkhZbqHrFft44x == null;

    internal static SchedulerTaskManager DZZtaIBkEBgBqT8Hb6Nx() => SchedulerTaskManager.cAg3cEBkhZbqHrFft44x;

    internal static object qCnQkABkfaGcMg5Apaub(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void lL5stWBkQDs5rGmXAvu0([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static DateTime BakRlfBkCOR0ew5TWLPL() => DateTime.Now;

    internal static void ypp23MBkvTwPVWZE50Ya() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Sg5bkdBk85N8NOLsqgvX([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static object ERmyIKBkZObuC3XGcP5U([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static Type PlKJkkBkuvvgkXFvwEo2([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object wD9TUkBkILpqsA3a83DX([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);

    internal static object CR7KevBkVy3XA3q2Px6e([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);
  }
}
