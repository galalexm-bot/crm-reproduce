// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEntityActionHistoryLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>Интерфейс загрузчика истории для сущности</summary>
  public interface IEntityActionHistoryLoader
  {
    /// <summary>Загрузить историю для сущности по экземпляру</summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    IEnumerable<EntityActionEventArgs> LoadHistory([NotNull] IEntity<long> entity);

    /// <summary>
    /// Загрузить историю для сущности по типу объекта и идентификатору
    /// </summary>
    /// <param name="actionObject">Идентификтор типа сущности</param>
    /// <param name="objectId">Идентификатор сущности</param>
    /// <returns></returns>
    IEnumerable<EntityActionEventArgs> LoadHistory(
      Guid actionObject,
      long? objectId,
      Guid? actionType = null);

    /// <summary>
    /// Загрузить историю для сущности по единице работы и типу объекта
    /// </summary>
    /// <param name="unitOfWorkUid">Идентификатор единицы работы</param>
    /// <param name="actionObject">Идентификтор типа сущности</param>
    /// <returns></returns>
    IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid, Guid actionObject);

    /// <summary>
    /// Загрузить историю для сущности по по единице работы, типу объекта, типу действия и идентификатору объекта
    /// </summary>
    /// <param name="unitOfWorkUid">Идентификатор единицы работы</param>
    /// <param name="actionObject">Идентификтор типа сущности</param>
    /// <param name="actionTypeUid">Идентификатор типа действия</param>
    /// <param name="objectId">Идентификатор сущности</param>
    /// <returns></returns>
    IEnumerable<EntityActionEventArgs> LoadHistory(
      Guid unitOfWorkUid,
      Guid actionObject,
      Guid actionTypeUid,
      long? objectId = null);

    /// <summary>Загрузить историю для сущности по единице работы</summary>
    /// <param name="unitOfWorkUid">Идентификатор единицы работы</param>
    /// <returns></returns>
    IEnumerable<EntityActionEventArgs> LoadHistory(Guid unitOfWorkUid);
  }
}
