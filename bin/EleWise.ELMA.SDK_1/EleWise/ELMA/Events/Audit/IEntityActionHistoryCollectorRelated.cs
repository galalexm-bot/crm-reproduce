// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEntityActionHistoryCollectorRelated
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Сборщик дополнительных данных для отображения истории по объекту.
  /// Срабатывает только при отображении
  /// </summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IEntityActionHistoryCollectorRelated
  {
    /// <summary>Получить данные для отображения истории</summary>
    /// <param name="id">Идентификатор объекта</param>
    /// <param name="actionObject">Идентификатор типа сущности</param>
    /// <param name="relatedEventList">Список событий сущности - источник данных для добавления в общий список отображения истории</param>
    /// <param name="relatedObjectList">Список связанных объектов сущности</param>
    /// <returns>Список аргументов для добавления в общий список отображения</returns>
    IEnumerable<EntityActionEventArgs> CollectHistory(
      long id,
      Guid actionObject,
      IEnumerable<EntityActionEventArgs> relatedEventList,
      IEnumerable<HistoryCollectorRelatedModel> relatedObjectList);

    /// <summary>Получить список связанных объектов</summary>
    /// <param name="id">Идентификатор объекта</param>
    /// <param name="actionObject">Идентификатор типа сущности</param>
    /// <returns>Идентификаторы объектов используемые в коллеткоре, с указанием коллектора источника</returns>
    IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject);

    /// <summary>Используется ли сборщик</summary>
    /// <param name="id">идентификатор объекта для загрузки истории</param>
    /// <param name="actionObject">Тип объекта</param>
    bool CanUse(long id, Guid actionObject);
  }
}
