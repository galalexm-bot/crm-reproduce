// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Actors.ComponentMetadataPublishingServerInstanceActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Model;
using EleWise.ELMA.UI.Events;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.UI.Actors
{
  /// <summary>Актор экземпляра сервиса (для публикации компонентов)</summary>
  internal sealed class ComponentMetadataPublishingServerInstanceActor : 
    Actor,
    IComponentMetadataPublishingServerInstanceActor,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IComponentMetadataPublishingEventHandler componentMetadataPublishingEventHandler;
    internal static ComponentMetadataPublishingServerInstanceActor GPWqgPBV9AYqDVamM3te;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataPublishingEventHandler">Событие публикации компонента</param>
    public ComponentMetadataPublishingServerInstanceActor(
      IComponentMetadataPublishingEventHandler componentMetadataPublishingEventHandler)
    {
      ComponentMetadataPublishingServerInstanceActor.USGxQTBVrOV6o1LSsRKB();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.componentMetadataPublishingEventHandler = componentMetadataPublishingEventHandler;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public Task PublicationSuccess(Guid componentMetadataUid, UIMetadataPublishResult result) => (Task) ComponentMetadataPublishingServerInstanceActor.OrkbkeBVg7D7JRMXQMOc((object) this.componentMetadataPublishingEventHandler, componentMetadataUid, (object) result);

    /// <inheritdoc />
    public Task PublicationError(Guid componentMetadataUid, Exception exception) => this.componentMetadataPublishingEventHandler.PublicationError(componentMetadataUid, exception);

    internal static void USGxQTBVrOV6o1LSsRKB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool EhW4OFBVdOB0MwjW8wgX() => ComponentMetadataPublishingServerInstanceActor.GPWqgPBV9AYqDVamM3te == null;

    internal static ComponentMetadataPublishingServerInstanceActor TB3pFgBVlO9QN2yQCYEL() => ComponentMetadataPublishingServerInstanceActor.GPWqgPBV9AYqDVamM3te;

    internal static object OrkbkeBVg7D7JRMXQMOc(
      [In] object obj0,
      Guid componentMetadataUid,
      [In] object obj2)
    {
      return (object) ((IComponentMetadataPublishingEventHandler) obj0).PublicationSuccess(componentMetadataUid, (UIMetadataPublishResult) obj2);
    }
  }
}
