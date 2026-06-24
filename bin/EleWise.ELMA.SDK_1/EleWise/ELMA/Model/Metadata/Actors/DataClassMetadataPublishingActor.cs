// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.DataClassMetadataPublishingActor
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
  internal sealed class DataClassMetadataPublishingActor : 
    DataClassMetadataPublishingActorBase,
    IDataClassMetadataPublishingActor,
    IActorWithGuidKey,
    IActor
  {
    private static DataClassMetadataPublishingActor cP3biQbj10Kl0TsyYBus;

    /// <inheritdoc />
    public DataClassMetadataPublishingActor(
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
      DataClassMetadataPublishingActor.ukj5QpbjpuTXfTIjyCrW();
      // ISSUE: type reference
      // ISSUE: explicit constructor call
      base.\u002Ector((ILogger) DataClassMetadataPublishingActor.iXkjI8bjDM4D3Ec0fQoe((object) loggerFactory, DataClassMetadataPublishingActor.mp8OKPbja55sJJhepFEx(__typeref (DataClassMetadataPublishingActor))), dataClassMetadataItemHeaderManager, checkDataClassService, searchMetadataService, dataClassAssemblyBuilderService, dataClassMetadataItemManager, dataClassTypeReferenceManager, sessionProvider, unitOfWorkManager, serverPlacementPublishService, searchFormService);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <inheritdoc />
    public Task Publish(string comment)
    {
      int num = 6;
      // ISSUE: variable of a compiler-generated type
      DataClassMetadataPublishingActor.\u003CPublish\u003Ed__1 stateMachine;
      AsyncTaskMethodBuilder tBuilder;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E1__state = -1;
            num = 4;
            continue;
          case 3:
            tBuilder.Start<DataClassMetadataPublishingActor.\u003CPublish\u003Ed__1>(ref stateMachine);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
            continue;
          case 4:
            // ISSUE: reference to a compiler-generated field
            tBuilder = stateMachine.\u003C\u003Et__builder;
            num = 3;
            continue;
          case 5:
            // ISSUE: reference to a compiler-generated field
            stateMachine.comment = comment;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
            continue;
          case 6:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003E4__this = this;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 5;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            stateMachine.\u003C\u003Et__builder = DataClassMetadataPublishingActor.xXiRO3bjtG2gECSyi9S4();
            num = 2;
            continue;
        }
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    /// <inheritdoc />
    public Task PublishComplete() => this.Complete();

    internal static void ukj5QpbjpuTXfTIjyCrW() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type mp8OKPbja55sJJhepFEx([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object iXkjI8bjDM4D3Ec0fQoe([In] object obj0, Type type) => (object) ((ILoggerFactory) obj0).CreateLogger(type);

    internal static bool qH37AsbjNAwv8DUP1k93() => DataClassMetadataPublishingActor.cP3biQbj10Kl0TsyYBus == null;

    internal static DataClassMetadataPublishingActor OmSvwZbj3RcUtdPcdDfA() => DataClassMetadataPublishingActor.cP3biQbj10Kl0TsyYBus;

    internal static AsyncTaskMethodBuilder xXiRO3bjtG2gECSyi9S4() => AsyncTaskMethodBuilder.Create();
  }
}
