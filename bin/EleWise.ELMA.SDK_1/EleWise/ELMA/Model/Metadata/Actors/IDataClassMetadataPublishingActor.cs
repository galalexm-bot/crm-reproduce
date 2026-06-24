// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.IDataClassMetadataPublishingActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Actors
{
  /// <summary>Актор публикации датакласса</summary>
  [FeatureFlagManaged("Publication.Actor.Enabled", true)]
  internal interface IDataClassMetadataPublishingActor : IActorWithGuidKey, IActor
  {
    /// <summary>Опубликовать датакласс</summary>
    /// <param name="comment">Комментарий при публикации</param>
    Task Publish(string comment);

    /// <summary>Завершение публикации</summary>
    /// <returns></returns>
    Task PublishComplete();
  }
}
