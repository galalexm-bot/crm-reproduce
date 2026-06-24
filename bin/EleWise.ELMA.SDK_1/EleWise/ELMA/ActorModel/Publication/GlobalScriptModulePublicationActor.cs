// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.GlobalScriptModulePublicationActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Scripts.Manager;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <summary>
  /// Актор публикации глобального модуля <see cref="T:EleWise.ELMA.Model.Scripts.IGlobalScriptModule" />
  /// </summary>
  internal sealed class GlobalScriptModulePublicationActor : 
    Actor,
    IGlobalScriptModulePublicationActor,
    IActorWithIntegerKey,
    IActor
  {
    private readonly string reminderPrefix;
    private readonly IServerPlacementPublishService serverPlacementPublishService;
    private readonly IGlobalScriptModuleManager globalScriptModuleManager;
    private readonly ILogger logger;
    private bool publicationStarted;
    private static GlobalScriptModulePublicationActor nELecMfpQMj2Hyo3Qd4t;

    /// <summary>Ctor</summary>
    /// <param name="loggerFactory">Фабрика логгеров</param>
    /// <param name="serverPlacementPublishService">Сервис публикации действия на всех серверах кластера ELMA</param>
    /// <param name="globalScriptModuleManager">Менеджер глобальных модулей сценариев</param>
    public GlobalScriptModulePublicationActor(
      ILoggerFactory loggerFactory,
      IServerPlacementPublishService serverPlacementPublishService,
      IGlobalScriptModuleManager globalScriptModuleManager)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.reminderPrefix = (string) GlobalScriptModulePublicationActor.c6wdlAfp8sxUm8Mhd2Rf(-1824388195 ^ -1824038963);
      this.LifeTime = GlobalScriptModulePublicationActor.bZ74XDfpZ4y60jIrhs6G(1.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.globalScriptModuleManager = globalScriptModuleManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 3:
            this.serverPlacementPublishService = serverPlacementPublishService;
            num = 2;
            continue;
          default:
            // ISSUE: type reference
            this.logger = (ILogger) GlobalScriptModulePublicationActor.qcCn6ofpIsKp1hKjgRNw((object) loggerFactory, GlobalScriptModulePublicationActor.BQwhv9fpuAMi77upr7so(__typeref (GlobalScriptModulePublicationActor)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc />
    public override TimeSpan LifeTime { get; }

    /// <inheritdoc />
    public override Task ReceiveReminder(string reminderName)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      GlobalScriptModulePublicationActor.\u003CReceiveReminder\u003Ed__9 stateMachine;
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
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 2;
              continue;
            case 4:
              goto label_8;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = GlobalScriptModulePublicationActor.L4WwclfpVI0LxrH8OEwB();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
              continue;
            case 6:
              tBuilder.Start<GlobalScriptModulePublicationActor.\u003CReceiveReminder\u003Ed__9>(ref stateMachine);
              num2 = 4;
              continue;
            default:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 6;
              continue;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        stateMachine.reminderName = reminderName;
        num1 = 5;
      }
label_8:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task Publish()
    {
      int num = 3;
      // ISSUE: variable of a compiler-generated type
      GlobalScriptModulePublicationActor.\u003CPublish\u003Ed__10 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = GlobalScriptModulePublicationActor.L4WwclfpVI0LxrH8OEwB();
            num = 4;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 0;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
            continue;
          case 5:
            goto label_3;
          default:
            tBuilder.Start<GlobalScriptModulePublicationActor.\u003CPublish\u003Ed__10>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 5 : 0;
            continue;
        }
      }
label_3:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task PublicationComplete()
    {
      int num = 1;
      // ISSUE: variable of a compiler-generated type
      GlobalScriptModulePublicationActor.\u003CPublicationComplete\u003Ed__11 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 4;
            continue;
          case 3:
            goto label_4;
          case 4:
            tBuilder.Start<GlobalScriptModulePublicationActor.\u003CPublicationComplete\u003Ed__11>(ref stateMachine);
            num = 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 2 : 1;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = GlobalScriptModulePublicationActor.L4WwclfpVI0LxrH8OEwB();
            num = 5;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <summary>Публиковать глобальный модуль сценариев</summary>
    /// <param name="scriptModuleId">Идентификатор глобального модуля сценариев</param>
    private Task PublishInternal(long scriptModuleId)
    {
      int num1 = 4;
      // ISSUE: variable of a compiler-generated type
      GlobalScriptModulePublicationActor.\u003CPublishInternal\u003Ed__12 stateMachine;
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
              stateMachine.\u003C\u003Et__builder = GlobalScriptModulePublicationActor.L4WwclfpVI0LxrH8OEwB();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 2;
              continue;
            case 2:
              goto label_9;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.scriptModuleId = scriptModuleId;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
            case 4:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E4__this = this;
              num2 = 3;
              continue;
            case 5:
              tBuilder.Start<GlobalScriptModulePublicationActor.\u003CPublishInternal\u003Ed__12>(ref stateMachine);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = 5;
              continue;
            default:
              goto label_8;
          }
        }
label_9:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E1__state = -1;
        num1 = 6;
      }
label_8:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    internal static object c6wdlAfp8sxUm8Mhd2Rf(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static TimeSpan bZ74XDfpZ4y60jIrhs6G([In] double obj0) => TimeSpan.FromHours(obj0);

    internal static Type BQwhv9fpuAMi77upr7so([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object qcCn6ofpIsKp1hKjgRNw([In] object obj0, Type type) => (object) ((ILoggerFactory) obj0).CreateLogger(type);

    internal static bool BNgDyHfpCkhpc045SWmI() => GlobalScriptModulePublicationActor.nELecMfpQMj2Hyo3Qd4t == null;

    internal static GlobalScriptModulePublicationActor HYyoTwfpvkNeM2CeafK3() => GlobalScriptModulePublicationActor.nELecMfpQMj2Hyo3Qd4t;

    internal static AsyncTaskMethodBuilder L4WwclfpVI0LxrH8OEwB() => AsyncTaskMethodBuilder.Create();
  }
}
