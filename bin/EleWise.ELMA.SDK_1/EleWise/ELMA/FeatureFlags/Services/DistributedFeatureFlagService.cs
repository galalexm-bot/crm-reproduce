// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FeatureFlags.Services.DistributedFeatureFlagService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.FeatureFlags;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.FeatureFlags.Services
{
  /// <summary>Распределенный сервис флагов функций</summary>
  [Service]
  internal sealed class DistributedFeatureFlagService : IDistributedFeatureFlagService
  {
    private readonly ILogger logger;
    private readonly IDictionary<Guid, IDictionary<string, bool?>> serversFeatureFlags;
    private readonly IActorModelRuntime actorModelRuntime;
    private static DistributedFeatureFlagService dM4vHyGWTct5SBNHA2Y9;

    /// <summary>Ctor</summary>
    /// <param name="actorModelRuntime">Среда исполнения акторов</param>
    public DistributedFeatureFlagService(IActorModelRuntime actorModelRuntime)
    {
      DistributedFeatureFlagService.P8r5uYGWOTBIR5D8iwsr();
      this.logger = (ILogger) DistributedFeatureFlagService.CGQyGGGW25JqEEjVDeO0(typeof (DistributedFeatureFlagService));
      this.serversFeatureFlags = (IDictionary<Guid, IDictionary<string, bool?>>) new Dictionary<Guid, IDictionary<string, bool?>>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public IEnumerable<Guid> AvailableServers => (IEnumerable<Guid>) this.serversFeatureFlags.Keys;

    /// <inheritdoc />
    public async Task<bool> Enabled(Guid serverUid, string name, bool defaultEnabled)
    {
      int num1 = 2;
      int num2;
      bool result;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 4;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_35;
          case 4:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 15 : 1;
              else
                goto label_15;
label_4:
              TaskAwaiter<bool?> taskAwaiter;
              TaskAwaiter<bool?> awaiter;
              while (true)
              {
                IDictionary<string, bool?> featureFlags;
                bool? nullable1;
                bool? nullable2;
                int num4;
                switch (num3)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<bool?>, DistributedFeatureFlagService.\u003CEnabled\u003Ed__6>(ref awaiter, this);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 6 : 9;
                    continue;
                  case 2:
                    taskAwaiter = new TaskAwaiter<bool?>();
                    num3 = 16;
                    continue;
                  case 3:
                    featureFlags[name] = nullable1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 8;
                    continue;
                  case 4:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 1;
                    continue;
                  case 5:
                  case 17:
                    nullable1 = awaiter.GetResult();
                    num3 = 3;
                    continue;
                  case 6:
                    // ISSUE: reference to a compiler-generated method
                    this.logger.InfoFormat((string) DistributedFeatureFlagService.\u003CEnabled\u003Ed__6.HcAlhcvdEX11J6lPBeEQ(-1350312861 << 3 ^ 2082158064), (object) name, (object) serverUid);
                    num3 = 19;
                    continue;
                  case 7:
                    if (!this.serversFeatureFlags.TryGetValue(serverUid, out featureFlags))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 18 : 2;
                      continue;
                    }
                    goto case 12;
                  case 8:
                  case 18:
                    nullable2 = nullable1;
                    num3 = 11;
                    continue;
                  case 9:
                    goto label_32;
                  case 10:
                    num4 = defaultEnabled ? 1 : 0;
                    break;
                  case 11:
                    if (nullable2.HasValue)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 14 : 3;
                      continue;
                    }
                    goto case 10;
                  case 12:
                    if (!featureFlags.TryGetValue(name, out nullable1))
                    {
                      num3 = 6;
                      continue;
                    }
                    goto case 8;
                  case 13:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 5;
                      continue;
                    }
                    goto case 20;
                  case 14:
                    num4 = nullable2.GetValueOrDefault() ? 1 : 0;
                    break;
                  case 15:
                    nullable1 = new bool?();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 7 : 4;
                    continue;
                  case 16:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 17;
                    continue;
                  case 19:
                    awaiter = this.actorModelRuntime.GetActor<IFeatureFlagActor>(serverUid).Enabled(name).GetAwaiter();
                    num3 = 13;
                    continue;
                  case 20:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 4;
                    continue;
                  case 21:
                    goto label_15;
                  default:
                    goto label_36;
                }
                result = num4 != 0;
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              }
label_32:
              return;
label_15:
              awaiter = taskAwaiter;
              num3 = 2;
              goto label_4;
            }
            catch (Exception ex)
            {
              int num5 = 2;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_29;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
                    continue;
                  default:
                    goto label_26;
                }
              }
label_29:
              return;
label_26:
              return;
            }
          case 5:
label_36:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          default:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 3;
            continue;
        }
      }
label_35:;
    }

    /// <summary>Обновить кэш состояний флагов</summary>
    /// <param name="serverUid">Уникальный идентификатор сервера</param>
    /// <param name="featureFlags">Состояния флагов</param>
    internal Task UpdateCache(Guid serverUid, IDictionary<string, bool?> featureFlags)
    {
      this.logger.DebugFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137544408), (object) serverUid);
      this.serversFeatureFlags[serverUid] = featureFlags;
      return Task.CompletedTask;
    }

    internal static void P8r5uYGWOTBIR5D8iwsr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object CGQyGGGW25JqEEjVDeO0(Type componentType) => (object) Logger.GetLogger(componentType);

    internal static bool r3v1AyGWkOHXAie0hQIY() => DistributedFeatureFlagService.dM4vHyGWTct5SBNHA2Y9 == null;

    internal static DistributedFeatureFlagService x9aAFkGWn6x6pZMMiryh() => DistributedFeatureFlagService.dM4vHyGWTct5SBNHA2Y9;

    [Component]
    private sealed class ServerStatusEventHandler : IServerStatusEventHandler, IEventHandler
    {
      private readonly object logger;
      private readonly object distributedFeatureFlagService;
      internal static object JcM1Dtv9s2EswPjYcg0M;

      public ServerStatusEventHandler(
        DistributedFeatureFlagService distributedFeatureFlagService)
      {
        DistributedFeatureFlagService.ServerStatusEventHandler.CN7nC7vdF6UyIlBVTqfG();
        // ISSUE: type reference
        this.logger = DistributedFeatureFlagService.ServerStatusEventHandler.atHtkovdW5fp4CcqhbkE(DistributedFeatureFlagService.ServerStatusEventHandler.EvvAx1vdB5bNR15AesOK(__typeref (DistributedFeatureFlagService)));
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.distributedFeatureFlagService = (object) distributedFeatureFlagService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 1;
              continue;
          }
        }
label_3:;
      }

      public void ServerStarted(Guid serverUid, Version serverVersion)
      {
      }

      public void ServerStarting(Guid serverUid)
      {
      }

      public void ServerStoped(Guid serverUid)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              ((ILogger) this.logger).DebugFormat((string) DistributedFeatureFlagService.ServerStatusEventHandler.Oc1E0IvdoOycIncn4MfF(874012245 ^ 874350821), (object) serverUid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              ((DistributedFeatureFlagService) this.distributedFeatureFlagService).serversFeatureFlags.Remove(serverUid);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 0;
              continue;
          }
        }
label_2:;
      }

      internal static void CN7nC7vdF6UyIlBVTqfG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static Type EvvAx1vdB5bNR15AesOK([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object atHtkovdW5fp4CcqhbkE(Type componentType) => (object) Logger.GetLogger(componentType);

      internal static bool TNXfoCv9cYPVAjIA8mFy() => DistributedFeatureFlagService.ServerStatusEventHandler.JcM1Dtv9s2EswPjYcg0M == null;

      internal static DistributedFeatureFlagService.ServerStatusEventHandler EPpPdTv9zdskqu0vECmp() => (DistributedFeatureFlagService.ServerStatusEventHandler) DistributedFeatureFlagService.ServerStatusEventHandler.JcM1Dtv9s2EswPjYcg0M;

      internal static object Oc1E0IvdoOycIncn4MfF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
