// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Publication.ServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Publication
{
  /// <inheritdoc />
  internal sealed class ServerInstanceActor : 
    Actor,
    IServerInstanceActor,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly IRuntimeApplication runtimeApplication;
    private readonly ILazy<MetadataItemManager> metadataItemManager;
    private readonly IPublicationEventHandler publicationEventHandler;
    private TaskCompletionSource<bool> waitPublication;
    internal static ServerInstanceActor M2sbqHfapGo9KjDugNS2;

    /// <summary>ctor</summary>
    /// <param name="actorModelRuntime">Модель Акторов</param>
    /// <param name="runtimeApplication">Среда исполнения приложения</param>
    /// <param name="metadataItemManager">Менеджер элементов метаданных</param>
    /// <param name="publicationEventHandler">События публикации</param>
    public ServerInstanceActor(
      IActorModelRuntime actorModelRuntime,
      IRuntimeApplication runtimeApplication,
      ILazy<MetadataItemManager> metadataItemManager,
      IPublicationEventHandler publicationEventHandler)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.LifeTime = TimeSpan.FromDays(365.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.actorModelRuntime = actorModelRuntime;
      this.runtimeApplication = runtimeApplication;
      this.metadataItemManager = metadataItemManager;
      this.publicationEventHandler = publicationEventHandler;
    }

    /// <inheritdoc />
    public override TimeSpan LifeTime { get; }

    /// <inheritdoc />
    public Task DeltaPublicationStart(
      MetadataAssemblyPublishResult result,
      Guid[] softPublished,
      Guid[] deltaPublished,
      AssemblyModelsMetadata restartNeeded)
    {
      int num1 = 7;
      ServerInstanceActor serverInstanceActor;
      MetadataAssemblyPublishResult result1;
      Guid[] softPublished1;
      Guid[] deltaPublished1;
      AssemblyModelsMetadata restartNeeded1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_15;
            case 2:
              softPublished1 = softPublished;
              num2 = 4;
              continue;
            case 3:
              restartNeeded1 = restartNeeded;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 8 : 0;
              continue;
            case 4:
              deltaPublished1 = deltaPublished;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 3 : 1;
              continue;
            case 5:
            case 10:
              this.waitPublication = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
              num2 = 9;
              continue;
            case 6:
              serverInstanceActor = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
              continue;
            case 7:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 6 : 3;
              continue;
            case 8:
              if (ServerInstanceActor.W3g8u0fatD5jnUuoVW2k((object) this.runtimeApplication))
              {
                if (this.waitPublication == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 2 : 10;
                  continue;
                }
                goto case 11;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
                continue;
              }
            case 9:
              goto label_16;
            case 11:
              ServerInstanceActor.YgJJHVfaHoFljpBFuuJr((object) this.waitPublication, (object) new Exception((string) ServerInstanceActor.W8eipAfa6QJ8cOHNXMCy(ServerInstanceActor.j7CtNufa4m66JhbCRAGw(-1822890472 ^ -1822576240))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 5;
              continue;
            default:
              goto label_6;
          }
        }
label_15:
        result1 = result;
        num1 = 2;
      }
label_6:
      return (Task) ServerInstanceActor.yrXr3BfawEiosKWved88();
label_16:
      return this.actorModelRuntime.GetActor<IPublicationActor>(Guid.Empty).Wait(ServerInstanceActor.JFlqrpfaAwt05vjEWbpK((object) this.runtimeApplication)).ContinueWith((Action<Task>) (actorTask =>
      {
        int num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              serverInstanceActor.RunExternalTask((Func<Task>) (() => serverInstanceActor.metadataItemManager.Value.PublicationStarted(result1, softPublished1, deltaPublished1, (IRootMetadata[]) ServerInstanceActor.\u003C\u003Ec__DisplayClass9_0.raUv4QZEkjQOKvsJhTFT((object) restartNeeded1), (Task) serverInstanceActor.waitPublication.Task)));
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }), TaskContinuationOptions.RunContinuationsAsynchronously | TaskContinuationOptions.NotOnFaulted);
    }

    /// <inheritdoc />
    public Task DeltaPublicationComplete()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TaskCompletionSource<bool> waitPublication = this.waitPublication;
            if (waitPublication == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
              continue;
            }
            waitPublication.TrySetResult(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task PublicationComplete(Guid publicationToken)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.publicationEventHandler.Complete(publicationToken);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (Task) ServerInstanceActor.yrXr3BfawEiosKWved88();
    }

    /// <inheritdoc />
    public Task PublicationError(Guid publicationToken, Exception exception)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TaskCompletionSource<bool> waitPublication = this.waitPublication;
            if (waitPublication == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
              continue;
            }
            ServerInstanceActor.RIngfZfa7aIvb8Po1keo((object) waitPublication, (object) exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 3 : 2;
            continue;
          case 2:
            goto label_3;
          default:
            ServerInstanceActor.BDHNGlfaxGxbBS9HZpdU((object) this.publicationEventHandler, publicationToken, (object) exception);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:
      return (Task) ServerInstanceActor.yrXr3BfawEiosKWved88();
    }

    /// <inheritdoc />
    public Task Deactivate()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.DeactivateOnIdle();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return Task.CompletedTask;
    }

    internal static bool W3g8u0fatD5jnUuoVW2k([In] object obj0) => ((IRuntimeApplication) obj0).IsStarted;

    internal static object yrXr3BfawEiosKWved88() => (object) Task.CompletedTask;

    internal static object j7CtNufa4m66JhbCRAGw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object W8eipAfa6QJ8cOHNXMCy([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool YgJJHVfaHoFljpBFuuJr([In] object obj0, [In] object obj1) => ((TaskCompletionSource<bool>) obj0).TrySetException((Exception) obj1);

    internal static Guid JFlqrpfaAwt05vjEWbpK([In] object obj0) => ((IRuntimeApplication) obj0).ConnectionUid;

    internal static bool Ovhv1NfaabN0wuHT43rX() => ServerInstanceActor.M2sbqHfapGo9KjDugNS2 == null;

    internal static ServerInstanceActor YAVxG6faDTYs99OR430k() => ServerInstanceActor.M2sbqHfapGo9KjDugNS2;

    internal static bool RIngfZfa7aIvb8Po1keo([In] object obj0, [In] object obj1) => ((TaskCompletionSource<bool>) obj0).TrySetException((Exception) obj1);

    internal static void BDHNGlfaxGxbBS9HZpdU([In] object obj0, Guid publicationToken, [In] object obj2) => ((IPublicationEventHandler) obj0).Error(publicationToken, (Exception) obj2);
  }
}
