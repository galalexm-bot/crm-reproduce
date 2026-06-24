// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.DataClassMetadataPublishingServerInstanceActor
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
  /// <summary>Актор экземпляра сервера (для публикации DataClass)</summary>
  internal sealed class DataClassMetadataPublishingServerInstanceActor : 
    Actor,
    IDataClassMetadataPublishingServerInstanceActor,
    IServerPlacementActor,
    IActorWithGuidKey,
    IActor
  {
    private readonly IDataClassMetadataPublishingEventHandler dataClassMetadataPublishingEventHandler;
    internal static DataClassMetadataPublishingServerInstanceActor j8nk1IbYKY6pFfS6K1ON;

    /// <summary>Ctor</summary>
    /// <param name="dataClassMetadataPublishingEventHandler">Событие публикации DataClass-а</param>
    public DataClassMetadataPublishingServerInstanceActor(
      IDataClassMetadataPublishingEventHandler dataClassMetadataPublishingEventHandler)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.dataClassMetadataPublishingEventHandler = dataClassMetadataPublishingEventHandler;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public Task Complete(Guid publicationToken, UIMetadataPublishResult result) => (Task) DataClassMetadataPublishingServerInstanceActor.I2bNjdbYkj1EJNJr3AO7((object) this.dataClassMetadataPublishingEventHandler, publicationToken, (object) result);

    /// <inheritdoc />
    public Task Error(Guid publicationToken, Exception exception) => (Task) DataClassMetadataPublishingServerInstanceActor.RgkbjYbYn2pnMHQwWwnV((object) this.dataClassMetadataPublishingEventHandler, publicationToken, (object) exception);

    internal static bool IJCUUxbYXAtKwUsvhwWZ() => DataClassMetadataPublishingServerInstanceActor.j8nk1IbYKY6pFfS6K1ON == null;

    internal static DataClassMetadataPublishingServerInstanceActor DruahVbYTs4D18UZFoEg() => DataClassMetadataPublishingServerInstanceActor.j8nk1IbYKY6pFfS6K1ON;

    internal static object I2bNjdbYkj1EJNJr3AO7([In] object obj0, Guid publicationToken, [In] object obj2) => (object) ((IDataClassMetadataPublishingEventHandler) obj0).Complete(publicationToken, (UIMetadataPublishResult) obj2);

    internal static object RgkbjYbYn2pnMHQwWwnV([In] object obj0, Guid publicationToken, [In] object obj2) => (object) ((IDataClassMetadataPublishingEventHandler) obj0).Error(publicationToken, (Exception) obj2);
  }
}
