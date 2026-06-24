// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.FunctionMetadataPublishingServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model.Events.Publication;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Actors
{
  /// <summary>Актора экземпляра сервера (для публикации фунций)</summary>
  internal sealed class FunctionMetadataPublishingServerInstanceActor : 
    Actor,
    IFunctionMetadataPublishingServerInstanceActor,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IFunctionMetadataPublishingEventHandler functionMetadataPublishingEventHandler;
    private static FunctionMetadataPublishingServerInstanceActor lWwPlJbLFEmWxLC0J4UR;

    /// <summary>Ctor</summary>
    /// <param name="functionMetadataPublishingEventHandler">Событие публикации функции</param>
    public FunctionMetadataPublishingServerInstanceActor(
      IFunctionMetadataPublishingEventHandler functionMetadataPublishingEventHandler)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.functionMetadataPublishingEventHandler = functionMetadataPublishingEventHandler;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public Task PublicationSuccess(Guid functionMetadataUid, UIMetadataPublishResult result) => (Task) FunctionMetadataPublishingServerInstanceActor.MNCc3UbLoD5FFK7IO7PO((object) this.functionMetadataPublishingEventHandler, functionMetadataUid, (object) result);

    /// <inheritdoc />
    public Task PublicationError(Guid functionMetadataUid, Exception exception) => (Task) FunctionMetadataPublishingServerInstanceActor.qA0GCUbLbZ1jyKWwMtFi((object) this.functionMetadataPublishingEventHandler, functionMetadataUid, (object) exception);

    internal static bool p49sPTbLBsJ3Ukwa0qeX() => FunctionMetadataPublishingServerInstanceActor.lWwPlJbLFEmWxLC0J4UR == null;

    internal static FunctionMetadataPublishingServerInstanceActor fXauF1bLWxbA925onOo7() => FunctionMetadataPublishingServerInstanceActor.lWwPlJbLFEmWxLC0J4UR;

    internal static object MNCc3UbLoD5FFK7IO7PO([In] object obj0, Guid functionMetadataUid, [In] object obj2) => (object) ((IFunctionMetadataPublishingEventHandler) obj0).Complete(functionMetadataUid, (UIMetadataPublishResult) obj2);

    internal static object qA0GCUbLbZ1jyKWwMtFi([In] object obj0, Guid functionMetadataUid, [In] object obj2) => (object) ((IFunctionMetadataPublishingEventHandler) obj0).Error(functionMetadataUid, (Exception) obj2);
  }
}
