// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEntityModelHistoryEventsFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Точка расширения, позволяющая отфильтровать сущность перед записью факта изменения
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IEntityModelHistoryEventsFilter
  {
    /// <summary>Поддерживается ли данная сущность</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="actionUid">Тип действия</param>
    /// <returns><c>false</c>, если необходимо пропустить сущность и не записывать факт изменения</returns>
    bool IsSupported(IEntity entity, Guid actionUid);

    /// <summary>Поддерживается ли данная сущность</summary>
    /// <param name="typeUid">Тип сущности</param>
    /// <param name="entityId">Идентификатор</param>
    /// <param name="entityUid">Уникальный идентификатор</param>
    /// <param name="actionUid">Тип действия</param>
    /// <returns><c>false</c>, если необходимо пропустить сущность и не записывать факт изменения</returns>
    bool IsSupported(Guid typeUid, long entityId, Guid entityUid, Guid actionUid);
  }
}
