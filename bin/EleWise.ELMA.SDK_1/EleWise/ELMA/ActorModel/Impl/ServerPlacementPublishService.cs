// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Impl.ServerPlacementPublishService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Impl
{
  /// <inheritdoc />
  internal class ServerPlacementPublishService : IServerPlacementPublishService
  {
    private readonly IRuntimeApplication runtimeApplication;
    private readonly IActorModelRuntime actorModelRuntime;
    internal static ServerPlacementPublishService Q51xiBfallU7cvHX9m1e;

    /// <summary>ctor</summary>
    /// <param name="runtimeApplication">Средой исполнения приложения</param>
    /// <param name="actorModelRuntime">Модель Акторов</param>
    public ServerPlacementPublishService(
      IRuntimeApplication runtimeApplication,
      IActorModelRuntime actorModelRuntime)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
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
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
            continue;
          case 2:
            this.runtimeApplication = runtimeApplication;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <inheritdoc />
    public Task Publish<T>(
      Func<T, Task> action,
      bool ignoreError,
      Action<Guid, Exception> errorAction)
      where T : IServerPlacementActor
    {
      return Task.WhenAll(this.runtimeApplication.GetActiveConnectionUids().Select<Guid, Task>((Func<Guid, Task>) (uid =>
      {
        int num = 1;
        // ISSUE: variable of a compiler-generated type
        ServerPlacementPublishService.\u003C\u003Ec__DisplayClass3_0<T>.\u003C\u003CPublish\u003Eb__0\u003Ed stateMachine;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            case 2:
              tBuilder.Start<ServerPlacementPublishService.\u003C\u003Ec__DisplayClass3_0<T>.\u003C\u003CPublish\u003Eb__0\u003Ed>(ref stateMachine);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 3;
              continue;
            case 3:
              goto label_3;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num = 5;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 0;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 4 : 3;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              stateMachine.uid = uid;
              num = 6;
              continue;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated field
        return stateMachine.\u003C\u003Et__builder.Task;
      })));
    }

    /// <inheritdoc />
    public async Task<IReadOnlyDictionary<Guid, TRes>> Publish<T, TRes>(
      Func<T, Task<TRes>> action,
      bool ignoreError,
      Action<Guid, Exception> errorAction)
      where T : IServerPlacementActor
    {
      int num1 = 3;
      while (true)
      {
        int num2;
        IReadOnlyDictionary<Guid, TRes> dictionary;
        switch (num1)
        {
          case 1:
            goto label_35;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 5 : 5;
            continue;
          case 3:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 2;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(dictionary);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 1;
            continue;
          case 5:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 3;
              else
                goto label_19;
label_7:
              TaskAwaiter<(Guid, bool, TRes)[]> taskAwaiter1;
              TaskAwaiter<(Guid, bool, TRes)[]> awaiter1;
              while (true)
              {
                int num4;
                Func<T, Task<TRes>> action1;
                ServerPlacementPublishService placementPublishService;
                Action<Guid, Exception> errorAction1;
                bool ignoreError1;
                switch (num3)
                {
                  case 1:
                  case 5:
                    (Guid, bool, TRes)[] result1 = awaiter1.GetResult();
                    // ISSUE: reference to a compiler-generated field
                    Func<(Guid, bool, TRes), bool> func1 = ServerPlacementPublishService.\u003C\u003Ec__4<T, TRes>.\u003C\u003E9__4_1;
                    Func<(Guid, bool, TRes), bool> predicate;
                    if (func1 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      ServerPlacementPublishService.\u003C\u003Ec__4<T, TRes>.\u003C\u003E9__4_1 = predicate = (Func<(Guid, bool, TRes), bool>) (r => !r.IsFaulted);
                    }
                    else
                      goto label_39;
label_24:
                    IEnumerable<(Guid, bool, TRes)> source = ((IEnumerable<(Guid, bool, TRes)>) result1).Where<(Guid, bool, TRes)>(predicate);
                    // ISSUE: reference to a compiler-generated field
                    Func<(Guid, bool, TRes), TRes> func2 = ServerPlacementPublishService.\u003C\u003Ec__4<T, TRes>.\u003C\u003E9__4_3;
                    Func<(Guid, bool, TRes), TRes> elementSelector;
                    if (func2 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      ServerPlacementPublishService.\u003C\u003Ec__4<T, TRes>.\u003C\u003E9__4_3 = elementSelector = (Func<(Guid, bool, TRes), TRes>) (r => r.Result);
                    }
                    else
                      goto label_38;
label_27:
                    dictionary = (IReadOnlyDictionary<Guid, TRes>) source.ToDictionary<(Guid, bool, TRes), Guid, TRes>((Func<(Guid, bool, TRes), Guid>) (r => r.Uid), elementSelector);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 2 : 4;
                    continue;
label_38:
                    elementSelector = func2;
                    goto label_27;
label_39:
                    predicate = func1;
                    goto label_24;
                  case 2:
                    awaiter1 = Task.WhenAll<(Guid, bool, TRes)>(this.runtimeApplication.GetActiveConnectionUids().Select<Guid, Task<(Guid, bool, TRes)>>((Func<Guid, Task<(Guid, bool, TRes)>>) (async uid =>
                    {
                      int num5 = 5;
                      (Guid, bool, TRes) result2;
                      int num6;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 0:
                            goto label_43;
                          case 1:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.SetResult(result2);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
                            continue;
                          case 2:
                            try
                            {
                              int num7 = 0;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                                num7 = 0;
                              while (true)
                              {
                                switch (num7)
                                {
                                  case 1:
                                    goto label_8;
                                  default:
                                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
                                    continue;
                                }
                              }
label_8:
                              TRes res1;
                              try
                              {
                                int num8;
                                if (num6 != 0)
                                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 4 : 4;
                                else
                                  goto label_22;
label_10:
                                Guid guid;
                                TaskAwaiter<TRes> taskAwaiter2;
                                TaskAwaiter<TRes> awaiter2;
                                while (true)
                                {
                                  switch (num8)
                                  {
                                    case 1:
                                      res1 = awaiter2.GetResult();
                                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 6 : 8;
                                      continue;
                                    case 2:
                                      // ISSUE: explicit reference operation
                                      // ISSUE: reference to a compiler-generated field
                                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TRes>, ServerPlacementPublishService.\u003C\u003Ec__DisplayClass4_0<T, TRes>.\u003C\u003CPublish\u003Eb__0\u003Ed>(ref awaiter2, this);
                                      num8 = 3;
                                      continue;
                                    case 3:
                                      goto label_36;
                                    case 4:
                                      guid = uid;
                                      num8 = 11;
                                      continue;
                                    case 5:
                                      // ISSUE: explicit reference operation
                                      // ISSUE: reference to a compiler-generated field
                                      (^this).\u003C\u003E1__state = num6 = 0;
                                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 6 : 5;
                                      continue;
                                    case 6:
                                      taskAwaiter2 = awaiter2;
                                      num8 = 2;
                                      continue;
                                    case 7:
                                      if (!awaiter2.IsCompleted)
                                      {
                                        num8 = 5;
                                        continue;
                                      }
                                      goto case 1;
                                    case 8:
                                      result2 = (guid, false, res1);
                                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 10 : 5;
                                      continue;
                                    case 9:
                                      // ISSUE: explicit reference operation
                                      // ISSUE: reference to a compiler-generated field
                                      (^this).\u003C\u003E1__state = num6 = -1;
                                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
                                      continue;
                                    case 10:
                                      goto label_3;
                                    case 11:
                                      awaiter2 = action1(placementPublishService.actorModelRuntime.GetActor<T>(uid)).GetAwaiter();
                                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 7;
                                      continue;
                                    case 12:
                                      goto label_22;
                                    default:
                                      taskAwaiter2 = new TaskAwaiter<TRes>();
                                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 9 : 4;
                                      continue;
                                  }
                                }
label_36:
                                return;
label_22:
                                awaiter2 = taskAwaiter2;
                                num8 = 0;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                                {
                                  num8 = 0;
                                  goto label_10;
                                }
                                else
                                  goto label_10;
                              }
                              catch (Exception ex)
                              {
                                int num9 = 1;
                                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
                                  num9 = 1;
                                while (true)
                                {
                                  int num10;
                                  switch (num9)
                                  {
                                    case 1:
                                      Action<Guid, Exception> action2 = errorAction1;
                                      if (action2 == null)
                                      {
                                        num10 = 4;
                                        break;
                                      }
                                      action2(uid, ex);
                                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
                                      continue;
                                    case 2:
                                      goto label_28;
                                    case 3:
                                      goto label_3;
                                    default:
                                      if (ignoreError1)
                                      {
                                        Guid guid = uid;
                                        res1 = default (TRes);
                                        TRes res2 = res1;
                                        result2 = (guid, true, res2);
                                        num10 = 3;
                                        break;
                                      }
                                      num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 1;
                                      continue;
                                  }
                                  num9 = num10;
                                }
label_28:
                                throw;
                              }
                            }
                            catch (Exception ex)
                            {
                              int num11 = 1;
                              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                                num11 = 1;
                              while (true)
                              {
                                switch (num11)
                                {
                                  case 1:
                                    // ISSUE: explicit reference operation
                                    // ISSUE: reference to a compiler-generated field
                                    (^this).\u003C\u003E1__state = -2;
                                    num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
                                    continue;
                                  case 2:
                                    goto label_34;
                                  default:
                                    // ISSUE: explicit reference operation
                                    // ISSUE: reference to a compiler-generated field
                                    (^this).\u003C\u003Et__builder.SetException(ex);
                                    num11 = 2;
                                    continue;
                                }
                              }
label_34:
                              return;
                            }
                          case 3:
label_3:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = -2;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 1;
                            continue;
                          case 4:
                            num5 = 2;
                            continue;
                          case 5:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            num6 = (^this).\u003C\u003E1__state;
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 4 : 4;
                            continue;
                          default:
                            goto label_40;
                        }
                      }
label_43:
                      return;
label_40:;
                    }))).GetAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 6 : 0;
                    continue;
                  case 3:
                    num3 = 13;
                    continue;
                  case 4:
                    goto label_36;
                  case 6:
                    if (awaiter1.IsCompleted)
                    {
                      num4 = 5;
                      break;
                    }
                    goto case 14;
                  case 7:
                    goto label_32;
                  case 8:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 0;
                    continue;
                  case 9:
                    errorAction1 = errorAction;
                    num3 = 12;
                    continue;
                  case 10:
                    taskAwaiter1 = awaiter1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                    continue;
                  case 11:
                    goto label_19;
                  case 12:
                    ignoreError1 = ignoreError;
                    num3 = 2;
                    continue;
                  case 13:
                    action1 = action;
                    num4 = 16;
                    break;
                  case 14:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 10;
                    continue;
                  case 15:
                    taskAwaiter1 = new TaskAwaiter<(Guid, bool, TRes)[]>();
                    num4 = 8;
                    break;
                  case 16:
                    placementPublishService = this;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 9;
                    continue;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<(Guid, bool, TRes)[]>, ServerPlacementPublishService.\u003CPublish\u003Ed__4<T, TRes>>(ref awaiter1, this);
                    num3 = 7;
                    continue;
                }
                num3 = num4;
              }
label_32:
              return;
label_19:
              awaiter1 = taskAwaiter1;
              num3 = 15;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num12 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                num12 = 2;
              while (true)
              {
                switch (num12)
                {
                  case 0:
                    goto label_28;
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_25;
                }
              }
label_28:
              return;
label_25:
              return;
            }
        }
label_36:
        // ISSUE: explicit reference operation
        // ISSUE: reference to a compiler-generated field
        (^this).\u003C\u003E1__state = -2;
        num1 = 4;
      }
label_35:;
    }

    internal static bool eruMEtfari4cLiMi1qx3() => ServerPlacementPublishService.Q51xiBfallU7cvHX9m1e == null;

    internal static ServerPlacementPublishService v49F1sfagZr8VIHS3LyH() => ServerPlacementPublishService.Q51xiBfallU7cvHX9m1e;
  }
}
