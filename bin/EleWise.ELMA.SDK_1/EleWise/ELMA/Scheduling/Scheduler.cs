// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Scheduler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Scheduling;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Ядро планировщика заданий</summary>
  /// <example>
  /// <code>
  /// //С помощью данного сервиса мы можем запускать уже существующие триггеры
  /// //Идентификаторы работы и триггера можно узнать в веб части (Администрирование -&gt; Система -&gt; Планировщик)
  /// <![CDATA[
  /// //запуск триггера с передачей гуидов
  /// Locator.GetServiceNotNull<Scheduler>().Run(new Guid("*тут гуид работы*"), new Guid("*тут гуид тригера*"));
  /// 
  /// //запуск триггера с передачей строк
  /// Locator.GetServiceNotNull<Scheduler>().Run("*тут гуид работы*", "*тут гуид тригера*");
  /// ]]>
  /// </code>
  /// </example>
  [PublicApiMember("SchedulerServicesApi", "SR.M('Сервис управления планировщиком')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем запускать уже существующие триггеры\r\n    /// //Идентификаторы работы и триггера можно узнать в веб части (Администрирование -> Система -> Планировщик)\r\n    /// \r\n    /// //запуск триггера с передачей гуидов\r\n    /// PublicAPI.Services.Scheduler.Run(new Guid(\"*тут гуид работы*\"), new Guid(\"*тут гуид тригера*\"));\r\n    /// \r\n    /// //запуск триггера с передачей строк\r\n    /// PublicAPI.Services.Scheduler.Run(\"*тут гуид работы*\", \"*тут гуид тригера*\"); \r\n    /// </code>')")]
  [Service(Type = ComponentType.Server)]
  [DeveloperApi(DeveloperApiType.Service)]
  public class Scheduler
  {
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IFeatureFlagService featureFlagService;
    private System.Timers.Timer _timer;
    private ThreadSubPool _threadPool;
    private Scheduler.SweepHandlerComposition _handlerComposition;
    private readonly ConcurrentDictionary<ISweepHandler, object> _executingHandlers;
    private CultureInfo currentCulture;
    private CultureInfo currentUICulture;
    internal static Scheduler lkpYKbBKzNX9WGmrQctg;

    /// <summary>Ctor</summary>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public Scheduler(IActorModelRuntime actorModelRuntime, IFeatureFlagService featureFlagService)
    {
      Scheduler.oMEtqYBXWiPfLoVKtYtu();
      this._executingHandlers = new ConcurrentDictionary<ISweepHandler, object>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.featureFlagService = featureFlagService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 2:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public IEnumerable<ISchedulerJobRepository> SchedulerJobRepositories { get; set; }

    /// <summary>Запуск триггера</summary>
    /// <param name="id">Идентификатор работы</param>
    /// <param name="triggerId">Идентификатор триггера</param>
    [PublicApiNodeId("SchedulerServicesApi")]
    public void Run(Guid id, Guid triggerId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.actorModelRuntime.GetActor<ISchedulerActor>(Guid.Empty).ForceRunJob(triggerId, id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Запуск триггера</summary>
    /// <param name="id">Идентификатор работы</param>
    /// <param name="triggerId">Идентификатор триггера</param>
    [PublicApiNodeId("SchedulerServicesApi")]
    public void Run(string id, string triggerId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Run(new Guid(id), new Guid(triggerId));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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
    /// Обертка для исполнителей элементарных задач планировщика в виде одного исполнителя
    /// </summary>
    public ISweepHandler SweepHandler
    {
      get
      {
        int num = 2;
        Scheduler.SweepHandlerComposition sweepHandler;
        Scheduler.SweepHandlerComposition handlerComposition;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._handlerComposition = sweepHandler = new Scheduler.SweepHandlerComposition(this);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
              continue;
            case 2:
              handlerComposition = this._handlerComposition;
              if (handlerComposition == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return (ISweepHandler) handlerComposition;
label_6:
        return (ISweepHandler) sweepHandler;
      }
    }

    /// <summary>Исполнители элементарных задач планировщика</summary>
    public IEnumerable<ISweepHandler> SweepHandlers => Locator.GetServiceNotNull<IEnumerable<ISweepHandler>>();

    /// <summary>Запустить планировщик</summary>
    public void Start()
    {
      int num1 = 1;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this._threadPool = new ThreadSubPool(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138085742), 5);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            this._timer.Elapsed += new ElapsedEventHandler(this.TimerElapsed);
            num1 = 7;
            continue;
          case 3:
            this.currentCulture = (CultureInfo) Scheduler.s32xdUBXhCdWWE3NSZV4(Scheduler.Y5ZiMSBXbftr6mxZXWHN());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 9 : 3;
            continue;
          case 4:
            this._timer = new System.Timers.Timer((double) (num2 * 1000));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 2 : 0;
            continue;
          case 5:
            num2 = 10;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 2 : 3;
            continue;
          case 6:
            goto label_2;
          case 7:
            this._timer.Start();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 6 : 1;
            continue;
          case 8:
            if (num2 <= 0)
            {
              num1 = 5;
              continue;
            }
            goto case 3;
          case 9:
            this.currentUICulture = (CultureInfo) Scheduler.xZSiXUBXGJqhVxWwP7l1(Scheduler.Y5ZiMSBXbftr6mxZXWHN());
            num1 = 4;
            continue;
          default:
            num2 = EleWise.ELMA.SR.GetSetting<int>((string) Scheduler.bK0k3uBXoLEu2P6NeihY(-420743386 ^ -420812072), 10);
            num1 = 8;
            continue;
        }
      }
label_2:;
    }

    protected virtual void ExecuteHandlers()
    {
      int num1 = 2;
      IEnumerator<ISweepHandler> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_26;
          case 1:
            goto label_3;
          case 2:
            enumerator = this.SweepHandlers.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
            continue;
          default:
            goto label_25;
        }
      }
label_26:
      return;
label_25:
      return;
label_3:
      try
      {
label_12:
        if (Scheduler.SiAyiuBXfDrpRdnHK2iM((object) enumerator))
          goto label_5;
        else
          goto label_13;
label_4:
        ISweepHandler current;
        int num2;
        while (true)
        {
          IThreadPoolContainer threadPoolContainer;
          IThreadPool threadPool1;
          IThreadPool threadPool2;
          object obj;
          switch (num2)
          {
            case 1:
            case 2:
              goto label_12;
            case 3:
              new Scheduler.HandlerExecutor(this, current, threadPool2).Execute();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
              continue;
            case 4:
              threadPool1 = (IThreadPool) this._threadPool;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            case 5:
              if (Scheduler.Fgb5kEBXEoq03KgEQVRf((object) threadPoolContainer) == null)
              {
                num2 = 4;
                continue;
              }
              obj = Scheduler.Fgb5kEBXEoq03KgEQVRf((object) threadPoolContainer);
              break;
            case 6:
              threadPoolContainer = current as IThreadPoolContainer;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 9 : 10;
              continue;
            case 7:
              goto label_21;
            case 8:
              goto label_5;
            case 9:
              if (!this._executingHandlers.TryAdd(current, (object) null))
              {
                num2 = 2;
                continue;
              }
              goto case 6;
            case 10:
              if (threadPoolContainer != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 5 : 1;
                continue;
              }
              goto case 4;
            default:
              obj = (object) threadPool1;
              break;
          }
          threadPool2 = (IThreadPool) obj;
          num2 = 3;
        }
label_21:
        return;
label_5:
        current = enumerator.Current;
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        {
          num2 = 9;
          goto label_4;
        }
        else
          goto label_4;
label_13:
        num2 = 7;
        goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
        else
          goto label_27;
label_24:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_27:
        enumerator.Dispose();
        num3 = 2;
        goto label_24;
      }
    }

    private void TimerElapsed(object sender, ElapsedEventArgs e)
    {
      int num1 = 2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_20;
            case 2:
              if (!this.featureFlagService.Enabled((string) Scheduler.bK0k3uBXoLEu2P6NeihY(-882126494 ^ -882183056), true))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
                continue;
              }
              Scheduler.fYCNkxBXQNmRt8KYeqNi(Scheduler.Y5ZiMSBXbftr6mxZXWHN(), (object) this.currentCulture);
              num2 = 3;
              continue;
            case 3:
              Scheduler.utW911BXCwQwSdKEEWWi((object) Thread.CurrentThread, (object) this.currentUICulture);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_13;
            case 6:
              goto label_5;
            default:
              if (Monitor.TryEnter((object) this))
              {
                num2 = 6;
                continue;
              }
              goto label_17;
          }
        }
label_17:
        num1 = 4;
      }
label_20:
      return;
label_3:
      return;
label_13:
      return;
label_5:
      try
      {
        this._timer.Stop();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_9;
            default:
              Scheduler.hhAH2FBXvZAm7ZHLRd81((object) this);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              continue;
          }
        }
label_9:;
      }
      finally
      {
        Scheduler.jyG9AQBX8xcKXsQi6iPK((object) this);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
          num4 = 1;
        while (true)
        {
          switch (num4)
          {
            case 1:
              Scheduler.LmvNhrBXZa55upJ4iD1m((object) this._timer);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            default:
              goto label_15;
          }
        }
label_15:;
      }
    }

    internal static void oMEtqYBXWiPfLoVKtYtu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool b5D60jBXFSfqL4MeGm21() => Scheduler.lkpYKbBKzNX9WGmrQctg == null;

    internal static Scheduler hWwtBSBXB7hWCmvlccmB() => Scheduler.lkpYKbBKzNX9WGmrQctg;

    internal static object bK0k3uBXoLEu2P6NeihY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Y5ZiMSBXbftr6mxZXWHN() => (object) Thread.CurrentThread;

    internal static object s32xdUBXhCdWWE3NSZV4([In] object obj0) => (object) ((Thread) obj0).CurrentCulture;

    internal static object xZSiXUBXGJqhVxWwP7l1([In] object obj0) => (object) ((Thread) obj0).CurrentUICulture;

    internal static object Fgb5kEBXEoq03KgEQVRf([In] object obj0) => (object) ((IThreadPoolContainer) obj0).Pool;

    internal static bool SiAyiuBXfDrpRdnHK2iM([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void fYCNkxBXQNmRt8KYeqNi([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentCulture = (CultureInfo) obj1;

    internal static void utW911BXCwQwSdKEEWWi([In] object obj0, [In] object obj1) => ((Thread) obj0).CurrentUICulture = (CultureInfo) obj1;

    internal static void hhAH2FBXvZAm7ZHLRd81([In] object obj0) => ((Scheduler) obj0).ExecuteHandlers();

    internal static void jyG9AQBX8xcKXsQi6iPK([In] object obj0) => Monitor.Exit(obj0);

    internal static void LmvNhrBXZa55upJ4iD1m([In] object obj0) => ((System.Timers.Timer) obj0).Start();

    private class HandlerExecutor
    {
      private readonly object _owner;
      private readonly object _handler;
      private readonly object _threadPool;
      private static object EnTnTZQZLM72R1AyeNxb;

      public HandlerExecutor(Scheduler owner, ISweepHandler handler, IThreadPool threadPool)
      {
        Scheduler.HandlerExecutor.HDgBsuQZcf1fwrPeqTbk();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              this._threadPool = (object) threadPool;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 2;
              continue;
            case 2:
              goto label_2;
            case 3:
              this._owner = (object) owner;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
              continue;
            default:
              this._handler = (object) handler;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
          }
        }
label_2:;
      }

      public void Execute()
      {
        int num1 = 3;
        Scheduler.HandlerExecutor handlerExecutor;
        Type type;
        while (true)
        {
          switch (num1)
          {
            case 1:
              type = this._handler.GetType().GetTypeWithoutProxy();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
              continue;
            case 2:
              handlerExecutor = this;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 1 : 0;
              continue;
            case 3:
              num1 = 2;
              continue;
            case 4:
              goto label_2;
            default:
              System.Action action;
              Scheduler.HandlerExecutor.j234yVQZzFD47k2BMjJC(this._threadPool, (object) (ThreadStart) (() =>
              {
                switch (1)
                {
                  case 1:
                    try
                    {
                      System.Action action1 = action;
                      int num3;
                      if (action1 == null)
                      {
                        num3 = 0;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                          num3 = 1;
                      }
                      else
                        goto label_15;
label_4:
                      System.Action action2;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            action = action2 = (System.Action) (() =>
                            {
                              int num4 = 1;
                              while (true)
                              {
                                switch (num4)
                                {
                                  case 0:
                                    goto label_2;
                                  case 1:
                                    // ISSUE: reference to a compiler-generated method
                                    Scheduler.HandlerExecutor.\u003C\u003Ec__DisplayClass4_0.qjfyhDZCscfGftbNsMZL(handlerExecutor._handler);
                                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                                    continue;
                                  default:
                                    goto label_4;
                                }
                              }
label_2:
                              return;
label_4:;
                            });
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
                            continue;
                          case 2:
                            goto label_5;
                          default:
                            goto label_7;
                        }
                      }
label_5:
                      break;
label_7:
                      System.Action action3 = action2;
label_8:
                      Type ownerType = type;
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      string name = (string) Scheduler.HandlerExecutor.\u003C\u003Ec__DisplayClass4_0.rnbdgTZCLcNKLAdLohdf(1581325282 << 3 ^ -233899190) + (string) Scheduler.HandlerExecutor.\u003C\u003Ec__DisplayClass4_0.FoSawHZCUCMKd7ZFQ9DI((object) type);
                      // ISSUE: reference to a compiler-generated method
                      string description = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951112304), Scheduler.HandlerExecutor.\u003C\u003Ec__DisplayClass4_0.FoSawHZCUCMKd7ZFQ9DI((object) type));
                      new BackgroundTask(action3, ownerType, name, description).Execute();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 2;
                      goto label_4;
label_15:
                      action3 = action1;
                      goto label_8;
                    }
                    finally
                    {
                      ((Scheduler) handlerExecutor._owner)._executingHandlers.TryRemove((ISweepHandler) handlerExecutor._handler, out object _);
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                      }
                    }
                }
              }), (object) type.FullName);
              num1 = 4;
              continue;
          }
        }
label_2:;
      }

      internal static void HDgBsuQZcf1fwrPeqTbk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool yVea88QZUlHTIugSlx9y() => Scheduler.HandlerExecutor.EnTnTZQZLM72R1AyeNxb == null;

      internal static Scheduler.HandlerExecutor YglCN9QZskn157BgdUqr() => (Scheduler.HandlerExecutor) Scheduler.HandlerExecutor.EnTnTZQZLM72R1AyeNxb;

      internal static void j234yVQZzFD47k2BMjJC([In] object obj0, [In] object obj1, [In] object obj2) => ((IThreadPool) obj0).Queue((ThreadStart) obj1, (string) obj2);
    }

    private class SweepHandlerComposition : ISweepHandler
    {
      private readonly object _scheduler;
      internal static object NbQ8lcQuFvHOO03jh85N;

      public SweepHandlerComposition(Scheduler scheduler)
      {
        Scheduler.SweepHandlerComposition.oESiH7QuoU7wPtlVlWvX();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this._scheduler = (object) scheduler;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      public void Execute()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              Scheduler.SweepHandlerComposition.UTiyF1Qub4Iv1Rv68DVy(this._scheduler);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static void oESiH7QuoU7wPtlVlWvX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool SITvvjQuB9sX4JbBVQY4() => Scheduler.SweepHandlerComposition.NbQ8lcQuFvHOO03jh85N == null;

      internal static Scheduler.SweepHandlerComposition oHbnrIQuWQRsHxJ2w4Zs() => (Scheduler.SweepHandlerComposition) Scheduler.SweepHandlerComposition.NbQ8lcQuFvHOO03jh85N;

      internal static void UTiyF1Qub4Iv1Rv68DVy([In] object obj0) => ((Scheduler) obj0).ExecuteHandlers();
    }
  }
}
