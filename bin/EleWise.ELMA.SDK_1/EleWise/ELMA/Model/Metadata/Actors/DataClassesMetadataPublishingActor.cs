// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.DataClassesMetadataPublishingActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.UI.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Actors
{
  /// <summary>Актор публикации дата-классов</summary>
  internal sealed class DataClassesMetadataPublishingActor : 
    DataClassMetadataPublishingActorBase,
    IDataClassesMetadataPublishingActor,
    IActorWithGuidKey,
    IActor
  {
    internal static DataClassesMetadataPublishingActor uJwYo1bjkJQahN5TWY1Z;

    /// <inheritdoc />
    public DataClassesMetadataPublishingActor(
      ILoggerFactory loggerFactory,
      IDataClassMetadataItemHeaderManager dataClassMetadataItemHeaderManager,
      ICheckDataClassService checkDataClassService,
      ISearchMetadataService searchMetadataService,
      IDataClassAssemblyBuilderService dataClassAssemblyBuilderService,
      IDataClassMetadataItemManager dataClassMetadataItemManager,
      IDataClassTypeReferenceManager dataClassTypeReferenceManager,
      ISessionProvider sessionProvider,
      IUnitOfWorkManager unitOfWorkManager,
      IServerPlacementPublishService serverPlacementPublishService,
      ISearchFormServiceInternal searchFormService)
    {
      DataClassesMetadataPublishingActor.ghUflLbj2TphvsFXn8sk();
      // ISSUE: type reference
      // ISSUE: explicit constructor call
      base.\u002Ector((ILogger) DataClassesMetadataPublishingActor.q4V4VdbjPT6sxpEPFaAp((object) loggerFactory, DataClassesMetadataPublishingActor.r4MfgXbjeogClvjfC6e9(__typeref (DataClassesMetadataPublishingActor))), dataClassMetadataItemHeaderManager, checkDataClassService, searchMetadataService, dataClassAssemblyBuilderService, dataClassMetadataItemManager, dataClassTypeReferenceManager, sessionProvider, unitOfWorkManager, serverPlacementPublishService, searchFormService);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public async Task<Guid> Publish(Guid[] dataClassMetadataHeadersUid, string comment)
    {
      int num1 = 2;
      Guid result;
      int num2;
      DataClassesMetadataPublishingActor metadataPublishingActor1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            metadataPublishingActor1 = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 1;
            continue;
          case 3:
label_4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 4;
            continue;
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 5 : 2;
            continue;
          case 5:
            goto label_37;
          default:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 15;
              else
                goto label_23;
label_9:
              TaskAwaiter taskAwaiter;
              TaskAwaiter awaiter;
              while (true)
              {
                int num4;
                DataClassesMetadataPublishingActor metadataPublishingActor;
                string comment1;
                Guid[] dataClassMetadataHeadersUid1;
                switch (num3)
                {
                  case 1:
                    dataClassMetadataHeadersUid1 = dataClassMetadataHeadersUid;
                    num3 = 12;
                    continue;
                  case 2:
                    goto label_34;
                  case 3:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    awaiter = DataClassesMetadataPublishingActor.\u003CPublish\u003Ed__1.xg7QLNC0ATXAfpDnE5fq((object) metadataPublishingActor1.RegisterOrUpdateReminder((string) DataClassesMetadataPublishingActor.\u003CPublish\u003Ed__1.E6SmjjC0wDBef8gm48Qk(-951514650 ^ -951273000), TimeSpan.FromMinutes(1.0), DataClassesMetadataPublishingActor.\u003CPublish\u003Ed__1.WBy86oC0HwDyNS0LaG5r(1.0)));
                    num4 = 8;
                    break;
                  case 4:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = -1;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 9 : 8;
                    continue;
                  case 5:
                    metadataPublishingActor = this;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 9 : 14;
                    continue;
                  case 6:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, DataClassesMetadataPublishingActor.\u003CPublish\u003Ed__1>(ref awaiter, this);
                    num4 = 2;
                    break;
                  case 7:
                    goto label_23;
                  case 8:
                    if (awaiter.IsCompleted)
                    {
                      num3 = 11;
                      continue;
                    }
                    goto case 13;
                  case 9:
                  case 11:
                    awaiter.GetResult();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 6 : 17;
                    continue;
                  case 10:
                    goto label_28;
                  case 12:
                    if (!metadataPublishingActor1.PublicationToken.HasValue)
                    {
                      num4 = 18;
                      break;
                    }
                    goto label_28;
                  case 13:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = num2 = 0;
                    num3 = 16;
                    continue;
                  case 14:
                    comment1 = comment;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
                    continue;
                  case 15:
                    num3 = 5;
                    continue;
                  case 16:
                    taskAwaiter = awaiter;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 6 : 0;
                    continue;
                  case 17:
                    metadataPublishingActor1.RunExternalTask((Func<Task>) (() => metadataPublishingActor.PublishInternal(comment1, dataClassMetadataHeadersUid1)));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                    continue;
                  case 18:
                    // ISSUE: reference to a compiler-generated method
                    metadataPublishingActor1.PublicationToken = new Guid?(DataClassesMetadataPublishingActor.\u003CPublish\u003Ed__1.NngoDcC06bfEpChKIseZ());
                    num4 = 3;
                    break;
                  case 19:
                    goto label_4;
                  case 20:
                    taskAwaiter = new TaskAwaiter();
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 4;
                    continue;
                  default:
                    result = metadataPublishingActor1.PublicationToken.Value;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 19 : 13;
                    continue;
                }
                num3 = num4;
              }
label_34:
              return;
label_28:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              throw new InvalidOperationException((string) DataClassesMetadataPublishingActor.\u003CPublish\u003Ed__1.MwtoojC04vPPu4orQGQG(DataClassesMetadataPublishingActor.\u003CPublish\u003Ed__1.E6SmjjC0wDBef8gm48Qk(1319452732 ^ 1319169862)));
label_23:
              awaiter = taskAwaiter;
              num3 = 20;
              goto label_9;
            }
            catch (Exception ex)
            {
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
                num5 = 0;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 2;
                    continue;
                  case 2:
                    goto label_30;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
                    continue;
                }
              }
label_30:
              return;
            }
        }
      }
label_37:;
    }

    /// <inheritdoc />
    public Task PublishComplete() => this.Complete();

    internal static void ghUflLbj2TphvsFXn8sk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type r4MfgXbjeogClvjfC6e9([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object q4V4VdbjPT6sxpEPFaAp([In] object obj0, Type type) => (object) ((ILoggerFactory) obj0).CreateLogger(type);

    internal static bool OEdoc6bjn4SK9Md8PSh3() => DataClassesMetadataPublishingActor.uJwYo1bjkJQahN5TWY1Z == null;

    internal static DataClassesMetadataPublishingActor yqkZxYbjO6BBHWTmIImw() => DataClassesMetadataPublishingActor.uJwYo1bjkJQahN5TWY1Z;
  }
}
