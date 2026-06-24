// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.Actors.ConsistentHashingCacheActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Starting;
using EleWise.ELMA.Cache.ActorModel.Configuration;
using EleWise.ELMA.Cache.ActorModel.Partitioning;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Cache.ActorModel.Actors
{
  /// <inheritdoc />
  internal sealed class ConsistentHashingCacheActor : 
    Actor,
    IConsistentHashingCacheActor,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    private static MembershipTable membershipTable;
    private static readonly MemoryCache Cache;
    private readonly CacheOptions options;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly ILogger logger;
    private readonly string localNode;
    internal static ConsistentHashingCacheActor SJTOjKfTZekBARWk63ch;

    /// <summary>Инициализирует экземпляр класса.</summary>
    /// <param name="cacheService">Интерфейс работы с кэшем.</param>
    /// <param name="actorModelRuntime">Интерфейс Модели Акторов.</param>
    /// <param name="runtimeApplication">Интерфейс для работы со средой исполнения приложения.</param>
    /// <param name="loggerFactory">Фабрика для создания логгеров.</param>
    public ConsistentHashingCacheActor(
      ICacheService cacheService,
      IActorModelRuntime actorModelRuntime,
      IRuntimeApplication runtimeApplication,
      ILoggerFactory loggerFactory)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            this.logger = (ILogger) ConsistentHashingCacheActor.oTEKtpfTSWJqafBO2H5g((object) loggerFactory, ConsistentHashingCacheActor.sulmmyfTV2CVDgW17vN9(__typeref (ServerInstanceActor)));
            num = 7;
            continue;
          case 2:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (ConsistentHashingCacheActor.membershipTable != null)
            {
              num = 3;
              continue;
            }
            break;
          case 5:
            this.localNode = ConsistentHashingCacheActor.WjpriqfTRBi8fMB3cVeF((object) runtimeApplication).ToString();
            num = 4;
            continue;
          case 6:
            goto label_2;
          case 7:
            this.options = (CacheOptions) ((cacheService is IOptionsProvider optionsProvider ? ConsistentHashingCacheActor.sgleEofTi1vRs6MwjPQr((object) optionsProvider) : (object) null) ?? (object) new CacheOptions());
            num = 5;
            continue;
        }
        ConsistentHashingCacheActor.membershipTable = new MembershipTable(this.localNode);
        num = 6;
      }
label_7:
      return;
label_2:;
    }

    /// <inheritdoc />
    public Task ClearRegion(string region, bool forward = true)
    {
      int num1 = 7;
      // ISSUE: variable of a compiler-generated type
      ConsistentHashingCacheActor.\u003CClearRegion\u003Ed__8 stateMachine;
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
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 2;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 5;
              continue;
            case 3:
              goto label_9;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = ConsistentHashingCacheActor.n4pwGWfTquFvcIurGRQB();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 0;
              continue;
            case 5:
              tBuilder.Start<ConsistentHashingCacheActor.\u003CClearRegion\u003Ed__8>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.region = region;
              num2 = 3;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 6 : 4;
              continue;
            default:
              goto label_5;
          }
        }
label_9:
        // ISSUE: reference to a compiler-generated field
        stateMachine.forward = forward;
        num1 = 4;
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public async Task<bool> Contains(string key, string region)
    {
      int num1 = 4;
      while (true)
      {
        bool success;
        int num2;
        switch (num1)
        {
          case 1:
            goto label_26;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(success);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 0;
            continue;
          case 3:
            num1 = 5;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 3 : 3;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
              else
                goto label_12;
label_7:
              TaskAwaiter<CacheResult> taskAwaiter;
              TaskAwaiter<CacheResult> awaiter;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    taskAwaiter = awaiter;
                    num3 = 8;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
                    continue;
                  case 3:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 11;
                      continue;
                    }
                    goto case 2;
                  case 4:
                  case 11:
                    success = awaiter.GetResult().Success;
                    num3 = 7;
                    continue;
                  case 5:
                    taskAwaiter = new TaskAwaiter<CacheResult>();
                    num3 = 6;
                    continue;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = 4;
                    continue;
                  case 7:
                    goto label_3;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CacheResult>, ConsistentHashingCacheActor.\u003CContains\u003Ed__9>(ref awaiter, this);
                    num3 = 9;
                    continue;
                  case 9:
                    goto label_23;
                  case 10:
                    goto label_12;
                  default:
                    awaiter = this.Get(key, region).GetAwaiter();
                    num3 = 3;
                    continue;
                }
              }
label_23:
              return;
label_12:
              awaiter = taskAwaiter;
              num3 = 5;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
              {
                num3 = 3;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                num4 = 0;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    goto label_19;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 2;
                    continue;
                }
              }
label_19:
              return;
            }
        }
label_3:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 2;
      }
label_26:;
    }

    /// <inheritdoc />
    public async Task<CacheResult> Get(string key, string region)
    {
      int num1 = 4;
      CacheResult result;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 4 : 5;
            continue;
          case 2:
            goto label_49;
          case 3:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 3;
            continue;
          case 5:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = 2;
            continue;
          default:
            try
            {
              int num3;
              if (num2 == 0)
                num3 = 14;
              else
                goto label_39;
label_7:
              string targetNode;
              string[] replicaNodes;
              CacheEntry cacheEntry;
              string cacheKey;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    targetNode = ConsistentHashingCacheActor.membershipTable.FindNode(cacheKey, this.options.ReplicaFactor, out replicaNodes);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                    continue;
                  case 2:
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    result = new CacheResult((byte[]) ConsistentHashingCacheActor.\u003CGet\u003Ed__10.zWc7JS8ULa6aXSayh6q6((object) cacheEntry));
                    num3 = 9;
                    continue;
                  case 3:
                  case 9:
                    goto label_3;
                  case 5:
                    if (cacheEntry != null)
                    {
                      num3 = 13;
                      continue;
                    }
                    goto case 11;
                  case 6:
                  case 14:
                    num3 = 8;
                    continue;
                  case 7:
                    if (((IEnumerable<string>) replicaNodes).Contains<string>(this.localNode))
                    {
                      num3 = 4;
                      continue;
                    }
                    goto case 10;
                  case 8:
                    try
                    {
                      int num4;
                      if (num2 == 0)
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 12 : 7;
                      else
                        goto label_26;
label_18:
                      TaskAwaiter<CacheResult> taskAwaiter;
                      TaskAwaiter<CacheResult> awaiter;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<CacheResult>, ConsistentHashingCacheActor.\u003CGet\u003Ed__10>(ref awaiter, this);
                            num4 = 7;
                            continue;
                          case 2:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 0 : 0;
                            continue;
                          case 3:
                            taskAwaiter = awaiter;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
                            continue;
                          case 5:
                            goto label_3;
                          case 6:
                          case 12:
                            awaiter = taskAwaiter;
                            num4 = 8;
                            continue;
                          case 7:
                            goto label_46;
                          case 8:
                            taskAwaiter = new TaskAwaiter<CacheResult>();
                            num4 = 2;
                            continue;
                          case 9:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 0;
                            num4 = 3;
                            continue;
                          case 10:
                            goto label_26;
                          case 11:
                            if (awaiter.IsCompleted)
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 4 : 4;
                              continue;
                            }
                            goto case 9;
                          default:
                            result = awaiter.GetResult();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 5 : 4;
                            continue;
                        }
                      }
label_46:
                      return;
label_26:
                      // ISSUE: reference to a compiler-generated method
                      awaiter = this.actorModelRuntime.GetActor<IConsistentHashingCacheActor>(ConsistentHashingCacheActor.\u003CGet\u003Ed__10.L8rInv8UcjLoMoxNkdKJ((object) targetNode)).Get(key, region).GetAwaiter();
                      num4 = 5;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                      {
                        num4 = 11;
                        goto label_18;
                      }
                      else
                        goto label_18;
                    }
                    catch (Exception ex)
                    {
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
                        num5 = 1;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            // ISSUE: reference to a compiler-generated method
                            this.logger.Warn(ex, (string) ConsistentHashingCacheActor.\u003CGet\u003Ed__10.p3Hs2a8UzJjlywqBes5q(1514961705 ^ 1514829715) + key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459165245) + region + (string) ConsistentHashingCacheActor.\u003CGet\u003Ed__10.p3Hs2a8UzJjlywqBes5q(2045296739 + 1688595713 ^ -561471202) + targetNode + (string) ConsistentHashingCacheActor.\u003CGet\u003Ed__10.p3Hs2a8UzJjlywqBes5q(322893104 - -1992822529 ^ -1979643757) + (string) ConsistentHashingCacheActor.\u003CGet\u003Ed__10.NFNbB28sFqNgK0Ft7PQ7((object) ex));
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                            continue;
                          default:
                            goto label_41;
                        }
                      }
                    }
                  case 10:
                    // ISSUE: reference to a compiler-generated method
                    ConsistentHashingCacheActor.\u003CGet\u003Ed__10.oGE3YT8UUe4EkuetmEVl((object) ConsistentHashingCacheActor.Cache, (object) cacheKey, (object) null);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 11 : 5;
                    continue;
                  case 11:
                    // ISSUE: reference to a compiler-generated method
                    if (ConsistentHashingCacheActor.\u003CGet\u003Ed__10.xjTg3U8UserrTS2h4yws((object) targetNode, (object) this.localNode))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 5 : 6;
                      continue;
                    }
                    goto case 15;
                  case 12:
                    goto label_39;
                  case 13:
                    // ISSUE: reference to a compiler-generated method
                    if (ConsistentHashingCacheActor.\u003CGet\u003Ed__10.CQtP4E8UYVdwTYUUB8Pu((object) targetNode, (object) this.localNode))
                    {
                      num3 = 2;
                      continue;
                    }
                    goto case 7;
                  case 15:
label_41:
                    result = CacheResult.Failed;
                    num3 = 3;
                    continue;
                  default:
                    cacheEntry = ConsistentHashingCacheActor.Cache.Get(cacheKey, (string) null) as CacheEntry;
                    num3 = 5;
                    continue;
                }
              }
label_39:
              cacheKey = this.GetCacheKey(key, region);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
              {
                num3 = 1;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num6 = 2;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_43;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                    continue;
                  default:
                    goto label_34;
                }
              }
label_43:
              return;
label_34:
              return;
            }
        }
      }
label_49:;
    }

    /// <inheritdoc />
    public Task Remove(string key, string region, bool replica = false)
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      ConsistentHashingCacheActor.\u003CRemove\u003Ed__11 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.replica = replica;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 4 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 5;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ConsistentHashingCacheActor.n4pwGWfTquFvcIurGRQB();
            num = 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 7;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.region = region;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 0;
            continue;
          case 7:
            tBuilder.Start<ConsistentHashingCacheActor.\u003CRemove\u003Ed__11>(ref stateMachine);
            num = 8;
            continue;
          case 8:
            goto label_5;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.key = key;
            num = 6;
            continue;
        }
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task Set(string key, string region, byte[] value, TimeSpan duration, bool replica = false)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      ConsistentHashingCacheActor.\u003CSet\u003Ed__12 stateMachine;
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
              stateMachine.replica = replica;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 10 : 7;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.duration = duration;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_13;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 4;
              continue;
            case 6:
              goto label_11;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = 3;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated field
              stateMachine.region = region;
              num2 = 9;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              stateMachine.value = value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 2;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = ConsistentHashingCacheActor.n4pwGWfTquFvcIurGRQB();
              num2 = 7;
              continue;
            default:
              tBuilder.Start<ConsistentHashingCacheActor.\u003CSet\u003Ed__12>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 6 : 4;
              continue;
          }
        }
label_13:
        // ISSUE: reference to a compiler-generated field
        stateMachine.key = key;
        num1 = 8;
      }
label_11:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    public Task Accept(
      (string key, string region, byte[] value, TimeSpan duration)[] entries,
      bool replica = false)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      ConsistentHashingCacheActor.\u003CAccept\u003Ed__13 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              tBuilder.Start<ConsistentHashingCacheActor.\u003CAccept\u003Ed__13>(ref stateMachine);
              num2 = 4;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.entries = entries;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_10;
            case 4:
              goto label_5;
            case 5:
              goto label_8;
            case 6:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 1;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = ConsistentHashingCacheActor.n4pwGWfTquFvcIurGRQB();
              num2 = 5;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated field
        stateMachine.replica = replica;
        num1 = 7;
        continue;
label_8:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E1__state = -1;
        num1 = 6;
        continue;
label_10:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E4__this = this;
        num1 = 2;
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task UpdateMembershipTable(string node, bool added)
    {
      int num = 2;
      // ISSUE: variable of a compiler-generated type
      ConsistentHashingCacheActor.\u003CUpdateMembershipTable\u003Ed__14 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.node = node;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 7;
            continue;
          case 5:
            tBuilder.Start<ConsistentHashingCacheActor.\u003CUpdateMembershipTable\u003Ed__14>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 0;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ConsistentHashingCacheActor.n4pwGWfTquFvcIurGRQB();
            num = 4;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 5;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.added = added;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 6 : 3;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private Task DistributeKeys(string remoteNode, (double start, double end)[] keyAngles)
    {
      int num = 5;
      AsyncTaskMethodBuilder tBuilder;
      // ISSUE: variable of a compiler-generated type
      ConsistentHashingCacheActor.\u003CDistributeKeys\u003Ed__15 stateMachine;
      while (true)
      {
        switch (num)
        {
          case 1:
            tBuilder.Start<ConsistentHashingCacheActor.\u003CDistributeKeys\u003Ed__15>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 3 : 6;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = ConsistentHashingCacheActor.n4pwGWfTquFvcIurGRQB();
            num = 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.remoteNode = remoteNode;
            num = 7;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 4 : 0;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            stateMachine.keyAngles = keyAngles;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 3 : 2;
            continue;
          default:
            goto label_9;
        }
      }
label_9:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private Task DistributeKeyCopies((double start, double end)[] keyAngles)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      ConsistentHashingCacheActor.\u003CDistributeKeyCopies\u003Ed__16 stateMachine;
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
              stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.keyAngles = keyAngles;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 2;
              continue;
            case 4:
              goto label_3;
            case 5:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 4;
              continue;
            case 6:
              goto label_4;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = 5;
              continue;
          }
        }
label_3:
        tBuilder.Start<ConsistentHashingCacheActor.\u003CDistributeKeyCopies\u003Ed__16>(ref stateMachine);
        num1 = 6;
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    private CacheEntry[] GetEntriesForDistribution((double start, double end)[] keyAngles)
    {
      int num1 = 2;
      (double, double)[] keyAngles1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            keyAngles1 = keyAngles;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return ConsistentHashingCacheActor.Cache.Select<KeyValuePair<string, object>, CacheEntry>((Func<KeyValuePair<string, object>, CacheEntry>) (p => (CacheEntry) p.Value)).Where<CacheEntry>((Func<CacheEntry, bool>) (v =>
      {
        int num2 = 1;
        CacheEntry v1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            default:
              v1 = v;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 0;
              continue;
          }
        }
label_3:
        return ((IEnumerable<(double, double)>) keyAngles1).Any<(double, double)>((Func<(double, double), bool>) (r => v1.Angle > r.start && v1.Angle <= r.end));
      })).ToArray<CacheEntry>();
    }

    private (string key, string region, byte[] value, TimeSpan duration)[] ConvertEntriesForDistribution(
      CacheEntry[] entries)
    {
      return ((IEnumerable<CacheEntry>) entries).Select<CacheEntry, (string, string, byte[], TimeSpan)>((Func<CacheEntry, (string, string, byte[], TimeSpan)>) (e => (this.ExtractKey(e.Key), this.ExtractRegion(e.Key), e.Value, e.Expiration - DateTime.UtcNow))).ToArray<(string, string, byte[], TimeSpan)>();
    }

    private void AddToCache(string key, byte[] value, TimeSpan duration)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        uint hash;
        CacheEntry cacheEntry;
        CacheItemPolicy cacheItemPolicy1;
        DateTime expiration;
        DateTime dateTime;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ConsistentHashingCacheActor.xoBNkOfTku7W3jAhWVJc((object) ConsistentHashingCacheActor.Cache, (object) key, (object) cacheEntry, (object) cacheItemPolicy1, (object) null);
              num2 = 2;
              continue;
            case 2:
              goto label_3;
            case 3:
              expiration = dateTime.Add(duration);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 4:
              dateTime = ConsistentHashingCacheActor.oQQeHsfTK7nvDS4BPa4O();
              num2 = 3;
              continue;
            case 5:
              CacheItemPolicy cacheItemPolicy2 = new CacheItemPolicy();
              ConsistentHashingCacheActor.ePGVYafTTeB0pjceuExn((object) cacheItemPolicy2, (DateTimeOffset) expiration);
              cacheItemPolicy1 = cacheItemPolicy2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
              continue;
            case 6:
              goto label_4;
            case 7:
              goto label_9;
            default:
              hash = key.ToHash();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 6 : 6;
              continue;
          }
        }
label_4:
        double angle = ConsistentHashingCacheActor.R8sTbefTXELplyT0lCEs(hash);
        num1 = 7;
        continue;
label_9:
        cacheEntry = new CacheEntry(key, value, hash, angle, expiration);
        num1 = 5;
      }
label_3:;
    }

    private string GetCacheKey(string key, string region)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ConsistentHashingCacheActor.g5Be7efTnNZ3I3WYSgYX((object) region))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      string str1 = region;
      goto label_6;
label_5:
      str1 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633171013);
label_6:
      object obj = ConsistentHashingCacheActor.GtkNSVfTOrA8gryjDEdI(-688192331 - 435440695 ^ -1123555012);
      string str2 = key;
      return (string) ConsistentHashingCacheActor.eWYoZ3fT2fXAWbPyoFYS((object) str1, obj, (object) str2);
    }

    private string ExtractKey(string key) => (string) ConsistentHashingCacheActor.YY0EBrfTeYN72OJMuLS7((object) key, (object) new char[1]
    {
      ':'
    })[1];

    private string ExtractRegion(string key)
    {
      int num = 1;
      string empty;
      while (true)
      {
        switch (num)
        {
          case 1:
            empty = (string) ConsistentHashingCacheActor.YY0EBrfTeYN72OJMuLS7((object) key, (object) new char[1]
            {
              ':'
            })[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          case 2:
          case 4:
            goto label_2;
          case 3:
            empty = string.Empty;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 2 : 4;
            continue;
          default:
            if (!(empty == (string) ConsistentHashingCacheActor.GtkNSVfTOrA8gryjDEdI(-1204263869 ^ -1341583247 ^ 137638364)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 2;
              continue;
            }
            goto case 3;
        }
      }
label_2:
      return empty;
    }

    private string CacheEntriesToString(
      (string key, string region, byte[] value, TimeSpan duration)[] data)
    {
      return string.Join((string) ConsistentHashingCacheActor.GtkNSVfTOrA8gryjDEdI(964881585 - -1459193222 ^ -1870889419), ((IEnumerable<(string, string, byte[], TimeSpan)>) data).Select<(string, string, byte[], TimeSpan), string>((Func<(string, string, byte[], TimeSpan), string>) (x => this.GetCacheKey(x.key, x.region) ?? "")));
    }

    private string KeyAnglesToString((double start, double end)[] keyAngles) => string.Join((string) ConsistentHashingCacheActor.GtkNSVfTOrA8gryjDEdI(1319452732 ^ 1319455806), ((IEnumerable<(double, double)>) keyAngles).Select<(double, double), string>((Func<(double, double), string>) (r => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70139725), (object) r.start, (object) r.end))));

    static ConsistentHashingCacheActor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ConsistentHashingCacheActor.H6wkLmfTP5xxljDOhrW6();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ConsistentHashingCacheActor.Cache = new MemoryCache(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319110192));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static Type sulmmyfTV2CVDgW17vN9([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object oTEKtpfTSWJqafBO2H5g([In] object obj0, Type type) => (object) ((ILoggerFactory) obj0).CreateLogger(type);

    internal static object sgleEofTi1vRs6MwjPQr([In] object obj0) => (object) ((IOptionsProvider) obj0).Options;

    internal static Guid WjpriqfTRBi8fMB3cVeF([In] object obj0) => ((IRuntimeApplication) obj0).ConnectionUid;

    internal static bool dUsvuofTu7fRGajHUgAq() => ConsistentHashingCacheActor.SJTOjKfTZekBARWk63ch == null;

    internal static ConsistentHashingCacheActor fEhw6SfTIrbFoPl1aFnJ() => ConsistentHashingCacheActor.SJTOjKfTZekBARWk63ch;

    internal static AsyncTaskMethodBuilder n4pwGWfTquFvcIurGRQB() => AsyncTaskMethodBuilder.Create();

    internal static DateTime oQQeHsfTK7nvDS4BPa4O() => DateTime.UtcNow;

    internal static double R8sTbefTXELplyT0lCEs(uint hash) => hash.ToAngle();

    internal static void ePGVYafTTeB0pjceuExn([In] object obj0, [In] DateTimeOffset obj1) => ((CacheItemPolicy) obj0).AbsoluteExpiration = obj1;

    internal static void xoBNkOfTku7W3jAhWVJc(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      ((ObjectCache) obj0).Set((string) obj1, obj2, (CacheItemPolicy) obj3, (string) obj4);
    }

    internal static bool g5Be7efTnNZ3I3WYSgYX([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object GtkNSVfTOrA8gryjDEdI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object eWYoZ3fT2fXAWbPyoFYS([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object YY0EBrfTeYN72OJMuLS7([In] object obj0, [In] object obj1) => (object) ((string) obj0).Split((char[]) obj1);

    internal static void H6wkLmfTP5xxljDOhrW6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
