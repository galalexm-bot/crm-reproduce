// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Actors.IDataClassesMetadataPublishingActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Model.Metadata.Actors
{
  /// <summary>Актор публикации датаклассов</summary>
  [FeatureFlagManaged("Publication.Actor.Enabled", true)]
  internal interface IDataClassesMetadataPublishingActor : IActorWithGuidKey, IActor
  {
    /// <summary>Опубликовать дата-классы</summary>
    /// <param name="dataClassMetadataHeadersUid">Уникальный идентификаторы заголовков метаданных датаклассов</param>
    /// <param name="comment">Комментарий при публикации</param>
    /// <returns>Токен публикации</returns>
    Task<Guid> Publish(Guid[] dataClassMetadataHeadersUid, string comment);

    /// <summary>Завершение публикации</summary>
    /// <returns></returns>
    Task PublishComplete();
  }
}
