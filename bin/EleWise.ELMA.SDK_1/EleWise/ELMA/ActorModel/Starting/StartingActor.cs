// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Starting.StartingActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Starting
{
  /// <inheritdoc />
  [StartingAvailablePlacement]
  internal sealed class StartingActor : Actor, IStartingActor, IActorWithGuidKey, IActor
  {
    /// <summary>Наименование для напоминания</summary>
    internal const string reminderName = "live";
    private readonly IRuntimeApplication runtimeApplication;
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IServerPlacementPublishService serverPlacementPublishService;
    private Version clusterVersion;
    private readonly ILogger logger;
    internal static StartingActor oMIhS9f3r6DjpVoFxNKq;

    /// <summary>ctor</summary>
    /// <param name="runtimeApplication">IRuntimeApplication injection</param>
    /// <param name="actorModelRuntime">IActorModelRuntime injection</param>
    /// <param name="serverPlacementPublishService">IServerPlacementPublishService injection</param>
    public StartingActor(
      IRuntimeApplication runtimeApplication,
      IActorModelRuntime actorModelRuntime,
      IServerPlacementPublishService serverPlacementPublishService)
    {
      StartingActor.dW3e0wf3jLvy4NMwysF1();
      // ISSUE: type reference
      this.logger = (ILogger) StartingActor.R2V2aff3LIaSZA2DVQH1(StartingActor.WWfINIf3YAtgH9DH5Flk(__typeref (StartingActor)));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.runtimeApplication = runtimeApplication;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.serverPlacementPublishService = serverPlacementPublishService;
            num = 2;
            continue;
          default:
            this.actorModelRuntime = actorModelRuntime;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 3 : 3;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override Task OnActivateAsync()
    {
      int num = 4;
      // ISSUE: variable of a compiler-generated type
      StartingActor.\u003COnActivateAsync\u003Ed__7 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            tBuilder.Start<StartingActor.\u003COnActivateAsync\u003Ed__7>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 0;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = StartingActor.nYAnXIf3Uu3PDZiLKy3s();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 2 : 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 2;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 5;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public override Task ReceiveReminder(string reminderName)
    {
      int num1 = 1;
      // ISSUE: variable of a compiler-generated type
      StartingActor.\u003CReceiveReminder\u003Ed__8 stateMachine;
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
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 5 : 4;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = StartingActor.nYAnXIf3Uu3PDZiLKy3s();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 0;
              continue;
            case 4:
              goto label_9;
            case 5:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 6;
              continue;
            case 6:
              tBuilder.Start<StartingActor.\u003CReceiveReminder\u003Ed__8>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 4 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        // ISSUE: reference to a compiler-generated field
        stateMachine.reminderName = reminderName;
        num1 = 3;
      }
label_9:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task Start(Guid serverUid)
    {
      int num = 3;
      // ISSUE: variable of a compiler-generated type
      StartingActor.\u003CStart\u003Ed__9 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.serverUid = serverUid;
            num = 5;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = 2;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 6;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
            num = 4;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          default:
            tBuilder.Start<StartingActor.\u003CStart\u003Ed__9>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
            continue;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task Finish(Guid serverUid, Version serverVersion)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      StartingActor.\u003CFinish\u003Ed__10 stateMachine;
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
              stateMachine.\u003C\u003Et__builder = StartingActor.nYAnXIf3Uu3PDZiLKy3s();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 6 : 6;
              continue;
            case 2:
              tBuilder.Start<StartingActor.\u003CFinish\u003Ed__10>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 2 : 3;
              continue;
            case 3:
              goto label_3;
            case 4:
              goto label_5;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 4;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            case 7:
              // ISSUE: reference to a compiler-generated field
              stateMachine.serverVersion = serverVersion;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 2;
              continue;
          }
        }
label_5:
        // ISSUE: reference to a compiler-generated field
        stateMachine.serverUid = serverUid;
        num1 = 7;
      }
label_3:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task ConfigurationScriptsRecompileRequired(Guid serverUid)
    {
      int num1 = 5;
      // ISSUE: variable of a compiler-generated type
      StartingActor.\u003CConfigurationScriptsRecompileRequired\u003Ed__11 stateMachine;
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
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 0;
              continue;
            case 2:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 3;
              continue;
            case 3:
              tBuilder.Start<StartingActor.\u003CConfigurationScriptsRecompileRequired\u003Ed__11>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.serverUid = serverUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 6;
              continue;
            case 5:
              goto label_6;
            case 6:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = StartingActor.nYAnXIf3Uu3PDZiLKy3s();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E4__this = this;
        num1 = 4;
      }
label_5:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    internal static void dW3e0wf3jLvy4NMwysF1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type WWfINIf3YAtgH9DH5Flk([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object R2V2aff3LIaSZA2DVQH1(Type componentType) => (object) Logger.GetLogger(componentType);

    internal static bool F0iZCAf3g2QX1C5004Wq() => StartingActor.oMIhS9f3r6DjpVoFxNKq == null;

    internal static StartingActor RqmoKnf35yGumowKLsJy() => StartingActor.oMIhS9f3r6DjpVoFxNKq;

    internal static AsyncTaskMethodBuilder nYAnXIf3Uu3PDZiLKy3s() => AsyncTaskMethodBuilder.Create();

    internal static object oqcPiLf3sjTdVV5NrEpB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object sJU4xSf3cP0gGw6iW3lX([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void HmlOKOf3zIgRIGOijVE1([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Debug(obj1, (Exception) obj2);
  }
}
