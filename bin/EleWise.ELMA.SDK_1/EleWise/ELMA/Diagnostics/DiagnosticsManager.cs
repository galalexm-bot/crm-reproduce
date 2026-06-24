// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.DiagnosticsManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Counters;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Diagnostics.Glimpse;
using EleWise.ELMA.Diagnostics.Logs;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Менеджер диагностики</summary>
  [Service(Type = ComponentType.Server, EnableInterceptors = false, InjectProperties = true)]
  [DeveloperApi(DeveloperApiType.Service)]
  public sealed class DiagnosticsManager : IInitHandler, IDisposable
  {
    private static readonly ConcurrentDictionary<Type, Type> callStartEventTypes;
    private static readonly ConcurrentDictionary<Type, Type> callEndEventTypes;
    private static readonly ConcurrentDictionary<Type, Type> callErrorEventTypes;
    private readonly GlimpseHelper glimpseHelper;
    private static DiagnosticsManager _instance;
    private readonly ConcurrentBag<CallContextInfo> activeContext;
    private static AsyncLocal<CallContextInfo> currentContext;
    private static bool _enabled;
    private bool _countersInitializeInvoked;
    private bool _countersInitialized;
    private bool _countersEnabled;
    private string _folder;
    private DiagnosticsSettings _settings;
    private Dictionary<Type, IPerformanceCounter> _counters;
    private ILogger _logger;
    private DiagnosticsLogManager _logManager;
    private MetricsContainer _metrics;
    private IEnumerable<IMetricAggregator> metricAggregators;
    private IEnumerable<IDiagnosticsEventProcessor> _eventProcessors;
    private static readonly Type AbstractCallStartEventType;
    private static readonly Type AbstractCallEndEventType;
    private static readonly Type AbstractCallErrorEventType;
    internal static DiagnosticsManager zlvdFFEoDsblYpiVC5rQ;

    /// <summary>Текущий экземпляр менеджера диагностики</summary>
    public static DiagnosticsManager Instance
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (DiagnosticsManager._instance == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        throw new InvalidOperationException((string) DiagnosticsManager.GFrT5REo6ZlxcEniDpry(DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-2099751081 ^ -2099480039)));
label_3:
        return DiagnosticsManager._instance;
      }
    }

    /// <summary>Инициализирован ли экземпляр менеджера</summary>
    public static bool Initialized => DiagnosticsManager._instance != null;

    /// <summary>Включена ли диагностика</summary>
    public static bool Enabled
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (DiagnosticsManager._instance != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        return DiagnosticsManager._enabled;
label_3:
        return false;
      }
    }

    public static object Point(string message)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (message == null)
            {
              num = 3;
              continue;
            }
            goto case 4;
          case 2:
            if (DiagnosticsManager.Enabled)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 4:
            DiagnosticsManager.WEkjNdEoA5oqY5TNT0x3(DiagnosticsManager.cfEwLOEoHIORnHXTg734(), (object) message);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_6:
      return (object) null;
    }

    /// <summary>Начать вызов</summary>
    /// <typeparam name="TCallInfo">Тип вызова</typeparam>
    /// <param name="callInfoCreator">Делегат создания информации о вызове</param>
    /// <returns></returns>
    [DebuggerHidden]
    [CanBeNull]
    public static TCallInfo StartCall<TCallInfo>(Func<TCallInfo> callInfoCreator) where TCallInfo : AbstractCallInfo, IEmptyCallInfo, new()
    {
      CallContextInfo diagnosticSession = DiagnosticsManager.Enabled ? DiagnosticsManager.Instance.GetCurrentDiagnosticSession() : (CallContextInfo) null;
      TCallInfo callInfo = default (TCallInfo);
      if (diagnosticSession != null)
      {
        if (callInfoCreator != null)
        {
          try
          {
            callInfo = callInfoCreator();
          }
          catch (Exception ex)
          {
            callInfo = default (TCallInfo);
            EleWise.ELMA.Logging.Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173869041)), ex);
          }
        }
      }
      return DiagnosticsManager.Initialized && diagnosticSession != null && callInfoCreator != null && (object) callInfo != null ? DiagnosticsManager.Instance.StartCall<TCallInfo>(callInfo, diagnosticSession) : default (TCallInfo);
    }

    /// <summary>Начать вызов</summary>
    /// <typeparam name="TCallInfo">Тип вызова</typeparam>
    /// <param name="callInfoCreator">Делегат создания информации о вызове</param>
    /// <param name="action">Вызов</param>
    [DebuggerHidden]
    public static void StartCall<TCallInfo>(Func<TCallInfo> callInfoCreator, System.Action action) where TCallInfo : AbstractCallInfo, IEmptyCallInfo, new()
    {
      if (callInfoCreator == null)
      {
        action();
      }
      else
      {
        TCallInfo callInfo = DiagnosticsManager.StartCall<TCallInfo>(callInfoCreator);
        try
        {
          action();
        }
        catch (Exception ex)
        {
          if ((object) callInfo != null)
            callInfo.Exception = ex;
          throw;
        }
        finally
        {
          if ((object) callInfo != null)
            ((IDisposable) callInfo).Dispose();
        }
      }
    }

    /// <summary>Начать асинхронный вызов</summary>
    /// <typeparam name="TCallInfo">Тип вызова</typeparam>
    /// <param name="callInfoCreator">Делегат создания информации о вызове</param>
    /// <param name="action">Асинхронный вызов</param>
    /// <param name="cancellationToken">Токен отмены</param>
    [DebuggerHidden]
    public static async Task StartAsyncCall<TCallInfo>(
      Func<TCallInfo> callInfoCreator,
      Func<CancellationToken, Task> action,
      CancellationToken cancellationToken)
      where TCallInfo : IEmptyCallInfo, AbstractCallInfo, new()
    {
      int num1 = 4;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = 2;
            continue;
          case 2:
            goto label_62;
          case 3:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 3 : 1;
              else
                goto label_48;
label_4:
              TaskAwaiter taskAwaiter;
              TCallInfo callInfo;
              TaskAwaiter awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    awaiter = action(cancellationToken).GetAwaiter();
                    num3 = 4;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 15;
                    continue;
                  case 3:
                    if (num2 != 1)
                    {
                      num3 = 14;
                      continue;
                    }
                    goto case 10;
                  case 4:
                    if (!awaiter.IsCompleted)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 2;
                      continue;
                    }
                    goto case 17;
                  case 5:
label_6:
                    callInfo = default (TCallInfo);
                    num3 = 18;
                    continue;
                  case 6:
                  case 13:
                    callInfo = DiagnosticsManager.StartCall<TCallInfo>(callInfoCreator);
                    num3 = 10;
                    continue;
                  case 7:
                    try
                    {
                      int num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
                        num4 = 0;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
                            continue;
                          case 2:
                            goto label_6;
                          default:
                            goto label_16;
                        }
                      }
label_16:
                      try
                      {
                        int num5;
                        if (num2 != 1)
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                        else
                          goto label_20;
label_19:
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              awaiter = action(cancellationToken).GetAwaiter();
                              num5 = 10;
                              continue;
                            case 2:
                              taskAwaiter = awaiter;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 7 : 1;
                              continue;
                            case 3:
                              goto label_20;
                            case 4:
                            case 6:
                              awaiter.GetResult();
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
                              continue;
                            case 5:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003E1__state = num2 = -1;
                              num5 = 6;
                              continue;
                            case 7:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DiagnosticsManager.\u003CStartAsyncCall\u003Ed__12<TCallInfo>>(ref awaiter, this);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 11 : 11;
                              continue;
                            case 8:
                              // ISSUE: explicit reference operation
                              // ISSUE: reference to a compiler-generated field
                              (^this).\u003C\u003E1__state = num2 = 1;
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 2 : 2;
                              continue;
                            case 9:
                              taskAwaiter = new TaskAwaiter();
                              num5 = 5;
                              continue;
                            case 10:
                              if (awaiter.IsCompleted)
                              {
                                num5 = 4;
                                continue;
                              }
                              goto case 8;
                            case 11:
                              goto label_56;
                            default:
                              goto label_6;
                          }
                        }
label_56:
                        return;
label_20:
                        awaiter = taskAwaiter;
                        num5 = 9;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
                        {
                          num5 = 8;
                          goto label_19;
                        }
                        else
                          goto label_19;
                      }
                      catch (Exception ex)
                      {
                        int num6 = 3;
                        while (true)
                        {
                          switch (num6)
                          {
                            case 1:
                              callInfo.Exception = ex;
                              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
                              continue;
                            case 3:
                              if ((object) callInfo == null)
                              {
                                num6 = 2;
                                continue;
                              }
                              goto case 1;
                            default:
                              goto label_36;
                          }
                        }
label_36:
                        throw;
                      }
                    }
                    finally
                    {
                      int num7;
                      if (num2 >= 0)
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
                      else
                        goto label_42;
label_40:
                      switch (num7)
                      {
                        case 1:
                          goto label_42;
                        case 4:
                          break;
                        default:
                      }
label_41:
                      ((IDisposable) callInfo).Dispose();
                      num7 = 3;
                      goto label_40;
label_42:
                      if ((object) callInfo == null)
                      {
                        num7 = 2;
                        goto label_40;
                      }
                      else
                        goto label_41;
                    }
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DiagnosticsManager.\u003CStartAsyncCall\u003Ed__12<TCallInfo>>(ref awaiter, this);
                    num3 = 12;
                    continue;
                  case 9:
                    goto label_48;
                  case 10:
                    num3 = 7;
                    continue;
                  case 11:
                  case 18:
                    goto label_63;
                  case 12:
                    goto label_59;
                  case 14:
                    if (callInfoCreator != null)
                    {
                      num3 = 13;
                      continue;
                    }
                    goto case 1;
                  case 15:
                    taskAwaiter = awaiter;
                    num3 = 8;
                    continue;
                  case 16:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 17;
                    continue;
                  case 17:
                    awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 3 : 11;
                    continue;
                  default:
                    taskAwaiter = new TaskAwaiter();
                    num3 = 16;
                    continue;
                }
              }
label_59:
              return;
label_48:
              awaiter = taskAwaiter;
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
              {
                num3 = 0;
                goto label_4;
              }
              else
                goto label_4;
            }
            catch (Exception ex)
            {
              int num8 = 2;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    goto label_50;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
                    continue;
                }
              }
label_50:
              return;
            }
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 2 : 3;
            continue;
        }
label_63:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
      }
label_62:;
    }

    /// <summary>Начать вызов</summary>
    /// <param name="callInfo">Информация о вызове</param>
    /// <returns></returns>
    [CanBeNull]
    public static AbstractCallInfo StartCall(AbstractCallInfo callInfo)
    {
      int num = 2;
      CallContextInfo callContextInfo;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            obj = DiagnosticsManager.s0gqoCEox6ORDoc2gbdF(DiagnosticsManager.cfEwLOEoHIORnHXTg734());
            break;
          case 2:
            if (DiagnosticsManager.D7eFTsEo75UZYJP0RHcU())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 1;
              continue;
            }
            goto case 6;
          case 3:
            if (DiagnosticsManager.D7eFTsEo75UZYJP0RHcU())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 4:
            if (callContextInfo != null)
            {
              num = 3;
              continue;
            }
            goto label_8;
          case 5:
            if (callInfo != null)
            {
              num = 4;
              continue;
            }
            goto label_8;
          case 6:
            obj = (object) null;
            break;
          default:
            goto label_7;
        }
        callContextInfo = (CallContextInfo) obj;
        num = 5;
      }
label_7:
      return DiagnosticsManager.Instance.StartCall<AbstractCallInfo>(callInfo, callContextInfo);
label_8:
      return (AbstractCallInfo) null;
    }

    /// <summary>Завершить вызов</summary>
    /// <param name="callInfo">Информация о вызове</param>
    /// <param name="ex">Ошибка</param>
    public static void StopCall(AbstractCallInfo callInfo, Exception ex = null)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_5;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
            continue;
          case 3:
            if (callInfo != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 1;
              continue;
            }
            goto label_8;
          case 4:
            goto label_22;
          default:
            goto label_2;
        }
      }
label_3:
      return;
label_22:
      return;
label_2:
      return;
label_5:
      try
      {
        DiagnosticsManager.jj1vamEo0BbxV7NPRFYI((object) callInfo, (object) ex);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_19;
            default:
              DiagnosticsManager.pdbbSQEomoVj2vV4GTNW((object) callInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
              continue;
          }
        }
label_19:
        return;
      }
      catch (Exception ex1)
      {
        int num3 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
          num3 = 3;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_15;
            case 1:
              DiagnosticsManager.Instance.Logger.Error((object) EleWise.ELMA.SR.T((string) DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-441065788 ^ -2092910478 ^ 1727089414)), ex1);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 2;
              continue;
            case 2:
              goto label_14;
            case 3:
              if (!DiagnosticsManager.ap6D33EoymnnryL7eNbO())
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            default:
              goto label_10;
          }
        }
label_15:
        return;
label_14:
        return;
label_10:
        return;
      }
label_8:;
    }

    internal static Guid? GetCurrentCallContextUid()
    {
      if (!DiagnosticsManager.Enabled)
        return new Guid?();
      return DiagnosticsManager.Instance.GetCurrentDiagnosticSession()?.Uid;
    }

    internal static long? GetCurrentCallId()
    {
      if (!DiagnosticsManager.Enabled)
        return new long?();
      CallContextInfo diagnosticSession = DiagnosticsManager.Instance.GetCurrentDiagnosticSession();
      if (diagnosticSession == null)
        return new long?();
      return diagnosticSession.CurrentCall != null ? new long?(diagnosticSession.CurrentCall.Id) : new long?();
    }

    /// <summary>Ctor</summary>
    /// <param name="logger">Логгер</param>
    /// <param name="logManager">Менеджер логов системы диагностики</param>
    /// <param name="processors">Обработчики событий</param>
    public DiagnosticsManager(
      ILogger logger,
      DiagnosticsLogManager logManager,
      IEnumerable<IDiagnosticsEventProcessor> processors)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.glimpseHelper = new GlimpseHelper();
      this.activeContext = new ConcurrentBag<CallContextInfo>();
      this._settings = new DiagnosticsSettings();
      this._counters = new Dictionary<Type, IPerformanceCounter>();
      this._metrics = new MetricsContainer();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._eventProcessors = processors;
      this._logger = logger ?? EleWise.ELMA.Logging.Logger.Log;
      this._folder = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501739621), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479246412));
      if (!Directory.Exists(this._folder))
        Directory.CreateDirectory(this._folder);
      this._logManager = logManager;
    }

    /// <summary>Освобождение занимаемых ресурсов</summary>
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (DiagnosticsManager._instance == this)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          default:
            DiagnosticsManager._instance = (DiagnosticsManager) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Проверить настройки перед сохранением</summary>
    /// <param name="settings">Настройки</param>
    internal void ValidateSettings(DiagnosticsSettings settings)
    {
      int num1 = 1;
      IEnumerator<IDiagnosticsEventProcessor> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_27;
          case 1:
            if (settings == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            goto label_3;
          case 3:
            goto label_24;
          case 4:
            if (this._eventProcessors == null)
            {
              num1 = 6;
              continue;
            }
            goto case 5;
          case 5:
            enumerator = this._eventProcessors.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 1;
            continue;
          case 6:
            goto label_19;
          default:
            goto label_5;
        }
      }
label_27:
      return;
label_24:
      return;
label_19:
      return;
label_5:
      return;
label_3:
      try
      {
label_13:
        if (DiagnosticsManager.Okkv6hEoJB4AhgQfdpRH((object) enumerator))
          goto label_7;
        else
          goto label_14;
label_4:
        IDiagnosticsSettingsValidator settingsValidator;
        EventProcessorsInfo eventProcessorsInfo;
        int num2;
        IDiagnosticsEventProcessor ep;
        while (true)
        {
          switch (num2)
          {
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              eventProcessorsInfo = settings.EventProcessorsInfos.FirstOrDefault<EventProcessorsInfo>((Func<EventProcessorsInfo, bool>) (i => DiagnosticsManager.\u003C\u003Ec__DisplayClass19_0.phcHCM8Sshiyb8gvwFrc(DiagnosticsManager.\u003C\u003Ec__DisplayClass19_0.ErVD1F8SUjQ2J29lweeP((object) i), ep.Uid)));
              num2 = 5;
              continue;
            case 3:
              goto label_6;
            case 4:
              if (settingsValidator != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 2;
                continue;
              }
              goto label_13;
            case 5:
              if (eventProcessorsInfo == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
                continue;
              }
              goto case 6;
            case 6:
              DiagnosticsManager.h19F4hEoMEQ1QnxyBsnY((object) settingsValidator, (object) eventProcessorsInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            case 7:
              goto label_7;
            case 8:
              ep = enumerator.Current;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 9 : 4;
              continue;
            case 9:
              settingsValidator = ep as IDiagnosticsSettingsValidator;
              num2 = 4;
              continue;
            default:
              goto label_13;
          }
        }
label_6:
        return;
label_7:
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        {
          num2 = 8;
          goto label_4;
        }
        else
          goto label_4;
label_14:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 3 : 3;
        goto label_4;
      }
      finally
      {
        if (enumerator != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                enumerator.Dispose();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                continue;
              default:
                goto label_26;
            }
          }
        }
label_26:;
      }
    }

    /// <summary>Обновить настройки</summary>
    public void RefreshSettings()
    {
      int num1 = 2;
      bool lockTaken;
      DiagnosticsManager diagnosticsManager;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_62;
          case 1:
            lockTaken = false;
            num1 = 3;
            continue;
          case 2:
            diagnosticsManager = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_61;
        }
      }
label_62:
      return;
label_61:
      return;
label_4:
      try
      {
        Monitor.Enter((object) diagnosticsManager, ref lockTaken);
        int num2 = 8;
        DiagnosticsSettings settings;
        DiagnosticsSettingsModule service;
        IEnumerator<IDiagnosticsEventProcessor> enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this._metrics.Periods.Add(new DateTimeRange(new DateTime?(DiagnosticsManager.HNeKw6EolNJvs9RfYKVQ((object) this._metrics)), new DateTime?(DateTime.Now)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 3 : 2;
              continue;
            case 2:
              DiagnosticsManager.yh1YBcEodZ5as4eVq223((object) this._metrics, DiagnosticsManager.iLcRN3Eo9X1r3BvpHCsM());
              num2 = 15;
              continue;
            case 3:
            case 5:
            case 15:
            case 21:
              this._settings = settings;
              num2 = 20;
              continue;
            case 4:
              goto label_21;
            case 6:
              settings = service.Settings;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 14 : 6;
              continue;
            case 7:
            case 19:
              if (!DiagnosticsManager._enabled)
              {
                num2 = 21;
                continue;
              }
              goto case 11;
            case 8:
              service = Locator.GetService<DiagnosticsSettingsModule>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
              continue;
            case 9:
              if (DiagnosticsManager._enabled)
              {
                num2 = 19;
                continue;
              }
              goto case 12;
            case 10:
              if (this._eventProcessors != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 16 : 8;
                continue;
              }
              goto label_27;
            case 11:
              if (settings.Enabled)
              {
                num2 = 5;
                continue;
              }
              goto case 1;
            case 12:
              if (settings.Enabled)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 2;
                continue;
              }
              goto case 7;
            case 13:
              goto label_47;
            case 14:
              if (settings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 5 : 17;
                continue;
              }
              goto case 9;
            case 16:
              enumerator = this._eventProcessors.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 2 : 4;
              continue;
            case 17:
              goto label_23;
            case 18:
              this._countersEnabled = DiagnosticsManager.IKKfM5Eor72B5hxyGEEb((object) this._settings);
              num2 = 10;
              continue;
            case 20:
              DiagnosticsManager._enabled = this._settings.Enabled;
              num2 = 18;
              continue;
            default:
              if (service != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 6 : 2;
                continue;
              }
              goto label_42;
          }
        }
label_47:
        return;
label_23:
        return;
label_42:
        return;
label_21:
        try
        {
label_28:
          if (enumerator.MoveNext())
            goto label_40;
          else
            goto label_29;
label_22:
          EventProcessorsInfo eventProcessorsInfo;
          int num3;
          IDiagnosticsEventProcessor ep;
          while (true)
          {
            switch (num3)
            {
              case 1:
                if (eventProcessorsInfo != null)
                {
                  num3 = 12;
                  continue;
                }
                goto label_28;
              case 2:
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                eventProcessorsInfo = settings.EventProcessorsInfos.FirstOrDefault<EventProcessorsInfo>((Func<EventProcessorsInfo, bool>) (i => DiagnosticsManager.\u003C\u003Ec__DisplayClass20_0.IpwaLs8iWOy765Tu7bD7((object) i) == DiagnosticsManager.\u003C\u003Ec__DisplayClass20_0.GYd2ol8iobmuIpA68438((object) ep)));
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
                continue;
              case 3:
                this.EventOccured -= new DiagnosticsEventHandler(ep.Process);
                num3 = 2;
                continue;
              case 4:
                this.EventOccured += new DiagnosticsEventHandler(ep.Process);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 9 : 3;
                continue;
              case 5:
                goto label_40;
              case 6:
                if (DiagnosticsManager.lClo2SEo5p31Kef2QXeE((object) eventProcessorsInfo))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
                  continue;
                }
                goto label_28;
              case 7:
                goto label_57;
              case 8:
                ep = enumerator.Current;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 3;
                continue;
              case 9:
              case 11:
                goto label_28;
              case 10:
                if (DiagnosticsManager._enabled)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 3 : 4;
                  continue;
                }
                goto label_28;
              case 12:
                DiagnosticsManager.LLTS5WEogesiXQaXOOt8((object) ep, (object) eventProcessorsInfo, DiagnosticsManager._enabled);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 5 : 6;
                continue;
              default:
                if (!DiagnosticsManager.JNTcR8Eojm2acA0qTdmR((object) settings))
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 9 : 11;
                  continue;
                }
                goto case 10;
            }
          }
label_57:
          return;
label_29:
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 7 : 6;
          goto label_22;
label_40:
          num3 = 8;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
          {
            num3 = 4;
            goto label_22;
          }
          else
            goto label_22;
        }
        finally
        {
          if (enumerator != null)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
              num4 = 1;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  DiagnosticsManager.p1jMDkEoY3vQUMpHyOge((object) enumerator);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_49;
              }
            }
          }
label_49:;
        }
label_27:;
      }
      finally
      {
        int num5;
        if (!lockTaken)
          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 1 : 0;
        else
          goto label_63;
label_60:
        switch (num5)
        {
          case 1:
          case 2:
        }
label_63:
        DiagnosticsManager.uq82RVEoLDU1VYwt7Rg4((object) diagnosticsManager);
        num5 = 2;
        goto label_60;
      }
    }

    /// <summary>
    /// Папка, в которой находятся сформированные отчеты, логи и т.д.
    /// </summary>
    public string Folder => this._folder;

    /// <summary>Настройки</summary>
    public DiagnosticsSettings Settings => this._settings;

    /// <summary>Метрики</summary>
    public MetricsContainer Metrics => this._metrics;

    /// <summary>Менеджер логов диагностики</summary>
    public DiagnosticsLogManager LogManager => this._logManager;

    /// <summary>Получить информацию о текущих потоках выполнения</summary>
    /// <returns></returns>
    public IEnumerable<CallContextInfo> GetCurrentCalls() => (IEnumerable<CallContextInfo>) this.activeContext.ToArray();

    /// <summary>Запустить новую сессию диагностики</summary>
    /// <param name="name">Название сессии</param>
    /// <returns></returns>
    public CallContextInfo StartNewDiagnosticSession(string name) => this.StartNewDiagnosticSessionInternal(name, true);

    /// <summary>Получить текущую сессию диагностики</summary>
    /// <returns></returns>
    public CallContextInfo GetCurrentDiagnosticSession()
    {
      int num = 4;
      CallContextInfo diagnosticSession;
      CallContextType contextType;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (contextType)
            {
              case CallContextType.WebRequest:
                goto label_4;
              case CallContextType.Background:
              case CallContextType.BackgroundTask:
                goto label_8;
              case CallContextType.SubContext:
                goto label_11;
              default:
                num = 9;
                continue;
            }
          case 2:
          case 5:
          case 12:
            goto label_2;
          case 3:
            contextType = this.GetContextType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 1;
            continue;
          case 4:
            diagnosticSession = (CallContextInfo) null;
            num = 3;
            continue;
          case 6:
            diagnosticSession = diagnosticSession.ChildContextInfo;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
            continue;
          case 7:
label_4:
            diagnosticSession = DiagnosticsManager.NwAMAIEos89Q3mIwwEjt(DiagnosticsManager.SXn6LmEoUGa9Gh6jmEnX((object) HttpContext.Current), DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(--1333735954 ^ 1333468160)) as CallContextInfo;
            num = 11;
            continue;
          case 8:
          case 9:
            goto label_10;
          case 13:
label_8:
            diagnosticSession = DiagnosticsManager.currentContext.Value;
            num = 10;
            continue;
          case 14:
            if (DiagnosticsManager.uAMEobEocHRVeHwi0oCt((object) diagnosticSession) == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 2 : 2;
              continue;
            }
            goto case 6;
          default:
label_11:
            if (diagnosticSession == null)
            {
              num = 12;
              continue;
            }
            goto case 14;
        }
      }
label_2:
      return diagnosticSession;
label_10:
      throw new InvalidOperationException((string) DiagnosticsManager.GFrT5REo6ZlxcEniDpry(DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(1642859704 ^ 1642603252)));
    }

    /// <summary>Закрыть текущую сессию дагностики</summary>
    /// <param name="ex">Ошибка</param>
    /// <returns></returns>
    public CallContextInfo CloseCurrentSession(Exception ex = null)
    {
      int num1 = 2;
      CallContextInfo result;
      CallContextInfo currentContextInfo;
      DiagnosticsManager diagnosticsManager;
      while (true)
      {
        switch (num1)
        {
          case 1:
            diagnosticsManager = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 9 : 12;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
            continue;
          case 3:
            if (currentContextInfo == null)
            {
              num1 = 14;
              continue;
            }
            DiagnosticsManager.pQEqDFEozWqTitxX76QH((object) currentContextInfo, (object) ex);
            num1 = 5;
            continue;
          case 4:
            this.metricAggregators.ForEach<IMetricAggregator>((Action<IMetricAggregator>) (a =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    DiagnosticsManager.\u003C\u003Ec__DisplayClass32_0.BPb6ZX8ifpnGgtiMb4ln((object) a, (object) currentContextInfo, (object) diagnosticsManager._metrics);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 10 : 6;
            continue;
          case 5:
            if (DiagnosticsManager.GeHF9jEbFHAisGXOMb3m((object) currentContextInfo) != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 11 : 0;
              continue;
            }
            this.RemoveCurrentCallContext();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 9 : 6;
            continue;
          case 6:
            this.activeContext.TryTake(out result);
            num1 = 8;
            continue;
          case 7:
            DiagnosticsManager.CxwZXyEbot7NejWn62Z9((object) ((CallContextInfo) DiagnosticsManager.GeHF9jEbFHAisGXOMb3m((object) currentContextInfo)).Metrics, DiagnosticsManager.AK1GJDEbWX2wM64MsFeU((object) currentContextInfo));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
            continue;
          case 8:
            DiagnosticsManager.CxwZXyEbot7NejWn62Z9((object) this._metrics, DiagnosticsManager.AK1GJDEbWX2wM64MsFeU((object) currentContextInfo));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 3 : 4;
            continue;
          case 9:
            result = (CallContextInfo) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 6 : 3;
            continue;
          case 10:
            goto label_9;
          case 11:
            DiagnosticsManager.TSVbRGEbBOCqTT34Rl39(DiagnosticsManager.GeHF9jEbFHAisGXOMb3m((object) currentContextInfo), (object) null);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 4 : 7;
            continue;
          case 12:
            currentContextInfo = this.GetCurrentDiagnosticSession();
            num1 = 3;
            continue;
          case 13:
            goto label_18;
          case 14:
            goto label_4;
          default:
            this.metricAggregators.ForEach<IMetricAggregator>((Action<IMetricAggregator>) (a =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    a.Add((object) currentContextInfo, diagnosticsManager._metrics);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 13 : 9;
            continue;
        }
      }
label_4:
      return (CallContextInfo) null;
label_9:
      return currentContextInfo;
label_18:
      return currentContextInfo;
    }

    /// <summary>Обнулить статистику</summary>
    public void ClearStatistics()
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        MetricsContainer metrics;
        bool lockTaken;
        while (true)
        {
          switch (num2)
          {
            case 1:
              metrics = this._metrics;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            case 2:
              try
              {
                Monitor.Enter((object) metrics, ref lockTaken);
                int num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
                  num3 = 0;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      this._metrics = new MetricsContainer();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_16;
                  }
                }
              }
              finally
              {
                int num4;
                if (!lockTaken)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 1;
                else
                  goto label_11;
label_9:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_11:
                DiagnosticsManager.uq82RVEoLDU1VYwt7Rg4((object) metrics);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
                {
                  num4 = 0;
                  goto label_9;
                }
                else
                  goto label_9;
              }
            case 3:
              goto label_17;
            case 4:
              goto label_10;
            case 5:
label_16:
              ((IStatistics) DiagnosticsManager.qd12ToEbhGG0lRo2skTE(DiagnosticsManager.H9RQrCEbbd4T3KT4oJTh((object) Locator.GetServiceNotNull<SessionFactoryHolder>()))).Clear();
              num2 = 3;
              continue;
            default:
              lockTaken = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
              continue;
          }
        }
label_17:
        this._metrics.StartTime = DiagnosticsManager.iLcRN3Eo9X1r3BvpHCsM();
        num1 = 4;
      }
label_10:;
    }

    /// <summary>Обработать событие диагностики</summary>
    /// <param name="e">Событие</param>
    public void OnEvent(DiagnosticsEvent e)
    {
      int num1 = 1;
      DiagnosticsEventHandler eventOccured;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (!DiagnosticsManager.by43HJEbGDYRCPdQxNNU((object) this.Settings))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 2:
            if (eventOccured != null)
            {
              num1 = 3;
              continue;
            }
            goto case 5;
          case 3:
            try
            {
              DiagnosticsManager.X7j5HTEbflDDlKWrnOlx((object) eventOccured, (object) e);
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_17;
              }
            }
            catch (Exception ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    DiagnosticsManager.bG4CT0EbQPuKMi3bRsqT((object) this.Logger, (object) EleWise.ELMA.SR.T((string) DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-1839087379 - 334718690 ^ 2120905861)), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_17;
                }
              }
            }
          case 4:
            DiagnosticsManager.e8L6dZEbEKSVueyhmOH4((object) this.glimpseHelper, (object) e);
            num1 = 8;
            continue;
          case 5:
label_17:
            if (DiagnosticsManager.Enabled)
            {
              num1 = 6;
              continue;
            }
            goto label_10;
          case 6:
            DiagnosticsManager.MJ4gf3EbCF8AK2qwKmqj((object) this.LogManager, (object) e);
            num1 = 7;
            continue;
          case 7:
            goto label_19;
          default:
            eventOccured = this.EventOccured;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 2;
            continue;
        }
      }
label_19:
      return;
label_10:;
    }

    /// <summary>Отправить сообщение в Glimpse</summary>
    /// <param name="message">Сообщение</param>
    public void MessagePoint(string message)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_20;
          case 1:
            goto label_24;
          case 2:
            if (message != null)
            {
              num1 = 5;
              continue;
            }
            goto label_17;
          case 3:
            if (DiagnosticsManager.Enabled)
            {
              num1 = 2;
              continue;
            }
            goto label_15;
          case 4:
            goto label_3;
          case 5:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 4;
            continue;
          default:
            goto label_11;
        }
      }
label_20:
      return;
label_24:
      return;
label_11:
      return;
label_3:
      try
      {
        CallContextInfo diagnosticSession = this.GetCurrentDiagnosticSession();
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Trace.WriteLine(message);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_10;
            case 3:
              if (diagnosticSession == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
                continue;
              }
              goto case 1;
            case 4:
              goto label_5;
            default:
              this.OnEvent((DiagnosticsEvent) new MessagePointEvent(diagnosticSession, message));
              num2 = 4;
              continue;
          }
        }
label_10:
        return;
label_5:
        return;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_2;
            default:
              DiagnosticsManager.vUZYoWEbvtP5rrvDSJAR((object) this.Logger, (object) EleWise.ELMA.SR.T((string) DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(1470998129 - 231418599 ^ 1239832122), (object) ex));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
              continue;
          }
        }
label_2:
        return;
      }
label_17:
      return;
label_15:;
    }

    /// <summary>Возникновение события диагностики</summary>
    public event DiagnosticsEventHandler EventOccured
    {
      add
      {
        int num = 4;
        DiagnosticsEventHandler diagnosticsEventHandler1;
        DiagnosticsEventHandler comparand;
        DiagnosticsEventHandler diagnosticsEventHandler2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (diagnosticsEventHandler1 == comparand)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 5;
                continue;
              }
              goto case 3;
            case 2:
              diagnosticsEventHandler2 = (DiagnosticsEventHandler) DiagnosticsManager.RH6HDREb8Ai3yQLlnl5O((object) comparand, (object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
              continue;
            case 3:
              comparand = diagnosticsEventHandler1;
              num = 2;
              continue;
            case 4:
              diagnosticsEventHandler1 = this.EventOccured;
              num = 3;
              continue;
            case 5:
              goto label_2;
            default:
              diagnosticsEventHandler1 = Interlocked.CompareExchange<DiagnosticsEventHandler>(ref this.EventOccured, diagnosticsEventHandler2, comparand);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
              continue;
          }
        }
label_2:;
      }
      remove
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          DiagnosticsEventHandler diagnosticsEventHandler1;
          DiagnosticsEventHandler comparand;
          DiagnosticsEventHandler diagnosticsEventHandler2;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_3;
              case 2:
                diagnosticsEventHandler1 = Interlocked.CompareExchange<DiagnosticsEventHandler>(ref this.EventOccured, diagnosticsEventHandler2, comparand);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                continue;
              case 3:
                comparand = diagnosticsEventHandler1;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 1 : 5;
                continue;
              case 4:
                goto label_7;
              case 5:
                diagnosticsEventHandler2 = (DiagnosticsEventHandler) DiagnosticsManager.sIuLh1EbZWHlWOj4IZKr((object) comparand, (object) value);
                num2 = 2;
                continue;
              default:
                if (diagnosticsEventHandler1 == comparand)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 1 : 0;
                  continue;
                }
                goto case 3;
            }
          }
label_7:
          diagnosticsEventHandler1 = this.EventOccured;
          num1 = 3;
        }
label_3:;
      }
    }

    /// <summary>Получить счетчик производительности</summary>
    /// <typeparam name="TCounter"></typeparam>
    /// <returns></returns>
    public TCounter GetCounter<TCounter>() where TCounter : IPerformanceCounter
    {
      this.InitCounters();
      IPerformanceCounter counter;
      if (!this._counters.TryGetValue(TypeOf<TCounter>.Raw, out counter))
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309368476), (object) TypeOf<TCounter>.Name));
      return (TCounter) counter;
    }

    /// <summary>Включены ли счетчики</summary>
    public bool CountersEnabled
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.InitCounters();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_4;
            default:
              if (this._countersInitialized)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 2;
                continue;
              }
              goto label_5;
          }
        }
label_4:
        return this._countersEnabled;
label_5:
        return false;
      }
    }

    /// <summary>Начало Web-запроса</summary>
    /// <param name="context">Контекст Web-запроса</param>
    public void WebRequestStart(HttpContext context)
    {
      switch (1)
      {
        case 1:
          try
          {
            int num;
            if (!DiagnosticsManager.D7eFTsEo75UZYJP0RHcU())
              num = 5;
            else
              goto label_5;
label_3:
            CallContextInfo callContextInfo;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_5;
                case 2:
                  goto label_10;
                case 3:
                  DiagnosticsManager.n1xSp8EbV1QV4Uf6aKVd((object) callContextInfo, context.Request == null ? (object) "" : DiagnosticsManager.RpWGsYEbIj2HgsP4HDYR(DiagnosticsManager.NFuqw8Ebu36QpghEgO6I((object) context)));
                  num = 4;
                  continue;
                case 4:
                  DiagnosticsManager.f1eqAEEbiAjAMOSdWMcB((object) callContextInfo, DiagnosticsManager.NFuqw8Ebu36QpghEgO6I((object) context) == null ? (object) "" : DiagnosticsManager.xRZZuTEbSDnBkWk9BVFJ(DiagnosticsManager.NFuqw8Ebu36QpghEgO6I((object) context)));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                  continue;
                case 5:
                  goto label_9;
                default:
                  this.OnEvent((DiagnosticsEvent) new WebRequestStartEvent(callContextInfo, context));
                  num = 2;
                  continue;
              }
            }
label_10:
            break;
label_9:
            break;
label_5:
            callContextInfo = this.StartNewDiagnosticSessionInternal(context.Request == null ? "" : ((HttpRequest) DiagnosticsManager.NFuqw8Ebu36QpghEgO6I((object) context)).RawUrl);
            num = 3;
            goto label_3;
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_7;
                default:
                  DiagnosticsManager.vUZYoWEbvtP5rrvDSJAR((object) this.Logger, (object) EleWise.ELMA.SR.T((string) DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(1514961705 ^ 1514690201), (object) ex));
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                  continue;
              }
            }
label_7:
            break;
          }
      }
    }

    /// <summary>Авторизация веб-запроса</summary>
    /// <param name="user">Пользователь</param>
    public void WebRequestAuthorized(IUser user)
    {
      int num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_20;
          case 1:
            goto label_6;
          case 2:
            if (user != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
              continue;
            }
            num1 = 5;
            continue;
          case 3:
            goto label_3;
          case 4:
            if (!DiagnosticsManager.D7eFTsEo75UZYJP0RHcU())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 3;
              continue;
            }
            goto case 2;
          case 5:
            goto label_2;
          default:
            goto label_18;
        }
      }
label_20:
      return;
label_3:
      return;
label_2:
      return;
label_18:
      return;
label_6:
      try
      {
        CallContextInfo diagnosticSession = this.GetCurrentDiagnosticSession();
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              DiagnosticsManager.cJEETMEbqxp3RqLSPVQk((object) diagnosticSession, DiagnosticsManager.jTLxYZEbRAxogBNkbBUW((object) user));
              num2 = 3;
              continue;
            case 2:
              if (diagnosticSession != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
                continue;
              }
              break;
            case 3:
              DiagnosticsManager.TgrBllEbXVQf24xdPMW1((object) diagnosticSession, DiagnosticsManager.K2JUeWEbKPEQ4oZ3f4dJ((object) user));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_14;
          }
          this.OnEvent((DiagnosticsEvent) new WebRequestAuthorizedEvent(diagnosticSession, (HttpContext) DiagnosticsManager.Eyma3yEbTZE79B3YbiMN(), user));
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 4 : 4;
        }
label_14:;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_8;
            case 1:
              DiagnosticsManager.bG4CT0EbQPuKMi3bRsqT((object) this.Logger, DiagnosticsManager.GFrT5REo6ZlxcEniDpry(DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-643786247 ^ -643517367)), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_8:
        return;
label_4:;
      }
    }

    /// <summary>Конец веб-запроса</summary>
    /// <param name="context">Контекст Web-запроса</param>
    public void WebRequestEnd(HttpContext context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.WebRequestError(context, (Exception) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Ошибка при выполнении веб-запроса</summary>
    /// <param name="context">Контекст Web-запроса</param>
    /// <param name="ex">Ошибка</param>
    public void WebRequestError(HttpContext context, Exception ex)
    {
      int num1 = 5;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_30;
          case 4:
            if (context != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 2 : 2;
              continue;
            }
            goto label_12;
          case 5:
            if (DiagnosticsManager.Enabled)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 2;
              continue;
            }
            goto label_3;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_30:
      return;
label_12:
      return;
label_3:
      return;
label_9:
      try
      {
        CallContextInfo callContextInfo = this.CloseCurrentSession(ex);
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.OnEvent((DiagnosticsEvent) new WebRequestEndEvent(callContextInfo, context));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 7 : 0;
              continue;
            case 2:
              if (!this.CountersEnabled)
              {
                num2 = 4;
                continue;
              }
              goto case 8;
            case 3:
              if (callContextInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
                continue;
              }
              goto label_24;
            case 4:
            case 6:
              if (ex != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 5:
              goto label_28;
            case 7:
              goto label_19;
            case 8:
              this.GetCounter<WebRequestAvgTimeCounter>().IncrementBy(callContextInfo.TotalTime.Ticks);
              num2 = 6;
              continue;
            default:
              this.OnEvent((DiagnosticsEvent) new WebRequestErrorEvent(callContextInfo, context));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 5 : 5;
              continue;
          }
        }
label_28:
        return;
label_19:
        return;
label_24:;
      }
      catch (Exception ex1)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_13;
            default:
              DiagnosticsManager.bG4CT0EbQPuKMi3bRsqT((object) this.Logger, DiagnosticsManager.GFrT5REo6ZlxcEniDpry(DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(--1418440330 ^ 1418691386)), (object) ex1);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 1;
              continue;
          }
        }
label_13:;
      }
    }

    /// <summary>Начало нового фонового потока</summary>
    /// <param name="methodInfo">Информация о методе выполняющемся в потоке</param>
    /// <param name="createdParentContextInfoUid">Идентификатор CallContextInfo в рамках которого был запущен данный поток</param>
    /// <param name="description">Описание</param>
    internal void BackgroundThreadStart(
      [NotNull] MethodInfo methodInfo,
      Guid createdParentContextInfoUid,
      string description)
    {
      int num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
            continue;
          case 2:
            if (DiagnosticsManager.D7eFTsEo75UZYJP0RHcU())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
            }
            goto label_18;
          case 3:
            goto label_19;
          case 4:
            goto label_20;
          default:
            goto label_2;
        }
      }
label_19:
      return;
label_20:
      return;
label_2:
      try
      {
        CallContextInfo callContextInfo = this.StartNewDiagnosticSessionInternal((string) DiagnosticsManager.NCRMTQEberDK7VT66GIy(DiagnosticsManager.fhfIwLEbkdi1k6ZyYpxk(methodInfo.DeclaringType, (object) methodInfo), DiagnosticsManager.jDWKlxEb2bil84gyFQjX((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606644682), DiagnosticsManager.SSAfpxEbOaOmuCktGcGB(DiagnosticsManager.LUpwk1EbnIUlHlKnaEto((object) methodInfo), true), DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-2106517564 ^ -2106521480))));
        int num2 = 4;
        while (true)
        {
          switch (num2)
          {
            case 1:
              DiagnosticsManager.vjN1hjEb1NDJbao5ORnn((object) callContextInfo, createdParentContextInfoUid);
              num2 = 5;
              continue;
            case 2:
              goto label_16;
            case 3:
              DiagnosticsManager.prNnH2EbNlbVCSxyRwKN((object) this.GetCounter<BackgroundThreadCounter>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            case 4:
              DiagnosticsManager.UptJ24EbPj39ioRfvarm((object) callContextInfo, (object) description);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
              continue;
            case 5:
              if (this.CountersEnabled)
              {
                num2 = 3;
                continue;
              }
              break;
          }
          this.OnEvent((DiagnosticsEvent) new BackgroundThreadStartEvent(callContextInfo));
          num2 = 2;
        }
label_16:
        return;
      }
      catch (Exception ex)
      {
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_12;
            case 1:
              this.Logger.Error((object) EleWise.ELMA.SR.T((string) DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-542721635 ^ -542993363)), ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_12:
        return;
label_5:
        return;
      }
label_18:;
    }

    /// <summary>Завершение фоновой задачи</summary>
    /// <param name="ex"></param>
    internal void BackgroundThreadEnd(Exception ex = null)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_26;
          case 3:
            if (DiagnosticsManager.D7eFTsEo75UZYJP0RHcU())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            }
            num1 = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_26:
      return;
label_6:
      try
      {
        CallContextInfo callContextInfo = this.CloseCurrentSession(ex);
        int num2 = 3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.OnEvent((DiagnosticsEvent) new BackgroundThreadErrorEvent(callContextInfo));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 0;
              continue;
            case 2:
              goto label_24;
            case 3:
              if (callContextInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
                continue;
              }
              goto label_20;
            case 4:
              DiagnosticsManager.LPg3gHEb3QqpD2OOpN7B((object) this.GetCounter<BackgroundThreadCounter>());
              num2 = 7;
              continue;
            case 5:
              this.OnEvent((DiagnosticsEvent) new BackgroundThreadEndEvent(callContextInfo));
              num2 = 6;
              continue;
            case 6:
              goto label_10;
            case 7:
              if (ex == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 5;
                continue;
              }
              goto case 1;
            default:
              if (this.CountersEnabled)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 2 : 4;
                continue;
              }
              goto case 7;
          }
        }
label_24:
        return;
label_10:
        return;
label_20:;
      }
      catch (Exception ex1)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_9;
            default:
              DiagnosticsManager.bG4CT0EbQPuKMi3bRsqT((object) this.Logger, DiagnosticsManager.GFrT5REo6ZlxcEniDpry((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874279909)), (object) ex1);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 1;
              continue;
          }
        }
label_9:;
      }
    }

    /// <summary>Начало фоновой задачи</summary>
    /// <param name="name">Название фоновой задачи</param>
    /// <param name="ownerType">Тип владельца</param>
    /// <param name="description">Описание</param>
    public void BackgroundTaskStart(string name, Type ownerType, string description)
    {
      int num1 = 4;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_22;
          case 1:
            goto label_21;
          case 2:
            goto label_5;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 2;
            continue;
          case 4:
            if (DiagnosticsManager.D7eFTsEo75UZYJP0RHcU())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 3;
              continue;
            }
            goto label_19;
          default:
            goto label_15;
        }
      }
label_22:
      return;
label_21:
      return;
label_15:
      return;
label_19:
      return;
label_5:
      try
      {
        CallContextInfo callContextInfo = this.StartNewDiagnosticSessionInternal((string) DiagnosticsManager.NCRMTQEberDK7VT66GIy((object) name, !DiagnosticsManager.WQgXJ2EbpAJdMfuFuMhF(ownerType, (Type) null) ? (object) "" : (object) ((string) DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-1822890472 ^ -1822916302) + DiagnosticsHelper.GetTypeName(ownerType, true) + (string) DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(1917998801 >> 2 ^ 479246980))), true, new CallContextType?(CallContextType.BackgroundTask));
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              callContextInfo.Description = description;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 2:
              this.OnEvent((DiagnosticsEvent) new BackgroundTaskStartEvent(callContextInfo));
              num2 = 4;
              continue;
            case 3:
              DiagnosticsManager.prNnH2EbNlbVCSxyRwKN((object) this.GetCounter<BackgroundTaskCounter>());
              num2 = 2;
              continue;
            case 4:
              goto label_9;
            default:
              if (this.CountersEnabled)
              {
                num2 = 3;
                continue;
              }
              goto case 2;
          }
        }
label_9:;
      }
      catch (Exception ex)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_6;
            case 1:
              DiagnosticsManager.bG4CT0EbQPuKMi3bRsqT((object) this.Logger, DiagnosticsManager.GFrT5REo6ZlxcEniDpry(DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-35995181 ^ -35722141)), (object) ex);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_6:
        return;
label_4:;
      }
    }

    /// <summary>Конец фоновой задачи</summary>
    public void BackgroundTaskEnd()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.BackgroundTaskError((Exception) null);
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

    /// <summary>Ошибка при выполнении фоновой задачи</summary>
    /// <param name="ex">Ошибка</param>
    public void BackgroundTaskError(Exception ex)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_4;
          case 2:
            goto label_25;
          case 3:
            if (DiagnosticsManager.D7eFTsEo75UZYJP0RHcU())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
              continue;
            }
            num1 = 2;
            continue;
          default:
            goto label_23;
        }
      }
label_2:
      return;
label_25:
      return;
label_23:
      return;
label_4:
      try
      {
        CallContextInfo callContextInfo = this.CloseCurrentSession(ex);
        int num2 = 7;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 8:
              if (ex != null)
              {
                num2 = 6;
                continue;
              }
              goto case 3;
            case 2:
              goto label_19;
            case 3:
              this.OnEvent((DiagnosticsEvent) new BackgroundTaskEndEvent(callContextInfo));
              num2 = 10;
              continue;
            case 4:
              DiagnosticsManager.rGBLKxEbDwDuaynuiKpy((object) this.GetCounter<BackgroundAvgTimeCounter>(), DiagnosticsManager.YiV8OCEbapi9LotMMhs7((object) callContextInfo).Ticks);
              num2 = 8;
              continue;
            case 5:
              DiagnosticsManager.LPg3gHEb3QqpD2OOpN7B((object) this.GetCounter<BackgroundTaskCounter>());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 4 : 3;
              continue;
            case 6:
              this.OnEvent((DiagnosticsEvent) new BackgroundTaskErrorEvent(callContextInfo));
              num2 = 2;
              continue;
            case 7:
              if (callContextInfo == null)
              {
                num2 = 9;
                continue;
              }
              goto default;
            case 9:
              goto label_18;
            case 10:
              goto label_14;
            default:
              if (!this.CountersEnabled)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
                continue;
              }
              goto case 5;
          }
        }
label_19:
        return;
label_18:
        return;
label_14:;
      }
      catch (Exception ex1)
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_9;
            default:
              DiagnosticsManager.bG4CT0EbQPuKMi3bRsqT((object) this.Logger, DiagnosticsManager.GFrT5REo6ZlxcEniDpry(DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(~289714581 ^ -289446950)), (object) ex1);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
              continue;
          }
        }
label_9:;
      }
    }

    private ILogger Logger => this._logger;

    private void InitCounters()
    {
      int num1 = 1;
      bool lockTaken;
      Dictionary<Type, IPerformanceCounter> counters;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            if (!this._countersInitializeInvoked)
            {
              counters = this._counters;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 4;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_60;
          case 3:
            goto label_5;
          case 4:
            lockTaken = false;
            num1 = 3;
            continue;
          default:
            goto label_43;
        }
      }
label_2:
      return;
label_60:
      return;
label_43:
      return;
label_5:
      try
      {
        Monitor.Enter((object) counters, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 3:
              this._countersInitialized = false;
              num2 = 2;
              continue;
            case 2:
              goto label_11;
            case 4:
              goto label_58;
            default:
              if (!this._countersInitializeInvoked)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
                continue;
              }
              goto label_53;
          }
        }
label_58:
        return;
label_53:
        return;
label_11:
        try
        {
          IEnumerable<IPerformanceCounter> extensionPoints = ((ComponentManager) DiagnosticsManager.Qj6V1DEbtFE5njYYFDn7()).GetExtensionPoints<IPerformanceCounter>();
          int num3 = 4;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
            num3 = 5;
          IEnumerator<IPerformanceCounter> enumerator;
          while (true)
          {
            switch (num3)
            {
              case 1:
                try
                {
label_35:
                  if (DiagnosticsManager.Okkv6hEoJB4AhgQfdpRH((object) enumerator))
                    goto label_32;
                  else
                    goto label_36;
label_31:
                  IPerformanceCounter current;
                  int num4;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        this._counters[current.GetType()] = current;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_32;
                      case 3:
                        goto label_26;
                      default:
                        goto label_35;
                    }
                  }
label_32:
                  current = enumerator.Current;
                  num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
                  {
                    num4 = 1;
                    goto label_31;
                  }
                  else
                    goto label_31;
label_36:
                  num4 = 3;
                  goto label_31;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
                      num5 = 0;
                    while (true)
                    {
                      switch (num5)
                      {
                        case 1:
                          goto label_42;
                        default:
                          enumerator.Dispose();
                          num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 1;
                          continue;
                      }
                    }
                  }
label_42:;
                }
              case 2:
label_27:
                this._countersInitialized = true;
                num3 = 4;
                continue;
              case 3:
                try
                {
label_16:
                  if (DiagnosticsManager.Okkv6hEoJB4AhgQfdpRH((object) enumerator))
                    goto label_18;
                  else
                    goto label_17;
label_15:
                  int num6;
                  switch (num6)
                  {
                    case 1:
                      goto label_18;
                    case 2:
                      goto label_16;
                    default:
                      goto label_27;
                  }
label_17:
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                  goto label_15;
label_18:
                  DiagnosticsManager.w890vyEbwcB5cjdjBD6S((object) enumerator.Current, (object) PerformanceCategoryRegistrar.DefaultCategoryName);
                  num6 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                  {
                    num6 = 2;
                    goto label_15;
                  }
                  else
                    goto label_15;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num7 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
                      num7 = 0;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 1:
                          goto label_25;
                        default:
                          enumerator.Dispose();
                          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
                          continue;
                      }
                    }
                  }
label_25:;
                }
              case 4:
                goto label_49;
              case 5:
                enumerator = extensionPoints.GetEnumerator();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
                continue;
              case 6:
label_26:
                Locator.GetServiceNotNull<IPerformanceCategoryRegistrar>().CheckRegisterDefault();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
                continue;
              default:
                enumerator = extensionPoints.GetEnumerator();
                num3 = 3;
                continue;
            }
          }
label_49:;
        }
        catch (Exception ex)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_47;
              default:
                this.Logger.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012340679), ex);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
                continue;
            }
          }
label_47:;
        }
        finally
        {
          this._countersInitializeInvoked = true;
          int num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
            num9 = 0;
          switch (num9)
          {
            default:
          }
        }
      }
      finally
      {
        int num10;
        if (!lockTaken)
          num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
        else
          goto label_59;
label_57:
        switch (num10)
        {
          case 1:
            break;
          default:
        }
label_59:
        DiagnosticsManager.uq82RVEoLDU1VYwt7Rg4((object) counters);
        num10 = 2;
        goto label_57;
      }
    }

    private CallContextType GetContextType()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (DiagnosticsManager.Eyma3yEbTZE79B3YbiMN() != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return CallContextType.WebRequest;
label_5:
      return CallContextType.Background;
    }

    private void SaveCallContext(CallContextInfo callContext)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        CallContextType contextType;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (contextType != CallContextType.Background)
              {
                num2 = 2;
                continue;
              }
              DiagnosticsManager.currentContext.Value = callContext;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 6 : 0;
              continue;
            case 2:
              goto label_4;
            case 3:
              goto label_3;
            case 4:
              if (contextType != CallContextType.WebRequest)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
                continue;
              }
              break;
            case 5:
              goto label_9;
            case 6:
              goto label_5;
          }
          DiagnosticsManager.X5F91wEb4IHcNW97Zsle(DiagnosticsManager.SXn6LmEoUGa9Gh6jmEnX(DiagnosticsManager.Eyma3yEbTZE79B3YbiMN()), DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-542721635 ^ -542992497), (object) callContext);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 3 : 3;
        }
label_9:
        contextType = this.GetContextType();
        num1 = 4;
      }
label_3:
      return;
label_5:
      return;
label_4:
      throw new InvalidOperationException((string) DiagnosticsManager.GFrT5REo6ZlxcEniDpry(DiagnosticsManager.kvor04Eo4Cc5Fia7LVfg(-1822890472 ^ -1822635948)));
    }

    private void RemoveCurrentCallContext()
    {
      int num = 4;
      CallContextType contextType;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (contextType == CallContextType.Background)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 3:
            if (contextType == CallContextType.WebRequest)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 1;
              continue;
            }
            goto case 2;
          case 4:
            contextType = this.GetContextType();
            num = 3;
            continue;
          case 5:
            goto label_2;
          default:
            DiagnosticsManager.currentContext.Value = (CallContextInfo) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 5 : 5;
            continue;
        }
      }
label_3:
      return;
label_2:
      return;
label_4:
      throw new InvalidOperationException((string) DiagnosticsManager.GFrT5REo6ZlxcEniDpry((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021662521)));
    }

    private CallContextInfo StartNewDiagnosticSessionInternal(
      string name,
      bool isSubContext = false,
      CallContextType? subContextType = null)
    {
      CallContextInfo diagnosticSession = this.GetCurrentDiagnosticSession();
      if (diagnosticSession == null)
      {
        CallContextInfo callContext = new CallContextInfo(new CallContextType?(isSubContext ? (CallContextType) ((int) subContextType ?? 3) : this.GetContextType()))
        {
          Name = name
        };
        this.SaveCallContext(callContext);
        this.activeContext.Add(callContext);
        return callContext;
      }
      if (!isSubContext)
        return diagnosticSession;
      CallContextInfo call = new CallContextInfo(new CallContextType?((CallContextType) ((int) subContextType ?? 3)))
      {
        Name = name,
        ParentContextInfo = diagnosticSession
      };
      diagnosticSession.ChildContextInfo = call;
      if (diagnosticSession.CurrentCall != null)
        diagnosticSession.CurrentCall.AddWorkTreeElement((IWorkTreeElement) call);
      else
        diagnosticSession.AddWorkTreeElement((IWorkTreeElement) call);
      return call;
    }

    private TCallInfo StartCall<TCallInfo>(TCallInfo callInfo, CallContextInfo callContextInfo) where TCallInfo : AbstractCallInfo
    {
      try
      {
        callInfo.StartCall(callContextInfo);
      }
      catch (Exception ex)
      {
        DiagnosticsManager.Instance.Logger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479246340)), ex);
      }
      return callInfo;
    }

    void IInitHandler.Init() => DiagnosticsManager._instance = this;

    void IInitHandler.InitComplete()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.metricAggregators = ((ComponentManager) DiagnosticsManager.Qj6V1DEbtFE5njYYFDn7()).GetExtensionPoints<IMetricAggregator>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    static DiagnosticsManager()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            DiagnosticsManager.callErrorEventTypes = new ConcurrentDictionary<Type, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 7 : 4;
            continue;
          case 2:
            DiagnosticsManager.callStartEventTypes = new ConcurrentDictionary<Type, Type>();
            num = 5;
            continue;
          case 3:
            DiagnosticsManager.oGEU9SEb6YBUvSDTDwKU();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 2;
            continue;
          case 4:
            // ISSUE: type reference
            DiagnosticsManager.AbstractCallEndEventType = DiagnosticsManager.JhubSEEbHgmpCoJhZZAS(__typeref (AbstractCallEndEvent<>));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 5:
            DiagnosticsManager.callEndEventTypes = new ConcurrentDictionary<Type, Type>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
            continue;
          case 6:
            goto label_2;
          case 7:
            DiagnosticsManager.currentContext = new AsyncLocal<CallContextInfo>();
            num = 8;
            continue;
          case 8:
            DiagnosticsManager.AbstractCallStartEventType = typeof (AbstractCallStartEvent<>);
            num = 4;
            continue;
          default:
            // ISSUE: type reference
            DiagnosticsManager.AbstractCallErrorEventType = DiagnosticsManager.JhubSEEbHgmpCoJhZZAS(__typeref (AbstractCallErrorEvent<>));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 6 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object kvor04Eo4Cc5Fia7LVfg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GFrT5REo6ZlxcEniDpry([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool b6qOjtEot81kwlmHBWIA() => DiagnosticsManager.zlvdFFEoDsblYpiVC5rQ == null;

    internal static DiagnosticsManager BRyZDlEow910xauGca3C() => DiagnosticsManager.zlvdFFEoDsblYpiVC5rQ;

    internal static object cfEwLOEoHIORnHXTg734() => (object) DiagnosticsManager.Instance;

    internal static void WEkjNdEoA5oqY5TNT0x3([In] object obj0, [In] object obj1) => ((DiagnosticsManager) obj0).MessagePoint((string) obj1);

    internal static bool D7eFTsEo75UZYJP0RHcU() => DiagnosticsManager.Enabled;

    internal static object s0gqoCEox6ORDoc2gbdF([In] object obj0) => (object) ((DiagnosticsManager) obj0).GetCurrentDiagnosticSession();

    internal static void jj1vamEo0BbxV7NPRFYI([In] object obj0, [In] object obj1) => ((AbstractCallInfo) obj0).Exception = (Exception) obj1;

    internal static void pdbbSQEomoVj2vV4GTNW([In] object obj0) => ((AbstractCallInfo) obj0).Dispose();

    internal static bool ap6D33EoymnnryL7eNbO() => DiagnosticsManager.Initialized;

    internal static void h19F4hEoMEQ1QnxyBsnY([In] object obj0, [In] object obj1) => ((IDiagnosticsSettingsValidator) obj0).ValidateSettings((EventProcessorsInfo) obj1);

    internal static bool Okkv6hEoJB4AhgQfdpRH([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static DateTime iLcRN3Eo9X1r3BvpHCsM() => DateTime.Now;

    internal static void yh1YBcEodZ5as4eVq223([In] object obj0, DateTime value) => ((MetricsContainer) obj0).StartTime = value;

    internal static DateTime HNeKw6EolNJvs9RfYKVQ([In] object obj0) => ((MetricsContainer) obj0).StartTime;

    internal static bool IKKfM5Eor72B5hxyGEEb([In] object obj0) => ((DiagnosticsSettings) obj0).CountersEnabled;

    internal static void LLTS5WEogesiXQaXOOt8([In] object obj0, [In] object obj1, bool diagnosticsEnable) => ((IDiagnosticsEventProcessor) obj0).RefreshSettings((EventProcessorsInfo) obj1, diagnosticsEnable);

    internal static bool lClo2SEo5p31Kef2QXeE([In] object obj0) => ((EventProcessorsInfo) obj0).Enabled;

    internal static bool JNTcR8Eojm2acA0qTdmR([In] object obj0) => ((DiagnosticsSettings) obj0).LogsEnabled;

    internal static void p1jMDkEoY3vQUMpHyOge([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void uq82RVEoLDU1VYwt7Rg4([In] object obj0) => Monitor.Exit(obj0);

    internal static object SXn6LmEoUGa9Gh6jmEnX([In] object obj0) => (object) ((HttpContext) obj0).Items;

    internal static object NwAMAIEos89Q3mIwwEjt([In] object obj0, [In] object obj1) => ((IDictionary) obj0)[obj1];

    internal static object uAMEobEocHRVeHwi0oCt([In] object obj0) => (object) ((CallContextInfo) obj0).ChildContextInfo;

    internal static void pQEqDFEozWqTitxX76QH([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).CloseCallContext((Exception) obj1);

    internal static object GeHF9jEbFHAisGXOMb3m([In] object obj0) => (object) ((CallContextInfo) obj0).ParentContextInfo;

    internal static void TSVbRGEbBOCqTT34Rl39([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).ChildContextInfo = (CallContextInfo) obj1;

    internal static object AK1GJDEbWX2wM64MsFeU([In] object obj0) => (object) ((CallContextInfo) obj0).Metrics;

    internal static void CxwZXyEbot7NejWn62Z9([In] object obj0, [In] object obj1) => ((MetricsContainer) obj0).Merge((MetricsContainer) obj1);

    internal static object H9RQrCEbbd4T3KT4oJTh([In] object obj0) => (object) ((SessionFactoryHolder) obj0).SessionFactory;

    internal static object qd12ToEbhGG0lRo2skTE([In] object obj0) => (object) ((ISessionFactory) obj0).Statistics;

    internal static bool by43HJEbGDYRCPdQxNNU([In] object obj0) => ((DiagnosticsSettings) obj0).GlimpseDiagnostic;

    internal static void e8L6dZEbEKSVueyhmOH4([In] object obj0, [In] object obj1) => ((GlimpseHelper) obj0).OnDiagnosticEvent((DiagnosticsEvent) obj1);

    internal static void X7j5HTEbflDDlKWrnOlx([In] object obj0, [In] object obj1) => ((DiagnosticsEventHandler) obj0)((DiagnosticsEvent) obj1);

    internal static void bG4CT0EbQPuKMi3bRsqT([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void MJ4gf3EbCF8AK2qwKmqj([In] object obj0, [In] object obj1) => ((DiagnosticsLogManager) obj0).Log((DiagnosticsEvent) obj1);

    internal static void vUZYoWEbvtP5rrvDSJAR([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object RH6HDREb8Ai3yQLlnl5O([In] object obj0, [In] object obj1) => (object) Delegate.Combine((Delegate) obj0, (Delegate) obj1);

    internal static object sIuLh1EbZWHlWOj4IZKr([In] object obj0, [In] object obj1) => (object) Delegate.Remove((Delegate) obj0, (Delegate) obj1);

    internal static object NFuqw8Ebu36QpghEgO6I([In] object obj0) => (object) ((HttpContext) obj0).Request;

    internal static object RpWGsYEbIj2HgsP4HDYR([In] object obj0) => (object) ((HttpRequest) obj0).UserHostAddress;

    internal static void n1xSp8EbV1QV4Uf6aKVd([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).UserHostAddress = (string) obj1;

    internal static object xRZZuTEbSDnBkWk9BVFJ([In] object obj0) => (object) ((HttpRequest) obj0).HttpMethod;

    internal static void f1eqAEEbiAjAMOSdWMcB([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).HttpMethod = (string) obj1;

    internal static object jTLxYZEbRAxogBNkbBUW([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void cJEETMEbqxp3RqLSPVQk([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).UserId = obj1;

    internal static object K2JUeWEbKPEQ4oZ3f4dJ([In] object obj0) => (object) ((IUser) obj0).UserName;

    internal static void TgrBllEbXVQf24xdPMW1([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).UserName = (string) obj1;

    internal static object Eyma3yEbTZE79B3YbiMN() => (object) HttpContext.Current;

    internal static object fhfIwLEbkdi1k6ZyYpxk(Type ownerType, [In] object obj1) => (object) DiagnosticsHelper.GetMethodCallName(ownerType, (MethodInfo) obj1);

    internal static Type LUpwk1EbnIUlHlKnaEto([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static object SSAfpxEbOaOmuCktGcGB(Type type, bool useFullName) => (object) DiagnosticsHelper.GetTypeName(type, useFullName);

    internal static object jDWKlxEb2bil84gyFQjX([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object NCRMTQEberDK7VT66GIy([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void UptJ24EbPj39ioRfvarm([In] object obj0, [In] object obj1) => ((CallContextInfo) obj0).Description = (string) obj1;

    internal static void vjN1hjEb1NDJbao5ORnn([In] object obj0, Guid value) => ((CallContextInfo) obj0).CreatedParentContextInfoUid = value;

    internal static void prNnH2EbNlbVCSxyRwKN([In] object obj0) => ((NumberOfItemsCounter) obj0).Increment();

    internal static void LPg3gHEb3QqpD2OOpN7B([In] object obj0) => ((NumberOfItemsCounter) obj0).Decrement();

    internal static bool WQgXJ2EbpAJdMfuFuMhF([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static TimeSpan YiV8OCEbapi9LotMMhs7([In] object obj0) => ((CallContextInfo) obj0).TotalTime;

    internal static void rGBLKxEbDwDuaynuiKpy([In] object obj0, long ticks) => ((AvgTimeCounter) obj0).IncrementBy(ticks);

    internal static object Qj6V1DEbtFE5njYYFDn7() => (object) ComponentManager.Current;

    internal static void w890vyEbwcB5cjdjBD6S([In] object obj0, [In] object obj1) => ((IPerformanceCounter) obj0).Init((string) obj1);

    internal static void X5F91wEb4IHcNW97Zsle([In] object obj0, [In] object obj1, [In] object obj2) => ((IDictionary) obj0)[obj1] = obj2;

    internal static void oGEU9SEb6YBUvSDTDwKU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type JhubSEEbHgmpCoJhZZAS([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    [Component]
    private class SettingsLoader : IModuleContainerEvents
    {
      internal static object E8EOes8STR0issOrYKLn;

      public void Activated()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              if (!DiagnosticsManager.Initialized)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              DiagnosticsManager.SettingsLoader.wg0PPo8SOCdOObIeJ2Au((object) DiagnosticsManager.Instance);
              num = 3;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_7;
          }
        }
label_5:
        return;
label_2:
        return;
label_7:;
      }

      public void Terminating()
      {
      }

      public SettingsLoader()
      {
        DiagnosticsManager.SettingsLoader.LVTEXA8S2pnnENfkHv6O();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void wg0PPo8SOCdOObIeJ2Au([In] object obj0) => ((DiagnosticsManager) obj0).RefreshSettings();

      internal static bool EK8FOg8SkxNKuKnRAS0s() => DiagnosticsManager.SettingsLoader.E8EOes8STR0issOrYKLn == null;

      internal static DiagnosticsManager.SettingsLoader YTJWHR8SnmVWDFo8dO4c() => (DiagnosticsManager.SettingsLoader) DiagnosticsManager.SettingsLoader.E8EOes8STR0issOrYKLn;

      internal static void LVTEXA8S2pnnENfkHv6O() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    [Component(Type = ComponentType.WebServer)]
    private class SettingsRefreshHandler : ISweepHandler, IThreadPoolContainer
    {
      private readonly object _sweepPool;
      internal static object Q4vXp78SeKCWi4K8A4hc;

      public SettingsRefreshHandler()
      {
        DiagnosticsManager.SettingsRefreshHandler.gFMxmK8SN92PbJPxCWkS();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this._sweepPool = (object) new ThreadSubPool(1);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      IThreadPool IThreadPoolContainer.Pool => (IThreadPool) this._sweepPool;

      public void Execute()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              DiagnosticsManager.SettingsRefreshHandler.I8C61f8SaJfpcyuYfJe4(DiagnosticsManager.SettingsRefreshHandler.ElEdwR8SpdJjcLHTHQla());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            case 2:
              if (DiagnosticsManager.SettingsRefreshHandler.thfi7D8S3f24BPRaDmUG())
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
                continue;
              }
              goto label_6;
            default:
              goto label_7;
          }
        }
label_2:
        return;
label_7:
        return;
label_6:;
      }

      internal static void gFMxmK8SN92PbJPxCWkS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool sMEtqH8SPbopKbJRwR5Q() => DiagnosticsManager.SettingsRefreshHandler.Q4vXp78SeKCWi4K8A4hc == null;

      internal static DiagnosticsManager.SettingsRefreshHandler TuKZdO8S1XsaQWqdRNwR() => (DiagnosticsManager.SettingsRefreshHandler) DiagnosticsManager.SettingsRefreshHandler.Q4vXp78SeKCWi4K8A4hc;

      internal static bool thfi7D8S3f24BPRaDmUG() => DiagnosticsManager.Initialized;

      internal static object ElEdwR8SpdJjcLHTHQla() => (object) DiagnosticsManager.Instance;

      internal static void I8C61f8SaJfpcyuYfJe4([In] object obj0) => ((DiagnosticsManager) obj0).RefreshSettings();
    }

    /// <summary>Внутрений хелпер менеджера диагностики</summary>
    internal static class Helper
    {
      internal static DiagnosticsManager.Helper eMIWT18SDbBYTXU4UZ55;

      /// <summary>Хелпер начала вызова</summary>
      /// <param name="callInfo">Информация о вызове</param>
      internal static void StartCallHelper(AbstractCallInfo callInfo)
      {
        int num1 = 3;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_37;
            case 2:
              goto label_2;
            case 3:
              if (callInfo == null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 2;
                continue;
              }
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_37:
        return;
label_2:
        return;
label_5:
        try
        {
          int num2;
          if (DiagnosticsManager.Helper.qMJaB68S456FBsgRAtba((object) callInfo) == null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 8 : 5;
          else
            goto label_11;
label_8:
          object obj;
          Type type1;
          Type type2;
          DiagnosticEventsAttribute attribute;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_33;
              case 1:
                if (attribute == null)
                {
                  num2 = 13;
                  continue;
                }
                goto case 5;
              case 2:
                type1 = DiagnosticsManager.Helper.A9GZXZ8SHLHPCj10Zlds((object) attribute);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 9 : 14;
                continue;
              case 3:
                goto label_29;
              case 4:
                obj = DiagnosticsManager.Helper.c5kj8k8S7p6tctigg0Fi(type1, (object) new object[1]
                {
                  (object) callInfo
                });
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 7 : 11;
                continue;
              case 5:
                if (DiagnosticsManager.Helper.rg4WWy8SAJkpsEihqb5p(DiagnosticsManager.Helper.A9GZXZ8SHLHPCj10Zlds((object) attribute), (Type) null))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 2 : 0;
                  continue;
                }
                goto case 6;
              case 6:
              case 14:
                if (!DiagnosticsManager.Helper.rg4WWy8SAJkpsEihqb5p(type1, (Type) null))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                  continue;
                }
                goto case 4;
              case 7:
              case 13:
                type1 = DiagnosticsManager.callStartEventTypes.GetOrAdd(type2, (Func<Type, Type>) (type => DiagnosticsManager.AbstractCallStartEventType.MakeGenericType(type)));
                num2 = 6;
                continue;
              case 8:
                goto label_20;
              case 9:
                goto label_19;
              case 10:
                goto label_11;
              case 11:
                DiagnosticsManager.Helper.JhcJSE8S0CTiIGZdmrPe(DiagnosticsManager.Helper.b6tibn8SxJaNP6iia7Q7(), (object) (obj as DiagnosticsEvent));
                num2 = 9;
                continue;
              case 12:
                attribute = AttributeHelper<DiagnosticEventsAttribute>.GetAttribute(type2, true);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
                continue;
              case 15:
                type1 = (Type) null;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 12 : 8;
                continue;
              case 16:
                goto label_27;
              default:
                goto label_16;
            }
          }
label_33:
          return;
label_29:
          return;
label_20:
          return;
label_19:
          return;
label_16:
          return;
label_11:
          if (!DiagnosticsManager.Helper.LK8pwy8S6OXLHpQIIOJX())
          {
            num2 = 3;
            goto label_8;
          }
label_27:
          type2 = callInfo.GetType();
          num2 = 15;
          goto label_8;
        }
        catch (Exception ex)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ((ILogger) DiagnosticsManager.Helper.rWvJEY8Sm9PDA4tFZHvW((object) DiagnosticsManager.Instance)).Error(DiagnosticsManager.Helper.duUFvH8SM7q46Vq7wapC(DiagnosticsManager.Helper.X73T3H8Sy0FYWiGuWNR8(-218496594 ^ -218223586)), ex);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 2;
                continue;
              case 2:
                goto label_15;
              default:
                if (DiagnosticsManager.Helper.LK8pwy8S6OXLHpQIIOJX())
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
                  continue;
                }
                goto label_13;
            }
          }
label_15:
          return;
label_13:;
        }
      }

      /// <summary>Хелпер завершения вызова</summary>
      /// <param name="callInfo">Информация о вызове</param>
      /// <returns></returns>
      internal static void StopCallHelper(AbstractCallInfo callInfo)
      {
        int num1 = 4;
        while (true)
        {
          switch (num1)
          {
            case 1:
              goto label_45;
            case 2:
              goto label_44;
            case 3:
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 4:
              if (callInfo != null)
              {
                num1 = 3;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_45:
        return;
label_44:
        return;
label_2:
        return;
label_5:
        try
        {
          if (DiagnosticsManager.Helper.qMJaB68S456FBsgRAtba((object) callInfo) == null)
            return;
          int num2 = 4;
          while (true)
          {
            int num3;
            Type type1;
            DiagnosticEventsAttribute attribute;
            Type type2;
            object e;
            Type type3;
            Type orAdd;
            switch (num2)
            {
              case 1:
                type3 = attribute.ErrorEvent;
                goto label_32;
              case 2:
                goto label_36;
              case 3:
                ((DiagnosticsManager) DiagnosticsManager.Helper.b6tibn8SxJaNP6iia7Q7()).OnEvent(e as DiagnosticsEvent);
                num2 = 13;
                continue;
              case 4:
                if (!DiagnosticsManager.Helper.LK8pwy8S6OXLHpQIIOJX())
                {
                  num2 = 2;
                  continue;
                }
                goto case 8;
              case 5:
                if (DiagnosticsManager.Helper.TCUEUe8SJ5p4qInOZgbo((object) callInfo) == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 6;
                  continue;
                }
                goto case 1;
              case 6:
                type3 = DiagnosticsManager.Helper.SShM6j8S9QynKtfPxyJ5((object) attribute);
                goto label_32;
              case 7:
                type2 = (Type) null;
                num3 = 16;
                break;
              case 8:
                type1 = callInfo.GetType();
                num2 = 7;
                continue;
              case 9:
                if (attribute == null)
                {
                  num3 = 12;
                  break;
                }
                goto case 5;
              case 10:
                orAdd = DiagnosticsManager.callErrorEventTypes.GetOrAdd(type1, (Func<Type, Type>) (type => DiagnosticsManager.AbstractCallErrorEventType.MakeGenericType(type)));
                goto label_35;
              case 12:
              case 14:
                if (DiagnosticsManager.Helper.TCUEUe8SJ5p4qInOZgbo((object) callInfo) != null)
                {
                  num2 = 10;
                  continue;
                }
                orAdd = DiagnosticsManager.callEndEventTypes.GetOrAdd(type1, (Func<Type, Type>) (type => DiagnosticsManager.AbstractCallEndEventType.MakeGenericType(type)));
                goto label_35;
              case 13:
                goto label_26;
              case 15:
                e = DiagnosticsManager.Helper.c5kj8k8S7p6tctigg0Fi(type2, (object) new object[1]
                {
                  (object) callInfo
                });
                num2 = 3;
                continue;
              case 16:
                attribute = AttributeHelper<DiagnosticEventsAttribute>.GetAttribute(type1, true);
                num2 = 9;
                continue;
              default:
                if (DiagnosticsManager.Helper.rg4WWy8SAJkpsEihqb5p(type2, (Type) null))
                {
                  num2 = 15;
                  continue;
                }
                goto label_21;
            }
label_8:
            num2 = num3;
            continue;
label_32:
            type2 = type3;
            num3 = 11;
            goto label_8;
label_35:
            type2 = orAdd;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
          }
label_36:
          return;
label_26:
          return;
label_21:;
        }
        catch (Exception ex)
        {
          int num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
            num4 = 1;
          while (true)
          {
            switch (num4)
            {
              case 0:
                goto label_20;
              case 1:
                if (DiagnosticsManager.Helper.LK8pwy8S6OXLHpQIIOJX())
                {
                  num4 = 2;
                  continue;
                }
                goto label_11;
              case 2:
                DiagnosticsManager.Helper.LtpVbi8SdS9pdhEUWa4E((object) ((DiagnosticsManager) DiagnosticsManager.Helper.b6tibn8SxJaNP6iia7Q7()).Logger, DiagnosticsManager.Helper.duUFvH8SM7q46Vq7wapC(DiagnosticsManager.Helper.X73T3H8Sy0FYWiGuWNR8(-87337865 ^ -87066169)), (object) ex);
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                continue;
              default:
                goto label_10;
            }
          }
label_20:
          return;
label_10:
          return;
label_11:;
        }
      }

      internal static object qMJaB68S456FBsgRAtba([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

      internal static bool LK8pwy8S6OXLHpQIIOJX() => DiagnosticsManager.Initialized;

      internal static Type A9GZXZ8SHLHPCj10Zlds([In] object obj0) => ((DiagnosticEventsAttribute) obj0).StartEvent;

      internal static bool rg4WWy8SAJkpsEihqb5p([In] Type obj0, [In] Type obj1) => obj0 != obj1;

      internal static object c5kj8k8S7p6tctigg0Fi([In] Type obj0, [In] object obj1) => Activator.CreateInstance(obj0, (object[]) obj1);

      internal static object b6tibn8SxJaNP6iia7Q7() => (object) DiagnosticsManager.Instance;

      internal static void JhcJSE8S0CTiIGZdmrPe([In] object obj0, [In] object obj1) => ((DiagnosticsManager) obj0).OnEvent((DiagnosticsEvent) obj1);

      internal static object rWvJEY8Sm9PDA4tFZHvW([In] object obj0) => (object) ((DiagnosticsManager) obj0).Logger;

      internal static object X73T3H8Sy0FYWiGuWNR8(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object duUFvH8SM7q46Vq7wapC([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool eGZXmJ8Stj79RVRgLVbw() => DiagnosticsManager.Helper.eMIWT18SDbBYTXU4UZ55 == null;

      internal static DiagnosticsManager.Helper KvjLGN8SwlZlU8SMZ1cx() => DiagnosticsManager.Helper.eMIWT18SDbBYTXU4UZ55;

      internal static object TCUEUe8SJ5p4qInOZgbo([In] object obj0) => (object) ((AbstractCallInfo) obj0).Exception;

      internal static Type SShM6j8S9QynKtfPxyJ5([In] object obj0) => ((DiagnosticEventsAttribute) obj0).EndEvent;

      internal static void LtpVbi8SdS9pdhEUWa4E([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);
    }
  }
}
