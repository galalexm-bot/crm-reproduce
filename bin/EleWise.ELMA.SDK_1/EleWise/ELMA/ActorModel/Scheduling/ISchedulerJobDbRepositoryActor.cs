// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Scheduling.ISchedulerJobDbRepositoryActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Scheduling
{
  /// <summary>
  /// Интерфейс актора репозитория работ планировщика, хранящихся в БД
  /// </summary>
  internal interface ISchedulerJobDbRepositoryActor : IActorWithGuidKey, IActor
  {
    /// <summary>
    /// Получить уникальные идентификаторы периодических задач для исполнения в указанный момент времени
    /// </summary>
    /// <param name="dateTimeToRun">Дата/время для запуска</param>
    /// <returns>Уникальные идентификаторы периодических задач</returns>
    Task<IEnumerable<Guid>> GetSchedulerTasksUid(DateTime dateTimeToRun);

    /// <summary>
    /// Добавить триггер с указанным Uid для принудительного запуска
    /// </summary>
    /// <param name="triggerUid">Уникальный идентификатор триггера</param>
    Task AddForceRunTrigger(Guid triggerUid);

    /// <summary>Обновить данные из БД</summary>
    Task Refresh();
  }
}
