// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.IEntityActionHistoryEventService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using System;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Интерфейс для сервиса управления событиями истории действий с объектом
  /// </summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IEntityActionHistoryEventService
  {
    /// <summary>
    /// Инициализировать сервис, будут произведены все необходимые проверки
    /// </summary>
    void Initialize();

    /// <summary>
    /// Создать экземпляр аргументов события по типу действия, идентификатору и сущности
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="objectUid">Идентификатор объекта действия</param>
    /// <param name="actionUid">Идентификатор типа действия</param>
    /// <param name="eventArgsUid">Идентификтор класса аргумента</param>
    /// <typeparam name="TEventArgs">Тип класса аргумента, к которому нужно привести объект</typeparam>
    /// <returns>Экземпляр объекта, <c>null</c> если ничего не найдено</returns>
    TEventArgs Create<TEventArgs>(
      IEntity entity,
      Guid objectUid,
      Guid actionUid,
      Guid eventArgsUid)
      where TEventArgs : class, IEntityHistoryEventArgs;

    /// <summary>
    /// Получить тип класса аргументов события по идентификатору
    /// </summary>
    /// <param name="eventArgsUid">Идентификатор</param>
    /// <returns>Тип класса, <c>null</c> если ничего не найдено</returns>
    Type GetEventArgsType(Guid eventArgsUid);
  }
}
